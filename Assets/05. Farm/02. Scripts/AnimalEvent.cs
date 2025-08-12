using Unity.Cinemachine;
using UnityEngine;

public class AnimalEvent : MonoBehaviour
{
    [SerializeField] private CinemachineClearShot clearShot;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clearShot.ChildCameras[0].Priority = 1;
            clearShot.ChildCameras[3].Priority = 10;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clearShot.ChildCameras[0].Priority = 10;
            clearShot.ChildCameras[3].Priority = 1;
        }
    }
}