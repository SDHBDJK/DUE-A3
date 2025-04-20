using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;       // 角色移动速度
    public float rotationSpeed = 700f; // 角色旋转速度
    private Rigidbody rb;              // 角色的Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        // 获取方向输入 (横向: A/D 或 左/右箭头，纵向: W/S 或 上/下箭头)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        // 只有在有输入时才移动
        if (moveDirection.magnitude >= 0.1f)
        {
            // 计算目标方向：通过输入的方向向量来计算旋转角度
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);

            // 旋转角色，使其朝向目标方向
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // 移动角色
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(other.gameObject);
        }
    }
}
