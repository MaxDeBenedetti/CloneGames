using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Sprite))]
public class SpritePopup : Editor {
	
	int index;
	string[] choices;
	
	public override void OnInspectorGUI(){
		DrawDefaultInspector();
		
		Sprite sprite = target as Sprite;
		index = sprite.spriteNum;
		choices = sprite.spriteSheet.names;
		index = EditorGUILayout.Popup(index, choices);
		sprite.spriteNum = index;
		sprite.UpdateMesh();
	}
}
