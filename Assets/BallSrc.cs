using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallSrc : MonoBehaviour

{
    
    
    
    float currentTime = 0.0f;
    float startingTime = 60f;
    public TextMeshProUGUI countDown;
    public GameObject loser;
    public GameObject winner;
    float destroytimeLeft = 15f;
    List<GameObject> destobj = new List<GameObject>();
    public GameObject firstball;
    public GameObject secondball;
    public GameObject mainball;
 


    
   

    private void Start()
    {
        
        currentTime = startingTime;
        destobj.Add(firstball);
        destobj.Add(secondball);
    }

   
    public void LotteryBall()
    {
        int index = Random.Range(0, destobj.Count);

        GameObject itemToDestroy = destobj[index];
        destobj.RemoveAt(index);
        GameObject.Destroy(itemToDestroy);
        itemToDestroy = null;

        destroytimeLeft += 15.0f;
        Debug.Log(index);
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDown.text = "Time: " + currentTime.ToString("0");
        if(currentTime<5)
        {
            countDown.color = Color.red;

            
        }

        if (destobj.Count != 0)
        {
            destroytimeLeft -= Time.deltaTime;
            if (destroytimeLeft < 0)
            {

                
                LotteryBall();

            }

        }


    }
}
