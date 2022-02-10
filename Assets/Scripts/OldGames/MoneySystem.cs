using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MoneySystem : MonoBehaviour
{
    [SerializeField] private int playerMoney;
    
    
    

    public int playerMoney1
    {
        get => playerMoney;
        set => playerMoney = value;
    }

    [SerializeField] private TextMeshProUGUI moneyInfo;
    
    [SerializeField] private 
    void Start()
    {
        moneyInfo.text = "" + playerMoney;
    }

    
    
    void Update()
    {
        moneyInfo.text = "" + playerMoney;
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MoneyReducer"))
        {
            StartCoroutine(ReduceMoney(other.gameObject));
            Debug.Log(other.GetComponent<MoneyReducer>().reducerMoney1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
        
    }

    private IEnumerator ReduceMoney(GameObject reducerObject)
    {
        yield return new WaitForSeconds(0.8f);
        while (playerMoney > 0 && reducerObject.GetComponent<MoneyReducer>().reducerMoney1 > 0)
        {
            playerMoney -= 2;
            reducerObject.GetComponent<MoneyReducer>().reducerMoney1 -= 2;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
