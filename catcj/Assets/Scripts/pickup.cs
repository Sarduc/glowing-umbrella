using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    int speed = 5;
    [SerializeField]
    int ID;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-4f, 4f), 9f, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -6)
        {
            redeploy();
        }
    }


    public void redeploy()
    {
        transform.position = new Vector3(Random.Range(-8.75f, 8.75f), Random.Range(7f, 9f), 0);
        ID = Random.Range(0, 6);
    }
}
