using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI chickenText;
    private float money = 0;
    private float time = 0f;
    private int chicken = 0;


    void Update()
    {
        time += Time.deltaTime;
        if(time>=1f)
        {
            Debug.Log("time");
            time = 0f;
            money += 0.25f * chicken;
        }
        moneyText.text = "Money: " + money.ToString();
        chickenText.text = "Chickens: " + chicken.ToString();
    }
    public void AddChicken()
    {
        chicken++;
    }
}
