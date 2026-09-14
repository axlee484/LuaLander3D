using UnityEngine;

public class HurtBox : MonoBehaviour
{
    [SerializeField] private Health health;
    private void Start()
    {
        health = GetComponent<Health>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        var collider = collision.collider;
        if(collider.TryGetComponent<HitBox>(out var hitBox))
        {
            health.TakeDamage(hitBox.Damage);
        }
    }
}
