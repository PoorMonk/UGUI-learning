using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStartGame(string strSceneName)
    {
        //Application.LoadLevel(strSceneName);
        SceneManager.LoadScene(strSceneName);
    }
}
