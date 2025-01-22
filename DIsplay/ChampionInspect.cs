using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionInspect : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 inspectScale = new Vector3(35f, 35f, 35f);
    public float scaleSpeed = 5f;

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
        StartCoroutine(ScaleUp(inspectScale));
    }

    void StopInspecting()
    {
        StartCoroutine(ScaleDown(originalScale));
    }

    IEnumerator ScaleUp(Vector3 targetScale)
    {
        while (transform.localScale != targetScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator ScaleDown(Vector3 targetScale)
    {
        while (transform.localScale != targetScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
            yield return null;
        }
    }
}


/*```

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
*/