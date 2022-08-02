using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthDisplay _healthDisplay;
    public float CurrentHealth { get; private set; }
    public float MinHealth { get; private set; } = 0;
    public float MaxHealth { get; private set; } = 100;

    private int _changeHealthValue = 10;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void Heal()
    {
        CurrentHealth += _changeHealthValue;

        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        _healthDisplay.OnChangeHealth();
    }

    public void TakeDamage()
    {
        CurrentHealth -= _changeHealthValue;

        if (CurrentHealth < MinHealth)
        {
            CurrentHealth = MinHealth;
        }

        _healthDisplay.OnChangeHealth();
    }
}
