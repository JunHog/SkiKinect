using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinBox : MonoBehaviour {

    public string _nextScene = "start-screen-1";
    public float _delay = 3f;

    private IEnumerator OnTriggerEnter(Collider other) {
        GameObject.Find("Player").SendMessage("Finnish");


        yield return new WaitForSeconds(_delay);
        GameObject.Find("Camera").SendMessage("Finnish");
    }
}
