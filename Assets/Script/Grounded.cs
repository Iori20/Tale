using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    Player_Frog Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<Player_Frog>();
    }

    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 8)
        {
            Player.isJumping = false;
        }
    }

    void OnCollisonExit2D(Collision2D collisor)
    {
            if(collisor.gameObject.layer == 8)
            {
                Player.isJumping = true;
            }
    }
}