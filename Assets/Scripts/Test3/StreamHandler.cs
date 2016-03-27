using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;

public class StreamHandler {

    private static StreamHandler instance = null;
    private static int tag = 0;

    public List<MemoryStream> streamList = null;

    public static StreamHandler Instance {
        get{
            if (instance == null)
            {
                instance = new StreamHandler();
                return instance;
            }
            else {
                return instance;
            }
        }
    }

    private StreamHandler() {
        streamList = new List<MemoryStream>();
    }
}
