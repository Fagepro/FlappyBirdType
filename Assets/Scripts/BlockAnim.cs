using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAnim : MonoBehaviour
{
    [SerializeField] private float blockSpeed;

    private bool isAlive = true;

    private void Awake()
    {
    }
    private void LateUpdate()
    {
        Invoke(nameof(DestroyThisAtTime), 15f);

        if (!isAlive) return;
            this.transform.Translate(new Vector2(-blockSpeed / 100, 0f));
    }

    private void DestroyThisAtTime()
    {
        Destroy(this.gameObject);
    }

    private void StopAnim() 
    {
        isAlive = false;
    }
}
