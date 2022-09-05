using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    // Start is called before the first frame update
    private bool mouseRight;
    private Animator animator;
    void Start()
    {
        //mouseRight = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DefenseFunc();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            mouseRight = true;
        else if (Input.GetMouseButtonUp(1))
            mouseRight = false;
    }

    void DefenseFunc()
    {
        if (mouseRight == true)
            animator.SetBool("Defense", true);
        else if (mouseRight == false)
            animator.SetBool("Defense", false);

    }
}
