using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyDance();
    }
    public override void enemyDance()
    { 
        if(transform.position.y < 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * jumpForce);
        }
        else
        {
            transform.position = new Vector3(3, 3, 3);
        }
    }
}
