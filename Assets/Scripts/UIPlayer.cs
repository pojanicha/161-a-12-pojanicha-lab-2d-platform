using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{

    [SerializeField] private Slider slider;
    [SerializeField] private Player player;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       slider.maxValue = player.Health;
       slider.value = player.Health;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.Health;

    }
}

