using UnityEngine;

public class InstantiateChild : MonoBehaviour
{
    [Header("Transforms Arrays")]
    public Transform[] transforms;
    public Transform circle;

    public Transform CreateTransform(int index)
    {
        Transform obj = Instantiate(transforms[index], transform.position, transform.rotation);
        obj.SetParent(circle);
        return obj;
    }
}
