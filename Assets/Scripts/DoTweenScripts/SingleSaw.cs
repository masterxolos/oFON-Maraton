using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SingleSaw : MonoBehaviour
{
    
    void Start()
    {
        gameObject.transform.DORotate(new Vector3(0,0,178), 1f).SetLoops(-1, LoopType.Yoyo);
        gameObject.transform.DOLocalMoveX(3.7f, 1f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
