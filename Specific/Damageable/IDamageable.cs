using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanCandir.Damageable
{
    public interface IDamageable<T>
    {
        public void TakeDamage(T damage);

        public void IsDead();
    }
}

