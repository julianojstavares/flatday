using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ChangePosition changePosition;
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log(other.gameObject.name);
        if(other != null)
            changePosition.Move(other.transform);
    }
}
