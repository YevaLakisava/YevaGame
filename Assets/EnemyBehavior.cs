using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float speed;
    Vector3 pPos;
    [SerializeField] float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pPos = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        pPos = player.transform.position;
        Vector3 NewPos;
        NewPos = pPos - transform.position;
        NewPos = NewPos.normalized * speed * Time.deltaTime;
        transform.position = transform.position + NewPos;
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }

}
