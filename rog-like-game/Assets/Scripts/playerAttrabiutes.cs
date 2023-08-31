using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttrabiutes : MonoBehaviour
{

    [SerializeField] float player_movespeed;
    [SerializeField] float player_damage;
    public static float player_hp = 100;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        

        isDead();
    }

    void isDead()
    {
        if (player_hp <= 0)
        {

           // Debug.Log(player_hp);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
           collision.gameObject.GetComponent<enemy>().enemy_hp -= player_damage;
        }
    }

}
