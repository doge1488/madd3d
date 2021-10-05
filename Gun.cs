 using System.Collections.Generic;
using UnityEngine;

public  class Gun : MonoBehaviour
{   public  int range = 100;
    public int damage = 25;
    public float fireRate = .25f;
    public Camera fpsCam ;

    RaycastHit hit;
   

    
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
   {
       Shoot();
   }
        
    }
    void Shoot ()
    {
     
     if(hit.collider.tag == "Enemy")
     {
         
            
            GetComponent<Enemy>().TakeDamage(damage );
            
         
     }

   
    
     }


    }

