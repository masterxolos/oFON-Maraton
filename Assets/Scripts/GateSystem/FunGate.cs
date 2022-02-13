using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FunGate : MonoBehaviour
{
    public int funNum;
    [SerializeField] private GameObject[] gateBlocs = new GameObject[6];
    [SerializeField] private Material greenMat;
    private int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            i++;
            if (i == 2)
            {
                i = 0;
                if (funNum < 6)
                {
                    gateBlocs[funNum].GetComponent<MeshRenderer>().material = greenMat;
                    funNum++;
                }
            }
            other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
            //Destroy(other.gameObject);
        }
    }
}
