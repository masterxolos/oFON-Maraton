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
                    if (beautyNum < 6)
                    {
                        k++;
                        if (k == requestedHeart)
                        {
                            Instantiate(particle, afterbeauty.transform);
                            standart.SetActive(false);
                            afterbeauty.SetActive(true);
                            afterbody.SetActive(false);
                            afterstyle.SetActive(false);
                        }

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
