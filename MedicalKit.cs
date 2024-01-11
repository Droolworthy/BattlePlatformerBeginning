using UnityEngine;

public class MedicalKit : MonoBehaviour
{
    [SerializeField] private int _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            player.RestoreHealth(_health);

            Destroy(gameObject);
        }
    }
}
