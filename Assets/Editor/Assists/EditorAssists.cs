﻿//======================================================================
//        Copyright (C) 2015-2020 Winddy He. All rights reserved
//        Email: hgplan@126.com
//======================================================================
using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using Object = UnityEngine.Object;

namespace Core.Editor
{
    public class EditorAssists
    {
        public static void RegisterUndo(string name, params Object[] objects)
        {
            if (objects != null && objects.Length > 0)
            {
                UnityEditor.Undo.RecordObjects(objects, name);
                foreach (var obj in objects)
                {
                    if (obj == null) continue;
                    EditorUtility.SetDirty(obj);
                }
            }
        }

        public static string ToMemorySize(long byteNum)
        {
            if (byteNum < 0)
                byteNum = 0;

            if (byteNum < 1024)
            {
                return byteNum + "B";
            }
            else if (byteNum < 1048576 && byteNum >= 1024) 
            {
                return (byteNum / 1024.0f).ToString("F2") + "KB";
            }
            else if (byteNum < 1073741824 && byteNum >= 1048576)
            {
                return (byteNum / 1048576.0f).ToString("F2") + "MB";
            }
            else
            {
                return (byteNum / 1073741824.0f).ToString("F2") + "GB";
            }
        }
    }
}