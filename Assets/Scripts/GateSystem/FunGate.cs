using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunGate : MonoBehaviour
{
    public int funNum;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            funNum++;
            Destroy(other.gameObject);
        }
    }
}
