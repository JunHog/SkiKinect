using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speedometer : MonoBehaviour {

    public Text speedText;

    Vector3 previous;
    float velocity;



    // Use this for initialization
    void Start () {
        InvokeRepeating("Launch", 3.0f, 0.7f);
    }

    // Update is called once per frame
    void Launch() {
            //double speed = GetComponent<Rigidbody>().velocity * 3.6;
            //speedText.text = speed.ToString("f2") + " Km/H";

            velocity = ((transform.position - previous).magnitude) / (Time.deltaTime*100);
            previous = transform.position;
            if(velocity<1000)
                speedText.text =  velocity.ToString("f0") + " Km/H";
        }

}
