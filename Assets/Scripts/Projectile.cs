using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed = 7f;
    [SerializeField] float damage = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            var health = collision.GetComponent<Health>();
            var attacker = collision.GetComponent<Attacker>();

            if(attacker && health)
            {
                health.DealDamage(damage);
                Destroy(gameObject);
            }
    }

}
