using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Object : MonoBehaviour
{
    [SerializeField] private int _speed = 5;
    [SerializeField] private float _damage = 10;
    [SerializeField] private int _health = 100;
    // ENCAPSULATION 
    protected int health
    {
        get { return _health; }
        set
        {
            if (value <= 0)
            {
                isDead = true;
            }
            _health = value;
        }
    }
    protected float damage
    {
        get
        {
            if (_damage > 100)
            {
                Debug.LogError($"{this.gameObject.name} DAMAGE value need to be less equal 100 if not it will be 10");
                return 10;
            }
            else
            {
                return _damage;
            }
        }

    }
    protected int speed
    {
        get
        {
            if (_speed <= 0 || _speed > 100)
            {
                Debug.LogError($"{this.gameObject.name} SPEED value need to be more 0 and less equal 100 if not it will be 1");
                return 1;
            }
            else
            {
                return _speed;
            }
        }
        set { _speed = value; }
    }
    protected bool isDead = false;

    // POLYMORPHISM
    public abstract void Move();

    public virtual void TakeDamage(int damage)
    {
        health -= Mathf.Abs(damage);
    }
}
