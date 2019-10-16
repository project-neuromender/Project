using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        float v = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3(0, 0, v) * Time.deltaTime);
    }
}
