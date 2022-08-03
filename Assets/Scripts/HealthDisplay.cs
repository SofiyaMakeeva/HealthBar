using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _sliderHealth;
    [SerializeField] private Health _playerHealth;

    private float _duration = 5;

    private void Start()
    {
        _sliderHealth.minValue = _playerHealth.MinHealth;
        _sliderHealth.maxValue = _playerHealth.MaxHealth;
        _sliderHealth.value = _playerHealth.CurrentHealth;
    }

    private void OnEnable()
    {
        _playerHealth.HealthChanged += OnChangeHealth;
    }

    private void OnDisable()
    {
        _playerHealth.HealthChanged -= OnChangeHealth;
    }

    private void OnChangeHealth()
    {
        StartCoroutine(ChangeHealthUI());
    }

    private IEnumerator ChangeHealthUI()
    {
        while (_playerHealth.CurrentHealth != _sliderHealth.value)
        {
            _sliderHealth.value = Mathf.MoveTowards(_sliderHealth.value, _playerHealth.CurrentHealth, _duration * Time.deltaTime);

            yield return null;
        }
    }
}
