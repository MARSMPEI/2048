using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleweedRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new Vector3(0, 0, 1);
        gameObject.transform.Rotate(vector3);
    }
}
