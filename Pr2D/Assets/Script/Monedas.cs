using UnityEngine;

public class DestruirAlColisionar : MonoBehaviour
{
    public Score score;
    public AudioClip coinSound; // AudioClip para monedas normales
    public AudioClip coinSound500; // AudioClip para monedas de 500 puntos

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("El personaje me ha tocado");

        // Verificar si la moneda tiene el tag "Moneda500Puntos" y sumar 500 puntos
        if (gameObject.CompareTag("Moneda500Puntos"))
        {
            score.totalScore += 500;
            // Reproducir el segundo sonido si está asignado
            if (coinSound500 != null)
            {
                AudioSource.PlayClipAtPoint(coinSound500, transform.position);
            }
        }
        else
        {
            score.totalScore += 100;
            // Reproducir el sonido normal si está asignado
            if (coinSound != null)
            {
                AudioSource.PlayClipAtPoint(coinSound, transform.position);
            }
        }

        gameObject.SetActive(false);
    }
}
