using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBk : MonoBehaviour {

    float parralax = 1f;
    void Update() {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        // materials[0] to acces first element (for multiple materials)
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;
    
        offset.x = transform.position.x / transform.localScale.x / parralax;
        offset.y = transform.position.x / transform.localScale.y / parralax;

        mat.mainTextureOffset = offset;
    }
}
