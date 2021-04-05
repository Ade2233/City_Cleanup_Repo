using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forceStrength;
    // Start is called before the first frame update
    void Start()
    {
        public void MoveUp()
        {
            Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D>();
            PlayerObject.AddForce(Vector2.up * forceStrength);
        }
        public void MoveDown()
        {
            Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D>();
            PlayerObject.AddForce(Vector2.down * forceStrength);
        }
        public void MoveLeft()
        {
            Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D>();
            PlayerObject.AddForce(Vector2.left * forceStrength);
        }
        public void MoveRight()
        {
            Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D>();
            PlayerObject.AddForce(Vector2.right * forceStrength);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
