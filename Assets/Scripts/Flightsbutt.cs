using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flightsbutt : MonoBehaviour
{
    public GameObject appears;
    public GameObject appears2;
    public GameObject appears3;
    public bool isEnabled = true;

    public void ButtonClicked()
    {
        isEnabled = !isEnabled;
        appears.SetActive(isEnabled);
        appears2.SetActive(isEnabled);
        appears3.SetActive(isEnabled);
    }
}