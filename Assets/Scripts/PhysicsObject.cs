using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour//, IInteractable
{
 
    public GameObject player;
    private Rigidbody2D m_ThisRigidbody = null;
    private bool pickCheck;
 


    private void Start()
    {
        gameObject.tag = "Interactable";
       m_ThisRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (Input.GetButton("Pick") && PlayerController.m_CanInteract == true)
        {
            pickCheck = true;
        }

        if (Input.GetButtonDown("Drop") && PlayerController.m_CanInteract == true)
        {
            pickCheck = false;
          Action();
          
        }
        if (pickCheck == true)
        {
            Interact();
        }

    }

    // Pick up the object, or drop it if it is already being held
    public void Interact()
    {

            m_ThisRigidbody.gravityScale = 0;
            transform.position = player.transform.position +new Vector3(0,-1,0);
    }
    
  
    // Throw the object
    public void Action()
    {
        m_ThisRigidbody.gravityScale = 1;

    }
    
}