using UnityEngine;

public class CometSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    public GameObject target;

    void Start()
    {
        InvokeRepeating("Spawner", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Spawner() {
        Instantiate(target, transform.position, transform.rotation, null); 

    }
}
