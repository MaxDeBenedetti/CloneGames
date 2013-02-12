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
	}
	
	void OnCollisionEnter(Collision collision){
		GameObject.Destroy(gameObject);	
		
	}
}
