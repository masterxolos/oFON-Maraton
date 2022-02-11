using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FunGate : MonoBehaviour
{
    public int funNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            funNum++;
            other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
            //Destroy(other.gameObject);
        }
    }
}
