using UnityEngine;

public class Moneda500Puntos : MonoBehaviour
{
    public Score score;
    public AudioClip coinSound; // AudioClip para reproducir al recoger la moneda

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el objeto que ha colisionado tiene el tag "Moneda500Puntos"
        if (collision.CompareTag("Moneda500Puntos"))
        {
            Debug.Log("El personaje ha tocado la moneda 500 puntos");

            // Sumar 500 puntos al puntaje
            score.totalScore += 500;

            // Reproducir el sonido de la moneda si el AudioClip está asignado
            if (coinSound != null)
            {
                AudioSource.PlayClipAtPoint(coinSound, transform.position);
            }

            // Desactivar la moneda
            gameObject.SetActive(false);
        }
    }
}
