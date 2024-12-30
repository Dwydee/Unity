using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 300f;
    public Color color = Color.blue;

    Rigidbody rb;
    Renderer r;
    bool isGrounded;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(0, jumpforce, 0);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        
    }


}
