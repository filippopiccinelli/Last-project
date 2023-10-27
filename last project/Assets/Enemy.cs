using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float jumpForce = 2f; [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyDance();
    }
 public virtual void enemyDance()
    {
        if (transform.position.y < 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * jumpForce);
        }
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
