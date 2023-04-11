using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonActivate : MonoBehaviour
{
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextButton.SetActive(CurrectButton.flag);
    }
}
