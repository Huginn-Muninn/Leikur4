using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickcheck : MonoBehaviour
{
    public int target;
    private int count;//fyrir teljarann

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickupp")
        {
            Destroy(collision.gameObject);
            count = count + 1;
            Debug.Log(count);
        }
    }
    void Update()
    {
        if (count >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Leikurinn breytir um borð
        }
    }
}
