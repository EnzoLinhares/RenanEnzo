using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
public class PlayerProjetil : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform boss;
    public float velocidadeProjetil = 5f;

    public GameObject boitata;

    
    void Start()
    {
        
    }

    public void LancarProjetil()
    {
        Vector2 direcao = (boss.position - transform.position).normalized;

        GameObject projetil = Instantiate(projetilPrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direcao * velocidadeProjetil;

        

       
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LancarProjetil();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Boss"))
        {
            Debug.Log("matei ele");
            Destroy(gameObject);
        }
    }
}
