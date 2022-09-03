using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Move;
using Assets.Script.Entity;
using static UnityEditor.FilePathAttribute;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody body;
    private Animator animator;
    private Player player;
    private int xLocation = 0;
    public Ground _ground;

    public Move()
    {
        player = new Player() { jumpHeight = 50, speed = 15, isGrounded = false, isRun = true };
    }

    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveFunc();
    }

    void MoveFunc()
    {
        bool d = Input.GetKey(KeyCode.D);
        bool a = Input.GetKey(KeyCode.A);
        bool j = Input.GetKey(KeyCode.Space);
        Vector3 tempVect = new Vector3(0, 0, 0);
        if (d )
        {
            tempVect.x = -1;
            tempVect = tempVect.normalized * player.speed * Time.deltaTime;
            body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.left);
            transform.rotation = quaternion;
        }
        if (a)
        {
            tempVect.x = 1;
            tempVect = tempVect.normalized * player.speed * Time.deltaTime;
            body.MovePosition(transform.position + tempVect);
            var quaternion = Quaternion.LookRotation(tempVect, Vector3.right);
            transform.rotation = quaternion;
        }
        AnimRun(tempVect);
        Debug.Log(animator.GetFloat("Speed"));
        Debug.Log("is_ground : " + _ground.IsGround);
        if (j && _ground.IsGround)
        {
            AnimFunc(-1);
            body.velocity = Vector3.zero;
            body.AddForce(transform.up * player.jumpHeight);
        }

    }

    void AnimFunc(float speed) 
    {
        animator.SetFloat("Speed", speed);
    }
    void AnimRun(Vector3 vector) 
    {
        if (vector != Vector3.zero) 
        {
            AnimFunc(1);
        }
        else 
        {
            AnimFunc(-1);
        }
    }
}
