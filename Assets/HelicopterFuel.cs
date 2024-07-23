using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelicopterFuel : MonoBehaviour
{
    public Text fuelText;
    public int fuel = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            FuelLeft(5);
        }
    }

    void FuelLeft(int fuelLeft)
    {
        fuel -= fuelLeft;
        fuelText.text = "Fuel: " + fuel;
    }
}
