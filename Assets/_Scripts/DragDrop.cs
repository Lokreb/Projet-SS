using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
   /* public GameObject objectDrag;
    public GameObject ObjectDragToPos;

    public float DropDistance;

    public bool isLocked;

    Vector2 objectInitPos;

    void Start() {
        objectInitPos = objectDrag.transform.position;
    }

    public void DragObject() {
        if(!isLocked) {
            objectDrag.transform.position = Input.mousePosition;
        }
    }

    public void DropObject() {
        float Distance = Vector3.Distance(objectDrag.transform.position, ObjectDragToPos.transform.position);
        if(Distance < DropDistance) {
            //isLocked = true;
            objectDrag.transform.position = ObjectDragToPos.transform.position;
        } else {
            objectDrag.transform.position = objectInitPos;
        }
    }*/

    public GameObject objectDrag;
    public GameObject[] ObjectsDragToPos; // Utiliser un tableau d'objets
    public float DropDistance;
    public bool isLocked;

    Vector2 objectInitPos;

    void Start()
    {
        objectInitPos = objectDrag.transform.position;
    }

    public void DragObject()
    {
        if (!isLocked)
        {
            objectDrag.transform.position = Input.mousePosition;
        }
    }

    public void DropObject()
    {
        float minDistance = float.MaxValue;
        GameObject nearestObject = null;

        foreach (GameObject dropTarget in ObjectsDragToPos)
        {
            float distance = Vector3.Distance(objectDrag.transform.position, dropTarget.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestObject = dropTarget;
            }
        }

        if (nearestObject != null && minDistance < DropDistance)
        {
            // isLocked = true;
            objectDrag.transform.position = nearestObject.transform.position;
        }
        else
        {
            objectDrag.transform.position = objectInitPos;
        }
    }
}
