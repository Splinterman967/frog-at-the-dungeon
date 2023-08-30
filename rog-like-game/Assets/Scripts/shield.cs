using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{

    [SerializeField] float shield_damage;
    // Start is called before the first frame update
    void Start()
    {
        shield_damage = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= shield_damage;
        }
    }
}
