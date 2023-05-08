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
    // 답 선택시 답배열에 답이 있는지 확인하는 함수.
    public void AnswerReaderHandler()
    {
        // 클릭한 button의 text를 가져와서 answer 변수에 넣음.
        TextMeshProUGUI textMesh = GetComponentInChildren<TextMeshProUGUI>();
        answer = textMesh.text;
        // 배열에 답을 확인하는 함수.
        if (Array.IndexOf(QuestionAndAnswerTextChanger.answerList, answer) != -1){
            if (QuestionAndAnswerTextChanger.trigger>=2){
                changeScene.ChangeScene("index");
            }
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
