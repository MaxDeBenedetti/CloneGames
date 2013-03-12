using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {
	
	public PlayerBullet bullet;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void Fire(){
		PlayerBullet newBullet = GameObject.Instantiate(bullet) as PlayerBullet;
		newBullet.transform.position = this.gameObject.transform.position;	
	}
}
