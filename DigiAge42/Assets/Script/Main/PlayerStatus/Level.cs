using Assets.Script.Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public ScriptableObject scriptableObject;
    // Start is called before the first frame update
    void Start()
    {
        scriptableObject = GetComponent<ScriptableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
