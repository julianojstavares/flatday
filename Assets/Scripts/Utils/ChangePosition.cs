using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform earthStart;
    public Transform roadStart;

    public void Move(Transform obj)
    {
        if(obj.tag == "EarthCircle")
        {
            obj.position = earthStart.position;
        }
        
        if(obj.tag == "RoadCircle")
        {
            obj.position = roadStart.position;
        }
    }
}
