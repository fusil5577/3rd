using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] characterRenderers;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //받은 값으로 각도를 아크탄젠트로 구해주고 * (라디안 -> 각도)변경

        foreach (SpriteRenderer renderer in characterRenderers)
        {
            if (renderer.gameObject.activeSelf)
            {
                renderer.flipX = Mathf.Abs(rotZ) > 90f; // 절대값이 90도 보다 더 크면 즉, 왼쪽을 바라보면 뒤집어라.
            }
        }
    }
}
