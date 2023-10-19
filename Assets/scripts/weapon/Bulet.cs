using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{  
    public int Dame;
    public Doituong doituong;
    //public phePhai chuThe;
   

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider collider_cua_doi_tuong)
    {      
        ItakeDame itakedame = collider_cua_doi_tuong.GetComponent<ItakeDame>();
        itakedame?.Takedame(Dame,doituong);
        Destroy(gameObject);

    }
       
}
public enum  Doituong
{
    player,
    enemy,
}