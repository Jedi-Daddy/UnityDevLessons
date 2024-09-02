using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeBetweenDogs = 2.0f;
    private float timeButtonPressed = -5.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeBetweenDogs < Time.time - timeButtonPressed)
            {
                timeButtonPressed = Time.time;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}