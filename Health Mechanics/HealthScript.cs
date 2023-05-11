using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject ScreenOfDeath;
    public GameObject BloodBorder;

    void Start()
    {
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    void Update()
    {
        if (slider.value == 0)
        {
            ScreenOfDeath.SetActive(true);
        }

        if (slider.value < 20)
        {
            BloodBorder.SetActive(true);
        }
    }

    public void SetMaxHealth(int MaxHealth)
    {
        slider.maxValue = MaxHealth;
        slider.value = MaxHealth;
        gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void Injure()
    {
        slider.value -= 5;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void Heal()
    {
        slider.value += 5;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
