using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowManager : MonoBehaviour
{
    [SerializeField] private int count;

    public int Count
    {
        get => count;
        set => count = value;
    }

    public GameObject[] pillows;
    // Start is called before the first frame update
    void Start()
    { 
        count = pillows.Length -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
