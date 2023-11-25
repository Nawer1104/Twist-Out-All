using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public GameObject vfxClicked;

    public bool isClicked = false;

    private void OnMouseDown()
    {
        if (isClicked) return;
        isClicked = true;
        GetComponent<Rigidbody2D>().gravityScale = 1f;

        GameObject vfx = Instantiate(vfxClicked, transform.position, Quaternion.identity) as GameObject;
        Destroy(vfx, 1f);

        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].CheckLinks();
    }
}
