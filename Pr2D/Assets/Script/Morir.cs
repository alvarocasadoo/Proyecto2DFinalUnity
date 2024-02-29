using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public GameObject objetoADestruir;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == objetoADestruir)
        {
            Destroy(objetoADestruir);
        }
    }
}
