using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	
	public int speed = 6;
	
	// Use this for initialization
	void Start () {
	rigidbody.velocity = Vector3.left * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"|| other.gameObject.tag == "Wall")
			GameObject.Destroy(this.gameObject);
	}
}
