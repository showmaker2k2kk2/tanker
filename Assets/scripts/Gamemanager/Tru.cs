using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tru : Emity,ItakeDame
{
    protected override Emity Muc_tieu_Gan_nhat => GameManager.Instance.enemies.OrderBy(e => Vector3.Distance(transform.position, e.transform.position)).First();


    private Vector3 posi;

   
   protected override void Start()
    {
      base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
