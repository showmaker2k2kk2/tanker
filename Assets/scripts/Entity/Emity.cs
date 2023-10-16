using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Emity : MonoBehaviour
{
    public float speed;
    public float tocdoxoay;

    public CanVasHealth canHealth;
    protected NavMeshAgent agent;
    protected Agent _agent;

    public int starthealth = 100;
    public int curenthealth;

    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        curenthealth = starthealth;
        canHealth.setUpMaxHealth(curenthealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Takedame(int dame)
    {
        curenthealth = curenthealth - dame;
        canHealth.sethealth(curenthealth);
        if (curenthealth <= 0)
        {
            Death();

        }


    }
    private void Death()
    {
        this.Decall(2f, () =>
        {
            Destroy(gameObject);

        }

        );

    }
}
