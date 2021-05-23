using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetCircle;

    private void Update() {
        transform.up = (targetCircle.position - transform.position)*-1;
    }
}
