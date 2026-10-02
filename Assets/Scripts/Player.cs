using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject select1;
    public GameObject select2;
    public GameObject select3;
    Rigidbody2D rb;
    GameObject[] shapes = new GameObject[3];
    public GameObject hamburguerPrefab;
    public GameObject bananaPrefab;
    public GameObject eggPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }

        shapes[0] = select1;
        shapes[1] = select2;
        shapes[2] = select3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Select1"))
        {
             Instantiate(hamburguerPrefab, Vector3.zero, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Select2"))
        {
            Instantiate(bananaPrefab, Vector3.zero, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Select3"))
        {
            Instantiate(eggPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
