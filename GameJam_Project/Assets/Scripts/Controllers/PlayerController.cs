using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float jumpPower;
    
    void Update()
    {
        Movement();
    }
    public float PlayerSpeed = 2;
    private void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition += -transform.forward * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += -transform.right * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += transform.right * PlayerSpeed * Time.deltaTime;

        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpPower);
        }*/

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            PlayerSpeed = -1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerSpeed = +1;
    }


}
