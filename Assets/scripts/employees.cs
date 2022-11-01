using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class employees : MonoBehaviour
{
    public GameObject e;
    public GameObject a;
    public GameObject r;
    public GameObject t;
    public GameObject h;
    public float income;
    public GameObject ScriptHolder;

    // Start is called before the first frame update
    void Start()
    {
        e.SetActive(false);
        a.SetActive(false);
        r.SetActive(false);
        t.SetActive(false);
        h.SetActive(false);
    }

    private void Update()
    {
        income = ScriptHolder.GetComponent<product_buttons>().money;
    }

    // buttons to hire employees
    public void EmployeeOne()
    {
        if (income >= 750)
        {
            Debug.Log("why");
            income -= 750;
            e.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeTwo()
    {
        if (income >= 1500)
        {
            Debug.Log("why");
            income -= 1500;
            a.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeThree()
    {
        if (income >= 2300)
        {
            Debug.Log("why");
            income -= 2300;
            r.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeFour()
    {
        if (income >= 3000)
        {
            Debug.Log("why");
            income -= 3000;
            t.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeFive()
    {
        if (income >= 3800)
        {
            Debug.Log("why");
            income -= 3800;
            h.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }
}
