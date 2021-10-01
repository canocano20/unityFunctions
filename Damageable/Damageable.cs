using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanCandir.Damageable
{
    public class Damageable : MonoBehaviour, IDamageable<float>
    {
        [SerializeField] private float _health = 50f;

        public void TakeDamage(float damage)
        {
            _health -= damage;
        }

        public void IsDead()
        {
            if (_health <= 0f)
                Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Projectile"))
            {
                TakeDamage(collision.collider.GetComponent<ProjectileCollision>().damage);
                IsDead();
            }
        }
    }
}
