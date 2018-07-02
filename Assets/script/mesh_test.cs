using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesh_test : MonoBehaviour {
    public GameObject newObject;
    public Vector3[] vertices;
    public int[] triangles;
    public Vector2[] UVs;
    Mesh mesh;
    // Use this for initialization
    void Start () {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;
        triangles = mesh.triangles;
        UVs      = mesh.uv; 
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(newObject.gameObject.GetComponent<MeshCollider>());
        mesh = newObject.transform.GetComponent<MeshFilter>().mesh;
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        newObject.transform.GetComponent<MeshFilter>().mesh.vertices = vertices;
        newObject.transform.GetComponent<MeshFilter>().mesh.triangles = triangles;
        newObject.transform.GetComponent<MeshFilter>().mesh.uv = UVs;
        newObject.gameObject.AddComponent<MeshCollider>();
    }
    
}
