using UnityEngine;

public class TiroDeAgua : MonoBehaviour
{
    public BossSystem bosSistema;

    private void Start()
    {
        GameObject player = GameObject.Find("Boss");
        bosSistema = player.GetComponent<BossSystem>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Boss"))
        {
            Debug.Log("oi");
            Destroy(gameObject);
        }
    }
}
