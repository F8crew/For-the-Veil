using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;
public class CardContainer : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 inspectScale = new Vector3(1.2f, 1.2f, 1f); // Scale to apply when inspecting (z is 1 for 2D)
    public float inspectYPosition = -350f;
    public float inspectOffset = 3f;
    public float startPosition1 = -479F;
    private bool isInspecting = false;

    private void Start()
    {
        // Store the original scale of the object
        originalScale = transform.localScale;
        StopInspectingCard();
    }

    void OnMouseOver()
    {
        if (!isInspecting)
        {
            InspectCard();
            Debug.Log("Mouse enter");
        }
    }

    void OnMouseExit()
    {
        if (isInspecting)
        {
            StopInspectingCard();
            Debug.Log("Mouse exit");
        }
    }

    public void InspectCard()
    {
        if (!isInspecting)
        {
            isInspecting = true;
            // Scale the card
            transform.localScale = inspectScale;

            // Move the card in front of others
            Vector3 newPosition = transform.localPosition;
            newPosition.z = inspectOffset;
            newPosition.y = inspectYPosition;
            transform.localPosition = newPosition;

            MoveChildrenToFront();
        }
    }

    public void StopInspectingCard()
    {
        if (isInspecting)
        {
            isInspecting = false;
            transform.localScale = originalScale;
            Vector3 newPosition = transform.localPosition;
            newPosition.z = 2;

            if (Mathf.Abs(transform.rotation.eulerAngles.z) < 1f)
            {
                newPosition.y = startPosition1;
            }
            else
            {
                newPosition.y = startPosition1;
            }

            transform.localPosition = newPosition;

            MoveChildrenToBack();
        }
    }

    private void MoveChildrenToFront()
    {
        foreach (Transform child in transform)
        {
            Vector3 childPosition = child.localPosition;
            childPosition.z = -2;
            child.localPosition = childPosition;
        }
    }

    private void MoveChildrenToBack()
    {
        foreach (Transform child in transform)
        {
            Vector3 childPosition = child.localPosition;
            childPosition.z = 2;
            child.localPosition = childPosition;
        }
    }
}
/*
```
    public float startPosition1 = -479F;
    private bool isInspecting = false;

    private void Start()
    {
        // Store the original scale of the object
        originalScale = transform.localScale;
        StopInspecting();
    }

    void OnMouseOver()
    {
        if (!isInspecting)
        {
            Inspecting();
            Debug.Log("Mouse enter");
        }
    }

    void OnMouseExit()
    {
        if (isInspecting)
        {
            StopInspecting();
            Debug.Log("Mouse exit");
        }
    }

    public void Inspecting()
    {
        if (!isInspecting)
        {
            isInspecting = true;
            // Scale the card
            transform.localScale = inspectScale;

            // Move the card in front of others
            Vector3 newPosition = transform.localPosition;
            newPosition.z = inspectOffset;
            newPosition.y = inspectYPosition;
            transform.localPosition = newPosition;

            foreach (Transform child in transform)
            {
                Vector3 childPosition = child.localPosition;
                childPosition.z = -2;
                child.localPosition = childPosition;
            }
        }
    }

    public void StopInspecting()
    {
        if (isInspecting)
        {
            isInspecting = false;
            transform.localScale = originalScale;
            Vector3 newPosition = transform.localPosition;
            newPosition.z = 2;

            if (Mathf.Abs(transform.rotation.eulerAngles.z) < 1f)
            {
                newPosition.y = startPosition1;
            }
            else
            {
                newPosition.y = startPosition1;
            }

            transform.localPosition = newPosition;

            foreach (Transform child in transform)
            {
                Vector3 childPosition = child.localPosition;
                childPosition.z = 2;
                child.localPosition = childPosition;
            }
        }
    }
}*/