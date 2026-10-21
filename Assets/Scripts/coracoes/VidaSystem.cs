using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaSystem : MonoBehaviour
{

    public int vida;
    public int vidaMax;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;
    [SerializeField] private string nomeDaProximaCena;

    void Start()
    {
       
    }

    
    void Update()
    {
        SistemaCoracao();
        EstadoMorto();
    }

    void SistemaCoracao()
    { 
        if(vida > vidaMax)
        {
            vida = vidaMax;
        }
        for (int i = 0; i< coracao.Length; i++)

		{
            if (i < vida)
            {
                coracao[i].sprite = cheio;
            }
            else 
            {

                coracao[i].sprite = vazio;

            }


                if (i < vidaMax)
            {

                coracao[i].enabled = true;

            }
            else
            {

                coracao[i].enabled = false;

            }

		}

    }

    void EstadoMorto()
    {
        if(vida <= 0)
        {
            GetComponent<PlayerSystem>().enabled = false;
            Destroy(gameObject, 1.0f);

            if (gameObject.scene.isLoaded)
            {
                SceneManager.LoadScene("TelaDerrota");
            }
        }
    }

   
}
