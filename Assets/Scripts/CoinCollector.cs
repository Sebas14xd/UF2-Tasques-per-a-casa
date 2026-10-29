// Autor: Sebastian Coll Slodka
// Fecha: 29/10/2026
// Descripción: CoinCollector (Detección por tag vs nombre) - UF2
using UnityEngine;
public class CoinCollector : MonoBehaviour
{

    // VERSIÓN B: Detectar por Tag (La opción recomendada)
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Moneda recogida (Versión B - Tag)");
            Destroy(gameObject);
        }
    }
}