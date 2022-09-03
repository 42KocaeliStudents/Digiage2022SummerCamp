using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    private KeyCode pickupKey = KeyCode.F;
    public GameObject currentWeapon;
    public Transform hand;

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Weapon") && Input.GetKeyDown(pickupKey))
            {         
                hit.transform.position = hand.transform.position;
                hit.transform.rotation = hand.transform.rotation;
                hit.transform.parent = hand;
                currentWeapon = hit.collider.gameObject;
            }
        }
    }
}
