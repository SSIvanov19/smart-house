using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using TMPro;
using UnityEngine;

public class parkingcheker2 : MonoBehaviour
{
    public TextMeshProUGUI park;
    public Color red;
    public Color green;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            park.color = red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            park.color = green;
        }
    }
}
