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


#if UNITY_EDITOR

        GetMobileInput();

#elif UNITY_STANDALONE

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
        if (Input.touchCount > 0)
        {

            foreach (Touch touch in Input.touches)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    xMovement = 1.0f;
                }
                else if (touch.position.x < Screen.width / 2)
                {
                    xMovement = - 1.0f;
                }

            }
        }

        else
        {
            xMovement = 0;
        }
    }
}
