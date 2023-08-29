using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class enemy : MonoBehaviour
{


    [SerializeField] float enemy_movespeed;
    [SerializeField] float enemy_damage;
    public float enemy_hp;

    playerAttrabiutes player;

    public Transform player_transform;

    public Vector3 player_direction;
    // Start is called before the first frame update
    void Start()
    {
  
       // player_transform = player.GetComponent<Transform>();

        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        followPlayer();

    }

    


    void followPlayer()
    {
        player_direction = player_transform.position - transform.position;

        player_direction.Normalize();

        float enemy_speed =   enemy_movespeed * Time.deltaTime;

       // transform.Translate(player_direction);

        transform.position = Vector2.MoveTowards(transform.position, player_transform.position, enemy_speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //When enemys hits the player
        if (collision.gameObject.CompareTag("Player"))
        {
            player.player_hp -= enemy_damage;
        }
    }





}
