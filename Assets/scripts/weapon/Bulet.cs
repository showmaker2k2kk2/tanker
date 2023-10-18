using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    Character player;
    Character enemy;
    public int Dame;
    public phePhai chuThe;


    void Start()
    {
        player = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider collider_cua_doi_tuong)
    {      
        ItakeDame itakedame = collider_cua_doi_tuong.GetComponent<ItakeDame>();
        itakedame?.Takedame(Dame,chuThe);
        Destroy(gameObject);

    }
       
}
public enum phePhai
{
    enemy,
    player,
}