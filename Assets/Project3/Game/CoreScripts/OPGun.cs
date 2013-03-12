using UnityEngine;
using System.Collections;

public class OPGun : MonoBehaviour {
	
	public EnemyBullet bullet1;
	public EnemyBullet bullet2;
	public GameObject mark;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move();
		
	}
	
	public void Fire1(){
		EnemyBullet newBullet = GameObject.Instantiate(bullet1) as EnemyBullet;
		newBullet.transform.position = this.gameObject.transform.position;	
	}
	
	public void Fire2(){
		EnemyBullet newBullet = GameObject.Instantiate(bullet2) as EnemyBullet;
		newBullet.transform.position = this.gameObject.transform.position;	
	}
	
	public void move(){
		Vector3 move = new Vector3(gameObject.transform.position.x, mark.transform.position.y, gameObject.transform.position.z);
		gameObject.transform.position = move;
	}
	
	public void FireRand(){
		
		float ammo = Random.value*2;
		if(ammo <1)
			Fire1();
		else
			Fire2();
	}
}
