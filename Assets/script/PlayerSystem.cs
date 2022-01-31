using Unity.Entities;
using UnityEngine;

public class PlayerSystem : SystemBase {

    protected override void OnCreateForCompiler () {

        Debug.Log ("OnCreateForCompiler()");
    }


    protected override void OnCreate () {

        Debug.Log ("OnCreate()");
    }

    protected override void OnStartRunning () {

        Debug.Log ("OnStartRunning() ");

    }

  
    protected override void OnUpdate () {

        Debug.Log ("OnUpdate()");
    }

    protected override void OnStopRunning () {

        Debug.Log ("OnStopRunning()");

    }

    protected override void OnDestroy () {

        Debug.Log ("OnDestroy()");
    }
}
