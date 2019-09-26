using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarCameras : MonoBehaviour
{
    public Camera[] cameras;
    public int numerocameras;
    public int numeromaximo;

    // Start is called before the first frame update
    void Start()
    {
        numeromaximo = cameras.Length;
        numerocameras = 1;

        foreach (Camera obj in cameras)
        {
            obj.gameObject.SetActive (false);
        }
        cameras[numerocameras-1].gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.C) && numerocameras < numeromaximo){
         numerocameras++;
            foreach (Camera obj in cameras)
        {
            obj.gameObject.SetActive (false);
        }
        cameras[numerocameras-1].gameObject.SetActive(true);
    }
    if(Input.GetKey(KeyCode.C) && numerocameras == numeromaximo){
            foreach (Camera obj in cameras)
        {
            obj.gameObject.SetActive (false);
        }
        cameras[numerocameras-1].gameObject.SetActive(true);
        numerocameras = 0;
    }
    }   
}
