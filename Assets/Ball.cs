using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public Vector3 startPosition;
    public int points = 0;
    public TextMeshProUGUI screenText;
    private void Awake()
    {
        startPosition = transform.position;
        
    }

    public void resetPosition()
    {

        
        transform.position = startPosition;
        

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
