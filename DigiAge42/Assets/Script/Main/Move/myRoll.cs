using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRoll : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetTrigger("Roll");
        }
    }
}
