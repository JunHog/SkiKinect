using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finnished = false;
    private bool started = false;
    public float _delay = 2f;

    public static string finalTime = "";

    // Use this for initialization
    public IEnumerator Start() {
        yield return new WaitForSeconds(3f);
        started = true;
        startTime = Time.time;
    }


    // Update is called once per frame
    void Update () {
        string AddZero;
        if (finnished) {
            finalTime = timerText.text;
            return;
        }

        if (started) {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString("d2");
            if (t % 60 < 10.00) { AddZero = "0"; } else { AddZero = ""; }
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + "." + AddZero + seconds;
        }
	}

    public void Finnish() {
        finnished = true;
        timerText.color = Color.yellow;
        //yield return new WaitForSeconds(_delay);
        //SceneManager.LoadScene("start-screen-1");
    }

}
