using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speedometer : MonoBehaviour {

    public Text speedText;

    Vector3 previous;
    float velocity;
     

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    public IEnumerator Update () {
        string AddZero;
        //double speed = GetComponent<Rigidbody>().velocity * 3.6;
        //speedText.text = speed.ToString("f2") + " Km/H";

        velocity = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;

        yield return new WaitForSeconds(1f);

        if (velocity < 10.00) { AddZero = "0"; } else { AddZero = ""; }
        speedText.text = AddZero + velocity.ToString("f0") + " Km/H";

    }
}
