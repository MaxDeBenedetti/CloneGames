using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterMotor))]
public class PlatformerController : MonoBehaviour 
{
	public float speed = 10;
	
	CharacterMotor motor;
	
	void Start () 
	{
		motor = GetComponent<CharacterMotor>();
	}
	
	void Update () 
	{
		motor.targetVelocity.x = Input.GetAxis("Horizontal") * speed;
		motor.shouldJump = Input.GetButton("Jump");
	}
}
