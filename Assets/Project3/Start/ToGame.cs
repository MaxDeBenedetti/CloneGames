using UnityEngine;
using System.Collections;

public class ToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("ending",14);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.anyKey){
			Application.LoadLevel("Game");
		}
	}
}
