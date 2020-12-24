using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Light;

    void Start()
    {
        Invoke("LaunchProjectile", 2.0f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Light.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Light.SetActive(false);
        }
    }
    void LaunchProjectile()
    {
        Light.SetActive(true);
    }
}