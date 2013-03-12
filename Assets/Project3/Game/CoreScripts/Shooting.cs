using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	
	public float delay = 1;
	private OPGun gun;
	
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
			wait = CoreHealth._health * delay;
			gun.FireRand();
			yield return new WaitForSeconds(wait);
		}
	}
}
