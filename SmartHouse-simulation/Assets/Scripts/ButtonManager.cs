using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour
{

    public Animator animatorDoor1;
    public Animator animatorDoor2;
    public Animator animatorDoor3;
    public Animator animatorDoor4;
    public Animator animatorDoor5;
    public Animator animatorDoor6;

    public Animator animatorWin1;
    public Animator animatorWin2;
    public Animator animatorWin3;
    public Animator animatorWin4;
    public Animator animatorWin5;
    public Animator animatorWin6;

    GameObject lastPanel;
    GameObject currentPanel;


    public GameObject MainScreen;
    public GameObject HomeApp;
    public GameObject DoorApp;
    public GameObject WinApp;
    public GameObject TVApp;
    public GameObject ACApp;

    public GameObject CityApp;
    public GameObject ECApp;
    public GameObject TransportApp;
    public GameObject ParkApp;
    public GameObject CamApp;

    public GameObject Cameras;

    public GameObject Slider;
    public GameObject HourButton1;
    public GameObject HourButton2;

    public bool ShowCanvas = false;

    public GameObject answer;
    public GameObject smartphone;
    public GameObject pauseMenu;
    public GameObject optionMenu;
    public GameObject assistantTab;
    public GameObject mainCanvas;

    public bool TVPowerOn = false;
    int counter;

    public bool ACPowerOn = false;
    public int setTemp = 20;

    public Text setTempText;

    public Material _1;
    public Material Off;
    public Material _2;
    public Material _3;
    public Material _4;
    public Material _5;
    public Material _6;
    public Material _7;
    public Material _8;
    public Material _9;

    public MeshRenderer TV;

    public string[] Answers = new string[] { "I’m good", "moose", "boars" };
    public int rand;
    public TextMeshProUGUI answertext;
    public DayNightCycle daynightcycle;
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;

    public bool enter;

    void Start()
    {
        lastPanel = MainScreen;
        currentPanel = MainScreen;
        mainCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void ChPlus()
    {
        counter++;
    }

    public void ChMinus()
    {
        counter--;
    }
    

    public void tempPlus()
    {
        setTemp++;
    }

    public void tempMinus()
    {
        setTemp--;
    }


    public void TVPower()
    {
        TVPowerOn = !TVPowerOn;
    }

    public void ACPower()
    {
        ACPowerOn = !ACPowerOn;
    }

    public void showSlider()
    {
        Slider.SetActive(true);
        HourButton2.SetActive(true);
        HourButton1.SetActive(false);
    }

    public void hideSlider()
    {
        Slider.SetActive(false);
        HourButton1.SetActive(true);
        HourButton2.SetActive(false);
    }

    public void showHome()
    {
        currentPanel.SetActive(false);
        MainScreen.SetActive(true);
        lastPanel = currentPanel;
        currentPanel = MainScreen;
    }

    public void Back()
    {
        if (currentPanel == CamApp)
        {
            Cameras.SetActive(false);
        }
        GameObject currentPanel2 = currentPanel;
        currentPanel.SetActive(false);
        lastPanel.SetActive(true);
        currentPanel = lastPanel;
        lastPanel = currentPanel2;
    }

    public void showHomeApp()
    {
        lastPanel = MainScreen;
        currentPanel.SetActive(false);
        currentPanel = HomeApp;
        HomeApp.SetActive(true);
    }

    public void showDoorApp()
    {
        lastPanel = HomeApp;
        currentPanel.SetActive(false);
        currentPanel = DoorApp;
        DoorApp.SetActive(true);
    }

    public void showWinApp()
    {
        lastPanel = HomeApp;
        currentPanel.SetActive(false);
        currentPanel = WinApp;
        WinApp.SetActive(true);
    }

    public void showTVApp()
    {
        lastPanel = HomeApp;
        currentPanel.SetActive(false);
        currentPanel = TVApp;
        TVApp.SetActive(true);
    }

    public void showACApp()
    {
        lastPanel = HomeApp;
        currentPanel.SetActive(false);
        currentPanel = ACApp;
        ACApp.SetActive(true);
    }

    public void showCityApp()
    {
        lastPanel = MainScreen;
        currentPanel.SetActive(false);
        currentPanel = CityApp;
        CityApp.SetActive(true);
    }

    public void showECApp()
    {
        lastPanel = CityApp;
        currentPanel.SetActive(false);
        currentPanel = ECApp;
        ECApp.SetActive(true);
    }

    public void showTransportApp()
    {
        lastPanel = CityApp;
        currentPanel.SetActive(false);
        currentPanel = TransportApp;
        TransportApp.SetActive(true);
    }

    public void showParkApp()
    {
        lastPanel = CityApp;
        currentPanel.SetActive(false);
        currentPanel = ParkApp;
        ParkApp.SetActive(true);
    }

    public void showCamApp()
    {
        lastPanel = CityApp;
        currentPanel.SetActive(false);
        currentPanel = CamApp;
        Cameras.SetActive(true);
        CamApp.SetActive(true);
    }

    public void openDoor1 ()
    {
        animatorDoor1.SetTrigger("Open");
    }

    public void closeDoor1()
    {
        animatorDoor1.SetTrigger("Close");
    }

    public void openDoor2()
    {
        animatorDoor2.SetTrigger("Open");
    }

    public void closeDoor2()
    {
        animatorDoor2.SetTrigger("Close");
    }

    public void openDoor3()
    {
        animatorDoor3.SetTrigger("Open");
    }

    public void closeDoor3()
    {
        animatorDoor3.SetTrigger("Close");
    }

    public void openDoor4()
    {
        animatorDoor4.SetTrigger("Open");
    }

    public void closeDoor4()
    {
        animatorDoor4.SetTrigger("Close");
    }

    public void openDoor5()
    {
        animatorDoor5.SetTrigger("Open");
    }

    public void closeDoor5()
    {
        animatorDoor5.SetTrigger("Close");
    }

    public void openDoor6()
    {
        animatorDoor6.SetTrigger("Open");
    }

    public void closeDoor6()
    {
        animatorDoor6.SetTrigger("Close");
    }


    public void openWin1()
    {
        animatorWin1.SetTrigger("Open");
    }

    public void closeWin1()
    {
        animatorWin1.SetTrigger("Close");
    }

    public void openWin2()
    {
        animatorWin2.SetTrigger("Open");
    }

    public void closeWin2()
    {
        animatorWin2.SetTrigger("Close");
    }

    public void openWin3()
    {
        animatorWin3.SetTrigger("Open");
    }

    public void closeWin3()
    {
        animatorWin3.SetTrigger("Close");
    }

    public void openWin4()
    {
        animatorWin4.SetTrigger("Open");
    }

    public void closeWin4()
    {
        animatorWin4.SetTrigger("Close");
    }

    public void openWin5()
    {
        animatorWin5.SetTrigger("Open");
    }

    public void closeWin5()
    {
        animatorWin5.SetTrigger("Close");
    }

    public void openWin6()
    {
        animatorWin6.SetTrigger("Open");
    }

    public void closeWin6()
    {
        animatorWin6.SetTrigger("Close");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        ShowCanvas = false;
        Cursor.visible = false;
    }

    public void Option()
    {
        pauseMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void Backtomenu()
    {
        optionMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    //How are you?
    public void Question1()
    {
        rand = Random.Range(0, 10);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Please, tell me what time is it now?
    public void Question2()
    {
        rand = Random.Range(10, 12);
        answertext.text = Answers[rand]  + daynightcycle.hours.ToString() + ":00";
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //What is the temperature outside?
    public void Question3()
    {
        rand = Random.Range(12, 14);
        answertext.text = Answers[rand] + daynightcycle.temp.ToString() + "°C";
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //What is your name?
    public void Question4()
    {
        rand = Random.Range(14, 17);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //How old are you?
    public void Question5()
    {
        rand = Random.Range(17, 19);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Do you like me?
    public void Question6()
    {
        rand = Random.Range(19, 21);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //What can you do?
    public void Question7()
    {
        rand = Random.Range(21, 24);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //What is this simulation for?
    public void Question8()
    {
        rand = Random.Range(24, 27);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Where are you from?
    public void Question9()
    {
        rand = Random.Range(27, 29);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Do you have feelings?
    public void Question10()
    {
        rand = Random.Range(29, 31);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Can you play music?
    public void Question11()
    {
        rand = Random.Range(31, 33);
        answertext.text = Answers[rand];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    //Where are you?
    public void Question12()
    {
        answertext.text = Answers[33];
        assistantTab.SetActive(false);
        answer.SetActive(true);
        ShowCanvas = false;
        StartCoroutine(ExecuteAfterTime(5));
    }

    public void Next1()
    {
        wheel1.SetActive(false);
        wheel2.SetActive(true);
    }

    public void Next2()
    {
        wheel2.SetActive(false);
        wheel3.SetActive(true);
    }
    public void Back1()
    {
        wheel2.SetActive(false);
        wheel1.SetActive(true);
    }

    public void Back2()
    {
        wheel3.SetActive(false);
        wheel2.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ShowCanvas = !ShowCanvas;
            smartphone.SetActive(ShowCanvas);
            Cursor.visible = ShowCanvas;
            ResetScreen();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowCanvas = !ShowCanvas;
            pauseMenu.SetActive(ShowCanvas);
            if (ShowCanvas == false && optionMenu.activeInHierarchy == true)
            {
                optionMenu.SetActive(false);
                pauseMenu.SetActive(false);
            }
            Cursor.visible = ShowCanvas;
            ResetScreen();
        }

        setTempText.text = setTemp + "°C";

        if (TVPowerOn)
        {
            switch (counter)
            {
                case 1: TV.GetComponent<MeshRenderer>().material = _1; break;
                case 2: TV.GetComponent<MeshRenderer>().material = _2; break;
                case 3: TV.GetComponent<MeshRenderer>().material = _3; break;
                case 4: TV.GetComponent<MeshRenderer>().material = _4; break;
                case 5: TV.GetComponent<MeshRenderer>().material = _5; break;
                case 6: TV.GetComponent<MeshRenderer>().material = _6; break;
                case 7: TV.GetComponent<MeshRenderer>().material = _7; break;
                case 8: TV.GetComponent<MeshRenderer>().material = _8; break;
                case 9: TV.GetComponent<MeshRenderer>().material = _9; break;
                default: break;
            }

            if (counter > 9)
            {
                counter = 9;
            }
            if (counter < 1)
            {
                counter = 1;
            }
        }
        else
        {
            TV.GetComponent<MeshRenderer>().material = Off;
        }

        if (Input.GetKeyDown(KeyCode.Tab) && enter)
        {
            ShowCanvas = !ShowCanvas;
            assistantTab.SetActive(ShowCanvas);
            Cursor.visible = ShowCanvas;
            ResetScreen();
        }
    }
        
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        answer.SetActive(false);
    }

    public void ResetScreen()
    {
        mainCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }
}
