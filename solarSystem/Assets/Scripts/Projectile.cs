using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Tooltip("The distance this projectile will move each second in meters")]
    public float projectileSpeed = 3.0f;
   
    [Tooltip("How far from the main camero before destroying the projectile")]
    public float destroyDistance = 20.0f;  

   
    

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile() {
        transform.position += transform.forward * projectileSpeed * Time.deltaTime; 
        float dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (dist > destroyDistance) {
            Destroy(gameObject);
        }
    }
}
