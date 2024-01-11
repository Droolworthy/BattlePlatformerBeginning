using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _damage;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if(_currentHealth <= 0)
            Destroy(gameObject);
    }

    public void RestoreHealth(int health)
    {
        if(_currentHealth > 0)
            _currentHealth += health;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
            enemy.TakeDamage(_damage);
    }
}
