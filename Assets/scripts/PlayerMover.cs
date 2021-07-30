using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
  { 
    public int speed = 300;
    bool isMoving = false;

    void Start()
    {
        
    }
    void Update() {
        if (isMoving) {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            StartCoroutine(Roll(Vector3.right));
        }
		else if (Input.GetKey(KeyCode.LeftArrow)) {
            StartCoroutine(Roll(Vector3.left));
        }
    }

    IEnumerator Roll(Vector3 direction) {
        isMoving = true;

        float remainingAngle = 90;
        Vector3 rotationCenter = transform.position + direction / 2 + Vector3.down / 2;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, direction);

        while (remainingAngle > 0) {
            float rotationAngle = Mathf.Min(Time.deltaTime * speed, remainingAngle);
            transform.RotateAround(rotationCenter, rotationAxis, rotationAngle);
            remainingAngle -= rotationAngle;
            yield return null;
        }

        isMoving = false;
    }
}