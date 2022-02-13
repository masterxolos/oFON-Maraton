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
    private int k = 0;
    [SerializeField] private int requestedHeart = 0;
    [SerializeField] private GameObject standart;
    [SerializeField] private GameObject afterbeauty;
    [SerializeField] private GameObject afterbody;
    [SerializeField] private GameObject afterstyle;
    [SerializeField] private GameObject particle;
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
                    k++;
                    if (k == requestedHeart)
                    {
                        Instantiate(particle, afterbody.transform);
                        standart.SetActive(false);
                        afterbeauty.SetActive(false);
                        afterbody.SetActive(true);
                        afterstyle.SetActive(false);
                    }
                    gateBlocs[funNum].GetComponent<MeshRenderer>().material = greenMat;
                    funNum++;
                }
            }
            other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
            //Destroy(other.gameObject);
        }
    }
}
