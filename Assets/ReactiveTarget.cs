using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {
    [HideInInspector]
    public bool IsAlive { get; private set; }

    void Start() {
        IsAlive = true;
    }

    public void ReactToHit() {
        if (IsAlive) {
            IsAlive = false;
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
    }
}