using UnityEngine;

public class ChangeLookAtTarget : MonoBehaviour
{
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null) target = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        LookAtTarget.target = target; 
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100); 
    }
}
