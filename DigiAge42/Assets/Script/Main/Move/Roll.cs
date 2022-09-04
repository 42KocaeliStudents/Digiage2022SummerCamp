using Assets.Script.Entity;
using Assets.Script.Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    private Player player;
    public Ground _ground;
    private Animator animator;

    private bool isRoll;
    void Start()
    {
        OnLoad onLoad = new OnLoad();
        player = onLoad.GetPlayer();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        RollFunc();
    }

    private void RollFunc()
    {
        bool b = Input.GetKey(KeyCode.B);

        if (isRoll) return;
        if (b && _ground == true)
        {
            StartCoroutine(RollEnum());
        }
    }

    IEnumerator RollEnum() 
    {
        isRoll = true;
        SetAnim("Roll", isRoll);
        for (int i = 0; i < (90 / player.rotateSpeed); i++)
        {
            yield return new WaitForSeconds(0.01f);
        }
        isRoll = false;
    }

    public void AnimRun(string animName, Vector3 vector)
    {
        if (vector != Vector3.zero)
        {
            SetAnim(animName, true);
        }
        else
        {
            SetAnim(animName, false);
        }
    }

    public void SetAnim(string animName, bool value)
    {
        animator.SetBool(animName, value);
    }
}
