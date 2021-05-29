using UnityEngine;

public class SpawnOnRoad : MonoBehaviour
{
    public InstantiateChild instantiateClass;

    [Header("Time to Spawn")]
    public float ttsBoy = 0;
    private float timeCountBoy = 0;
    public float ttsHeart = 0;
    private float timeCountHeart = 0;

    private void FixedUpdate() 
    {
        CreateBoy();
        CreateHumanHeart();
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

    private void CreateHumanHeart()
    {
        timeCountHeart += Time.deltaTime;
        if(timeCountHeart > ttsHeart)
        {
            timeCountHeart = 0;
            Transform obj = instantiateClass.CreateTransform(1);
            obj.localScale = new Vector3(10, 10, 1);
        }
        
    }
}
