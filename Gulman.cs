using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gulman : Enemy
{
   new  public int enemyHealth = 50;
  new  public int enemyDamage = 15;

 PlayerHealth playerHealth;

void Update()
{
 if(enemyHealth<=0)
 {
     Die();
 }
}
  void Attack(Collider other)
 {
   if(other.CompareTag("Player"))
   {
  other.GetComponent<PlayerHealth>().ApplyDamage(damageAmount );

   }
 }
new  public void ApplyDamage(int damageAmount)
{
enemyHealth-=damageAmount;

}


}
