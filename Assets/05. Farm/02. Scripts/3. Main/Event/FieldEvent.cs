using Unity.Cinemachine;
using UnityEngine;

public class FieldEvent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCameraState(CameraState.Field);
            // FieldManager의 FieldState도 변경 필요
            GameManager.Instance.ui.ActivateFieldUI(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCameraState(CameraState.Outside);
            // FieldManager의 FieldState도 변경 필요
            GameManager.Instance.ui.ActivateFieldUI(false);
        }
    }
}