using UnityEngine;

public class CollisionDetect_Gameplay : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        PlayerCollider(other.transform);
    }

    private void PlayerCollider(Transform obj)
    {
        if(obj.tag == "Player")
        {

        };
    }
}
