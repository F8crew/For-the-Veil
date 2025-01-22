using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionInspect : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 inspectScale = new Vector3(35f, 35f, 35f);

    void Start()
    {
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

    void Inspecting()
    {
        transform.localScale = inspectScale;
    }

    void StopInspecting()
    {
        transform.localScale = originalScale;
    }
}
