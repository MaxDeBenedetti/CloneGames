using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	private Vector3 startpoint;
	
	public TextMesh livesText;
	public int livesNum = 3;
	
	public float ballSpeed = 3f;
	
	private static bool _launced = false;
	
	public static bool launched{
		get{
			return _launced;
		}
		set{
			_launced = value;
		}
	}
	

	// Use this for initialization
	void Start () {
		livesText.text = "Lives: " + livesNum;
		startpoint = rigidbody.position;
		launched = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//If the ball has not been launched yet
		if(!launched){
			rigidbody.velocity = Vector3.right * Input.GetAxis("Horizontal") * PaddleSpeed.speed;
			if(Input.GetButtonUp("Jump")){
				launched = true;
				rigidbody.velocity = Vector3.up * ballSpeed;
				
			}
		}
		
		
		//once the ball is moving
		else{
			Vector3 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
		
			//ball leaves the screen
			if(screenPosition.y < 0){
				//loses a life and if lives fall below zero, ends the game
				livesText.text = "Lives: " + (--livesNum);
				if(livesNum < 0){
					Application.LoadLevel("BrickBreak");	
				}
				//resets the ball when it goes off the screen.
				else{
					rigidbody.position = startpoint;
					rigidbody.velocity = Vector3.zero;
					launched = false;
				}
			}
			
			
		}
		
		
		
		
	}
	
	
	void OnCollisionEnter(Collision collision){
		
	}
	
	void OnCollisionExit(Collision collision){
		rigidbody.velocity = rigidbody.velocity * 1.1f;
	}
}
