using UnityEngine;
using System.Collections;

public class LoseCrown : MonoBehaviour {
	
	public Sprite oceanProtector;
	bool happened = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(happened && CoreHealth._health <=1){
			happened = false;
			oceanProtector.spriteNum++;	
		}
	}
}
