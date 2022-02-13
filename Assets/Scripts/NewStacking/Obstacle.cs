using CustomEventSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject brokenHeartPrefab;
    private void OnTriggerEnter(Collider other)
    {
        IStackable stackable = other.GetComponent<IStackable>();
        
        if (stackable != null)
        {
            Instantiate(brokenHeartPrefab, gameObject.transform.position+new Vector3(0,1,0), Quaternion.identity);
            Events.OnObstacleCollision.Invoke(stackable);
        }
    }
}
