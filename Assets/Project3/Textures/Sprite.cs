using UnityEngine;
using System.Collections;

//Making a mesh
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class Sprite : MonoBehaviour {
    
	public SpriteSheet spriteSheet;
	
	[HideInInspector]
	public Vector2[] uvs  = new Vector2[4];
	
	public int spriteNum=0;
	
    public float width = 1f;
    public float height = 1f;
    
    private float _width = 1f;
    private float _height = 1f;
	private int _spriteNum=0;
    
    // Use this for initialization
    void Start () {
    	
    }
    
    // Update is called once per frame
    void Update () {
		
		if(spriteNum<0)
			spriteNum = 0;
		
		if(spriteNum>=spriteSheet.uvs.Length)
			spriteNum=spriteSheet.uvs.Length-1;
		
        if (width != _width || height != _height || spriteNum != _spriteNum){
            _width = width;
            _height = height;
			_spriteNum = spriteNum;
            UpdateMesh();
        }
    }
    
    
    [ContextMenu("Update Mesh")]
    public void UpdateMesh() {

        Vector3[] verts = new Vector3[4];
        
        int[] tris = new int[6] {3,1,0,3,2,1};
		
		Rect picture = spriteSheet.uvs[spriteNum];
		

        
        verts[0] = new Vector3(-width / 2.0f, -height/2.0f, 0);
        verts[1] = new Vector3(width / 2.0f, -height/2.0f, 0);
        verts[2] = new Vector3(width / 2.0f, height/2.0f, 0);
        verts[3] = new Vector3(-width / 2.0f, height/2.0f, 0);
        
        uvs[0] = new Vector2(picture.x, picture.y);
        uvs[1] = new Vector2(picture.x+picture.width, picture.y);
        uvs[2] = new Vector2(picture.x + picture.width, picture.y +picture.height);
        uvs[3] = new Vector2(picture.x, picture.y+picture.height);
        
		
		
            Mesh mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;
		
		 Material mat  = spriteSheet.material;
		GetComponent<MeshRenderer>().sharedMaterial = mat;
		renderer.material = mat;
        
        mesh.vertices = verts;
        mesh.RecalculateNormals();
        mesh.uv = uvs;
        mesh.triangles = tris;

        renderer.material = spriteSheet.material;

    }
}