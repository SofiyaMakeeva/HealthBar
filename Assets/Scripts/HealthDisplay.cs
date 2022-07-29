using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _sliderHealth;
    [SerializeField] private HealthChange _playerHealth;

    private float _duration = 15;

    private void Start()
    {
        _sliderHealth.value = _playerHealth.CurrentHealth;
        _sliderHealth.minValue = _playerHealth.MinHealth;
        _sliderHealth.maxValue = _playerHealth.MaxHealth;
    }

    private void Update()
    {
        if (_sliderHealth.value != _playerHealth.CurrentHealth)
        {
            _sliderHealth.value = Mathf.MoveTowards(_sliderHealth.value, _playerHealth.CurrentHealth, _duration * Time.deltaTime);
        }
    }
}
