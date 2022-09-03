using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    public KeyCode pickupKey = KeyCode.F;
    public KeyCode dropKey = KeyCode.G;
    string weaponTag = "Weapon";

    public List<GameObject> weapons;
    public int maxWeapons = 2;

    public GameObject currentWeapon;
    public Transform hand;
    public Transform dropPoint;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectWeapon(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectWeapon(1);
        }

        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag(weaponTag) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
            {         
                weapons.Add(hit.collider.gameObject);

                hit.collider.gameObject.SetActive(false);

                hit.transform.parent = hand;
                hit.transform.position = Vector3.zero;
            }
        }

        if (Input.GetKeyDown(dropKey) && currentWeapon != null)
        {
            currentWeapon.transform.parent = null;

            currentWeapon.transform.position = dropPoint.position;
         
            var weaponInstanceId = currentWeapon.GetInstanceID();
            for (int i = 0; i < weapons.Count; i++)
            {
                if (weapons[i].GetInstanceID() == weaponInstanceId)
                {
                    weapons.RemoveAt(i);
                    break;
                }
            }

            currentWeapon = null;
        }
    }

    void SelectWeapon(int index)
    {
        if (weapons.Count > index && weapons[index] != null)
        {

            if (currentWeapon != null)
            {            
                currentWeapon.gameObject.SetActive(false);
            }
            currentWeapon = weapons[index];
            currentWeapon.SetActive(true);
        }
    }
}
