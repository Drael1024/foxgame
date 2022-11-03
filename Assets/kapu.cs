using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class kapu : MonoBehaviour
{
    public TextMeshProUGUI screenText;
    public int points = 0;
    private void OnTriggerEnter2D(Collider2D collider)
    {


        if (collider.transform.tag == "ball")
        {

            Debug.Log("Nyertél!");
            
            points++;
            screenText.text = "Score: " + points.ToString();
            collider.gameObject.GetComponent<Ball>().resetPosition();

            Debug.Log("Score:" + points);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        screenText.text = "Score: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
