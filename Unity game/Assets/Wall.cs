﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int health;
    public GameObject explosion;
    // Start is called before the first frame update
   
       public void TakeDamage()
    {

           health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject t= Instantiate(explosion, transform.position, transform.rotation);
            Destroy(t, 2);

        }     
    }
}