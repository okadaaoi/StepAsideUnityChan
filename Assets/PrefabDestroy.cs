using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ObjectDestroy(Collider collider)
    {
        //CarPrefab(Clone)を取得
        GameObject CarPrefab = GameObject.Find("CarPrefab(Clone)");
        //TrafficConePrefab(Clone)を取得
        GameObject TrafficConePrefab = GameObject.Find("TrafficConePrefab(Clone)");
        //CoinPrefab(Clone)を取得
        GameObject CoinPrefab = GameObject.Find("CoinPrefab(Clone)");

        //DestroyControllerと当たれば削除
        if (collider.gameObject.CompareTag("CarTag"))
        {
            //CarPrefab(Clone)削除
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("TrafficConeTag"))
        {
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("CoinTag"))
        {
            Destroy(collider.gameObject);
        }
    }
}