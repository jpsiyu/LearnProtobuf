using UnityEngine;
using System.Collections;
using ProtoTest;
using System.IO;

public class Test2 : MonoBehaviour {

	// Use this for initialization
    //void Start () {
    //    TestInfo info = new TestInfo{test = "haha", num = 2};
    //    using (var file = System.IO.File.Create("Test.bin")) {
    //        ProtoBuf.Serializer.Serialize(file, info);
    //    }
	
    //}

    void Start() {
        TestInfo info = null;
        using (var file = System.IO.File.OpenRead("Test.bin")) {
            info = ProtoBuf.Serializer.Deserialize<TestInfo>(file);
        }
        Debug.Log("deserialize info: " + info.test + info.num.ToString());
    }


	// Update is called once per frame
	void Update () {
	    
	}
}
