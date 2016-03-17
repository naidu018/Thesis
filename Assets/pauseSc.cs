
using UnityEngine;
using System.Collections;
//var pause: Canvas;
public class pauseSc : MonoBehaviour {
	public GameObject menu;
	private bool isShowing;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			isShowing=!isShowing;
			menu.SetActive(isShowing);
		}	

	}
}
