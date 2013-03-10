using UnityEngine;

using System.Collections;

 

public class TexturePacker : MonoBehaviour {

    

    public Texture2D packedTexture;

 

    // Use this for initialization

    void Start () {

        Material newMaterial = new Material(Shader.Find("Diffuse"));

        Component[] filters  = GetComponentsInChildren(typeof(MeshFilter));

        

        Texture2D[] textures = new Texture2D[filters.Length]; 

        

        for (int i=0;i < filters.Length;i++) {

            textures[i] = (Texture2D)filters[i].gameObject.renderer.material.mainTexture;

        }

        

        packedTexture=new Texture2D(1024,1024);

        Rect[] uvs = packedTexture.PackTextures(textures,0,1024);

        

        newMaterial.mainTexture = packedTexture;

        

        Vector2[] uva,uvb;

        for (int j=0;j < filters.Length;j++) {

            filters[j].gameObject.renderer.material=newMaterial;

            uva = (Vector2[])(((MeshFilter)filters[j]).mesh.uv);

            uvb = new Vector2[uva.Length];

            for (int k=0;k < uva.Length;k++){

                uvb[k]=new Vector2((uva[k].x*uvs[j].width)+uvs[j].x, (uva[k].y*uvs[j].height)+uvs[j].y);

            }

            ((MeshFilter)filters[j]).mesh.uv=uvb;

        }       

    }

}