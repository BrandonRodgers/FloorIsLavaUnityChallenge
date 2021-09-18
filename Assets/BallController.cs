using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class BallController : MonoBehaviour
{
    private SphereCollider sphereCollider;
    private PhysicMaterial physicsMaterial;
    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        physicsMaterial = sphereCollider.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            physicsMaterial.bounciness = 0.0f;
            physicsMaterial.staticFriction = 1.0f;
            physicsMaterial.dynamicFriction = 1.0f;
        }
    }
}
