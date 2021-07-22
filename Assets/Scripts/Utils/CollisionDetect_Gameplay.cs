using UnityEngine;

public class CollisionDetect_Gameplay : MonoBehaviour
{
    public Transform player;
    private Life playerLife;

    private AudioSource audioSource;

    public AudioClips sfx;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

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
            audioSource.clip = sfx.enemy;
            audioSource.Play();
        }
    }

    private void HumanHeartCollision(GameObject heart)
    {
        if(heart.name=="HumanHeart(Clone)")
        {
            audioSource.clip = sfx.player_AddLife;
            audioSource.Play();
            playerLife.AddLife();
            Destroy(heart);
        }
    }

}
