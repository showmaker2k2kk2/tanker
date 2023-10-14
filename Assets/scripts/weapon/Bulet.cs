using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    Character player;

    void Start()
    {
        player = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //private void OnTriggerEnter(Collider colide_cua_doi_tuong)
    //{
    //    if(!colide_cua_doi_tuong.gameObject.CompareTag("Player"))   
    //    {
    //        Destroy(colide_cua_doi_tuong.gameObject);
    //    }    
    //}

}
