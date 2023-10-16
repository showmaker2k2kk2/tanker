using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy :Emity
{
    private Agent agent;
    protected override Emity Muc_tieu_Gan_nhat=>GameManager.Instance.doi_tuong_tan_cong_cua_e.OrderBy(e => Vector3.Distance(transform.position, e.transform.position)).First();
  
    //public Transform position_Gun;
    //public GameObject bullet;
    //private gun gun;
    NavMeshAgent mesh;

    bool ban_tank=true;
    private float Range_attack_enemy = 10;


    private void Awake()
    {
        mesh= GetComponent<NavMeshAgent>();
        agent= GetComponent<Agent>();
    }

    
    protected override void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
       // float khoang_cach_dung_tu_enemy_den_player = Vector3.Distance(transform.position, player.transform.position);
       // float khoang_cach_dung_tu_enemy_den_tru = Vector3.Distance(transform.position, tru.transform.position);
       
       //if(khoang_cach_dung_tu_enemy_den_tru<Range_attack_enemy)
       // {
            
       // }    
        


       // MoveDesination();

    }
  public  void MoveDesination()
    {
        Vector3 pos = FindObjectOfType<Tru>().transform.position;
         mesh.SetDestination(pos);
    }  
   private void EnemyAttack(int dame)
    {
           mesh.isStopped= true;
        //xoay()

    }    
}
