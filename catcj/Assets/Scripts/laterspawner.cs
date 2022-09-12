using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laterspawner : MonoBehaviour
{
    [SerializeField] GameObject item;
    void Start()
    {
        StartCoroutine(vieenen_vienen());
    }

    public IEnumerator vieenen_vienen()
    {
        yield return new WaitForSeconds(5);
        Instantiate(item);
        yield return new WaitForSeconds(5);
        Instantiate(item);
        yield return new WaitForSeconds(5);
        Instantiate(item);
    }
}
