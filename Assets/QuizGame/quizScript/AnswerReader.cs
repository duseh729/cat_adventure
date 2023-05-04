using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI; // Text 컴포넌트에 접근하기 위해 추가해야 할 using 문
using TMPro; // TextMeshPro 바꾸기 위한 using 문
using UnityEngine;

public class AnswerReader : MonoBehaviour
{    
    private string answer;
    public void AnswerReaderHandler()
    {
        TextMeshProUGUI textMesh = GetComponentInChildren<TextMeshProUGUI>();
        answer = textMesh.text;
        Debug.Log(answer);
        if (Array.IndexOf(QuestionAndAnswerTextChanger.answerList, answer) != -1){
            Debug.Log("맞는 답이야");
            QuizManager.nextFlag = true;
            NextBtnEvent.nextBtn.gameObject.SetActive(QuizManager.nextFlag);
            // QuestionAndAnswerTextChanger.trigger ++;
        }else{
            Debug.Log("hihi");
            // choiceDifficulty.difficulty-=1;
            QuizManager.publicLife--;
        }
    } 
}
