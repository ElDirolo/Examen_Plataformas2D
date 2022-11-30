using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    
    [SerializeField] private Transform camTarget;
    [SerializeField] private Vector3 offset;

    [SerializeField] float smoothTime;
    Vector2 velocity;
    [SerializeField] Vector2 minPos;
    [SerializeField] Vector2 maxPos;
    
    

    void FixedUpdate()
    {
        Vector3 desiredPos = new Vector3(camTarget.position.x + offset.x, camTarget.position.y + offset.y, offset.z);

        float posX = Mathf.SmoothDamp(transform.position.x, desiredPos.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, desiredPos.y, ref velocity.y, smoothTime);

        transform.position = new Vector3(Mathf.Clamp(posX, minPos.x, maxPos.x), Mathf.Clamp(posY, minPos.y, maxPos.y), desiredPos.z);
    
    }


}
