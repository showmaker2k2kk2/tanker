using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform pointcreateBoss;
    public GameObject EnemyGun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointCreateBoss();
    }
    void PointCreateBoss()
    {
        GameObject bos = Instantiate(EnemyGun, pointcreateBoss.position, Quaternion.identity);
    }    
}
