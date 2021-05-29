using UnityEngine;

public class CollisionDetect_Gameplay : MonoBehaviour
{
    public Transform player;
    private Life playerLife;

    private void Start() 
    {
        playerLife = player.GetComponent<Life>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        EnemyCollision(other.gameObject.name);
        HumanHeartCollision(other.gameObject);
    }

    private void EnemyCollision(string name)
    {
        if(name=="Boy(Clone)")
        {
            playerLife.LoseLife();
        }
    }

    private void HumanHeartCollision(GameObject heart)
    {
        if(heart.name=="HumanHeart(Clone)")
        {
            playerLife.AddLife();
            Destroy(heart);
        }
    }

}
