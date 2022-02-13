using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CamDoTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CamMovement());
    }
    
    private IEnumerator CamMovement()
    {
        yield return new WaitForSeconds(2f);
        gameObject.transform.DOMove(new Vector3(1.66f, 4.24f, -3.49f), 0.8f);
        gameObject.transform.DORotate(new Vector3(13.84f, 9, 0f), 0.8f);
        yield return new WaitForSeconds(1.7f);
        
        gameObject.transform.DOMove(new Vector3(1.66f, 12.05f, -3.49f), 1f);
        gameObject.transform.DORotate(new Vector3(8.71f, 9, 0f), 1f);
        yield return new WaitForSeconds(1.8f);
        
        gameObject.transform.DOMove(new Vector3(28.6f, -9.7f, 169.57f), 4f);
        gameObject.transform.DORotate(new Vector3(-1f, 39.3f, 0f), 4f);
        yield return new WaitForSeconds(2.7f);
        
    }
}
