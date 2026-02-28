using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    [SerializeField] private float speedObjects;

    private float maxLeftRight = 28f;
    private float minZ = -14f;

    void Update()
    {
        transform.Translate(Vector3.forward * speedObjects * Time.deltaTime);
        DestroyObjects();
    }

    private void DestroyObjects()
    {
        if (transform.position.z > 20) Destroy(gameObject);
        if (transform.position.z < minZ) Destroy(gameObject);
        if(transform.position.x  > maxLeftRight) Destroy(gameObject);
        if(transform.position.x < - maxLeftRight) Destroy(gameObject);
    }

   
}
