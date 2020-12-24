using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statue1 : MonoBehaviour
{
    public GameObject Light;

    public GameObject statue;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LaunchProjectile", 5.0f);
    }

    // Update is called once per frame
    void LaunchProjectile()
    {
        statue.SetActive(true);

        Light.SetActive(true);
    }
}
