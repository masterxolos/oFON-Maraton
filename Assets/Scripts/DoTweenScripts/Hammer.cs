using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hammer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.DORotate(new Vector3(0, 180, 60f), 1.5f).SetLoops(-1, LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
