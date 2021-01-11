using UnityEngine;

public class Wood : MonoBehaviour
{
    //[SerializeField] GameObject knifePrefabs;
    /*private void Start()
    {
        float y = GetComponent<Collider2D>().bounds.size.y / 0.8f;
        Vector2 rpos = Random.insideUnitCircle * 0.5f;
        Vector2 rpos2 = Random.insideUnitCircle * 0.3f;
        Instantiate(knifePrefabs, new Vector2(rpos.x, y+0.5f), Quaternion.identity, transform);
        Instantiate(knifePrefabs, new Vector2(rpos2.x, y+0.5f), Quaternion.identity, transform);
    }
    */
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, 2);
    }
}