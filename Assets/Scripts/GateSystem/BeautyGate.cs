using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeautyGate : MonoBehaviour
{
    public int beautyNum;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            beautyNum++;
            Destroy(other.gameObject);
        }
    }
}
