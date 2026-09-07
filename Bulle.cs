using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Damage")]
    public int damage = 1;

    void Start()
    {
        // Авто-уничтожение через 3 секунды, чтобы не засорять сцену
        Destroy(gameObject, 3f);
    }

    // Срабатывает при столкновении с другим коллайдером
    void OnTriggerEnter2D(Collider2D other)
    {
        // Если пуля попала во врага
        if (other.CompareTag("Enemy"))
        {
            // Наносим урон врагу
            EnemyController enemy = other.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            // Уничтожаем пулю (она исчезает)
            Destroy(gameObject);
        }

        // Если пуля попала в стену (объект с тегом "Wall")
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}