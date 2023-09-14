using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fEffect : MonoBehaviour
{

    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Material flash_material;
    [SerializeField] float duration;

    Coroutine flashRoutine;
    Material original_material;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        original_material = spriteRenderer.material;
    }
    public void flash_effect()
    {
        if (flashRoutine != null)
        {
            StopCoroutine(flashRoutine);
        }

        flashRoutine = StartCoroutine(FlashRoutine());
    }

    private IEnumerator FlashRoutine()
    {

        spriteRenderer.material = flash_material;

        yield return new WaitForSeconds(duration);

        spriteRenderer.material = original_material;

        flashRoutine = null;
    }
}

