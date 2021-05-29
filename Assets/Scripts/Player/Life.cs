using UnityEngine;

public class Life : MonoBehaviour
{
    public LifeHud lifeHud;
    private int startLife = 0;
    public int life = 0;

    private void Start() 
    {
        startLife = lifeHud.panelLife.childCount;
        life = lifeHud.panelLife.childCount;   
    }

    public void AddLife()
    {
        if (life < startLife)
        {
            life += 1;
            lifeHud.AddHeart();
        }
    }

    public void LoseLife()
    {
        if (life > 0)
        {
            life -= 1;
            lifeHud.LoseHeart();
        }
    }
}
