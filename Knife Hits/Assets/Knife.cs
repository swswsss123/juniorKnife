using UnityEngine.SceneManagement;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] Rigidbody2D rB;
    private bool isWood;
    public static int best_score;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wood")
        {
            rB.velocity = Vector2.zero;
            transform.parent = collision.transform;
            Handheld.Vibrate();
            isWood = true;
        }
        if (collision.gameObject.tag == "Knife")
        {
            if(collision.gameObject.GetComponent<Knife>().isWood == true)
            {
                rB.velocity = Vector2.zero;
                rB.gravityScale = 0.5f;
                KnifeSpowner.throws--;
                
            }
        }
        if (collision.gameObject.tag == "Apple")
        {
            
            Apple.apple +=1;
            best_score += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Aller")
        {
            SceneManager.LoadScene(2);
        }
    }
}
