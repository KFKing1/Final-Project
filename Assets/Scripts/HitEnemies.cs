using UnityEngine;
using UnityEngine.SceneManagement;

public class HitEnemies : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}