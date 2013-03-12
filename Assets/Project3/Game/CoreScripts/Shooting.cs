using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	[HideInInspector]
	public float delay = 2;
	public OPGun gun;
	
	// Use this for initialization
	void Start () {
		
		gun = GameObject.FindObjectOfType(typeof(OPGun)) as OPGun;
		StartCoroutine("shoot", delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator shoot(float wait){
		while(true){
			wait = CoreHealth._health;
			gun.FireRand();
			yield return new WaitForSeconds(wait);
		}
	}
}
