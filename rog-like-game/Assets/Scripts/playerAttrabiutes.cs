using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerAttrabiutes : MonoBehaviour
{

    [SerializeField] float player_movespeed;
    [SerializeField] float player_damage;
    public static float player_hp = 100;


  
    void Update()
    {
        isPlayerDead();
    }

    public static bool  isPlayerDead()
    {
        if (player_hp <= 0)
        {
            return true;
        }
         return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
           collision.gameObject.GetComponent<enemy>().enemy_hp -= player_damage;
        }
    }

  


} 
