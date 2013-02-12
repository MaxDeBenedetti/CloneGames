using UnityEngine;
using System.Collections;

public class PaddleSpeed : MonoBehaviour {
	
	
	public static float speed = 10;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.right * Input.GetAxis("Horizontal") * speed;
		if(Input.GetButtonUp("Jump")){
			GameObject.Destroy(gameObject);	
			
		}
	}
}
