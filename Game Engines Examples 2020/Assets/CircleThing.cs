using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleThing : MonoBehaviour
{
    public int elements = 12;
    public float radius = 10;
    public int layers = 3;
    
    void Start()
    {
        float _colourMultiplier = (float)(1f/layers);
        Debug.Log(_colourMultiplier);
        for (int j = 0; j < layers; j++) {
            float theta = Mathf.PI * 2.0f / (float)(elements * (j + 1));
            for (int i = 0; i < (elements * (j+1)); i++)
            {
                GameObject sp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sp.GetComponent<Renderer>().material.color = Color.HSVToRGB(_colourMultiplier * j, 1, 1);

                Vector3 pos = new Vector3(Mathf.Sin(theta * i) * (radius * (j + 1)), 0, Mathf.Cos(theta * i) * (radius * (j + 1)));
                sp.transform.position = transform.TransformPoint(pos);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
