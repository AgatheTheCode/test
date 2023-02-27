using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exe02 : MonoBehaviour
{
    private float startTime,
    private bool Direction = false;

    public MeshRenderer rend;
    public float delay;
    public Color Color1;
    public Color Color2;

void Start()
{
    if(!rend)Debug.log("No Mesh Renderer");
    rend.material.SetColor("_Color", Color1);
    startTime = Time.time;
}
void Update()
{
    if(Direction)
    {
        rend.material.SetColor("_Color", Color.Lerp(Color1, Color2, (Time.time - startTime) / delay));
    }
    else
    {
        rend.material.SetColor("_Color", Color.Lerp(Color2, Color1, (Time.time - startTime) / delay));
    }
    if(Time.time - startTime > delay)
    {
        startTime = Time.time;
        Direction = !Direction;
    }
}
}
