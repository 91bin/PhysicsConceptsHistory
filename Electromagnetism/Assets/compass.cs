using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class compass : MonoBehaviour
{
    public float h = 1.0f;
    MeshFilter mf;
    MeshRenderer meshrenderer;
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    Vector2[] uv;
    // Start is called before the first frame update
    void Start()
    {
        mf = GetComponent<MeshFilter>();
        meshrenderer = GetComponent<MeshRenderer>();
        mesh = mf.mesh;

        vertices = new Vector3[]
        {
           
            new Vector3(1, 1, 1),   //left top front 0
            new Vector3(-1, 1, 1), //right top front 1
            new Vector3(1, -1, 1),   //left bottom front 2
            new Vector3(-1, -1, 1)   //right bottom front 3

        };

        triangles = new int[]
        {
            0,1,2,
            3,2,1
        };

        uv = new Vector2[]
        {
            new Vector2(0,1),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,0)
        };

       
    }

    // Update is called once per frame
    void Update()
    {
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        mf.mesh = mesh;
    }
   
}
