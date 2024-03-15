using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockScript : MonoBehaviour
{
    public float tileSize = 1.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (ContactPoint2D hitpos in collision.contacts)
            {
                Vector2 direction = hitpos.point - (Vector2)transform.position;
                direction.Normalize();

                if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                {
                    // Horizontal collision
                    if (direction.x > 0)
                    {
                        // Collided from the right
                        transform.Translate(Vector2.left * 1f);
                    }
                    else
                    {
                        // Collided from the left
                        transform.Translate(Vector2.right * 1f);
                    }
                }
                else
                {
                    // Vertical collision
                    if (direction.y > 0)
                    {
                        // Collided from above
                        transform.Translate(Vector2.down * 1f);
                    }
                    else
                    {
                        // Collided from below
                        transform.Translate(Vector2.up * 1f);
                    }
                }
            }
        }
    }
}