using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    public KeyCode pickupKey = KeyCode.F;
    public KeyCode dropKey = KeyCode.G;
    string weaponTag = "Weapon";

    public GameObject weapon;

    public GameObject currentWeapon;
    public Transform hand;
    public Transform dropPoint;
    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag(weaponTag) && Input.GetKeyDown(pickupKey))
            {         

                hit.collider.gameObject.SetActive(false);
                hit.transform.parent = hand;
                hit.transform.position = hand.transform.position;
                hit.transform.rotation = hand.transform.rotation;
                hit.collider.gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(dropKey) && currentWeapon != null)
        {
            currentWeapon.transform.parent = null;
            currentWeapon.transform.position = dropPoint.position;
            currentWeapon.transform.rotation = new Quaternion(180, 0, 0, 0);
            currentWeapon = null;
        }
    }
}
