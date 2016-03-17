using UnityEngine;
using System.Collections;

public class mainMenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void StartGame () {
	Application.LoadLevel ("scene2");
	}

	public void Start3DGame(){
		Application.LoadLevel ("scene3");
	}
	public void ExitGame () {
		Application.Quit();
	}
}
