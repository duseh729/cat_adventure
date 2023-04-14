using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void FailedButtonClicked()
    {
        Debug.Log("틀렸어");
        choiceDifficulty.difficulty-=1;
    }
}
