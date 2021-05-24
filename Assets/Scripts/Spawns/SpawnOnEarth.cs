using UnityEngine;

public class SpawnOnEarth : MonoBehaviour
{
    public InstantiateChild instantiateClass;

    [Header("Time to Spawn")]
    public float ttsHouse = 0;
    public float timeCountHouse = 0;

    private void FixedUpdate() 
    {
        CreateHouses();
    }

    private void CreateHouses()
    {
        timeCountHouse += Time.deltaTime;
        if(timeCountHouse > ttsHouse)
        {
            timeCountHouse = 0;
            Transform house = instantiateClass.CreateTransform(0);
            house.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
