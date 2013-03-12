using UnityEngine;
using System.Collections;


public class PlayerShoot : MonoBehaviour {
	
	public PlayerGun rightGun;
	public PlayerGun leftGun;
	
	public static float facing = 1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") != 0)
			facing = Input.GetAxis("Horizontal");
		
		if(Input.GetButtonDown("Fire1")){
			if(facing > 0){
				rightGun.Fire();
			}
			else{
				leftGun.Fire();
			}
		}
	}
}
