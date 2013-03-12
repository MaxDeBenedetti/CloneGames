using UnityEngine;
using UnityEditor;
using System.Collections;

public class ZTo0 : MonoBehaviour {
	
	//moves everything in a scene other than a camera to have a z of 0
	[MenuItem("MyMenu/Z To 0 %0")]
	static void zTo0(){
		
		GameObject[] selected = Selection.gameObjects;
                
                if(selected.Length > 0)
                {
                        
                        foreach(GameObject g in selected)
                        {
								
                                Vector3 place = g.transform.position;
								place.z = 0;
								g.transform.position = place;
                        }
                }
		
	}
}
