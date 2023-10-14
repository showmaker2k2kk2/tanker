using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy : Character
{
    public Transform target;
    

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDesination();
    }
    void MoveDesination()
    {
        agent.SetDestination(target.position);
    }    
}
