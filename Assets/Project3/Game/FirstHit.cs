using UnityEngine;
using System.Collections;

public class FirstHit : MonoBehaviour {
	
	public GameObject gate;
	public GameObject wall;
	public GameObject trueCore;
	public GameObject firstPosition;
	public Sprite oceanProtector;
	
	// Use this for initialization
	void Start () {
	gameObject.transform.position = firstPosition.transform.position;
		oceanProtector.spriteNum = 6;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		if(other.tag=="PlayerBullet"){
			wall.transform.position = gate.transform.position;
			GameObject.Instantiate(trueCore);
			oceanProtector.spriteNum = oceanProtector.spriteSheet.getSpriteInfo("OceanProtectorCrown");
			GameObject.Destroy(gameObject);
		}
	}
}
