using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static float time = 3;
    public static bool isQuizTimeRunning = true;
    public static bool timeOverTrigger = false;

    public TMP_Text timer;
    public TMP_Text timeOverUi;
    void Update()
    {
        if (isQuizTimeRunning){
            time -= Time.deltaTime;
        }else if(timer.text == "0"){
            isQuizTimeRunning = false;
        }else{
            if (timer.text == "0"){
            isQuizTimeRunning = false;
            timeOverTrigger = true;

            AnswerReader.correctAnswerTrigger = true;
            NextBtnEvent.nextBtn.gameObject.SetActive(true);
            NextBtnEvent.nextFlag = true;
            }else if(isQuizTimeRunning==false && timer.text != "0"){
                isQuizTimeRunning = true;
                timeOverTrigger = false;

                AnswerReader.correctAnswerTrigger = false;
                NextBtnEvent.nextBtn.gameObject.SetActive(false);
                NextBtnEvent.nextFlag = false;
            }else{
                AnswerReader.correctAnswerTrigger = false;
            }
        }
        timeOverUi.enabled = timeOverTrigger;
        timer.text = time.ToString("F0");
    }
}
