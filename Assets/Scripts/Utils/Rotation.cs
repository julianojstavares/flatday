using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 0;
    public float amount = 10;
    private void FixedUpdate() 
    {
        Rotate();
    }

    private void Rotate () 
    {
        Vector3 vector = new Vector3(0,0, speed * Time.fixedDeltaTime * amount);
        transform.Rotate(vector);
    }
}
