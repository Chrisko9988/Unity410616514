using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class function : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Ingame() {
        SceneManager.LoadSceneAsync(1);
    }
    public void LeaveGame() {
        Application.Quit();
    }
}
