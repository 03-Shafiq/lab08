using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

       
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {

            Destroy(collision.gameObject);
            SceneManager.LoadScene("Gameover");


        }
    }

  
}
