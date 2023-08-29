using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("collide");
            //Destroy(collision.gameObject);
        }
    }
}
