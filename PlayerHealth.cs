using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
 public int maxHealth = 100 ;

 public int currentHealth;
public int maxArmor = 200;
public int currentArmor ;
 
void Start()
{
 currentHealth=maxHealth;
 currentArmor=maxArmor;
 
}
 
void Update()
{
 
}
 public void GiveHealth(int amount, GameObject pickup)
 { if(currentHealth<maxHealth)
 {
  currentHealth+= amount;
  Destroy(pickup);
 }

 if(currentHealth>maxHealth)
 {
     currentHealth=maxHealth;
 }
 }
  public void GiveArmor(int amount , GameObject pickup)
  {
   if(currentArmor<maxArmor)
   {
       currentArmor+=amount;
       Destroy(pickup);
   }
if(currentArmor>maxArmor)
{
    currentArmor=maxArmor;
}

  }
public void ApplyDamage(int damageAmount)
{
 if(currentHealth<=damageAmount)
 {
     FindObjectOfType<Manager>().KillPlayer();
 }
 else
 {
     currentHealth -= damageAmount;

}
}

}