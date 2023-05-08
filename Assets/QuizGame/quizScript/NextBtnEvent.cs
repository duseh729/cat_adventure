using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBtnEvent : MonoBehaviour
{
    // button 오브젝트 가져오는 코드.
    public static Button nextBtn;
    
    void Start(){
        nextBtn=GetComponent<Button>();
    }

    void Update(){
        // 오브젝트 활성화/비활성화 하는 코드.
        nextBtn.gameObject.SetActive(QuizManager.nextFlag);
    }

    public void NextBtnClick(){
        QuestionAndAnswerTextChanger.trigger++;
        QuizManager.nextFlag=false;
    }
}
