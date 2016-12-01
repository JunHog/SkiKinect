using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finnished = false;
    private bool started = false;

	// Use this for initialization
	public IEnumerator Start() {
        yield return new WaitForSeconds(3f);
        started = true;
        startTime = Time.time;
    }


    // Update is called once per frame
    void Update () {
        string AddZero;
        if (finnished)
            return;

        if (started) {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString("d2");
            if (t % 60 < 10.00) { AddZero = "0"; } else { AddZero = ""; }
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + "." + AddZero + seconds;
        }
	}

    public void Finnished() {
        finnished = true;
        timerText.color = Color.yellow;
    }
}
