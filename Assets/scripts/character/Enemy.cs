using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy : Character
{
    bool ban_tank=true;
    private float Range_attack_enemy = 5;
    protected override void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("player");
        if (player == null)

        {
            return;
        }
        GameObject tru= GameObject.FindWithTag("tru");
        if (player == null)

        {
            return;
        }

        float khoang_cach_ban_tu_enemy_den_player = Vector3.Distance(transform.position, player.transform.position);
        float khoang_cach_ban_tu_enemy_den_tru = Vector3.Distance(transform.position, tru.transform.position);
   
        
        


        MoveDesination();

    }
  public  void MoveDesination()
    {
        Vector3 pos = FindObjectOfType<Tru>().transform.position;
        agent.SetDestination(pos);
    }    
}
