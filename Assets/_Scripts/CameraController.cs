using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform backShopPosition;
    public Transform shopPosition;
    public float transitionSpeed = 5f;
    public float arrivalThreshold = 0.00001f; // La distance à laquelle la caméra est considérée comme arrivée

    private Transform targetPosition;
    private bool isMoving = false;

    private void Start()
    {
        targetPosition = transform; // Position initiale de la caméra
    }

    public void TransitionToBackShop()
    {
        targetPosition = backShopPosition;
        isMoving = true;
    }

    public void TransitionToShop()
    {
        targetPosition = shopPosition;
        isMoving = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            // Déplace progressivement la caméra sur les axes X et Y vers la position cible
            Vector3 newPosition = new Vector3(targetPosition.position.x, targetPosition.position.y, -10f);
            transform.position = Vector3.Lerp(transform.position, newPosition, transitionSpeed * Time.deltaTime);

            // Vérifie si la caméra est suffisamment proche de la position cible
            if (Vector3.Distance(transform.position, newPosition) < arrivalThreshold)
            {
                // Arrête le mouvement en désactivant l'appel à Update()
                isMoving = false;
            }
        }
    }
}