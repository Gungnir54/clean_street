using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject healthPickUp;

    private void OnDestroy() {
        Transform t = Instantiate(healthPickUp).transform;
        t.position = transform.position;
    }
}
