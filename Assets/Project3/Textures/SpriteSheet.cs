using UnityEngine;

using System.Collections;

public class SpriteSheet : MonoBehaviour {
	
	public Texture2D[] sourceTextures;
	public Rect[] uvs;
	public Material material;
	public Texture2D theSheet;
	public string[] names;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public int getSpriteInfo(string name){
		//print (name);
		
		for(int i = 0; i < names.Length; i++){
			
			//print (names[i]);
			if(names[i]==(name)){
				return i;	
			}
		}
		return -1;
	}
}
