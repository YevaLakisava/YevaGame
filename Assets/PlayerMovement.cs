using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    int dirx;
    int diry;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dirx = 0;
        diry = 0;
        if (Input.GetKey(KeyCode.D))
        {
            dirx++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dirx--;
        }
        if (Input.GetKey(KeyCode.W))
        {
            diry++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            diry--;
        }
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + dirx * speed * Time.deltaTime, pos.y + diry * speed * Time.deltaTime , pos.z);



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            SceneManager.LoadScene(0);
        }
    }
}


     
