using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Sprite))]
public class CoreHealth : MonoBehaviour {
	
	[HideInInspector]
	public static int _health = 4;
	
	public int health = 4;
	public Sprite sprite;
	

	// Use this for initialization
	void Start () {
	_health = health;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
	if(other.gameObject.tag=="PlayerBullet"){
			_health--;
			
			if(_health <1){
				Application.LoadLevel("End");	
			}
			

				sprite.spriteNum++;
			
		}	
	}
}
