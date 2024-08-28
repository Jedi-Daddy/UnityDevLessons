using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
    public float verticalInput;
    public float horizontalInput;
    public float propSpeed = 50f;

    //get position|location of the propeller
    public Transform propeller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * horizontalInput);

        //rotate the propeller
        propeller.Rotate(Vector3.forward * propSpeed * Time.deltaTime);
    }
}