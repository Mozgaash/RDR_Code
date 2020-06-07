using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class cameraFollow : MonoBehaviour
{

    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    // variable de suavizado de unity
    public float smoothTime;

    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Optimizamos calculos debido a que update calcula a lo maximo del pc, mientras q este a lo que pueda el juego
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, 
            follow.transform.position.x, ref velocity.x, smoothTime);

        float posY = Mathf.SmoothDamp(transform.position.y,
            follow.transform.position.y, ref velocity.y, smoothTime);
        transform.position = new Vector3(
            Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
            Mathf.Clamp(posY, minCamPos.y, maxCamPos.y),
            transform.position.z);
    }
}
