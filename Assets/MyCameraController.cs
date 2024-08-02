using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラ取得
        mainCamera = Camera.main;
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        //MyCameraController myCameraCt;
        //myCameraCt.
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
    public void ObjectPosition()
    {
        //タグ付オブジェクト取得
        /*GameObject CarPrefab = GameObject.FindGameObjectWithTag("CarTag");
        GameObject TrafficConePrefab = GameObject.FindGameObjectWithTag("TrafficConeTag");
        GameObject CoinPrefab = GameObject.FindGameObjectWithTag("CoinTag");*/

        //カメラの位置を取得
        /*Vector3 cameraPosition = Camera.main.transform.position;
         //CarPrefabの位置を取得
         Vector3 CarPrefabPosition = this.transform.position;
         //TrafficPrefabの位置を取得
         Vector3 TrafficConePosition = this.transform.position;
         //CoinPrefabの位置を取得
         Vector3 CoinPrefabPosition = this.transform.position;

         //カメラとターゲットオブジェクトの位置を比較
         if (cameraPosition.z < CarPrefabPosition.z)
         {
             Debug.Log("Carはカメラより前");
         }
         else if (cameraPosition.z > CarPrefabPosition.z)
         {
             Debug.Log("Carはカメラより後ろ");
         }

         //TrafficConePrefab
         if (cameraPosition.z < TrafficConePosition.z)
         {
             Debug.Log("TrafficConeはカメラより前");
         }
         else if (cameraPosition.z > TrafficConePosition.z)
         {
             Debug.Log("TrafficConeはカメラより後ろ");
         }

         //CoinPrefab
         if (cameraPosition.z < CoinPrefabPosition.z)
         {
             Debug.Log("Coinはカメラより前");
         }
         else if (cameraPosition.z > CoinPrefabPosition.z)
         {
             Debug.Log("Coinはカメラより後ろ");
         }*/
    }
}