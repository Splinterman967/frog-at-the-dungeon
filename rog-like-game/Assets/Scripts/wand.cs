using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class wand : MonoBehaviour
{
    [Header("Projectile")]
    [SerializeField] GameObject electroball;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( Fire());
    }
    IEnumerator Fire()
    {

        while (true)
        {

            yield return new WaitForSeconds(projectile.electroball_frequency);

            GameObject spell_ball;
           
            spell_ball = Instantiate(electroball, transform.position, transform.rotation);

       }
       
    }


}
