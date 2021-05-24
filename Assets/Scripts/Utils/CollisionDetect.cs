using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ChangePosition changePosition;
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log(other.gameObject.name);
        if(other != null)
        {
            //MoveObject(other);
            DeleteObject(other.gameObject);
        }
            
    }

    private void MoveObject(Collider2D other)
    {
        changePosition.Move(other.transform);
    }

    private void DeleteObject(GameObject other)
    {
        Destroy(other);
    }
}
