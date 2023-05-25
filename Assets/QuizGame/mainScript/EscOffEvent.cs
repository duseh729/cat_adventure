using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscOffEvent : MonoBehaviour
{    
    private AudioManager audioManager;    
    void Start()
    {
        // AudioManager에 대한 참조 가져오기
        // 중요.
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void EscBtnClick(){
        EscManager.escFlag = false;
        EscManager.settingUiFlag = true;
        Time.timeScale = 1f;
        audioManager.audioSource.Play(); // 재생
    }
}
