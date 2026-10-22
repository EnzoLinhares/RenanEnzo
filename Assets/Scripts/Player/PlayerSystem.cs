using UnityEngine;
using System.Collections;

public class PlayerSystem : MonoBehaviour
{

    private float horizontalPlayer;
    private float verticalPlayer;
    public float movementSpeed = 5f;
    private Rigidbody2D physicsPlayer;

   
    void Start()
    {

        physicsPlayer = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {

        horizontalPlayer = Input.GetAxis("Horizontal");
        verticalPlayer = Input.GetAxis("Vertical");
        physicsPlayer.linearVelocity = new Vector3(horizontalPlayer, verticalPlayer) * movementSpeed;

    }
}
