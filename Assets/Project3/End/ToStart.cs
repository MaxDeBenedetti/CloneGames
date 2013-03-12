using UnityEngine;
using System.Collections;

public class ToStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.anyKey){
			Invoke("restart",1);
		}
	}
	
	void restart(){
		
		print ("hi");
		Application.LoadLevel("Start");
	}
}
