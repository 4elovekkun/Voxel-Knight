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

    public void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        cameraTransform = camera.GetComponent<Transform>();
        speed = 0.5f;
        minLimitVector = new Vector3(_leftLimit, _downLimit, cameraTransform.position.z);
        maxLimitVector = new Vector3(_rightLimit, _topLimit, cameraTransform.position.z);
    }

    public void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            cameraTransform.position = new Vector3
                (
                Mathf.Clamp(cameraTransform.position.x - touchDeltaPosition.x * speed * Time.deltaTime, _leftLimit - 0.5f, _rightLimit + 0.5f),
                Mathf.Clamp(cameraTransform.position.y - touchDeltaPosition.y * speed * Time.deltaTime, _downLimit - 0.5f, _topLimit + 0.5f),
                cameraTransform.position.z
                );
            if (cameraTransform.position.x > _rightLimit || cameraTransform.position.x < _leftLimit || cameraTransform.position.y > _topLimit || cameraTransform.position.y < _downLimit) {
                
            }
            Debug.Log("Ñâàéï");
        }
    }
}
