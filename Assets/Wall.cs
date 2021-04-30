using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int width = 10;
    public int height = 20;
    // Start is called before the first frame update
    void Start()
    {
        int halfw = width / 2;
        for(int row = 0 ; row < height ; row ++)
        {
            for(int col = -halfw ; col < halfw ; col ++)
            {
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 p = new Vector3(col, row * 1.1f, 0);
                go.transform.position = transform.TransformPoint(p);
                go.transform.rotation = transform.rotation;
                go.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
                go.AddComponent<Rigidbody>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
