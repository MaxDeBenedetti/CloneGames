using UnityEngine;
using System.Collections;

public class BrickMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(BallMovement.launched)
			rigidbody.velocity = Vector3.right * Input.GetAxis("Horizontal") * PaddleSpeed.speed;
		else
			rigidbody.velocity = Vector3.zero;
	}
	
	void OnCollisionExit(Collision collision){
		GameObject.Destroy(gameObject);	
		
	}
}
