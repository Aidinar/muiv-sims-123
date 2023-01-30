using UnityEngine;
using UnityEngine.UI;


public class Bar : MonoBehaviour
{

    public Image barImage;
    [SerializeField] float value;
    [SerializeField] float maxValue = 100;

    void Update()
    {
        barImage.fillAmount = value / maxValue;
        if (value > maxValue) value = maxValue;
    }
    public void Up(float upPoints)
    {
        if (value < maxValue)
        {
            value += upPoints;
        }
    }
    public void Down(float downPoints)
    {
        if (value > 0)
        {
            value -= downPoints;
        }
    }
}
