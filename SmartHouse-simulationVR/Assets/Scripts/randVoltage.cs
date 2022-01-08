using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randVoltage : MonoBehaviour
{
    public TextMeshPro text;
    public TextMeshPro text2;
    public TextMeshProUGUI textSmartphone;
    private float random;
    public float timeLeft = 10.0f;
    float min = 19.28f;
    float max = 21.38f;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            random = Random.Range(min, max);
            text.text = random.ToString() + " V";
            text2.text = random.ToString() + " V";
            textSmartphone.text = random.ToString() + " V";
            timeLeft = 3.0f;
            if (min < 220)
            {
                min += 10;
                max += 10;
            }
            else
            {
                min = 200;
                max = 240;
            }
        }
    
    }
}
