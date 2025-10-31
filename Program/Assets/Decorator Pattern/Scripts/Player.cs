using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed; // �̵� �ӵ�
    [SerializeField] float stopDistance = 0.1f; // ��ǥ ������ �󸶳� ����������� Ȯ���ϴ� ����
    
    [SerializeField] bool isMoving = false;
    [SerializeField] Vector3 targetPosition;
    [SerializeField] RaycastHit rayCastHit;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayCastHit))
            {
                targetPosition = rayCastHit.point;

                isMoving = true;
            }
        }

        if (isMoving)
        {
            Move();
        }
    }

    public void Move()
    {
        // ��ǥ ���� ���� ���
        Vector3 direction = (targetPosition - transform.position).normalized;

        float distance = Vector3.Distance(transform.position, targetPosition);

        transform.position += direction * speed * Time.deltaTime;

        // ���� ���� Ȯ��
        if (distance <= stopDistance)
        {
            isMoving = false;
        }
    }
}
