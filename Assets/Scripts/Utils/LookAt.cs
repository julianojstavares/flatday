using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetCircle;

    private void Awake() 
    {
        if(transform.tag == "EarthCircle")
        {
            targetCircle = GameObject.Find("Earth_Circle").transform;
        }

        if(transform.tag == "RoadCircle")
        {
            targetCircle = GameObject.Find("Road_Circle").transform;
        }
    }

    private void Update() {
        transform.up = (targetCircle.position - transform.position)*-1;
    }
}
