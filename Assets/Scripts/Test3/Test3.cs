using UnityEngine;
using System.Collections;
using ProtoTest;
using System.IO;
using System.Collections.Generic;
using System;

public class Test3 : MonoBehaviour {

    private MemoryStream mStream;
    private int counter = 0;
    private StreamHandler sh;

	// Use this for initialization
	void Start () {
        sh = StreamHandler.Instance;
	}

    void DoSet() {
        TestInfo info = new TestInfo { test = "hahaha", num = 200 };
        mStream = new MemoryStream();
        ProtoBuf.Serializer.Serialize<TestInfo>(mStream, info);
        mStream.Position = 0;
        Debug.Log(String.Format("serialize:len:{0}", mStream.ToArray().Length));

        sh.streamList.Add(mStream);
    }

    void DoGet() {
        TestInfo info = null;
        foreach (MemoryStream stream in sh.streamList) {
            info = ProtoBuf.Serializer.Deserialize<TestInfo>(stream);
            Debug.Log("len: " + stream.ToArray().Length);
            Debug.Log(String.Format("Deserialize:test:{0},num:{1}", info.test, info.num));
        }
    }
	
	// Update is called once per frame
	void Update () {
        while (counter < 1) {
            counter++;
            DoSet();
            DoGet();
        }
	}
}
