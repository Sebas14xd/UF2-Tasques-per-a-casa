// Autor: Sebastian Coll Slodka
// Fecha: 29/10/2026
// Descripción: PlayerMover3D_Inertia - UF2
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMover3D_Inertia : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 5f;
    [Range(0.01f, 1f)]
    public float inertiaFactor = 0.1f; 
    private Rigidbody rb;
    private Vector3 targetVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 inputDir = new Vector3(moveX, 0f, moveZ).normalized;
        targetVelocity = inputDir * speed;
        Vector3 currentVel = rb.linearVelocity;
        Vector3 smoothVel = Vector3.Lerp(currentVel, new Vector3(targetVelocity.x, currentVel.y, targetVelocity.z), inertiaFactor);
        rb.linearVelocity = smoothVel;
    }
}