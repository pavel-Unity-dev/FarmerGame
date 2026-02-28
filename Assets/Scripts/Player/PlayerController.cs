using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer;
    public GameObject pizzaPrefab;
    public Transform foodPosition;
    public Animator animator;

    private float maxUp = 16f;
    private float maxDown = -9f;
    private float maxLeftRight = 14f;


    private void Start()
    {  
        animator = GetComponent<Animator>();
    }
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))
                SpawnPizza();
            PlayerMove();
            MaxDistancePlayer();
    }

    private void PlayerMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        animator.SetFloat("MoveX", horizontal);
        animator.SetFloat("MoveY", vertical);

        Vector3 move = new Vector3(horizontal, 0, vertical);
        transform.Translate(move * speedPlayer * Time.deltaTime);

    }



    private void SpawnPizza()
    {
        Instantiate(pizzaPrefab, foodPosition.transform.position, transform.rotation);
    }



    private void MaxDistancePlayer()
    {
        if (transform.position.x > maxLeftRight)
        {
            transform.position = new Vector3(maxLeftRight, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -maxLeftRight)
        {
            transform.position = new Vector3(-maxLeftRight, transform.position.y, transform.position.z);
        }
        if (transform.position.z > maxUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxUp);
        }
        if (transform.position.z < maxDown)
            transform.position = new Vector3(transform.position.x, transform.position.y, maxDown);
    }
}
