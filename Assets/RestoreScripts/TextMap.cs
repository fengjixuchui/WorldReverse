/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class TextMap // TypeDefIndex: 31985
{
    // Methods
    // [IDTag] // 0x0000000189819C60-0x0000000189819CA0
    // [XID] // 0x0000000189819C60-0x0000000189819CA0
    public static string Get(string textMapID, bool replaceNewLine = false /* Metadata: 0x00B13AA1 */) => default; // 0x0000000184245BA0-0x0000000184245D30
                                                                                                                   // [IDTag] // 0x0000000189823F10-0x0000000189823F50
                                                                                                                   // [XID] // 0x0000000189823F10-0x0000000189823F50
    public static string Get(string textID, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] replaceParams) => default; // 0x0000000184245AD0-0x0000000184245BA0
                                                                                                                                   // [XID] // 0x0000000189835EF0-0x0000000189835F10
    public static void GetDataAsync(string textMapID, Action<string> callback) { } // 0x0000000184245410-0x0000000184245620
                                                                                   // [XID] // 0x000000018983D3F0-0x000000018983D410
    public static string GetEmbeddedTextMap(string textID) => default; // 0x0000000184245D30-0x0000000184245E20
                                                                       // [XID] // 0x0000000189844C50-0x0000000189844C70
    public static string GetRealTextMapById(uint textMapID) => default; // 0x00000001842458A0-0x0000000184245AD0
                                                                        // [XID] // 0x000000018984C000-0x000000018984C020
    public static string GetEmbeddedTextMapById(uint textMapID)
    {
        if (textMapID != 0)
        {
            var textMap = Singleton<TextMapManager>.Instance;
            string text1 = textMap.GetDataInFullDic(textMapID);
            if (text1 == null)
            {
                text1 = textMap.GetData(textMapID);
                if (text1 == null)
                {
                    SuperDebug.LogWarning(SuperDebug.UI, "Can't find textMapID:" + textMapID);
                    return "";
                }
                if (text1.StartsWith("#")) return text1;
                return UIUtil.FilterRegexContent(text1.Substring(1));
            }
        }
        return "";
    }// 0x0000000184245620-0x00000001842458A0
    private static string CompileMyDefinedPattern<T>(string text, T[] replaceParams) => default;
}

