using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSrc : MonoBehaviour

{
    public Vector3 startPosition;
    private void Awake()
    {
        startPosition = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Goal")
        {
            Debug.Log("Nyertél!");
            transform.position = startPosition;
        }
    }

    private void FixedUpdate()
    {
        //GetComponent<Rigidbody>().
    }
}
