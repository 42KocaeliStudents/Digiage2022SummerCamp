using Assets.Script.Entity;
using Assets.Script.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public GameObject player;
    public Ground _ground;
    private Animator animator;
    private bool isRoll = false;
    private bool moveLeft;
    private bool moveRight;
    Vector3 tempVect = new Vector3(0, 0, 0);
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        RollFunc();
    }

    private void RollFunc()
    {
        bool lCtrl = Input.GetKey(KeyCode.LeftControl);
        if (lCtrl && _ground == true)
        {
            player.GetComponent<Move>().p_speed = 15f;
            StartCoroutine(RollEnum());
        }
    }

    void RollMove()
    {
        if (player.GetComponent<Move>().transform.rotation.y > 0)
            RollMoveRight();
        else if (player.GetComponent<Move>().transform.rotation.y < 0)
            RollMoveLeft();
    }

    private void RollMoveLeft()
    {
        tempVect.x = -1;
        tempVect = tempVect.normalized * player.GetComponent<Move>().p_speed * Time.deltaTime;
        player.GetComponent<Move>().body.MovePosition(transform.position + tempVect);
    }

    private void RollMoveRight()
    {
        tempVect.x = 1;
        tempVect = tempVect.normalized * player.GetComponent<Move>().p_speed * Time.deltaTime;
        player.GetComponent<Move>().body.MovePosition(transform.position + tempVect);
    }

    IEnumerator RollEnum() 
    {
        isRoll = true;
        animator.SetTrigger("Roll");
        for (int i = 0; i < 205; i++)
        {
            RollMove();
            yield return new WaitForSeconds(0.01f);
        }
        tempVect.x = 0;
        isRoll = false;
    }
}
