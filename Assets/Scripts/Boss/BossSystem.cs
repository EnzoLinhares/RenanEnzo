using UnityEngine;

public class BossSystem : MonoBehaviour
{
    public static int vidaBoss = 20;    
    public GameObject spriteBoss;    

    private bool bossMorto = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("tiroPlayer"))
        {
            Debug.Log("matei ele");

            vidaBoss--;

        }
    }

    private void Update()
    {
        if(vidaBoss <= 0)
        {
            Destroy(spriteBoss);
        }
    }



}
