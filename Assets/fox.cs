using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fox : MonoBehaviour
{
    public GameObject foxie;
    public GameObject theend;
    private void OnTriggerEnter2D(Collider2D collider)
    {


        if (collider.transform.tag == "Frog")
        {
            Destroy(foxie);
            theend.SetActive(true);
        }

        /*if(!foxie)
        {
            loser.SetActive(true);
            Debug.Log("Lose");
        }*/
    }
            // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
