using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pictures : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Pictures;

    void Start()
    {
        Invoke("LaunchProjectile", 2.0f);
    }

    // Update is called once per frame
    void LaunchProjectile()
    {
        Pictures.SetActive(true);
    }
}
