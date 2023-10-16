using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy : Character
{
    public Transform position_Gun;
    public GameObject bullet;
    private gun gun;

    bool ban_tank=true;
    private float Range_attack_enemy = 10;
    
    protected override void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        //GameObject player = GameObject.FindWithTag("player");
        //if (player == null)

        //{
        //    return;
        //}
        GameObject tru= GameObject.FindWithTag("tru");
        if (tru == null)

        {
            return;
        }

        //float khoang_cach_dung_tu_enemy_den_player = Vector3.Distance(transform.position, player.transform.position);
        float khoang_cach_dung_tu_enemy_den_tru = Vector3.Distance(transform.position, tru.transform.position);
       
       if(khoang_cach_dung_tu_enemy_den_tru<Range_attack_enemy)
        {
            
        }    
        


        MoveDesination();

    }
  public  void MoveDesination()
    {
        Vector3 pos = FindObjectOfType<Tru>().transform.position;
        agent.SetDestination(pos);
    }  
   private void EnemyAttack(int dame)
    {
            agent.isStopped = true;
        //xoay()

    }    
}
