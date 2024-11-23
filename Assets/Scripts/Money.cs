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
    private bool dirtyFlag = false;


    void Update()
    {
        time += Time.deltaTime;
        if(time>=1f)
        {
            time = 0f;
            money += 0.25f * chicken;
            dirtyFlag = true;
        }

        if (dirtyFlag)
        {
            moneyText.text = "Money: " + money.ToString();
            chickenText.text = "Chickens: " + chicken.ToString();
            dirtyFlag = false;
        }
    }
    public void AddChicken()
    {
        chicken++;
    }
}
