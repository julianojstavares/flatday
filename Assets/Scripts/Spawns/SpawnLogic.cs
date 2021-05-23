using UnityEngine;

public class SpawnLogic : MonoBehaviour
{
    public InstantiateChild instantiate;

    private void Update() {
        instantiate.CreateTransform(0);
    }
}
