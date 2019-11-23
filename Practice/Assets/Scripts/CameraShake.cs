using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;
public class CameraShake : MonoBehaviour
{
    public float ShakeDuration = .3f;
    public float ShakeFrequency = 2.0f;
    public float ShakeAmplitude = 1f;
    
    private float ShakeElapsedTime = 0;
    

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin VirtualCameraNoise;
    // Start is called before the first frame update
    void Start()
    {

        if (VirtualCamera != null)
        {
            VirtualCameraNoise = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShakeElapsedTime = ShakeDuration;

        }
        if (VirtualCamera!=null&&VirtualCameraNoise!=null)
        {
            if (ShakeElapsedTime>0)
            {
                VirtualCameraNoise.m_AmplitudeGain = ShakeAmplitude;
                VirtualCameraNoise.m_FrequencyGain = ShakeFrequency;

                ShakeElapsedTime -= Time.deltaTime;
            }
            else
            {
                VirtualCameraNoise.m_AmplitudeGain = 0;
                ShakeElapsedTime = 0;
            }
        }
    }
}
