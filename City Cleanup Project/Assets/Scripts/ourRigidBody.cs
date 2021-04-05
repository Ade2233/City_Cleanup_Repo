using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ourRigidBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D ourRigidBody;
        ourRigidBody = GetComponent<Rigidbody2D>();
        Vector2 direction = Vector.right;
        float strength = 10;
        ourRigidBody.AddForce(direction.normalized * strength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
