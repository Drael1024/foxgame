using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject character;
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 destination = character.GetComponent<Transform>().position;
        transform.position = Vector3.Lerp(transform.position, destination + cameraOffset, 0.1f);
        //transform.position = character.GetComponent<Transform>().position + cameraOffset;
    }
}
