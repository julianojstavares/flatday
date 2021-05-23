using UnityEngine;

public class SpawnOnEarth : MonoBehaviour
{
    public InstantiateChild instantiate;

    [Header("Time to Spawn")]
    public float ttsHouse = 0;

    private void FixedUpdate() 
    {
        CreateHouses();
    }

    private void CreateHouses()
    {
        ttsHouse += Time.deltaTime;
        if(ttsHouse > 5)
        {
            ttsHouse = 0;
            Transform house = instantiate.CreateTransform(0);
        }
        
    }
}
