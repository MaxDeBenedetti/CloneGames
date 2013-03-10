using UnityEngine;
using System.Collections;
 
[RequireComponent (typeof (Rigidbody))]
[RequireComponent (typeof (CapsuleCollider))]
public class CharacterMotor : MonoBehaviour {
 
        public float speed = 1.0f;
        public float maxSpeedChange = 1.0f;
        public float jumpHeight = 1.0f;
        public float airMovement = 0.1f;
        
        [HideInInspector]
        public bool shouldJump = false;
        [HideInInspector]
        public Vector3 targetVelocity = Vector3.zero;
        

        
        void FixedUpdate () {
            Vector3 velocity = rigidbody.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
                velocityChange = velocityChange.normalized * Mathf.Clamp(velocityChange.magnitude, -maxSpeedChange, maxSpeedChange);
        velocityChange.y = 0;
		
		if (shouldJump)
			rigidbody.velocity = new Vector3(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
 

                
        rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
                

        }
        

 
        float CalculateJumpVerticalSpeed () {
            return Mathf.Sqrt(2 * jumpHeight * -Physics.gravity.y);
        }
}