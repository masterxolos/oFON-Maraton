using DG.Tweening;
using UnityEngine;

namespace GateSystem
{
    public class BeautyGate : MonoBehaviour
    {
        public int beautyNum;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Collected"))
            {
                beautyNum++;
                other.transform.DOScale(new Vector3(0, 0, 0), 0.1f);
                //Destroy(other.gameObject);
            }
        }
    }
}
