using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject _thingToFollow;
    [SerializeField] float _cameraOffset = -10f;

    void LateUpdate()
    {
        transform.position = _thingToFollow.transform.position + new Vector3(0, 0, _cameraOffset);
    }
} 