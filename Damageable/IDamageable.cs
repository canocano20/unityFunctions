using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T>
{
    public void TakeDamage(T damage);

    public void IsDead();
}