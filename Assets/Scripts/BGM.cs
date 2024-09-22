using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{

    public static BGM BGNinstance;

    private void Awake()
    {
        
        if(BGNinstance!=null&&BGNinstance!=this)
        {

            Destroy(this.gameObject);
            return;

        }

        BGNinstance = this;
        DontDestroyOnLoad(this);

    }

}
