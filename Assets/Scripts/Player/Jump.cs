using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public int force;
    private int amount = 100;
    public Ground ground;

    private AudioSource audioSource;

    public AudioClips sfx;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update() 
    {
        PressJump();
    }

    private void PressJump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && ground.onGround == true)
        {
            rb.AddForce(transform.up * force * amount);
            audioSource.clip = sfx.player_jump;
            audioSource.Play();
            //Debug.Log("Jump");
        }
    }
}
