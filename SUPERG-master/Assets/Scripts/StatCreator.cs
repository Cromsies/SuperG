using UnityEngine;
using System.Collections;


public class StatCreator : MonoBehaviour
{
   // public shoot Shit;

    void Start()
    {
        if (GetComponent<TextMesh>().text == "Shots Fired: ")
            GetComponent<TextMesh>().text = "Shots Fired : " + shoot.shotCounter;
        if (GetComponent<TextMesh>().text == "Hits: ")
            GetComponent<TextMesh>().text = "Hits: " + bullet.hitCounter/2;
        if (GetComponent<TextMesh>().text == "Accuracy: ")
            GetComponent<TextMesh>().text = "Accuracy : " + shoot.accuracy;
        if (GetComponent<TextMesh>().text == "FINAL SCORE: ")
            GetComponent<TextMesh>().text = "YOUR FINAL SCORE: " + bullet.hitCounter / 2 * 100;

    }
    

}