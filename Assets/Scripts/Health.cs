using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //[SerializeField] private HealthDisplay _healthDisplay;
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
    }

    public void TakeDamage()
    {
        _newHealth = CurrentHealth - _changeHealthValue;

        CurrentHealth = Mathf.Clamp(_newHealth, MinHealth, MaxHealth);
    }
}
