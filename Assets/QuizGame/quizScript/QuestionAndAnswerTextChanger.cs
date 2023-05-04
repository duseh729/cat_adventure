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

    public static int trigger = 0;
    // 게임이 끝나기 위한 변수
    public static bool flag = false;


    string[] questions = {"아이유가 정답임", "이순신이 정답임", "안중근이 정답임"};
    string[,] answers = {{"아이유", "카리나", "윈터", "이나경"}, {"이순신", "을지문덕", "광개토대왕", "김유신"}, {"안중근", "윤봉길", "이토 히로부미", "하얼빈"}};
    public static string[] answerList = {"아이유", "이순신", "안중근"};

    void Start(){
        // 한국어 폰트 설정
        TextMeshProUGUI textMeshProUGUI = GetComponent<TextMeshProUGUI>(); // TextMeshProUGUI 컴포넌트 가져오기
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.font = koreanFontAsset; // 한국어 폰트 파일 할당
        }
    }
    void Update(){
        if (trigger == 3){
            trigger=2;
            flag=true;
        }

        Text questionText = questionBox.GetComponent<Text>();

        questionText.text = questions[trigger];
        firstAnswerBox.text = answers[trigger,0];
        secondAnswerBox.text =answers[trigger,1];
        thirdAnswerBox.text = answers[trigger,2];
        fourthAnswerBox.text =answers[trigger,3];
    }
    // Start is called before the first frame update

}
