using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject goodBubble;
    public GameObject badBubble;

    public float spawnDelay = 1f;
    public float minX = -7.5f;
    public float maxX = 7.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBubble), 1f, spawnDelay);
    }

void SpawnBubble()
{
    if (GameManager.Instance != null && GameManager.Instance.isGameOver)
        return;

    float randomX = Random.Range(minX, maxX);
    Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);

    GameObject bubble = Random.value < 0.2f ? badBubble : goodBubble;
    Instantiate(bubble, spawnPos, Quaternion.identity);
}
}
