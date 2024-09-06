using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float xRotateSpeed = 10.00f;
    public float yRotateSpeed = 20.00f;
    public float zRotateSpeed = 30.00f;

    public float colorChangeStart = 01.00f;
    public float colorChangeRate = 03.00f;




    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = new Vector3(5f, 5f, 5f);

        InvokeRepeating("CubeColorChange", colorChangeStart, colorChangeRate);
    }

    void Update()
    {

        transform.Rotate(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime, zRotateSpeed * Time.deltaTime);

    }
    void CubeColorChange()
    {

        Material material = Renderer.material;
        Renderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}