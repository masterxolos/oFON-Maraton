using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class IntelligenceGate : MonoBehaviour
{
    public int intelNum;
    [SerializeField] private GameObject[] gateBlocs = new GameObject[6];
    [SerializeField] private Material greenMat;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            if (intelNum < 6)
            {
                gateBlocs[intelNum].GetComponent<MeshRenderer>().material = greenMat;
                intelNum++;
            }
            
            other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
            //Destroy(other.gameObject);
        }
    }
}
