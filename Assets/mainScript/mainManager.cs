using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainManager : MonoBehaviour
{
    public GameObject easyButton;
    public GameObject basicButton;
    public GameObject hardButton;

    void Start() {
        Camera.main.rect = new Rect(0, 0, 1, 1);
    }
}
