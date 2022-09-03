using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Move;
using Assets.Script.Entity;
using static UnityEditor.FilePathAttribute;
using Assets.Script.Main;
using Assets.Script.Concrete;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody body;
    private Animator animator;
    private Player player;
    private int xLocation = 0;
    public Ground _ground;
    private AnimatorManager _animatorManager;
    JumpManager jumpManager;

    public Move()
    {
    }

    void Start()
    {
        OnLoad onLoad = new OnLoad();

        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        _animatorManager = new AnimatorManager(animator);
        jumpManager = new JumpManager(_ground, body, player, _animatorManager);
        player = onLoad.GetPlayer();
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
        if (d)
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
        _animatorManager.AnimRun("Speed", tempVect);
        jumpManager.Jump(tempVect);

    }
}
