using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    private KeyCode pickupKey = KeyCode.E;
    public GameObject currentWeapon;
    public Transform hand;
    
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        
        if (Physics.Raycast(ray, out hit, 1))
        {
            if (hit.transform.CompareTag("Weapon") && Input.GetKeyDown(pickupKey))
            {
                if (currentWeapon != null)
                    Destroy(currentWeapon);
                currentWeapon = Instantiate(hit.transform.gameObject, hand.transform.position, hand.transform.rotation, hand);
            }
        }
    }
}
