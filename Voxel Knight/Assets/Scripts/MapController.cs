using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapController : MonoBehaviour
{
    public GameObject camera;
    public Transform cameraTransform;
    public float speed;
    public float _rightLimit = 11.46f;
    public float _leftLimit = -8.6f;
    public float _topLimit;
    public float _downLimit;

    public void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        cameraTransform = camera.GetComponent<Transform>();
        speed = 0.5f;
    }

    public void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            Debug.Log(Input.GetTouch(0).ToString());
            Debug.Log("Ñâàéï");
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                cameraTransform.position = new Vector3
                    (
                    Mathf.Clamp(cameraTransform.position.x - touchDeltaPosition.x * speed * Time.deltaTime, _leftLimit, _rightLimit),
                    Mathf.Clamp(cameraTransform.position.y - touchDeltaPosition.y * speed * Time.deltaTime, _downLimit, _topLimit),
                    cameraTransform.position.z
                    );
            }
        }
    }
}
