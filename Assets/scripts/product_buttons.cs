using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class product_buttons : MonoBehaviour
{
    public float money = 0.0f;
    public float netMoney = 0.0f;
    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayMoney();
    }

    // buttons to earn money
    public void FishQuater()
    {
        money += 5;
        netMoney += 5;

    }

    public void FishGallon()
    {
    
        if (money >= 500)
        {
            money += 20;
            netMoney += 20;
           // Debug.Log("ran");
        }


    }

    public void FishTwoAndAHalf()
    {
        if (money >= 2000) 
        {
            money += 50;
            netMoney += 50;
        }
       
    }

    public void FishBuckets()
    {
        if (money >= 5000)
        {
            money += 100;
            netMoney += 100;
        }
        
    }

    public void FishBarrel()
    {
        if (money >= 9000)
        {
            money += 1100;
            netMoney += 1100;
        }
        
    }

    public void DisplayMoney()
    {
        moneyText.text = money.ToString("C2");
    }
}
