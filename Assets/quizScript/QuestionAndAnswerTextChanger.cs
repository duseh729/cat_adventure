using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Text 컴포넌트에 접근하기 위해 추가해야 할 using 문
using TMPro; // TextMeshPro 바꾸기 위한 using 문

public class QuestionAndAnswerTextChanger : MonoBehaviour
{
    public GameObject questionBox;
    public TMP_Text firstAnswerBox;
    public TMP_Text secondAnswerBox;
    public TMP_Text thirdAnswerBox;
    public TMP_Text fourthAnswerBox;

    public TMP_FontAsset koreanFontAsset; // 한국어 폰트 파일

    string[] questions = {"아이유가 정답임", "이순신이 정답임", "안중근이 정답임"};
    string[] firstAnswers = {"아이유", "카리나", "윈터", "이나경"};
    string[] secondAnswers = {"이순신", "을지문덕", "광개토대왕", "김유신"};
    string[] thirdAnswers = {"안중근", "윤봉길", "이토 히로부미", "하얼빈"};

    void Start(){
        // 한국어 폰트 설정
        TextMeshProUGUI textMeshProUGUI = GetComponent<TextMeshProUGUI>(); // TextMeshProUGUI 컴포넌트 가져오기
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.font = koreanFontAsset; // 한국어 폰트 파일 할당
        }

        // questionTextObject의 Text 컴포넌트를 가져옴
        Text questionText = questionBox.GetComponent<Text>();

        // Text 컴포넌트의 text 속성을 사용하여 텍스트 변경
        questionText.text = questions[0];
        firstAnswerBox.text = firstAnswers[0];
        secondAnswerBox.text = firstAnswers[1];
        thirdAnswerBox.text = firstAnswers[2];
        fourthAnswerBox.text = firstAnswers[3];
    }
}
