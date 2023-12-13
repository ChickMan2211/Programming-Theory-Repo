using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum typeEnemy { none };
public class Enemy : Object // INHERITANCE
{

    public typeEnemy type;
    Rigidbody2D rb;

    public override void Move()
    {
        rb.velocity = Vector2.up * speed * Time.deltaTime;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(); // ABSTRACTION
    }
}
