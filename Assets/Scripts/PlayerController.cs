using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int _currentPillowCount = 0;
    [SerializeField] private Transform firstPillowLocation;
    [SerializeField] private float pillowHeight;

    [SerializeField] private GameObject[] pillows;
    [SerializeField] private GameObject CircularProgressBarPrefab;
    private GameObject CircularProgressBar;
    [SerializeField] private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PickupPillow()
    {
        
    }

    IEnumerator PickupPillow(PillowManager manager)
    {
        Debug.Log(manager.Count);
        while (manager.Count > -1)
        {
            CircularProgressBar = Instantiate(CircularProgressBarPrefab, canvas.transform);
            CircularProgressBar.GetComponent<RadialProgress>().speed = 100;
            CircularProgressBar.transform.parent = canvas.transform; 
            yield return new WaitForSeconds(1);
            
            pillows[_currentPillowCount] = manager.pillows[manager.Count];
            pillows[_currentPillowCount].transform.parent = gameObject.transform; 
            Destroy(pillows[_currentPillowCount].GetComponent<BoxCollider>());
            manager.pillows[manager.Count].transform
                .DOLocalMove(firstPillowLocation.localPosition + new Vector3(0, _currentPillowCount * pillowHeight, 0), 0.8f);
            manager.pillows[manager.Count] = null;

            _currentPillowCount++;
            manager.Count -= 1;
            Destroy(CircularProgressBar);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickupPillow"))
        {
            StartCoroutine(PickupPillow(other.gameObject.GetComponent<PillowManager>()));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PickupPillow"))
        {
            StopAllCoroutines();
            if(CircularProgressBar != null)
                Destroy(CircularProgressBar);
        }
    }
}
