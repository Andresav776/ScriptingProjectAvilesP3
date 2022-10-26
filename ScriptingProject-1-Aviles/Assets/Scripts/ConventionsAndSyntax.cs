using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // X Position = 0

        /*YOOOOO!
         * TWO LINES!
         */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("Bruv I'm going to hit the ground");
        }
    }
}
