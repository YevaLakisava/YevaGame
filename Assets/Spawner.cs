using UnityEngine;

public class Spawner : MonoBehaviour
{
    float time;
    [SerializeField] GameObject spawn;
    [SerializeField] float rate;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go;
        if (time > rate)
        {
            time -= rate;
            go = Instantiate(spawn);
            go.GetComponent<EnemyBehavior>().player = player;
        }
        time += Time.deltaTime;
    }
}
