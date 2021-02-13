using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Rotate : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(0f, 0.5f, 0f);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movementVector);
    }
}
