using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 0;
    public float amount = 10;
    private void Update() 
    {
        Rotate();
    }

    private void Rotate () 
    {
        Vector3 vector = new Vector3(0,0, speed * Time.deltaTime * amount);
        transform.Rotate(vector);
    }
}
