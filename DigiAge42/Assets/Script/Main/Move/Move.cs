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
    public Ground _ground;
    private AnimatorManager _animatorManager;
    private Transform _transform;

    JumpManager jumpManager;
    Vector3 tempVect;

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
        _animatorManager = new AnimatorManager(animator);
        jumpManager = new JumpManager(_ground, body, player, _animatorManager, _transform);
    }

    // Update is called once per frame
    void Update()
    {
        MoveFunc();
    }

    void MoveFunc()
    {
        tempVect = new Vector3(0, 0, 0);
        bool d = Input.GetKey(KeyCode.D);
        bool a = Input.GetKey(KeyCode.A);
        bool j = Input.GetKey(KeyCode.Space);
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
        if (j && _ground.IsGround)
        {
            jumpManager.Jump(tempVect);
        }
        _animatorManager.SetAnim("Speed", 1);
        _animatorManager.AnimRun("Speed", tempVect);

    }
}
