using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraMover : MonoBehaviour {
	
	public GameObject focus;
	public float offSetX, offSetY;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(focus != null)
			moveCam();
	}
	
	
	public void moveCam(){
		Vector3 camPosition = new Vector3(focus.transform.position.x +offSetX, focus.transform.position.y + offSetY, this.gameObject.transform.position.z);
		this.gameObject.transform.position = camPosition;
	}
}
