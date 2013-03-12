using UnityEngine;
using System.Collections;

public class CoreMovement : MonoBehaviour {
	
	public GameObject exposed;
	public GameObject resting;
	
	public float exposeTime;
	public float restTime;
	
	private bool isExposed;
	private float lastMoved;
	
	// Use this for initialization
	void Start () {
		exposed = GameObject.Find("CoreExposed");
		resting = GameObject.Find("CoreResting");
		isExposed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isExposed){
			gameObject.transform.position = exposed.transform.position;	
		}
		else{
			gameObject.transform.position = resting.transform.position;	
		}
	}
	
	public void changePosition(){
		lastMoved = Time.time;
		isExposed = !isExposed;
	}
}
