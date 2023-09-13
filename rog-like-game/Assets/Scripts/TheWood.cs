using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWood : MonoBehaviour
{
    public Transform player_transform;
    public Vector3 player_direction;
    void Start()
    {
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        followPlayer();
    }
    void followPlayer()
    {
        if (player_transform != null)
        {
            player_direction = player_transform.position - transform.position;
            player_direction.Normalize();
            float wood_speed = 20f * Time.deltaTime;
            // transform.Translate(player_direction);
            transform.position = Vector2.MoveTowards(transform.position, player_transform.position, wood_speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //When enemys hits the player
        if (collision.gameObject.CompareTag("Player"))
        {
            playerAttrabiutes.player_hp -= 5;
            Destroy(gameObject);
            //StartCoroutine(AgýrYara());

        }
    }
    //Aðýr yara mekaniði
    //IEnumerator AgýrYara()
    //{
    //    HealthBar.Regen = false;
    //    yield return new WaitForSeconds(1);
    //    HealthBar.Regen = true;
    //}
}
