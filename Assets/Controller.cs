using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    //Место объекта для создания
    public GameObject ExampleCube;

    //Место создания объекта
    public Transform SpawnPoint;

    public bool flag = true;

    void Update()
    {
        if (flag)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                flag = !flag;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                Instantiate(ExampleCube);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                flag = !flag;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                MeshRenderer meshRenderer = Cube.AddComponent<MeshRenderer>();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                bool Enable = Cube.GetComponent<MeshRenderer>().enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
