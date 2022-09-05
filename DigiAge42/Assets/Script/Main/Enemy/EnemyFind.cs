using Assets.Script.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class EnemyFind : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isEnemy = false;
    public string name;
    List<EnemyModel> enums;
    void Start()
    {
        GetsEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetsEnemy() 
    {
        enums = ((EnemyEnum[])Enum.GetValues(typeof(EnemyEnum))).Select(c => new EnemyModel() { Value = Convert.ToInt32(c), Name = c.ToString() }).ToList();
    }
    private void OnTriggerEnter(Collider collider)
    {
        GetsEnemy();
        foreach (var enumx in enums)
        {
            if (collider.gameObject.CompareTag(enumx.Name)) 
            {
                isEnemy = true;
                name = enumx.Name;
                Debug.Log("tag enemy is :" + enumx.Name);
                //Destroy(collider.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        GetsEnemy();
        foreach (var enumx in enums)
        {
            if (collider.gameObject.CompareTag(enumx.Name))
            {
                isEnemy = false;
                name = enumx.Name;
                Debug.Log("tag enemy is :" + enumx.Name);
                //Destroy(collider.gameObject);
            }
        }
    }
}
