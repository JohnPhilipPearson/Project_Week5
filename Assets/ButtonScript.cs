using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// Navigate to main scene
	public void StartScene()
	{
		// We will load the first scene (this is scene 0)
		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}
}
