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
    private Rigidbody body;
    private Animator animator;
    private Player player;
    public Ground _ground;
    private Transform _transform;
    bool    canDash;

    public Move()
    {

    }

    void Start()
    {
        OnLoad onLoad = new OnLoad();
        player = onLoad.GetPlayer();
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        _transform = GetComponent<Transform>();
        canDash = true;
    }

    void FixedUpdate()
    {
        MoveFunc();
    }

    void MoveFunc()
    {
        Vector3 tempVect = new Vector3(0, 0, 0);
        bool d = Input.GetKey(KeyCode.D);
        bool a = Input.GetKey(KeyCode.A);
        bool j = Input.GetKey(KeyCode.Space);
        bool k = Input.GetKey(KeyCode.K);
        if (d)
        {
            tempVect.x = -1;
            tempVect = tempVect.normalized * player.speed * Time.deltaTime;
            //Dash Mech
            if (k && canDash == true && _ground.IsGround == false)
                DashOmer(1, tempVect);
            else
                body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.left);
            transform.rotation = quaternion;
        }
        if (a)
        {
            tempVect.x = 1;
            tempVect = tempVect.normalized * player.speed * Time.deltaTime;
            //Dash Mech
            if (k && canDash == true && _ground.IsGround == false)
                DashOmer(2, tempVect);
            else
                body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.right);
            transform.rotation = quaternion;
        }
        if (_ground.IsGround && canDash == false)
            canDash = true;
        AnimRun("Speed", tempVect);
        Jump(j);
    }

    private void Jump(bool j) 
    {
        if (j && _ground.IsGround)
        {
            SetAnim("Speed", -1);
            body.velocity = Vector3.zero;
            body.AddForce(_transform.up * player.jumpHeight);
        }
    }

    private IEnumerator DashTimer(int x)
    {
        yield return new WaitForSeconds(0.2f);
        if (x == 1)
            canDash = true;
        else
        {
            if (!_ground.IsGround)
                canDash = false;
        }

    }

    void DashOmer(int key , Vector3 tempVect)
    {
        //Dash
        if (key == 1)
        {
            tempVect.x = -1;
            body.MovePosition(transform.position + tempVect);
            
        }
        else if (key == 2)
        {
            tempVect.x = 1;
            body.MovePosition(transform.position + tempVect);
        }
        Debug.Log("burasi dondu");
        StartCoroutine(DashTimer(0));
    }

    public void AnimRun(string animName, Vector3 vector)
    {
        if (vector != Vector3.zero)
        {
            SetAnim(animName, 1);
        }
        else
        {
            SetAnim(animName, -1);
        }
    }

    public void SetAnim(string animName, float value)
    {
        animator.SetFloat(animName, value);
    }

}
