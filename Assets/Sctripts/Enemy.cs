using UnityEngine;

public class Enemy : MonoBehaviour, ITakingDamage
{
    [SerializeField] Health _health;

    public void TakeDamage(int damage)
    {
        if (_health.TryShortenHealth(damage))     
            IsAlive();
    }

    private void IsAlive()
    {
        if (0 >= _health.LifeForce)
            Destroy(gameObject);
    }
}
