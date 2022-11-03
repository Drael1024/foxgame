using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public Vector3 startPosition;
    public int points = 0;
    public TextMeshProUGUI screenText;
    public GameObject loser;
    public GameObject winner;
    float currentTime = 60f;

    
    
    

    private void Start()
    {
       
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
