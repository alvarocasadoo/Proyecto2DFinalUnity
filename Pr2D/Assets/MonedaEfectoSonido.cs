using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public AudioClip coinSound; // Sonido de la moneda que se establecerá desde el Inspector de Unity
    private AudioSource audioSource;

    private void Start()
    {
        // Obtener el componente AudioSource adjunto al objeto o agregar uno si no existe
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto con el que colisionamos tiene el tag "Moneda"
        if (other.CompareTag("Moneda"))
        {
            // Reproducir el sonido de la moneda
            if (coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            // Opcional: Destruir la moneda después de recogerla
            Destroy(other.gameObject);
        }

        // Verificar si la moneda tiene el tag "Moneda500Puntos" y sumar 500 puntos
        if (other.CompareTag("Moneda500Puntos"))
        {
            // Reproducir el sonido de la moneda
            if (coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            // Opcional: Destruir la moneda después de recogerla
            Destroy(other.gameObject);

            // Sumar 500 puntos (añadir aquí la lógica para sumar los puntos al puntaje)
        }
    }
}
