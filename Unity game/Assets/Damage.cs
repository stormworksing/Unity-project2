using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "vol")
        {
            collision.gameObject.SendMessage("TakeDamage");
        }   
                
     }   
}
