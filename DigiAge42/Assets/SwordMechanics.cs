using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMechanics : MonoBehaviour
{
    private Animator anim;
    bool firstAttack;
    bool SecondAttack;
    float _time = 0f;
    public GameObject player;
    float maxComboDelay = 1.3f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
            OnClick();
        if (_time >= maxComboDelay)
        {
            firstAttack = false;
            SecondAttack = false;
            player.GetComponent<Move>().p_speed = 5;
            _time = 0;
        }
        if (!SecondAttack && firstAttack && _time >= 0.7f)
            player.GetComponent<Move>().p_speed = 5;
    }

    void OnClick()
    {
        if (!firstAttack)
        {
            anim.SetTrigger("Attack1");
            firstAttack = true;
            player.GetComponent<Move>().p_speed = 2;
            _time = 0;
        }

        if (firstAttack && !SecondAttack && _time >= 0.7f)
        {
            anim.SetTrigger("Attack2");
            player.GetComponent<Move>().p_speed = 2;
            SecondAttack = true;
        }
    }
}
