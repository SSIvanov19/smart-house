using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    public Light sun;

    public float secondsInFullDay = 86400f;

    //0 (пулопнощ),  0.25 (изгрев), 0.5 (обяд), 0.75 (залез), 1 (пулопнощ).
    [Range(0, 1)]
    public float currentTimeOfDay = 0;

    [HideInInspector]
    public float timeMultiplier = 1f;

    public double hours = 0;
    public int temp;

    float sunInitialIntensity;

    public Material DaySkybox;
    public Material NightSkybox;

    public GameObject houseLight;
    public GameObject insideLight;

    public Text hourtext;
    public Text temptext;
    public Text temptext2;

    public Sprite sunIcon;
    public Sprite moonIcon;

    public Image icon;
    public Image sliderImage;

    public ButtonManager buttonManager;

    void Start()
    {
        hourtext.text = hours.ToString();
        sunInitialIntensity = sun.intensity;
        temptext.text = temp.ToString();
        temptext2.text = temp.ToString();
    }

    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay <= 0.042)
        {
            hours = 0;
            temp = 10;
        }
        else if (currentTimeOfDay > 0.042 && currentTimeOfDay <= 0.042 * 2)
        {
            hours = 1;
            temp = 10;
        }
        else if (currentTimeOfDay > 0.042 * 2 && currentTimeOfDay <= 0.042 * 3)
        {
            hours = 2;
            temp = 9;
        }
        else if (currentTimeOfDay > 0.042 * 3 && currentTimeOfDay <= 0.042 * 4)
        {
            hours = 3;
            temp = 9;
        }
        else if (currentTimeOfDay > 0.042 * 4 && currentTimeOfDay <= 0.042 * 5)
        {
            hours = 4;
            temp = 9;
        }
        else if (currentTimeOfDay > 0.042 * 5 && currentTimeOfDay <= 0.042 * 6)
        {
            hours = 5;
            temp = 9;
        }
        else if (currentTimeOfDay > 0.042 * 6 && currentTimeOfDay <= 0.042 * 7)
        {
            hours = 6;
            temp = 9;
        }
        else if (currentTimeOfDay > 0.042 * 7 && currentTimeOfDay <= 0.042 * 8)
        {
            hours = 7;
            temp = 10;
        }
        else if (currentTimeOfDay > 0.042 * 8 && currentTimeOfDay <= 0.042 * 9)
        {
            hours = 8;
            temp = 11;
        }
        else if (currentTimeOfDay > 0.042 * 9 && currentTimeOfDay <= 0.042 * 10)
        {
            hours = 9;
            temp = 11;
        }
        else if (currentTimeOfDay > 0.042 * 10 && currentTimeOfDay <= 0.042 * 11)
        {
            hours = 10;
            temp = 14;
        }
        else if (currentTimeOfDay > 0.042 * 11 && currentTimeOfDay <= 0.042 * 12)
        {
            hours = 11;
            temp = 16;
        }
        else if (currentTimeOfDay > 0.042 * 12 && currentTimeOfDay <= 0.042 * 13)
        {
            hours = 12;
            temp = 18;
        }
        else if (currentTimeOfDay > 0.042 * 13 && currentTimeOfDay <= 0.042 * 14)
        {
            hours = 13;
            temp = 19;
        }
        else if (currentTimeOfDay > 0.042 * 14 && currentTimeOfDay <= 0.042 * 15)
        {
            hours = 14;
            temp = 20;
        }
        else if (currentTimeOfDay > 0.042 * 15 && currentTimeOfDay <= 0.042 * 16)
        {
            hours = 15;
            temp = 20;
        }
        else if (currentTimeOfDay > 0.042 * 16 && currentTimeOfDay <= 0.042 * 17)
        {
            hours = 16;
            temp = 20;
        }
        else if (currentTimeOfDay > 0.042 * 17 && currentTimeOfDay <= 0.042 * 18)
        {
            hours = 17;
            temp = 19;
        }
        else if (currentTimeOfDay > 0.042 * 18 && currentTimeOfDay <= 0.042 * 19)
        {
            hours = 18;
            temp = 19;
        }
        else if (currentTimeOfDay > 0.042 * 19 && currentTimeOfDay <= 0.042 * 20)
        {
            hours = 19;
            temp = 18;
        }
        else if (currentTimeOfDay > 0.042 * 20 && currentTimeOfDay <= 0.042 * 21)
        {
            hours = 20;
            temp = 17;
        }
        else if (currentTimeOfDay > 0.042 * 21 && currentTimeOfDay <= 0.042 * 22)
        {
            hours = 21;
            temp = 17;
        }
        else if (currentTimeOfDay > 0.042 * 22 && currentTimeOfDay <= 0.042 * 23)
        {
            hours = 22;
            temp = 16;
        }
        else if (currentTimeOfDay > 0.042 * 23 && currentTimeOfDay <= 0.042 * 24)
        {
            hours = 23;
            temp = 15;
        }
        else if (currentTimeOfDay > 0.042 * 24 && currentTimeOfDay <= 1)
        {
            hours = 24;
            temp = 14;
        }


        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }

        if(buttonManager.ACPowerOn)
        {
            temp = buttonManager.setTemp;
        }

        hourtext.text = hours.ToString() + ":00";

        temptext.text = "Tuesday 14 Apr |    " + temp.ToString() + "°C";
        temptext2.text = temp.ToString() + "°C";

        if (hours >= 18 || hours <= 6)
        {
            RenderSettings.skybox = NightSkybox;
            RenderSettings.ambientSkyColor = Color.black;
            RenderSettings.fog = true;
            houseLight.gameObject.SetActive(true);
            insideLight.gameObject.SetActive(true);
            icon.gameObject.GetComponent<Image>().sprite = moonIcon;
            sliderImage.gameObject.GetComponent<Image>().sprite = moonIcon;
        }
        else
        {
            RenderSettings.skybox = DaySkybox;
            RenderSettings.ambientSkyColor = Color.white;
            RenderSettings.fog = false;
            insideLight.gameObject.SetActive(false);
            houseLight.gameObject.SetActive(false);
            icon.GetComponent<Image>().sprite = sunIcon;
            sliderImage.GetComponent<Image>().sprite = sunIcon;
        }

    }

    public void hourSlider(float newhour)
    {
        currentTimeOfDay = newhour;
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);

        float intensityMultiplier = 1;
 
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        
        else if (currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        else if (currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }

        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
}
