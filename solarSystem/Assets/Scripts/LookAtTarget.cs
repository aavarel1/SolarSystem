using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    static public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null) {
            target = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target) transform.LookAt(target.transform);
    }
}
