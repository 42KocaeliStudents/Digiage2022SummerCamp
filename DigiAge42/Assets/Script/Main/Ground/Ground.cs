using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool IsGround;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("floor"))
            IsGround = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("floor"))
            IsGround = false;
    }
}
