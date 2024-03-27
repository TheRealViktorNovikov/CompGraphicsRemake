 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighthouse : MonoBehaviour
{
    // Start is called before the first frame update

    public float xAngle, yAngle, zAngle;
    public GameObject lighthouseLight;
    // Update is called once per frame
    void Update()
    {
        lighthouseLight.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
