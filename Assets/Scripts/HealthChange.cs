using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChange : MonoBehaviour
{
    public float CurrentHealth { get; private set; }
    public float MinHealth { get; private set; } = 0;
    public float MaxHealth { get; private set; } = 100;

    private int _changeHealthValue = 10;  

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void HealOnClick()
    {
        if (CurrentHealth < MaxHealth)
        {
            CurrentHealth += _changeHealthValue;
        }
    }

    public void HitOnClick()
    {     
        if (CurrentHealth > MinHealth)
        {
            CurrentHealth -= _changeHealthValue;
        }
    }
}
