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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("collide");
            enemy.EnemyHP -= 1;
            //Shield temas ettiði süre boyunca canlarýný -1 azaltacak
        }
    }
}
