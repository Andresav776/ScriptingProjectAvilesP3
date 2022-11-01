using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int cups = 4;

    // Start is called before the first frame update
    void Start()
    {
        while(cups > 0)
        {
            cups--;
            Debug.Log ("Cups left to Wash: " + cups);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
