using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform target;

    private void Awake() {
        target = GameObject.Find("Cenário").transform;
    }
    private void Update() {
        transform.up = (target.position - transform.position)*-1;
    }
}
