using UnityEngine;
using System.Collections;

public class CoreMovement : MonoBehaviour {
	
	public GameObject exposed;
	public GameObject resting;
	
	public float exposeTime;
	public float restTime;
	
	private bool isExposed;

	
	// Use this for initialization
	void Start () {
		exposed = GameObject.Find("CoreExposed");
		resting = GameObject.Find("CoreResting");
		StartCoroutine("movement");
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
	
	IEnumerator movement(){
		while(true){
			isExposed = false;
			yield return new WaitForSeconds(restTime);
			isExposed = true;
			yield return new WaitForSeconds(exposeTime);
		}
	}
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "PlayerBullet"){
			
			StopCoroutine("movement");
			StartCoroutine("movement");
		}
	}
}
