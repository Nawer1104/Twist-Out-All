using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public List<Link> links;

    public void CheckLinks()
    {
        foreach(Link link in links)
        {
            if (!link.isClicked) return;
        }

        foreach(GameObject gameObject in gameObjects)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }

        GameManager.Instance.CheckLevelUp();
    }


    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
