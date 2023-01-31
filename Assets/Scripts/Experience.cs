
using UnityEngine;
using UnityEngine.UI;


public class Experience : MonoBehaviour
{

    public Image experienceBar;
    float experience, maxExperience = 100;
    void Start()
    {
        experience = maxExperience;
    }

    
    void Update()
    {
        experienceBar.fillAmount = experience / maxExperience;
        if (experience > maxExperience) experience = maxExperience;
    }
    public void UP (float upPoints)
    {
        if (experience < maxExperience)
        {
            experience += upPoints;
        }
    }
    public void  Down(float DownPoints)
    {
        if (experience > 0)
        {
            experience -= DownPoints;
        }
    }
}
