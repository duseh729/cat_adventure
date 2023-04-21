using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro; // TextMeshPro 바꾸기 위한 using 문
[System.Serializable]

public class QuizManager : MonoBehaviour
{
    public TMP_Text life;

    public GameObject nextButton;
    void Update(){
        int publicLife = choiceDifficulty.difficulty;
        life.text = publicLife.ToString();
        if(publicLife==0){
            changeScene.ChangeScene("gameOver");
        }
        nextButton.SetActive(QuestionAndAnswerTextChanger.flag);
    }
}

// 구현해야 하는 것.
// # 문제 랜덤 위치 (문제는 3개 정도로 구현)
// 1. 문제랑 정답 여부를 같이 저장. ex) ([아이유, currect], [이수신, failed])
// 2. 문제만 게임에 출력.
// 3. 선택시 정답 여부에 따른 이벤트 생성. ex) (목숨 까이기, 틀렸다는 걸 보여주기)
// 4. 문제 위치는 Random 함수로 배치.

// @@@@@@@@@@ 완료
// # 스테이지 클리어시 다음 버튼 활성화.
// 1. flag 변수에 true, false로 스테이지 클리어 여부 저장
// 2. true 값이면 object 활성화 / false면 object 비활성화
// 3. 클릭시 다음 층으로 가기 (초고난이도??) 

// # esc 메뉴 기능.
// 1. 게임 전체에 esc 키보드 이벤트 리슨
// 2. esc 입력 시 true/false로 제어?
// 3. true/false에 따른 모달창 보이기
// 4. 설정 버튼 우측 상단에 위치 (esc키와 같은 기능)
// 5. esc 누르면 게임 멈춤.

// @@@@@@@@@@ 완료
// # 보유한 목숨 보이기.
// 1. count 변수로 남은 목숨에 따른 이미지 보여주기
// 2. 이미지 없을시 숫자만 보여주기
