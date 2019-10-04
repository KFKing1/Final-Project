using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject mobject;
    public static bool m_CanInteract = false;
   
    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, mobject.transform.position) < 30)
        {
            if (mobject.tag == "Interactable")
            {
      
                Debug.Log("khord");
                m_CanInteract = true;
            }
            else
            {

                m_CanInteract = false;
            }
        }
    }
    
}