using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PowerUp : MonoBehaviour
{
    public UnityEvent itemEffect;
    public float disableDuration = 10f;
    private CapsuleCollider2D trigger;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private AudioSource audioSource; // data field of the script

    void Start()
    {
        trigger = GetComponent<CapsuleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetItemTransparency(1f);
        animator = GetComponent<Animator>(); 
        audioSource = GetComponent<AudioSource>(); // in Start
    }
    
    private void PlaySound() {
        audioSource.Play();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            itemEffect.Invoke();
            collision.transform.localScale *= 1.5f;
            DisableItem();
            Invoke(nameof(EnablePowerUp), disableDuration);
        }
    }

    private void DisableItem()
    {
        trigger.enabled = false;
        animator.Play("PowerUpIdle");
        SetItemTransparency(0.5f);
    }

    private void EnablePowerUp()
    {
        StartCoroutine(Flicker());
    }

    private void SetItemTransparency(float alpha)
    {
        Color color = spriteRenderer.color;
        color.a = alpha;
        spriteRenderer.color = color;
    }

    private IEnumerator Flicker()
    {
        for (int i = 0; i < 3; i++)
        {
            spriteRenderer.color = Color.cyan;
            yield return new WaitForSeconds(0.1f);
            SetItemTransparency(1f);
            yield return new WaitForSeconds(0.1f);
        }

        trigger.enabled = true;
        animator.Play("PowerUpSpin");
    }
}