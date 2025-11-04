using System;
using UnityEngine;
using UnityEngine.UI;

public class UIAnt : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Ant ant;
    [SerializeField] private Vector3 offset = new Vector3(0, 1.5f, 0);





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (slider == null || ant == null) return;

        slider.gameObject.SetActive(true);
        slider.maxValue = ant.MaxHealth;
        slider.value = ant.MaxHealth;
    }

    void Update()
    {
        if (slider == null) return;

        if (ant == null || !ant.gameObject.activeInHierarchy || ant.Health <= 0)
        {
            slider.gameObject.SetActive(false);
            return;

        }
    }


    public void UpdateHealthUI()
    {
        if (slider == null || ant == null) return;
        slider.maxValue = ant.MaxHealth;
        slider.value = ant.Health;
    }
}

