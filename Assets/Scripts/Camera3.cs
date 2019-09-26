using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour
{

    public GameObject p;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(p.transform.position.x, p.transform.position.y + 10f, p.transform.position.z);
    }
}