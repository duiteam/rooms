using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // ��ɫ�ƶ��ٶ�
    public float jumpForce = 5f; // ��Ծ����

    [SerializeField]
    private bool isJumping = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ��������ƶ�
        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        // �����Ծ
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
        
    }
    private void FixedUpdate()
    {
        
        if (Physics2D.Raycast(transform.GetChild(0).position - new Vector3(transform.localScale.x/2f, 0, 0), Vector2.down, 0.1f, LayerMask.NameToLayer("Ground")) || Physics2D.Raycast(transform.GetChild(0).position + new Vector3(transform.localScale.x / 2f, 0, 0), Vector2.down, 0.1f, LayerMask.NameToLayer("Ground")))
        {
            isJumping = false;
        }
        else {
            isJumping = true;
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        // ��ײ��⣬�����ж��Ƿ��ڵ�����
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        */
    }
}