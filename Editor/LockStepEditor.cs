using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ET
{
    public class LockStepEditor
    {
        [MenuItem("ET/LockStep/Init")]
        public static void Init()
        {
            HybridCLREditor.Init();
            
            ExcelEditor.Init();
            
            ProtoEditor.Init();
            
            LoaderEditor.Init();    
            
            AssetDatabase.Refresh();
            
            Debug.Log("Init finish!");
        }
    }
}
