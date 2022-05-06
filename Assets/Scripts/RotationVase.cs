using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationVase : MonoBehaviour
{
    public float speed = 0f;
        void Update ()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
    }
}
