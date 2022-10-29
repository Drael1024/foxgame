using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Vector3 startPosition;
    public int points = 0;
    public TextMeshProUGUI screenText;
    public GameObject loser;
    public GameObject winner;
    float currentTime = 60f;

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
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0)
        {

            
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
