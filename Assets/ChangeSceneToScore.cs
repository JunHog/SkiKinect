using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneToScore : MonoBehaviour {

    public float _delay = 3f;

    // Use this for initialization
    public void Finnish() {
        SceneManager.LoadScene("start-screen-1");
    }
}
