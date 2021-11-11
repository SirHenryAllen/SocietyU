using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBk : MonoBehaviour {

    void Update() {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        // materials[0] to acces first element (for multiple materials)
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;
    
        offset.x += Time.deltaTime / 10f;

        mat.mainTextureOffset = offset;
    }
}
