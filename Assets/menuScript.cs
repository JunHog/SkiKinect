using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Button start;
    public Button exit;

	// Use this for initialization
	void Start () {
        start = start.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
    }
	
	// Update is called once per frame
    public void ExitGame() {
        Application.Quit();
    }

    public void PlayGame() {
        SceneManager.LoadScene("skiing");
    }
}
