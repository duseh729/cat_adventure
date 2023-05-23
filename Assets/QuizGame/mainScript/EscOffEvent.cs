using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscOffEvent : MonoBehaviour
{
    public void EscBtnClick(){
        EscManager.escFlag = false;
    }
}
