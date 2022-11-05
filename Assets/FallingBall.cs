using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour
{
    public float itemSpawnDelay=20.0f;
    public GameObject prefabItem;
    private float itemSpawnTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        itemSpawnTimer = itemSpawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        itemSpawnTimer -= Time.deltaTime;
        if (itemSpawnTimer <= 0.0f)
        {
            itemSpawnTimer = itemSpawnDelay;
            Instantiate(prefabItem, transform);
            Debug.Log("Lehullott");
        }
        
    }
    
}
