using UnityEngine;

public class GoblinDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.TakeDamage();
        }
    }
}
