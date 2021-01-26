using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidad = 10;
    
    Rigidbody miRigidBody;
    // Start is called before the first frame update
    void Start()
    {
      miRigidBody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
      float vertical = Input.GetAxis("Vertical");
      float horizontal = Input.GetAxis("Horizontal");

      miRigidBody.AddForce(new Vector3(horizontal,0,vertical)*velocidad);
    }
}
