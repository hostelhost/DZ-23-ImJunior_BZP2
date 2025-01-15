using UnityEngine;

public class Player : MonoBehaviour, ITakingDamage
{
    [SerializeField] Health _health;
    [SerializeField] Bag _bag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ICollectable collectable))
        {
            if (collectable is Gold gold)
                TakeCoin(gold.Execute());
            else if (collectable is AidKit aidKit)
                _health.TryToAcceptLifeForce(aidKit.Execute());            
        }         
    }

    public void TakeDamage(int damage)
    {
        if (_health.TryShortenHealth(damage))
            IsAlive();
    }

    private void TakeCoin(int coin)
    {
        _bag.TakeCoin(coin);
    }

    private void IsAlive()
    {
        if (0 >= _health.LifeForce)
            Destroy(gameObject);
    }
}
