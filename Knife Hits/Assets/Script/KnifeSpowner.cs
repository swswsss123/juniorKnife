
using UnityEngine;

public class KnifeSpowner : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] GameObject knifePrefabs;
    public static int throws;
    public GameObject[] knifes;

    private void Start()
    {
        knifePrefabs = Instantiate(knifes[PlayerPrefs.GetInt("Knife")], transform.position,Quaternion.identity);
        throws = 5;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knifePrefabs.transform.parent = null;
            Throw();
        }
    }
    private void Throw()
    {
        knifePrefabs.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
        
        if (throws >0)
        {
            knifePrefabs = Instantiate(knifePrefabs, transform);
            throws --;
        }
    }
}
