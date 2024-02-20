using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = PlayerInput.GetPlayerInput().xMovement;

        MovePlayer(xMovement);
    }

    private void MovePlayer(float xMovement)
    {

        transform.position += playerSpeed * Time.deltaTime * new Vector3(xMovement, 0, 0);

        Mathf.Clamp(transform.position.x, -10.0f, 10.0f);

    }
}
