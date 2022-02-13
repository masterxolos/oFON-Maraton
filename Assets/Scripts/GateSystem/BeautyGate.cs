using DG.Tweening;
using UnityEngine;

namespace GateSystem
{
    public class BeautyGate : MonoBehaviour
    {
        public int beautyNum;
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
                    if (beautyNum < 6)
                    {
                        gateBlocs[beautyNum].GetComponent<MeshRenderer>().material = greenMat;
                        beautyNum++;
                    }
                }

                other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
                //Destroy(other.gameObject);
            }
        }
    }
}
