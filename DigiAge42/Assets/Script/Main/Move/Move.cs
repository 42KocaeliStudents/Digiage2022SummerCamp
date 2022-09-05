using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Entity;
using static UnityEditor.FilePathAttribute;
using Assets.Script.Main;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Move : MonoBehaviour
{
    public Rigidbody body;
    BoxCollider bc;
    private Animator animator;
    private Player player;
    public Ground _ground;
    public float p_speed;
    bool canDash;
    Vector3 tempVect;

    private bool moveLeft;
    private bool moveRight;
    private bool canJump;
    private bool k;
    private bool canRoll;
    private bool lookRight = true;
    bool rollController = true;

    void Start()
    {
        OnLoad onLoad = new OnLoad();
        player = onLoad.GetPlayer();
        p_speed = player.speed;
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        bc = GetComponent<BoxCollider>();
        canDash = true;
    }

    void FixedUpdate()
    {
        MoveFunc();
    }

    private void Update()
    {
        // tüm input alma iþlemleri
        if (Input.GetKeyDown(KeyCode.U))
            animator.SetTrigger("Dance");
        if (Input.GetKeyDown(KeyCode.D))
            moveRight = true;
        if (Input.GetKeyUp(KeyCode.D))
            moveRight = false;
        if (Input.GetKeyDown(KeyCode.A))
            moveLeft = true;
        if (Input.GetKeyUp(KeyCode.A))
            moveLeft = false;
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
            canJump = true;
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Space))
            canJump = false;
        if (Input.GetKeyDown(KeyCode.K))
            k = true;
        if (Input.GetKeyUp(KeyCode.K))
            k = false;
        if (_ground.IsGround && canDash == false)
            canDash = true;
        if (Input.GetKeyDown(KeyCode.LeftControl))
            canRoll = true;
    }

    void MoveFunc()
    {
        tempVect = new Vector3(0, 0, 0);
        if (moveRight && !canRoll)
        {
            tempVect.x = -1;
            tempVect = tempVect.normalized * p_speed * Time.deltaTime;
            //Dash Mech
            if (k && canDash == true && _ground.IsGround == false)
                DashOmer(1, tempVect);
            else
                body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.left);
            transform.rotation = quaternion;
            lookRight = true;
        }
        if (moveLeft && !canRoll)
        {
            tempVect.x = 1;
            tempVect = tempVect.normalized * p_speed * Time.deltaTime;
            //Dash Mech
            if (k && canDash == true && _ground.IsGround == false)
                DashOmer(2, tempVect);
            else
                body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.right);
            transform.rotation = quaternion;
            lookRight = false;
        }
        if (canRoll)
        {
            // eger ki roll atma tusuna basildiysa animasyon oynar ve zamanlayici 1 saniye sonra roll atmasini durdurur. Bu sure icinde karakter haraket edemez.
            if (rollController)
            {
                animator.SetTrigger("Roll");
                StartCoroutine(dashDelay());
                rollController = false;
            }
            Rolling();
        }
        AnimRun("Speed", tempVect);
        Jump(canJump);
    }

    private void Jump(bool canJump)
    {
        if (canJump && _ground.IsGround && !canRoll)
        {
            SetAnim("Speed", -1);
            body.velocity = Vector3.zero;
            body.AddForce(transform.up * player.jumpHeight);
        }
    }

    private IEnumerator DashTimer(int x)
    {
        yield return new WaitForSeconds(0.1f);
        if (x == 1)
            canDash = true;
        else
        {
            if (!_ground.IsGround)
                canDash = false;
        }

    }

    void DashOmer(int key, Vector3 tempVect)
    {
        //Dash
        if (key == 1)
        {
            animator.SetTrigger("Dash");
            tempVect.x = -1;
            body.AddForce(-1000, 0, 0);

        }
        else if (key == 2)
        {
            animator.SetTrigger("Dash");
            tempVect.x = 1;
            body.AddForce(1000, 0, 0);
            
        }
        StartCoroutine(DashTimer(0));
    }

    public void AnimRun(string animName, Vector3 vector)
    {
        if (vector != Vector3.zero)
            SetAnim(animName, 1);
        else
            SetAnim(animName, -1);
    }

    public void SetAnim(string animName, float value)
    {
        animator.SetFloat(animName, value);
    }

    // yuvarlanma
    void Rolling()
    {
        p_speed = 5;
        if (lookRight) // eger ki saga bakiyor ise saga dogru hareket et
        {
            tempVect.x = -1;
            tempVect = tempVect.normalized * p_speed * Time.deltaTime;
            body.MovePosition(transform.position + tempVect);
        }
        else
        {
            tempVect.x = 1;
            tempVect = tempVect.normalized * p_speed * Time.deltaTime;
            body.MovePosition(transform.position + tempVect);
        }
    }

    // 1 saniye sonra yuvarlanma ozelligini kaldirir.
    IEnumerator dashDelay()
    {
        bc.center = new Vector3(0,0.4f,0.002f);
        bc.size = new Vector3(0.4f, 0.8f, 0.3f);
        yield return new WaitForSeconds(1);
        bc.center = new Vector3(0, 0.9f, 0.002f);
        bc.size = new Vector3(0.4f, 1.8f, 0.3f);
        p_speed = 4;
        canRoll = false;
        rollController = true;
    }

}
