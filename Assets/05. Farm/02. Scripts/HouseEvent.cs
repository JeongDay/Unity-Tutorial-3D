using System;
using Unity.Cinemachine;
using UnityEngine;

public class HouseEvent : MonoBehaviour
{
    [SerializeField] private CinemachineClearShot clearShot; // 관리 카메라
    [SerializeField] private GameObject houseTop; // 지붕 오브젝트
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            houseTop.SetActive(false);
            clearShot.ChildCameras[0].Priority = 1;
            clearShot.ChildCameras[2].Priority = 10;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            houseTop.SetActive(true);
            clearShot.ChildCameras[0].Priority = 10;
            clearShot.ChildCameras[2].Priority = 1;
        }
    }
}