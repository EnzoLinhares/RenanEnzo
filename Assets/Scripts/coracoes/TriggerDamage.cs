using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerDamage : MonoBehaviour
{

    public VidaSystem heart;

    private void Start()
    {
        GameObject player = GameObject.Find("Player");
        heart = player.GetComponent<VidaSystem>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("oi");
            heart.vida--;
            Destroy(gameObject);
        }
    }
   
}
