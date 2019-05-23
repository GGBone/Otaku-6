using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIInitialize : MonoBehaviour
{
    public GameObject init_prefab_;
    // Start is called before the first frame update
    void Start()
    {
        init_prefab_ = Resources.Load("UI/Button") as GameObject;
        if (init_prefab_)
        {
            GameObject button = Instantiate(init_prefab_);
            button.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
            button.GetComponentInChildren<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
