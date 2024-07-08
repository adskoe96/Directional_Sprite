using UnityEngine;

internal class SpriteBillboard : MonoBehaviour
{
    [SerializeField] private BillboardType billboardType;

    [Header("Lock Rotation")]
    [SerializeField] private bool lockX;
    [SerializeField] private bool lockY;
    [SerializeField] private bool lockZ;
    private static Vector3 originalRotation;
    internal enum BillboardType { LookAtCamera, CameraForward };

    private void Awake()
    {
        originalRotation = transform.rotation.eulerAngles;
    }

    private void LateUpdate()
    {
        switch (billboardType)
        {
            case BillboardType.LookAtCamera:
                try { transform.LookAt(Camera.main.transform.position, Vector3.up); }
                catch { break; }
                break;

            case BillboardType.CameraForward:
                try { transform.forward = Camera.main.transform.forward; }
                catch { break; }
                break;

            default:
                break;
        }

        Vector3 rotation = transform.rotation.eulerAngles;

        if (lockX) { rotation.x = originalRotation.x; }
        if (lockY) { rotation.y = originalRotation.y; }
        if (lockZ) { rotation.z = originalRotation.z; }
        
        transform.rotation = Quaternion.Euler(rotation);
    }
}
