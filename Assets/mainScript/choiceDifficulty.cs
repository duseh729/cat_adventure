using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class choiceDifficulty : MonoBehaviour, IPointerClickHandler
{
    public static int difficulty;
    public void OnPointerClick(PointerEventData eventData)
    {
        string idx = eventData.pointerPress.name;
        Debug.Log("Clicked button: " + idx);
        if (idx=="easy"){
            difficulty = 100;
        } else if (idx=="basic"){
            difficulty=10;
        } else{
            difficulty=1;
        }
        Debug.Log(difficulty);
    }

    void Start(){

    }
}
