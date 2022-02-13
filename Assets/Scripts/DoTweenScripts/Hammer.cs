using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hammer : MonoBehaviour
{
    // Start is called before the first frame update

    private bool goDown = true;
    private bool shouldGo = true;

    [SerializeField] private int hammerIndex = 0;

    void Start()
    {
        StartCoroutine(DOTweenHandler());
    }

    

    private IEnumerator DOTweenHandler()
    {
        if(hammerIndex == 0)
        {
            yield return new WaitForSeconds(1f);
        }
        else
        {
            yield return new WaitForSeconds(3f);
        }

       
            if (shouldGo)
            {
                if (goDown)
                {
                    shouldGo = false;
                    gameObject.transform.DORotate(new Vector3(0, 180, 60f), 1.5f);
                    yield return new WaitForSeconds(1.6f);
                    shouldGo = true;
                    goDown = false;
                }
                else
                {
                    shouldGo = false;
                    gameObject.transform.DORotate(new Vector3(0, 180, -52f), 1.5f);
                    yield return new WaitForSeconds(1.6f);
                    shouldGo = true;
                    goDown = false;
                }
            }
        
        
        
    }
}
