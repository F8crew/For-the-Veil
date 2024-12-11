using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardContainer : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 inspectScale = new Vector3(1.2f, 1.2f, 1f); // Scale to apply when inspecting (z is 1 for 2D)
    public float inspectYPosition = -350f;
    public float inspectOffset = 3f;

    private void Start()
    {
        // Store the original scale of the object
        originalScale = transform.localScale;
        StopInspecting();
    }

    void OnMouseOver()
    {
        Inspecting();
        Debug.Log("Mouse enter");
    }

    void OnMouseExit()
    {
        StopInspecting();
        Debug.Log("Mouse exit");
    }

    public void Inspecting()
    {
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
            childPosition.z = 3;
            child.localPosition = childPosition;
        }
    }

    public void StopInspecting()
    {
        transform.localScale = originalScale;
        Vector3 newPosition = transform.localPosition;
        newPosition.z = 2;
        newPosition.y = -479f;
        transform.localPosition = newPosition;

        foreach (Transform child in transform)
        {
            Vector3 childPosition = child.localPosition;
            childPosition.z = 2;
            child.localPosition = childPosition;
        }
    }
}
