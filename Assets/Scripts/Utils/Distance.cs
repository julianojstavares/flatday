using UnityEngine;

public class Distance : MonoBehaviour
{
    private float metersDistance { get; set; } = 0;
    public int metersPerSecond = 4;
    public string text {get; set;} = "";

    private void FixedUpdate() 
    {
        Count();
    }

    private void Count()
    {
        metersDistance += Time.fixedDeltaTime*metersPerSecond;
        text = metersDistance.ToString("f1").Replace(",", ".") + "m";
    }
}
