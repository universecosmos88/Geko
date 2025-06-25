using UnityEngine;

public class AutoWalker : MonoBehaviour
{
    public Transform pointA; // �̵� ������
    public Transform pointB; // �̵� ����
    public float speed = 2f;

    private Vector3 target;

    void Start()
    {
        target = pointB.position;
    }

    void Update()
    {
        // ���� ��ġ���� ��ǥ �������� �̵�
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // ��ǥ ������ �����ϸ� ���� ��ȯ
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == pointA.position ? pointB.position : pointA.position;
            // ĳ���� ���� ȸ��
            transform.LookAt(target);
        }
    }
}