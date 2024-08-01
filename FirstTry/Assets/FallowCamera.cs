using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtoFollow;
    
    void LateUpdate()
    {
      transform.position = thingtoFollow.transform.position + new Vector3(0f,0f,-10f);
    }
    
}
