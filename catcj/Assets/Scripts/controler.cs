using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controler : MonoBehaviour
{
    int speed = 10;
    [SerializeField ]int score;
    public int vidillas = 3;
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalinput * Time.deltaTime);

        if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9f, transform.position.y);
        }
        if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9f, transform.position.y);
        }

        if (vidillas <= 0)
        {
            SceneManager.LoadScene("game_over");
        }

        
    }

    public void auchis()
    {
        vidillas = vidillas - 1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Pickupeado");
        if (other.tag == "pickup")
        {
            pickup recogible = other.GetComponent<pickup>();
            score = score + 1;
            speed = speed + score;
            recogible.redeploy();
        }
    }
}
