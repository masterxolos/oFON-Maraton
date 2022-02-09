using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float horizontalSpeed;

    private float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(
            new Vector3(
                horizontalInput * horizontalSpeed * Time.deltaTime,0 , movementSpeed* Time.deltaTime ));
        
        
        
    }
}
