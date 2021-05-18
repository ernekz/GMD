using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScore : MonoBehaviour
{
    public GameObject TextDisplay;
    public float TheDistance = PlayerCasting.DistanceFromTarget;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                GlobalScore.CurrentScore = 0;
            }
        }
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Press to reset the score";
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }
}
