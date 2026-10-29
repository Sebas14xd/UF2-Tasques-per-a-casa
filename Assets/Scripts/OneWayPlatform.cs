// Autor: Sebastian Coll Slodka
// Fecha: 29/10/2026
// Descripción: OneWayPlatform - UF2

using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private Collider platformCollider;
    void Start()
    {
        platformCollider = GetComponent<Collider>();
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collider playerCollider = collision.collider;
            float playerFeetY = playerCollider.bounds.min.y;
            float platformTopY = platformCollider.bounds.max.y;

            if (playerFeetY < platformTopY - 0.2f)
            {
                Physics.IgnoreCollision(playerCollider, platformCollider, true);
            }
            else
            {
                Physics.IgnoreCollision(playerCollider, platformCollider, false);
            }
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collider playerCollider = collision.collider;
            Physics.IgnoreCollision(playerCollider, platformCollider, false);
        }
    }
}