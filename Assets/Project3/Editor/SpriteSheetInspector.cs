using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

[CustomEditor(typeof(SpriteSheet))]
public class SpriteSheetInspector : Editor {
	
	
	public override void OnInspectorGUI(){
		DrawDefaultInspector();
		
		
		if(GUILayout.Button("Make Sprite Sheet")){
			
			SpriteSheet s = this.target as SpriteSheet;
			
			s.names = new string[s.sourceTextures.Length];
			
			for(int i = 0; i <s.names.Length; i++){
				s.names[i] = s.sourceTextures[i].name;	
			}
			
			foreach(Texture2D tex in s.sourceTextures){
				TextureImporter importer = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(tex.GetInstanceID())) as TextureImporter;	
				importer.isReadable = true;
				AssetDatabase.ImportAsset(importer.assetPath);	
				
			}
			
			
			
			Texture2D newTexture = new Texture2D(1024,1024);
			s.uvs =newTexture.PackTextures(s.sourceTextures,0);
			
			string texturePath = AssetDatabase.GenerateUniqueAssetPath("Assets/Project3/Textures/Sheet.png");
			
			
		
			byte[] png = newTexture.EncodeToPNG();
			File.WriteAllBytes(texturePath, png);
			AssetDatabase.ImportAsset(texturePath);
			s.theSheet=AssetDatabase.LoadAssetAtPath(texturePath, typeof(Texture2D)) as Texture2D;
			

		
			Material newMat = new Material(Shader.Find("Mobile/Particles/Alpha Blended"));
			newMat.mainTexture = s.theSheet;
			string matPath = AssetDatabase.GenerateUniqueAssetPath("Assets/Project3/Materials/Sheet.mat");
			AssetDatabase.CreateAsset(newMat, matPath);
			AssetDatabase.SaveAssets();
			s.material = AssetDatabase.LoadAssetAtPath(matPath, typeof(Material)) as Material;
		
		
			
		}
	}
}
