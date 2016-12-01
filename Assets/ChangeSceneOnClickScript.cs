using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClickScript : MonoBehaviour {

    public string _nextScene = "";


	// Update is called once per frame
	public void Update () {
	
        if (Input.GetMouseButtonDown(0) || (Input.touches != null && Input.touches.Length>0)){
            //Application.LoadLevel(_nextScene);
            SceneManager.LoadScene(_nextScene);
        }

	}
}
