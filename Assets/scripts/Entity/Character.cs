using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Character : MonoBehaviour,ItakeDame
{   
    public float speed;
    public float tocdoxoay;

    public int starthealth=100;
    public int curenthealth;


    protected NavMeshAgent agent;
    public CanVasHealth canHealth;

    public  phePhai chuThe => throw new System.NotImplementedException();

    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        curenthealth = starthealth;
        canHealth.setUpMaxHealth(curenthealth);
        
    }

  
    void Update()
    {

        float ho = Input.GetAxisRaw("Horizontal");
        float Ve = Input.GetAxisRaw("Vertical");
        Vector3 huongbanphim = new Vector3(ho, 0, Ve);


        if (huongbanphim != Vector3.zero)
        {

            Movehuong(huongbanphim);

        }


        //Vector3 huong1 = new Vector3(ho, 0, ve);

        //Movehuong(huong1);


        if (Input.GetKeyDown(KeyCode.T))
        {
            Takedame(20);
        }    

    }

  

    protected virtual void Movehuong(Vector3 huong)
    {
        xoay(huong);
        agent.Move(transform.forward * speed * Time.deltaTime);
    }  
    protected virtual void xoay(Vector3 a)
    {
        Quaternion huongnhin = Quaternion.LookRotation(a, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, huongnhin, tocdoxoay * Time.deltaTime);
    }

    public virtual void Takedame(int dame)
    {
     curenthealth =curenthealth-dame;
     canHealth.sethealth(curenthealth);
     if(curenthealth<=0)
        {
            Death();

        }    
       
      
    }
  protected virtual void Death()
    {
        this.Decall(2f, () =>
        {
            Destroy(gameObject);

        }

        );
                       
    }

    public void Takedame(int dame, phePhai phe)
    {
        
    }
}
