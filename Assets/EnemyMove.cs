using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Transform[] Position;
    [SerializeField] float ObjectSpeed;
    Transform NextPos;
    int NextPosIndex;
    [SerializeField] private Transform m_GroundCheck;
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Position[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if(transform.position==NextPos.position)
        {
            NextPosIndex++;
            if(NextPosIndex>=Position.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Position[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed*Time.deltaTime);
        }
    }
}
