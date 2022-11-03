using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject destroygo;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D enemycollider)
    {
        if(enemycollider.transform.tag=="Frog")
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
