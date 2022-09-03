/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class BinaryTool // TypeDefIndex: 14767
{
    // Fields
    private static ByteArrayEncode[] _encode; // 0x00

    // Constructors
    static BinaryTool()
    {
        int processorCount;
        if (SystemInfo.processorCount > 2)
            processorCount = SystemInfo.processorCount;
        else
            processorCount = 2;
        _encode = new ByteArrayEncode[processorCount];
        for (int i = 0; i < processorCount; i++)
        {
            _encode[i] = new ByteArrayEncode();
        }
    } // 0x00000001809FC260-0x0000000180A093B0

    public static bool CheckValid(ByteArray byteArray)
    {
        if (byteArray != null && byteArray.bytes != null && byteArray.bytes.Length > 0) return true;
        SuperDebug.LogError("Parsing invalid byteArray: null or empty.");
        return false;
    }// 0x00000001809FC170-0x00000001809FC260

    [IDTag] // 0x000000018974BC30-0x000000018974BC70
    [XID] // 0x000000018974BC30-0x000000018974BC70
    public static bool FromBinary(ByteArray byteArray, ByteArrayEncode encode)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            for (int i = 0; i < encode.bytes.Length; i++)
            {
                encode.bytes[i] = encode.bytes[i + byteArray.pos];
                if ((encode.bytes[i] & 128) == 0)
                {
                    encode.length = i + 1;
                    break;
                }
            }
            flag = byteArray.movePosition(encode.length);
        }
        return flag;
    }// 0x000000018094B410-0x000000018094B5F0
    public static bool FromBinary(ByteArray byteArray, out byte val, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            val = (byte)byteArray.pos;
            return byteArray.movePosition(1);
        }
        val = 0;
        return flag;
    }
    public static bool FromBinary(ByteArray byteArray, out int val, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            flag = FromBinary(byteArray, out uint vala, threadFlag);
            val = (int)(-(vala & 1) ^ (vala >> 1));
            return flag;
        }
        val = 0;
        return flag;
    }
    public static bool FromBinary(ByteArray byteArray, out uint val, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            flag = FromBinary(byteArray, _encode[threadFlag]);
            val = (uint)_encode[threadFlag].ToNumber();
            return flag;
        }
        val = 0;
        return flag;
    }
    public static bool FromBinary(ByteArray byteArray, out string val, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            flag = FromBinary(byteArray, out uint val1, threadFlag);
            if (val1 != 0)
            {
                if (threadFlag != 0)
                {
                    val = Encoding.UTF8.GetString(byteArray.bytes, byteArray.pos, (int)val1);
                }
                else
                {
                    val = Encoding.UTF8.GetString(byteArray.bytes, byteArray.pos, (int)val1);
                    UniqueString.Intern(val);
                }
            }
            else
            {
                val = String.Intern("");
            }
            return byteArray.movePosition((int)val1);
        }
        val = null;
        return flag;
    }
    public static bool FromBinary(ByteArray byteArray, out ExistFlag val, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        if (BinaryTool.CheckValid(byteArray))
        {
            FromBinary(byteArray, out byte vala, threadFlag);
            val = new ExistFlag();
            val.bytes = new byte[vala];
            if (val != null)
            {
                for (int i = 0; i < vala; i++)
                {
                    byteArray.bytes[i++] = byteArray.bytes[i + byteArray.pos];
                }
            }
            flag = byteArray.movePosition(vala);
            return flag;
        }
        val = null;
        return flag;
    }
    public static bool FromBinary(ByteArray byteArray, out EmbeddedTextMapConfig data, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        if (useObjectPool)
        {
            data = ObjectPoolUtility.Allocate<EmbeddedTextMapConfig>();
        }
        else
        {
            data = new EmbeddedTextMapConfig();
        }
        return data.FromBinary(byteArray, threadFlag, useObjectPool);
    }
    public static bool FromBinary(ByteArray byteArray, out TextMapConfig data, int threadFlag = 0 /* Metadata: 0x00AEBED4 */, bool useObjectPool = false /* Metadata: 0x00AEBED8 */)
    {
        bool flag = false;
        data = new TextMapConfig();
        if (FromBinary(byteArray, out ExistFlag val))
        {
            if (!FieldTool.Exist(val, 0) || BinaryTool.FromBinary(byteArray, out data.textMapId))
            {
                if (!FieldTool.Exist(val, 1) || BinaryTool.FromBinary(byteArray, out data.textMapContent))
                {
                    flag = true;
                }
                else
                {
                    SuperDebug.LogError("FromBinary for: textMapContent  fails!");
                }
            }
            else
            {
                SuperDebug.LogError("FromBinary for: textMapId  fails!");
            }
        }
        else
        {
            SuperDebug.LogError("FromBinary for memberExist in TextMapConfig fails!");
        }
        return flag;
    }
}

