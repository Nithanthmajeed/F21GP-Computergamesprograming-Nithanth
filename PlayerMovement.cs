using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public int speed;
    public LayerMask groundLayers;
    public int jump;
    private bool istouching = true;
    public GameObject Scatter;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Scene ()
    {
        SceneManager.LoadScene("GameOver");
    }
    void Update()
    {

        float Hmove = Input.GetAxis("Horizontal");

        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove * speed);

        if ((Input.GetKey(KeyCode.Space)) && istouching == true)
        {
            Vector3 balljump = new Vector3(0.0f, 6.0f, 0.0f);
            rb.AddForce(balljump * jump);

        }
        istouching = false;

    }
    private void OnCollisionStay()
    {
        istouching = true;
    }

    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")

            
        {
            other.gameObject.SetActive(false);
            transform.gameObject.SetActive(false);
            for (int i = 0; i < 17; i++)
            {
                Instantiate(Scatter, transform.position, Quaternion.identity);
                Invoke("Scene", 1f);
               
            }
            
        }
    }

  
  
}