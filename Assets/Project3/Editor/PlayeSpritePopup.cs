using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PlayerSprite))]
public class PlayeSpritePopup : Editor {
	
	int index;
	string[] choices;
	
	public override void OnInspectorGUI(){
		DrawDefaultInspector();
		
		PlayerSprite sprite = target as PlayerSprite;
		index = sprite.spriteNum;
		choices = sprite.spriteSheet.names;
		index = EditorGUILayout.Popup(index, choices);
		sprite.spriteNum = index;
		sprite.UpdateMesh();
	}
}
