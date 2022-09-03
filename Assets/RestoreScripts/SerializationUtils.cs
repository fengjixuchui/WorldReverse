/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SerializationUtils // TypeDefIndex: 19572
{
    // Fields
    private static byte binKey; // 0x00
    public static Dictionary<System.Type, string> jsonDataMapping; // 0x08

    // Nested types
    public struct InvalidDataType // TypeDefIndex: 19573
    {
    }

    public enum PackedBinCategory // TypeDefIndex: 19574
    {
        NONEXCEL = 0,
        EXCEL = 1
    }

    // Constructors
    static SerializationUtils() { } // 0x00000001815A86C0-0x00000001815A9D00
    public SerializationUtils() { } // 0x00000001815A9D00-0x00000001815A9D60

    // Methods
    // [XID] // 0x00000001896D0980-0x00000001896D09A0
    public static ulong GetHash(string binPath) => default; // 0x00000001815A80D0-0x00000001815A8220
                                                            // [XID] // 0x0000000189A7B030-0x0000000189A7B050
    public static string ToJsonPath(string binPath) => default; // 0x00000001815A8220-0x00000001815A82E0
                                                                // [XID] // 0x000000018972A8A0-0x000000018972A8C0
    public static void DecodeBin(ByteArray byteArr)
    {
        for (int i = 0; i < byteArr.bytes.Length; i++)
        {
            byteArr.bytes[i] ^= binKey;
        }
    } // 0x00000001815A7500-0x00000001815A7650
      // [IDTag] // 0x00000001896E6B40-0x00000001896E6B80
      // [XID] // 0x00000001896E6B40-0x00000001896E6B80
    public static ByteArray ReadPackedBin(string sourcePath)
    {
        var binData = CommonMiscs.LoadBinData(sourcePath);
        ByteArray array = ByteArray.Get();
        if (binData != null)
        {
            array.bytes = binData;
            DecodeBin(array);
        }
        else
        {
            array.bytes = null;
            SuperDebug.LogError("Binary file is broken in file:" + sourcePath);
        }
        return array;
    }// 0x00000001815A7650-0x00000001815A7800
     // [XID] // 0x00000001896F0E00-0x00000001896F0E20
    public static void ReadPackedBinAsync(string sourcePath, Action<ByteArray> finishCallback, PackedBinCategory category = PackedBinCategory.NONEXCEL /* Metadata: 0x00AFCB03 */) { } // 0x00000001815A7DF0-0x00000001815A7FF0
                                                                                                                                                                                       // [IDTag] // 0x00000001896F8620-0x00000001896F8660
                                                                                                                                                                                       // [XID] // 0x00000001896F8620-0x00000001896F8660
    public static ByteArray ReadPackedBin(ulong sourcePathHash) => default; // 0x00000001815A7800-0x00000001815A79C0
    public static string GetDataToolTraversingFolder<T>() => default;
    // [XID] // 0x0000000189702F70-0x0000000189702F90
    public static ToBinType GetJsonFolder(System.Type type, ref string folderPath) => default; // 0x00000001815A82E0-0x00000001815A8570
                                                                                               // [XID] // 0x000000018970A640-0x000000018970A660
    public static ToBinType GetToBinType(string jsonFilePath, ref System.Type dataType) => default; // 0x00000001815A79C0-0x00000001815A7DF0
                                                                                                    // [XID] // 0x00000001897120B0-0x00000001897120D0
    private static ToBinType ParseToBinType(string entry) => default; // 0x00000001815A8570-0x00000001815A86C0
                                                                      // [XID] // 0x0000000189719750-0x0000000189719770
    public static ulong GetPathFormHash(ConfigMetaConfig.PathHash pathHash) => default; // 0x00000001815A7FF0-0x00000001815A80D0
}

