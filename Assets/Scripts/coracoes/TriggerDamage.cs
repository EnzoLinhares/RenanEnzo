using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerDamage : MonoBehaviour
{

    public VidaSystem heart;


    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Player")
        {
           
            heart.vida--;
        }
    }
   
}
