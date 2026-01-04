
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed;
    public bool isBadBubble;

    public AudioSource popSound; // 🔊 ADD THIS

    Animator anim;
    bool clicked = false;

    void Start()
    {
        anim = GetComponent<Animator>();

        if (anim == null)
        {
            Debug.LogError("Animator NOT found on " + gameObject.name);
        }

        if (popSound == null)
        {
            popSound = GetComponent<AudioSource>();
        }

        if (GameManager.Instance != null)
        {
            speed = GameManager.Instance.bubbleSpeed;
        }
        else
        {
            Debug.LogError("GameManager Instance not found!");
            speed = 2f;
        }
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        if (clicked) return;
        clicked = true;

        // 🎵 PLAY POP SOUND
        if (popSound != null)
            popSound.Play();

        if (anim != null)
            anim.SetTrigger("Pop");

        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager Instance is NULL!");
            return;
        }

        if (isBadBubble)
            GameManager.Instance.GameOver();
        else
            GameManager.Instance.AddScore(1);

        Destroy(gameObject, 0.35f); // delay for sound + animation
    }
}
