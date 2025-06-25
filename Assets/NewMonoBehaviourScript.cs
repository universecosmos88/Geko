using UnityEngine;

public class AutoWalker : MonoBehaviour
{
    public Transform pointA; // 이동 시작점
    public Transform pointB; // 이동 끝점
    public float speed = 2f;

    private Vector3 target;

    void Start()
    {
        target = pointB.position;
    }

    void Update()
    {
        // 현재 위치에서 목표 지점까지 이동
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // 목표 지점에 도달하면 방향 전환
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == pointA.position ? pointB.position : pointA.position;
            // 캐릭터 방향 회전
            transform.LookAt(target);
        }
    }
}