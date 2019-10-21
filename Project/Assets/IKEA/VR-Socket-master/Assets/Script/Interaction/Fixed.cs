using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    public GameObject cube1, cube2, cube3, cube4, snapZones;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(cube1.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(cube2.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(cube3.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(cube4.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(snapZones.GetComponent<Collider>(), GetComponent<Collider>());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
