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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class TextMapConfigLoader // TypeDefIndex: 31987
{
    // Fields
    private const string TEXTMAP_TRANSLATE_SIGN = "#$#"; // Metadata: 0x00B13AA2
    private static Dictionary<string, TextMapConfig> _dataDict; // 0x00

    // Properties
    public static Dictionary<string, TextMapConfig> dataDict { /* [XID] */ /* 0x00000001898530F0-0x0000000189853110 */ get; } // 0x000000018289E800-0x000000018289E8D0 

    // Constructors
    static TextMapConfigLoader() { } // 0x000000018289EBF0-0x000000018289EC80

    // Methods
    // [IDTag] // 0x000000018985AC40-0x000000018985AC80
    // [XID] // 0x000000018985AC40-0x000000018985AC80
    public static bool FromTxt(string path) => default; // 0x000000018289D1B0-0x000000018289DAB0
                                                        // [IDTag] // 0x0000000189864E10-0x0000000189864E50
                                                        // [XID] // 0x0000000189864E10-0x0000000189864E50
    public static bool FromTxt(string path, ref IDictionary<uint, string> dataDic) => default; // 0x000000018289DAB0-0x000000018289DC50
                                                                                               // [XID] // 0x000000018986F2B0-0x000000018986F2D0
    public static void FromTxtAsync(string path, Action<IDictionary<uint, string>> callback) { } // 0x000000018289E8D0-0x000000018289EA60
                                                                                                 // [XID] // 0x00000001898768C0-0x00000001898768E0
    private static bool StringToDic(string textString, ref IDictionary<uint, string> dataDic) => default; // 0x000000018289DC50-0x000000018289E390
                                                                                                          // [XID] // 0x000000018987E420-0x000000018987E440
    public static bool FromBinary(string path, ref IDictionary<uint, string> dataDic)
    {
        var packedBin = SerializationUtils.ReadPackedBin(path);
        if (packedBin != null && packedBin.bytes != null)
        {
            return BinaryToDic(packedBin, ref dataDic);
        }
        SuperDebug.LogError("TextMapConfig failed to LoadData from path:" + path);
        return false;
    }// 0x000000018289E670-0x000000018289E800
     // [XID] // 0x00000001898857F0-0x0000000189885810
    public static void FromBinaryAsync(string path, Action<IDictionary<uint, string>> callback) { } // 0x000000018289EA60-0x000000018289EBF0
                                                                                                    // [XID] // 0x000000018988CB20-0x000000018988CB40
    private static bool BinaryToDic(ByteArray byteArray, ref IDictionary<uint, string> dataDic) => default; // 0x000000018289E390-0x000000018289E670
}

