using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabBtnController : MonoBehaviour
{    
    public void OnPrefabBtnClicked()
    {
        Debug.Log("PrefabBtn입니다.");
    }
    public void OnNestedBtnClicked()
    {
        Debug.Log("NestedBtn입니다.");
    }
    public void OnVariantBtnClicked()
    {
        Debug.Log("VariantBtn입니다.");
    }
}
