using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Player player;
    [SerializeField] private Vector3 offset = new Vector3(0, 1.5f, 0);





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (slider == null || player == null) return;
        {
            slider.maxValue = player.MaxHealth;
            slider.value = player.Health;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (slider == null || player == null) return;
        slider.value = player.Health;

        transform.position = player.transform.position + offset;
    }


    public void UpdateHealthUI()
    {
        if (slider == null || player == null) return;
        slider.maxValue = player.MaxHealth;
    }
}

