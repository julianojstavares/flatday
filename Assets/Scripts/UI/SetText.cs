using UnityEngine;

public class SetText : MonoBehaviour
{
    private TMPro.TMP_Text textComponent;
    private Distance distance;

    private void Awake() 
    {
        textComponent = GetComponent<TMPro.TMP_Text>();
        distance = GetComponent<Distance>();
    }

    private void FixedUpdate() 
    {
        UpdateDistance();
    }

    private void UpdateDistance()
    {
        textComponent.text = distance.text;
    }
}
