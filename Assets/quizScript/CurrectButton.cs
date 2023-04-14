using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrectButton : MonoBehaviour
{
    public static bool flag = false;
    // Start is called before the first frame update
    public void CurrectButtonClicked()
    {
        Debug.Log("맞는 답이야");
        flag = true;
    }

    void Start(){}

    void Update(){}
}
