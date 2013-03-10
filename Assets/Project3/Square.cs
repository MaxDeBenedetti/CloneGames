using UnityEngine;
using System.Collections;

//Making a mesh
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class Square : MonoBehaviour {
    
    public float width = 1f;
    public float height = 1f;
    
    private float _width = 1f;
    private float _height = 1f;
    
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        if (width != _width || height != _height){
            _width = width;
            _height = height;
            UpdateMesh();
        }
    }
    
    
    [ContextMenu("Update Mesh")]
    void UpdateMesh() {
        //order 123,134
        Vector3[] verts = new Vector3[4];
        Vector2[] uvs  = new Vector2[4];
        int[] tris = new int[6] {0,1,2,0,2,3};
        Vector3[] norms = new Vector3[4] {
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            Vector3.back
        };
        
        verts[0] = new Vector3(-width / 2.0f, -height/2.0f, 0);
        verts[1] = new Vector3(width / 2.0f, -height/2.0f, 0);
        verts[2] = new Vector3(width / 2.0f, height/2.0f, 0);
        verts[3] = new Vector3(-width / 2.0f, height/2.0f, 0);
        
        uvs[0] = new Vector2(0,0);
        uvs[1] = new Vector2(1,0);
        uvs[2] = new Vector2(1,1);
        uvs[3] = new Vector2(0,1);
        
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;        
        if (!mesh) {
            mesh = new Mesh();
            GetComponent<MeshFilter>().sharedMesh = mesh;
        }
        
        Material mat = GetComponent<MeshRenderer>().sharedMaterial;
        if (!mat) {
            mat = new Material(Shader.Find("Diffuse"));
            GetComponent<MeshRenderer>().sharedMaterial = mat;
        }
        
        mesh.vertices = verts;
        mesh.normals = norms;
        mesh.uv = uvs;
        mesh.triangles = tris;
    }
}