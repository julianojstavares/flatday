using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool onGround = false;

    private void OnCollisionStay2D(Collision2D other) 
    {
        GameObject_Name(other, "Player", true);
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        GameObject_Name(other, "Player", false);
    }

    private void GameObject_Name(Collision2D other, string name, bool grounded)
    {
        if(other.gameObject.name == name)
        {
            onGround = grounded;
        }
    }
}
