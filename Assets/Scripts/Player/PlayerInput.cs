using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float xMovement { get; private set; }
    // Start is called before the first frame update

    private static PlayerInput playerInputInstance;


    public static PlayerInput GetPlayerInput()
    {
        return playerInputInstance;
    }

    private void Awake()
    {
        if (playerInputInstance != null && playerInputInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            playerInputInstance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE || UNITY_EDITOR

        GetPCInput();

#elif UNITY_ANDROID || UNITY_IOS

        GetMobileInput();
#endif

    }

    private void GetPCInput()
    {
        xMovement = Input.GetAxis("Horizontal");
    }

    private void GetMobileInput()
    {

    }
}
