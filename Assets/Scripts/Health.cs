using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public UnityAction HealthChanged;

    public float CurrentHealth { get; private set; }
    public float MinHealth { get; private set; } = 0;
    public float MaxHealth { get; private set; } = 100;

    private int _changeHealthValue = 10;
    private float _newHealth;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void Heal()
    {
        _newHealth = CurrentHealth + _changeHealthValue;

        CurrentHealth = Mathf.Clamp(_newHealth, MinHealth, MaxHealth);

        HealthChanged?.Invoke();
    }

    public void TakeDamage()
    {
        _newHealth = CurrentHealth - _changeHealthValue;

        CurrentHealth = Mathf.Clamp(_newHealth, MinHealth, MaxHealth);

        HealthChanged?.Invoke();
    }
}
