using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKit : MonoBehaviour 


{  
    PlayerHealth playerHealth;
    public int amount;

     public bool IsHealth;
     
     public bool IsArmor ;
     public bool  IsAmmo ;
     
     public bool IsSuperHova;
     
    // Start is called before the first frame update
    void Awake()
    {
    


    }

    void OnTriggerEnter3D(Collider other)
    { if(other.CompareTag("Player"))
    {
     if(IsHealth)
     {
     other.GetComponent<PlayerHealth>().GiveHealth(amount, this.gameObject );
     }
     if(IsArmor)
     {
      other.GetComponent<PlayerHealth>().GiveArmor(amount, this.gameObject );
     }
     if(IsAmmo)
     {
     
     }
     
     if(IsSuperHova)
     {

     }
     Destroy(gameObject);
     
    
    }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

