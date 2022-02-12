using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoubleSaw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.DORotate(new Vector3(0,0,178), 1f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
