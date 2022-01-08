using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class transportMeneger : MonoBehaviour
{
    public float timerTrain1 = 60;
    public float timerTrain2 = 125;
    public float timerBus = 50;
    public TextMeshProUGUI textTrain1;
    public TextMeshProUGUI textTrain2;
    public TextMeshProUGUI textBus;
    public TextMeshPro textTrain1Board;
    public TextMeshPro textTrain2Board;
    public TextMeshPro textBusBoard;
    public TextMeshPro textTrain1Board2;
    public TextMeshPro textTrain2Board2;
    public TextMeshPro textBusBoard2;



    // Update is called once per frame
    void Update()
    {
        timerTrain1 -= Time.deltaTime;
        timerTrain2 -= Time.deltaTime;
        timerBus -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timerTrain1 / 60F);
        int seconds = Mathf.FloorToInt(timerTrain1 - minutes * 60);
        string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

        int minutes2 = Mathf.FloorToInt(timerTrain2 / 60F);
        int seconds2 = Mathf.FloorToInt(timerTrain2 - minutes2 * 60);
        string niceTime2 = string.Format("{0:00}:{1:00}", minutes2, seconds2);

        int minutes3 = Mathf.FloorToInt(timerBus / 60F);
        int seconds3 = Mathf.FloorToInt(timerBus - minutes3 * 60);
        string niceTime3 = string.Format("{0:00}:{1:00}", minutes3, seconds3);

        textTrain1.text = niceTime;
        textTrain1Board.text = niceTime;
        textTrain1Board2.text = niceTime;

        textTrain2.text = niceTime2;
        textTrain2Board.text = niceTime2;
        textTrain2Board2.text = niceTime2;

        textBus.text = niceTime3;
        textBusBoard.text = niceTime3;
        textBusBoard2.text = niceTime3;

        if (timerTrain1 < 0)
        {
            timerTrain1 = 123;
        }

        if (timerTrain2 < 0)
        {
            timerTrain2 = 125;
        }

        if (timerBus < 0)
        {
            timerBus = 131;
        }
    }
}
