using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapController : MonoBehaviour
{
    public GameObject camera;
    public Transform cameraTransform;
    public float speed;
    public float _rightLimit;
    public float _leftLimit;
    public float _topLimit;
    public float _downLimit;
    private Vector3 minLimitVector;
    private Vector3 maxLimitVector;
    [SerializeField]
    float dumping;

    public void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        cameraTransform = camera.GetComponent<Transform>();
        speed = 0.004f;
        minLimitVector = new Vector3(_leftLimit, _downLimit, cameraTransform.position.z);
        maxLimitVector = new Vector3(_rightLimit, _topLimit, cameraTransform.position.z);
    }

    public void FixedUpdate()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = FixTouchDelta(Input.GetTouch(0));
            cameraTransform.position = new Vector3(cameraTransform.position.x - touchDeltaPosition.x * speed, cameraTransform.position.y - touchDeltaPosition.y * speed, cameraTransform.position.z);
            Debug.Log("—‚‡ÈÔ");
        }
    }
    private Vector2 FixTouchDelta(Touch aT)
    {
        float dt = Time.deltaTime / aT.deltaTime;
        if (float.IsNaN(dt) || float.IsInfinity(dt))
            dt = 1.0f;

        return aT.deltaPosition * dt;
    }
}
