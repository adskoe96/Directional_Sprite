using UnityEngine;

internal class DirectionalSprite : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform parent;
    private static Vector3 cameraForward, parentForward;

    private void Update()
    {
        try { cameraForward = Camera.main.transform.forward; }
        catch { return; }
        
        parentForward = parent.forward;
        float angleBetween = Vector3.SignedAngle(parentForward, cameraForward, Vector3.up);

        float normalizedAngle = (angleBetween + 360) % 360;

        if (normalizedAngle > 180)
        {
            normalizedAngle -= 360;
        }

        animator.SetFloat("x", Mathf.Sin(normalizedAngle * Mathf.Deg2Rad));
        animator.SetFloat("z", Mathf.Cos(normalizedAngle * Mathf.Deg2Rad));
    }
}
