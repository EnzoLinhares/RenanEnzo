using UnityEngine;

public class BossProjetil : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform player;
    public float velocidadeProjetil = 5f;
    public float intervaloDisparo = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(LancarProjetil), 0f, intervaloDisparo);
    }

    public void LancarProjetil()
    {
        Vector2 direcao = (player.position - transform.position).normalized;

        GameObject projetil = Instantiate(projetilPrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direcao * velocidadeProjetil;
    }
}
