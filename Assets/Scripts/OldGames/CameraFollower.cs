using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,target.position + offset, Time.deltaTime * 2);   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StopCam"))
        {
            gameObject.GetComponent<CameraFollower>().enabled = false;
            gameObject.GetComponent<CamDoTween>().enabled = true;
        }
    }
}
