using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBtnEvent : MonoBehaviour
{
    public static Button nextBtn;
    
    void Start(){
        nextBtn=GetComponent<Button>();
    }

    void Update(){
        nextBtn.gameObject.SetActive(QuizManager.nextFlag);
    }

    public void NextBtnClick(){
        QuestionAndAnswerTextChanger.trigger++;
        QuizManager.nextFlag=false;
    }
}
