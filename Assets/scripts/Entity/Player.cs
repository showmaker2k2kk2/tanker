using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Player :Emity
{
    protected override Emity Muc_tieu_Gan_nhat => GameManager.Instance.enemies.OrderBy(e=>Vector3.Distance(transform.position,e.transform.position)).First();
    
    private Agent agent;

    private void Awake()
    {
        agent = GetComponent<Agent>();
    }
    protected override void Start()
    {
        base.Start();
        Debug.Log(Muc_tieu_Gan_nhat.name);
    }

   
    void Update()
    {
        float ho = Input.GetAxisRaw("Horizontal");
        float Ve = Input.GetAxisRaw("Vertical");
        Vector3 huongbanphim = new Vector3(ho, 0, Ve);

      
        if (huongbanphim != Vector3.zero)
        {

            agent.Movehuong(huongbanphim);
            
        }


    }
}
