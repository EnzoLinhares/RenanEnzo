using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarParaGame : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void MudarDeCena(string GamePlay)
    {
        SceneManager.LoadScene(GamePlay);
    }

    public void VoltarMenu(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }
}
