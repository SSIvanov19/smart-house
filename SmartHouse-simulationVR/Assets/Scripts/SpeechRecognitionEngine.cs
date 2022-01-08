using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using TMPro;

public class SpeechRecognitionEngine : MonoBehaviour
{
    public string[] keywords = new string[] { "door", "window", "close", "open" };
    public ConfidenceLevel confidence = ConfidenceLevel.Low;

    public TextMeshProUGUI results;

    protected PhraseRecognizer recognizer;
    protected string word = "door";

    public ButtonManager buttonManager;

    private void Start()
    {
        if (keywords != null)
        {
            Debug.Log("Keyword found");
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
            Debug.Log(recognizer.IsRunning);
        }

        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        results.text = "You said: <b>" + word + "</b>";
    }

    private void Update()
    {
        if (buttonManager.showSmartphone)
        {
            switch (word)
            {
                //Open Door
                case "Open door one":
                    buttonManager.openDoor1();
                    break;
                case "Open door two":
                    buttonManager.openDoor2();
                    break;
                case "Open door three":
                    buttonManager.openDoor3();
                    break;
                case "Open door four":
                    buttonManager.openDoor4();
                    break;
                case "Open door five":
                    buttonManager.openDoor5();
                    break;
                case "Open door six":
                    buttonManager.openDoor6();
                    break;
                //Close Door
                case "Close door one":
                    buttonManager.closeDoor1();
                    break;
                case "Close door two":
                    buttonManager.closeDoor2();
                    break;
                case "Close door three":
                    buttonManager.closeDoor3();
                    break;
                case "Close door four":
                    buttonManager.openDoor4();
                    break;
                case "Close door five":
                    buttonManager.openDoor5();
                    break;
                case "Close door six":
                    buttonManager.openDoor6();
                    break;
                //Open Window
                case "Open window one":
                    buttonManager.openWin1();
                    break;
                case "Open window two":
                    buttonManager.openWin2();
                    break;
                case "Open window three":
                    buttonManager.openWin3();
                    break;
                case "Open window four":
                    buttonManager.openWin4();
                    break;
                case "Open window five":
                    buttonManager.openWin5();
                    break;
                case "Open window six":
                    buttonManager.openWin6();
                    break;
                //Close Window
                case "Close window one":
                    buttonManager.closeWin1();
                    break;
                case "Close window two":
                    buttonManager.closeWin2();
                    break;
                case "Close window three":
                    buttonManager.closeWin3();
                    break;
                case "Close window four":
                    buttonManager.closeWin4();
                    break;
                case "Close window five":
                    buttonManager.closeWin5();
                    break;
                case "Close window six":
                    buttonManager.closeWin6();
                    break;
                //TV and AC
                case "Turn on the TV":
                    buttonManager.TVPowerOnFun();
                    break;
                case "Turn off the TV":
                    buttonManager.TVPowerOff();
                    break;
                case "Turn on the AC":
                    buttonManager.ACPowerOnFun();
                    break;
                case "Turn off the AC":
                    buttonManager.ACPowerOff();
                    break;
                case "Next chanel":
                    buttonManager.ChPlus();
                    break;
                case "Previous chanel":
                    buttonManager.ChMinus();
                    break;
                case "Rise the temperature":
                    buttonManager.tempPlus();
                    break;
                case "Lower the temperature":
                    buttonManager.tempMinus();
                    break;
                //Pepper
                case "How are you":
                    {
                        buttonManager.Question1();
                        word = null;
                        break;
                    }
                case "Please tell me what time is it now":
                    {
                        buttonManager.Question2();
                        word = null;
                        break;
                    }
                case "What is the temperature outside":
                    {
                        buttonManager.Question3();
                        word = null;
                        break;
                    }
                case "What is your name":
                    buttonManager.Question4();
                    word = null;
                    break;
                case "How old are you":
                    buttonManager.Question5();
                    word = null;
                    break;
                case "Do you like me":
                    buttonManager.Question6();
                    word = null;
                    break;
                case "What can you do":
                    buttonManager.Question7();
                    word = null;
                    break;
                case "What is this simulation for":
                    buttonManager.Question8();
                    word = null;
                    break;
                case "Where are you from":
                    buttonManager.Question9();
                    word = null;
                    break;
                case "Do you have feelings":
                    buttonManager.Question10();
                    word = null;
                    break;
                case "Can you play music":
                    buttonManager.Question11();
                    word = null;
                    break;
                case "Where are you":
                    buttonManager.Question12();
                    word = null;
                    break;
            }
        }
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
