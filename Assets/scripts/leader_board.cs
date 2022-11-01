using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leader_board : MonoBehaviour
{
    public float companyWorth;
    public float[] comWorth = new float[7];
    public GameObject ScriptHolder;

    private void Start()
    {
        // how much a company is worth
        comWorth[0] = 750000.0f;
        comWorth[1] = 1000000.0f;
        comWorth[2] = 42000000.0f;
        comWorth[3] = 164000000.0f;
        comWorth[4] = 256000000.0f;
        comWorth[5] = 500000000.0f;
        comWorth[6] = 1000000000.0f;
    }

    private void Update()
    {
        companyWorth = ScriptHolder.GetComponent<product_buttons>().money;
        CheckingWorth();
    }

    // compare Organics to other companies
    public void CheckingWorth()
    {
        for(int i = 0; i < comWorth.Length; i++)
        {
            if (comWorth[i] < companyWorth)
            {
                comWorth[i] = companyWorth;
                //Debug.Log("it works");
            }
            else
            {
                return;
            }
        }
        return;
    }
}
