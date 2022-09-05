using Assets.Script.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilitaryManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Military military;
    public GameObject swordMechanics;
    void Start()
    {
        Debug.Log("Start");
        military = new Military();
        military.Healty = 100;
        Enemy enemy = new Enemy();
        enemy.Name = "Military";
        enemy.JumpHeight = 100;
        enemy.Speed = 100;
        enemy.IsGround = true;
        military.Enemy = enemy;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(swordMechanics.GetComponent<SwordMechanics>().attack);
        if (swordMechanics.GetComponent<SwordMechanics>().attack)
            military.Healty -= 1f;
        if (military.Healty <= 0)
            Destroy(this.gameObject);
        Debug.Log(military.Healty);
        Debug.Log("tag enemy is military manager :" + military.Enemy.Name);
    }
}
