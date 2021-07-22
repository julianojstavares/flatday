using UnityEngine;

public class LifeHud : MonoBehaviour
{
    public RectTransform panelLife;
    public RectTransform heart;

    public void AddHeart()
    {
        if(panelLife.childCount <= 3)
        {
            RectTransform heartUI = Instantiate(heart);
            heartUI.SetParent(panelLife);
            heartUI.localPosition = new Vector3(heartUI.transform.position.x, heartUI.transform.position.y, 0);
            heartUI.localScale = new Vector3(1,1,1);
        }
    }

    public void LoseHeart()
    {
        if(panelLife.childCount > 0)
        {
            GameObject heart = panelLife.GetChild(0).gameObject;
            Destroy(heart);
        }
    }

    private void Awake() {
        AddHeart();
        AddHeart();
        AddHeart();
    }
}
