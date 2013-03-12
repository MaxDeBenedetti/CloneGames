using UnityEngine;
using System.Collections;

public class boundry : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			PlayerPrefs.SetInt("ending",15);
			Application.LoadLevel("End");
		}
	}
}
