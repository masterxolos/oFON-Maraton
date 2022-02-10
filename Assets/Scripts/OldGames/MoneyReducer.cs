using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyReducer : MonoBehaviour
{
    [SerializeField] private int reducerMoney;
    [SerializeField] private TextMeshProUGUI moneyReducerText;
    public int reducerMoney1
    {
        get => reducerMoney;
        set => reducerMoney = value;
    }


    void Start()
    {
        
    }

   
    void Update()
    {
        if (reducerMoney >= 0)
        {
            moneyReducerText.text = "" + reducerMoney;
        }
        else
        {
            moneyReducerText.text = "" + 0;
            
            //Burada obje destroy olsun.
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

        }
    }
    
    
}
