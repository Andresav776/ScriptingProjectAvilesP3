using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatement : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 3f;
    }

    void TemperatureTest ()
    {
        // If coffee is too hot
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("I just burnt my tongue.");
        }

        // If coffee is too cold

        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("This coffee is cold.");
        }

        else
        {
            print("This is some good coffee.");
        }
    }
}
