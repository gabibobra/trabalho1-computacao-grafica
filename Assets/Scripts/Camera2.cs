using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public GameObject p;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(p.transform.position.x , p.transform.position.y + 1f, p.transform.position.z - 1.5f);
    }
}
