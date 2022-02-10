using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelligenceGate : MonoBehaviour
{
    public int intelNum;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            intelNum++;
            Destroy(other.gameObject);
        }
    }
}
