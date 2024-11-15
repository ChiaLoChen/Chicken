using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private float money = 0;
    private float time = 0f;

    public GameObject spawn;

    void Update()
    {
        time += Time.deltaTime;
        if(time>=1f)
        {
            Debug.Log("time");
            time = 0f;
            money += 0.25f * spawn.GetComponent<ChickenSpawn>().GetNumberOfChickens();
        }
        moneyText.text = "Money: " + money.ToString();
    }
}
