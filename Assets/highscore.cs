using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class highscore : MonoBehaviour {

    public string yourresult = "00:00:00";
    public static string bestTime;
    public Text yourTimeText;
    public Text bestTimeText;

    // Use this for initialization
    void Start () {
        yourresult = Timer.finalTime;
        yourTimeText.text = yourresult ;

        if (bestTime == null) {
            bestTime = yourresult;
            bestTimeText.text = bestTime;

        }else {
            bestTimeText.text = bestTime;
        }
    }
}
