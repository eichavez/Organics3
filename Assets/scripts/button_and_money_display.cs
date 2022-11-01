using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_and_money_display : MonoBehaviour
{
    public GameObject e;//employee check
    public GameObject a;//employee check
    public GameObject r;//employee check
    public GameObject t;//employee check
    public GameObject h;//employee check
    // employees
    public GameObject edger;
    public GameObject alex;
    public GameObject roger;
    public GameObject tom;
    public GameObject henry;


    // timers for auto production
    public float quartTimer, gallonTimer, twoHalfTimer, bucketTimer, barrelTimer;

    // for display
    public float money = 0.0f;
    public float netMoney = 0.0f;
    public Text moneyText;

    // upgrade
    private int fishBottleQuar = 4;
    private int fishBottleGal = 4;
    private int fishBottleTwoHalf = 2;
    private int fishBottleBuc = 2;
    private int fishBottleBar = 1;

    //Hiroshi Ranodm Break
    public double clickCount;
    public bool isEnoughClick;
    public GameObject PayButton1;
    public GameObject PayButton2;
    public GameObject PayButton3;
    public GameObject PayButton4;
    public GameObject PayButton5;
    public GameObject SellButton1;
    public GameObject SellButton2;
    public GameObject SellButton3;
    public GameObject SellButton4;
    public GameObject SellButton5;
    public float randomNum;
    public float randomButtonNum;
    //


    //enrique added stuff
    public GameObject RuleSheet;
    public GameObject WinScreen;
    private bool TrigWin = false; 

    // Start is called before the first frame update
    void Start()
    {
  
        // check to see if the employee was hired
        e.SetActive(false);
        a.SetActive(false);
        r.SetActive(false);
        t.SetActive(false);
        h.SetActive(false);
        // buttons for the employees
        edger.SetActive(false);
        alex.SetActive(false);
        roger.SetActive(false);
        tom.SetActive(false);
        henry.SetActive(false);

        //Hiroshi Random Break
        isEnoughClick = false;
        PayButton1.SetActive(false);
        PayButton2.SetActive(false);
        PayButton3.SetActive(false);
        PayButton4.SetActive(false);
        PayButton5.SetActive(false);
        randomNum = Random.Range(1, 30);
        randomButtonNum = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        // timers
        quartTimer += Time.deltaTime;
        gallonTimer += Time.deltaTime;
        twoHalfTimer += Time.deltaTime;
        bucketTimer += Time.deltaTime;
        barrelTimer += Time.deltaTime;

        DisplayMoney();
        Hired();
        //Hiroshi Added
        CountPlayerClick();
        CountDownThings();

        //enrique added 
        GoalMessage();

    }

     
    public void DisplayMoney()
    {
        moneyText.text = money.ToString("C2");
    }

    // buttons to hire employees
    public void EmployeeOne()
    {
        if (money >= 750)
        {
            money -= 750;
            e.SetActive(true);
        }
    }

    public void EmployeeTwo()
    {
        if (money >= 1500)
        {
            money -= 1500;
            a.SetActive(true);
        }
    }

    public void EmployeeThree()
    {
        if (money >= 2300)
        {
            money -= 2300;
            r.SetActive(true);
        }
    }

    public void EmployeeFour()
    {
        if (money >= 3000)
        {
            money -= 3000;
            t.SetActive(true);
        }
    }

    public void EmployeeFive()
    {
        if (money >= 3800)
        {
            money -= 3800;
            h.SetActive(true);
        }
    }

    //Hiroshi Random Break
    //player pay $50 to fix machine/button
    public void PaytoFix1()
    {

        if (money >= 50)
        {
            money -= 30;
            PayButton1.SetActive(false);
            SellButton1.SetActive(true);
            randomNum = Random.Range(1, 20);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    public void PaytoFix2()
    {

        if (money >= 200)
        {
            money -= 200;
            PayButton2.SetActive(false);
            SellButton2.SetActive(true);
            randomNum = Random.Range(1, 20);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    public void PaytoFix3()
    {

        if (money >= 300)
        {
            money -= 300;
            PayButton3.SetActive(false);
            SellButton3.SetActive(true);
            randomNum = Random.Range(1, 20);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    public void PaytoFix4()
    {

        if (money >= 400)
        {
            money -= 400;
            PayButton4.SetActive(false);
            SellButton4.SetActive(true);
            randomNum = Random.Range(1, 20);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    public void PaytoFix5()
    {

        if (money >= 600)
        {
            money -= 600;
            PayButton5.SetActive(false);
            SellButton5.SetActive(true);
            randomNum = Random.Range(1, 20);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    //count player's click
    public void CountPlayerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
    }
    //hide selling button and show fixing-machine button
    private void Break1()
    {
        if (isEnoughClick == true)
        {

            SellButton1.SetActive(false);
            PayButton1.SetActive(true);
            Debug.Log("Break!");
        }
    }
    private void Break2()
    {
        if (isEnoughClick == true)
        {

            SellButton2.SetActive(false);
            PayButton2.SetActive(true);
            Debug.Log("Break!");
        }
    }
    private void Break3()
    {
        if (isEnoughClick == true)
        {

            SellButton3.SetActive(false);
            PayButton3.SetActive(true);
            Debug.Log("Break!");
        }
    }
    private void Break4()
    {
        if (isEnoughClick == true)
        {

            SellButton4.SetActive(false);
            PayButton4.SetActive(true);
            Debug.Log("Break!");
        }
    }
    private void Break5()
    {
        if (isEnoughClick == true)
        {

            SellButton5.SetActive(false);
            PayButton5.SetActive(true);
            Debug.Log("Break!");
        }
    }
    // button script for Quater
    public void BreakQuater()
    {
        float price = 2f;
        if (clickCount <= randomNum)
        {
            if (quartTimer >= 0.4f)
            {
                money += price * fishBottleQuar;
                netMoney += 10;
                quartTimer -= 0.4f;
            }
        }
        else
        {
            Break1();
            clickCount = 0;
        }
    }
    // button script for Gallon
    public void BreakGallon()
    {
        float price = 25f;
        if (clickCount <= randomNum)
        {
            if (gallonTimer >= 0.8f)
            {
                money += price * fishBottleGal;
                netMoney += 25;
                gallonTimer -= 0.8f;
            }
        }
        else
        {
            Break2();
            clickCount = 0;
        }
    }
    // button script for 2+half Gallon
    public void BreakTwoAndAHalf()
    {
        float price = 50f;
        if (clickCount <= randomNum)
        {
            if (twoHalfTimer >= 1.5f)
            {
                money += price * fishBottleTwoHalf;
                netMoney += 50;
                twoHalfTimer -= 1.5f;
            }
        }
        else
        {
            Break3();
            clickCount = 0;
        }
    }
    // button script for bucket
    public void BreakBuckets()
    {
        float price = 100;
        if (clickCount <= randomNum)
        {
            if (bucketTimer >= 2f)
            {
                money += price * fishBottleBuc;
                netMoney += 100;
                bucketTimer -= 2f;
            } 
        }
        else
        {
            Break4();
            clickCount = 0;
        }
    }
    // button script for Barrel
    public void BreakBarrel()
    {
        float price = 1100;
        if (clickCount <= randomNum)
        {
            if (barrelTimer >= 2.3f)
            {
                money += price * fishBottleBar;
                netMoney += 1100;
                barrelTimer -= 2.3f;
            }
        }
        else
        {
            Break5();
            clickCount = 0;
        }
    }
    //Hiroshi Changed the content 
    public void Hired()
    {
        if (e.activeInHierarchy == true)
        {
            BreakQuater();
        }
        if (a.activeInHierarchy == true)
        {
            BreakGallon();
        }
        if (r.activeInHierarchy == true)
        {
            BreakTwoAndAHalf();
        }
        if (t.activeInHierarchy == true)
        {
            BreakBuckets();
        }
        if (h.activeInHierarchy == true)
        {
            BreakBarrel();
        }
    }
    private void CountDownThings()
    {
        if (clickCount <= 10)
        {
            isEnoughClick = true;
        }
    }

    // to switch back
    public void EmployeeMenuDeactive()
    {
        edger.SetActive(false);
        alex.SetActive(false);
        roger.SetActive(false);
        tom.SetActive(false);
        henry.SetActive(false);
    }

    // to switch to employee menu
    public void EmployeeMenuActive()
    {
        edger.SetActive(true);
        alex.SetActive(true);
        roger.SetActive(true);
        tom.SetActive(true);
        henry.SetActive(true);
    }

    public void Upgrade()
    {
        float totalBottles = 13;
        float costNextUpgrade = Mathf.Pow(1.07f, totalBottles) * 1558;

        if (money >= costNextUpgrade)
        {
            money -= costNextUpgrade;
            fishBottleQuar++;
            fishBottleGal++;
            fishBottleTwoHalf++;
            fishBottleBuc++;
            fishBottleBar++;
            totalBottles += 5;
        }
    }


    //Enrique added functions (4)
    public void GoalMessage()
    {    //50k is the final goal #50K 
        if (money >= 50000f )
        {
             WinScreen.SetActive(true);
            //TrigWin = true;
            // OpenWinScreen();
            //do somthing 
            Debug.Log("Hey You kinda won!");   
        }
    }
    public void OpenRules() 
    {
        //when this script is ran it will open a text box with some rules and the goal in mind 

        RuleSheet.SetActive(true); 
    }

    public void CloseRules() 
    {
        RuleSheet.SetActive(false);
    
    }

    public void CloseWinScreen()
    {
        WinScreen.SetActive(false);
        Debug.Log("CloseWin");

    }

    public void OpenWinScreen() 
    {
        WinScreen.SetActive(true);

    }
}
