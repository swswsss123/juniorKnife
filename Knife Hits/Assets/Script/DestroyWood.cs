using UnityEngine.SceneManagement;
using UnityEngine;

public class DestroyWood : MonoBehaviour
{
    bool isSheiking=false;
    Vector2 pos;
    float shake = .3f;
    [SerializeField] int health = 5;
    [SerializeField] Object destructedle;
    void Start()
    {
        pos = transform.position;
    }

    
    void Update()
    {
        if(isSheiking == true) 
        {
            transform.position = pos + UnityEngine.Random.insideUnitCircle * shake;
        
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Knife")
        {
            isSheiking = true;
            health--;
            if (health < 0)
            {
                ExploedObject();
                
            }
            Invoke("StopShake", 0.1f);
        }
    }
    private void StopShake()
    {
        isSheiking = false;
    }
    private void ExploedObject()
    {
        GameObject exploed = (GameObject)Instantiate(destructedle);
        exploed.transform.position = transform.position;
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }
}
