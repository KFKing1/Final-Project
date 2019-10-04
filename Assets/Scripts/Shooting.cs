using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootInterval = 0.3f;
    private float _lastShootTime;

    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float projectileSpeed = 20.0f;

    private void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        if (!(Time.time > shootInterval + _lastShootTime))
            return;

        ShootProjectile();
        _lastShootTime = Time.time;
    }

    private void ShootProjectile()
    {
        var p = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
        var r = p.GetComponent<Rigidbody2D>();
        r.velocity = transform.right * projectileSpeed;
    }
}