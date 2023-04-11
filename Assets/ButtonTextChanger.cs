using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChanger : MonoBehaviour
{
    public Button myButton; // Button 오브젝트를 저장할 public 변수
    public string myNewText = "hello"; // 변경할 텍스트를 저장할 public 변수

    void Start()
    {
        // Button 오브젝트를 찾아서 myButton 변수에 할당
        myButton = GetComponent<Button>();

        // Button 오브젝트의 Text 컴포넌트를 찾아서 텍스트를 변경
        myButton.GetComponentInChildren<Text>().text = myNewText;
    }
}