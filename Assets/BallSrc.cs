using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallSrc : MonoBehaviour

{
    public Vector3 startPosition;
    public TextMeshProUGUI screenText;
    public int points = 0;
    float currentTime = 0.0f;
    float startingTime = 60f;
    public TextMeshProUGUI countDown;
    public GameObject loser;
    public GameObject winner;
   
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
            points++;
            screenText.text = "Score: " + points.ToString();
            
            Debug.Log(points);
        }
    }

    private void Start()
    {
        screenText.text = "Score: " + points.ToString();
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDown.text = "Time: " + currentTime.ToString("0");
        if(currentTime<5)
        {
            countDown.color = Color.red;

            if(currentTime<=0)
            {
                currentTime = 0;
                if (points == 0 && currentTime == 0)
                {
                    loser.SetActive(true);
                    Debug.Log("Lose");
                }
                else 
                {
                    winner.SetActive(true);
                    Debug.Log("Win");
                }
            }
        }
        
       
    }
}
