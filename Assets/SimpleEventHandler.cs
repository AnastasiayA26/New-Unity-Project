using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEventHandler : MonoBehaviour
{
    public GameObject Cube;
    public Color CubeColor;
    // Start is called before the first frame update
    void Start()
    {
        CubeColor = Cube.GetComponent<MeshRenderer>().material.GetColor("_Color");
    }
    public void StartHover()
    {
        Cube.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.black);
    }
    public void EndHover()
    {
        Cube.GetComponent<MeshRenderer>().material.SetColor("_Color", CubeColor);
    }
    public void StartGrab()
    {
        Cube.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
    }
    public void EndGrab()
    {
        Cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
