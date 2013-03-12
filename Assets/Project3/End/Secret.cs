using UnityEngine;
using System.Collections;

public class Secret : MonoBehaviour {
	
	public Sprite ending;
	
	// Use this for initialization
	void Start () {
		ending.spriteNum =PlayerPrefs.GetInt("ending",14);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
