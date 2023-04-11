using UnityEngine;
using UnityEngine.UI;

public class ButtonFinder : MonoBehaviour
{
    public string buttonName; // 찾을 Button 오브젝트의 이름을 저장할 public 변수
    private Button myButton; // Button 오브젝트를 저장할 private 변수

    void Start()
    {
        buttonName = "Button";
        // Button 오브젝트를 이름으로 찾아서 myButton 변수에 할당
        myButton = GameObject.Find(buttonName).GetComponent<Button>();
        Debug.Log(myButton);
    }
    
}