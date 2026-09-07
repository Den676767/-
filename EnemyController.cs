using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy Stats")]
    public int health = 2;
    public float moveSpeed = 2f;

    [Header("References")]
    private Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Находим игрока по тегу (игрок должен иметь тег "Player")
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (player == null) return;

        // Двигаемся к игроку
        Vector2 direction = (player.position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

    // Метод для получения урона (вызывается из пули)
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"Враг получил урон. Осталось HP: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Враг уничтожен!");
        // Здесь можно добавить эффект взрыва или звук
        Destroy(gameObject);
    }
}