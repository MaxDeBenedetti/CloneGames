using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	
	public int playerHealth = 3;
	
	public float invulnerable = .5f;
	private float lastHit;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="EnemyBullet"&&(Time.time-lastHit)>invulnerable)
			Damage();
	}
	
	public void Damage(){
		lastHit =Time.time;
		playerHealth--;
		if(playerHealth <1)
			Application.LoadLevel("Start");
		GameObject.Destroy(GameObject.FindGameObjectWithTag("Health"));
	}
}
