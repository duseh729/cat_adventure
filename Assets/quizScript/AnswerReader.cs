using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI; // Text 컴포넌트에 접근하기 위해 추가해야 할 using 문
using TMPro; // TextMeshPro 바꾸기 위한 using 문

public class AnswerReader : MonoBehaviour
{    
    private string answer;
    public void answerReader()
    {
        
        TextMeshProUGUI textMesh = GetComponentInChildren<TextMeshProUGUI>();
        answer = textMesh.text;
        Debug.Log(answer);
        if (Array.IndexOf(QuestionAndAnswerTextChanger.answerList, answer) != -1){
            Debug.Log("맞는 답이야");
            QuestionAndAnswerTextChanger.trigger ++;
        }else{
            choiceDifficulty.difficulty-=1;
        }
    } 
}
