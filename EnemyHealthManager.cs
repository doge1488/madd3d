using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{   public int EnemyMaxhealth ;
    public int EnemyCurrentHealth;

    

    // Start is called before the first frame update
    void Start()
    {EnemyCurrentHealth=EnemyMaxhealth;
        
    }

    // Update is called once per frame
    void Update()
    { if(EnemyCurrentHealth<=0)
    {
        EnemyDeath();
    }
        
    }
    void EnemyDeath()
    {
        
    }
}
