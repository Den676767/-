using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Bullet Settings")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireRate = 0.2f; // Задержка между выстрелами

    private float fireTimer = 0f;

    void Update()
    {
        // Таймер для ограничения скорострельности
        fireTimer -= Time.deltaTime;

        // Стрельба по зажатой ЛКМ
        if (Input.GetMouseButton(0) && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireRate;
        }
    }

    void Shoot()
    {
        // Создаем пулю в точке вылета
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Направляем пулю вверх (относительно поворота игрока)
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.up * bulletSpeed;
    }
}