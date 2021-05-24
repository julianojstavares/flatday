using UnityEngine;

public class SpawnOnRoad : MonoBehaviour
{
    public InstantiateChild instantiateClass;

    [Header("Time to Spawn")]
    public float ttsBoy = 0;
    public float timeCountBoy = 0;

    private void FixedUpdate() 
    {
        CreateBoy();
    }

    private void CreateBoy()
    {
        timeCountBoy += Time.deltaTime;
        if(timeCountBoy > ttsBoy)
        {
            timeCountBoy = 0;
            Transform obj = instantiateClass.CreateTransform(0);
            obj.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
