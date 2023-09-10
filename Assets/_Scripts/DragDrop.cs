using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    public GameObject objectDrag;
    public GameObject[] ObjectsDragToPos; // Utiliser un tableau d'objets
    public float DropDistance;
    public bool isLocked;

    Vector2 objectInitPos;
    Transform originalParent; // Stocker le parent d'origine de l'objet

    void Start()
    {
        objectInitPos = objectDrag.transform.position;
        originalParent = objectDrag.transform.parent; // Enregistrez le parent d'origine
    }

    public void DragObject()
    {
        if (!isLocked)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Assurez-vous que la coordonnée Z est correcte

            // Déplacez l'objet vers la position de la souris en coordonnées du monde
            objectDrag.transform.position = mousePosition;
        }
    }

    public void DropObject()
    {
        if (!isLocked)
        {
            float minDistance = float.MaxValue;
            Transform nearestSlot = null;

            foreach (GameObject dropTarget in ObjectsDragToPos)
            {
                // Vérifiez si le slot est occupé
                if (dropTarget.transform.childCount > 0)
                {
                    // Récupérez l'enfant du slot
                    Transform child = dropTarget.transform.GetChild(0);

                    // Vérifiez si l'enfant est l'objet initial
                    if (child == objectDrag.transform)
                    {
                        // Désengager l'enfant du slot
                        child.SetParent(null);
                    }
                    else
                    {
                        continue; // Slot occupé par un autre objet, passez au suivant
                    }
                }

                // Convertissez les coordonnées du monde 3D des emplacements de slot
                Vector3 slotPosition = dropTarget.transform.position;

                float distance = Vector3.Distance(objectDrag.transform.position, slotPosition);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestSlot = dropTarget.transform;
                }
            }

            if (nearestSlot != null && minDistance < DropDistance)
            {
                //isLocked = true;
                objectDrag.transform.position = nearestSlot.position;
                // Mettez l'objet en tant qu'enfant du slot pour le verrouiller en place
                objectDrag.transform.SetParent(nearestSlot);
            }
            else
            {
                objectDrag.transform.position = objectInitPos;
                // Rétablissez le parent d'origine de l'objet (le canvas)
                objectDrag.transform.SetParent(originalParent);
            }
        }
    }
}
