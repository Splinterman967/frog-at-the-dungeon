using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{

    [SerializeField] float sword_damage;
    // Start is called before the first frame update
    void Start()
    {
        sword_damage = 50;
    }

    // Update is called once per frame
    void Update()
    {
        spinSword();
    }

    void spinSword()
    {
        transform.Rotate(0, 0, -200 * Time.deltaTime, Space.Self);

        transform.localPosition = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= sword_damage;
        }
    }
}
