using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabBtnController : MonoBehaviour
{    
    public void OnPrefabBtnClicked()
    {
        Debug.Log("PrefabBtn�Դϴ�.");
    }
    public void OnNestedBtnClicked()
    {
        Debug.Log("NestedBtn�Դϴ�.");
    }
    public void OnVariantBtnClicked()
    {
        Debug.Log("VariantBtn�Դϴ�.");
    }
}
