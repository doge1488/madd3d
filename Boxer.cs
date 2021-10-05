using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class Boxer : Enemy
{
   public int  enemydamage = 10;
   new public int enemyHealth = 120;
    public GameObject BoxerCorpse;
    
    public int MoveSpeed = 4;
     
     PlayerHealth playerHealth;
    
    void Start()
    {
       
        
    
    }
    void Update ()
    {
 if(enemyHealth<=0)
{
    Die();
    
}

    }
    
 


  public void Attack(other Collider)
 {
   if(other.CompareTag("Player"))
   {
  other.GetComponent<PlayerHealth>().ApplyDamage(enemyDamage );

   }
 }
   void Die()
   { Instantiate(BoxerCorpse,this.transform.position ,Quaternion.identity ) ;
  
  Destroy(gameObject);

   }
}


