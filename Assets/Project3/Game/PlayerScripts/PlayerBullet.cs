using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
	
	public int speed = 3;
	
	// Use this for initialization
	void Start () {
		if((PlayerShoot.facing)<0){
			rigidbody.velocity = Vector3.right * speed * -1;
			gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x,gameObject.transform.rotation.y+180,gameObject.transform.rotation.z,gameObject.transform.rotation.w);
		}
		else
			rigidbody.velocity = Vector3.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "EnemyWall"|| other.gameObject.tag == "Wall"|| other.gameObject.tag=="enemy")
			GameObject.Destroy(this.gameObject);
	}
}
