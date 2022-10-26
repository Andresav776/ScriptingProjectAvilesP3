using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int Numb = 2;

    int Times2 (int number)
    {
        int result;
        result = number * 2;
        return result;
    }

   void Start()
    {
        Numb = Times2(Numb);
        Debug.Log(Numb);
    }
}
