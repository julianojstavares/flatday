using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform target;
    public Transform earth;

    public void Move(Transform obj)
    {
        obj.position = target.position;
    }
}
