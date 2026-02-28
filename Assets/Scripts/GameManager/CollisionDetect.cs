using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    private GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);   
        }
        else if (other.CompareTag("Enemy"))
        {
            other.GetComponent<AnimalHungler>().FeedAnimal(1);
            Destroy(gameObject); 
        }
    }
}
