/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TextMapManager : GlobalManager // TypeDefIndex: 21325
{
    // Fields
    private IDictionary<uint, IDictionary<uint, string>> _textMapDic; // 0x10
    private PriorityQueueForTextMap _textMapPriorityQueue; // 0x18
    private Stack<IDictionary<uint, string>> _reuseDicStack; // 0x20
    private int MIN_DICTIONARY_COUNT; // 0x28
    private int MAX_DICTIONARY_COUNT; // 0x2C
    private int AUTO_CHANGE_STEP; // 0x30
    private int _autoChangeLevel; // 0x34
    private int _autoChangeCount; // 0x38
    private uint _maskValue; // 0x3C
    private IDictionary<uint, string> _textMapFullDic; // 0x40
    private const string EMBEDDED_TEXTMAP_HASH_FILE_PATH = "EmbeddedData"; // Metadata: 0x00AFF46A
    private const string EXCEL_OUTPUT = "_ExcelOutput"; // Metadata: 0x00AFF47A
    private const string EXCEL_OUTPUT_BETA = "_ExcelOutput_Beta"; // Metadata: 0x00AFF48A
    private Dictionary<uint, List<Action<string>>> _asyncLoadCBDic; // 0x48

    // Constructors
    public TextMapManager() { } // 0x00000001836F4670-0x00000001836F47B0

    // Methods
    // [XID] // 0x00000001899DE6B0-0x00000001899DE6D0
    public override void ReloadRes() { } // 0x00000001836F45B0-0x00000001836F4670
                                         // [XID] // 0x00000001899E63D0-0x00000001899E63F0
    public override void Init() { } // 0x00000001836F3840-0x00000001836F3980
                                    // [XID] // 0x00000001899ED880-0x00000001899ED8A0
    public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF465 */) { } // 0x00000001836F2AA0-0x00000001836F2B60
                                                                                                // [XID] // 0x00000001899F52F0-0x00000001899F5310
    public override void Destroy() { } // 0x00000001836F3100-0x00000001836F31A0
                                       // [XID] // 0x00000001899FC940-0x00000001899FC960
    public override void ClearOnLevelDestroy() { } // 0x00000001836F2B60-0x00000001836F2C00
                                                   // [XID] // 0x0000000189A03EC0-0x0000000189A03EE0
    private TextMapPlatformType GetTextMapPlatformType() => default; // 0x00000001836F29B0-0x00000001836F2AA0
    [DebuggerHidden] // 0x0000000189A0B510-0x0000000189A0B550
                     // [XID] // 0x0000000189A0B510-0x0000000189A0B550
    public IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFF466 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001836F3980-0x00000001836F3AD0
                                                                                                                                                                                           // [XID] // 0x0000000189A15C40-0x0000000189A15C60
    public void LoadAllTextMap() { } // 0x00000001836F3CF0-0x00000001836F3E00
                                     // [XID] // 0x0000000189A1D070-0x0000000189A1D090
    public void LoadEmbeddedTextMap()
    {
        LoadDataByPath(GetFileFolderPath() + "EmbeddedData", ref _textMapFullDic);
    } // 0x00000001836F3E00-0x00000001836F3F20
      // [XID] // 0x0000000189A246B0-0x0000000189A246D0
    public string GetData(uint textMapId)
    {
        if (_autoChangeLevel > 0)
        {
            return GetDataWithLRU(textMapId);
        }
        else
        {
            return GetDataInFullDic(textMapId);
        }
    }// 0x00000001836F20F0-0x00000001836F21B0
     // [XID] // 0x0000000189A2BB50-0x0000000189A2BB70
    public string GetDataInFullDic(uint textMapId)
    {
        string fixText = DataHotfixUtil.GetHotfixText(textMapId);
        if (fixText != null)
        {
            _textMapFullDic.Add(textMapId, fixText);
        }
        return fixText;
    }// 0x00000001836F3F20-0x00000001836F40B0
     // [XID] // 0x0000000189A33110-0x0000000189A33130
    private string GetDataWithLRU(uint textMapId) => default; // 0x00000001836F33B0-0x00000001836F3840
                                                              // [XID] // 0x0000000189A3AA40-0x0000000189A3AA60
    private uint GetFileIdByTextMapId(uint textMapId) => default; // 0x00000001836F2620-0x00000001836F26D0
                                                                  // [XID] // 0x0000000189A42330-0x0000000189A42350
    private string GetFilePathByFileId(uint fileId) => default; // 0x00000001836F32B0-0x00000001836F33B0
                                                                // [XID] // 0x0000000189A49940-0x0000000189A49960
    private string GetFileFolderPath()
    {
        string ret = "";
        switch (LocalizationVars.languageType)
        {
            case LanguageType.LanguageEn:
                ret = GlobalExcelConfig.pathHashFolderEN;
                break;
            case LanguageType.LanguageSc:
                ret = GlobalExcelConfig.pathHashFolderCHS;
                break;
            case LanguageType.LanguageTc:
                ret = GlobalExcelConfig.pathHashFolderCHT;
                break;
            case LanguageType.LanguageFr:
                ret = GlobalExcelConfig.pathHashFolderFR;
                break;
            case LanguageType.LanguageDe:
                ret = GlobalExcelConfig.pathHashFolderDE;
                break;
            case LanguageType.LanguageEs:
                ret = GlobalExcelConfig.pathHashFolderES;
                break;
            case LanguageType.LanguagePt:
                ret = GlobalExcelConfig.pathHashFolderPT;
                break;
            case LanguageType.LanguageRu:
                ret = GlobalExcelConfig.pathHashFolderRU;
                break;
            case LanguageType.LanguageJp:
                ret = GlobalExcelConfig.pathHashFolderJP;
                break;
            case LanguageType.LanguageKr:
                ret = GlobalExcelConfig.pathHashFolderKR;
                break;
            case LanguageType.LanguageTh:
                ret = GlobalExcelConfig.pathHashFolderTH;
                break;
            case LanguageType.LanguageVn:
                ret = GlobalExcelConfig.pathHashFolderVI;
                break;
            case LanguageType.LanguageId:
                ret = GlobalExcelConfig.pathHashFolderID;
                break;
        }
        return ret;
    }// 0x00000001836F2CE0-0x00000001836F3100
     // [XID] // 0x0000000189A51290-0x0000000189A512B0
    private IDictionary<uint, string> LoadDataByPathReuse(string path) => default; // 0x00000001836F2C00-0x00000001836F2CE0
                                                                                   // [XID] // 0x0000000189A588E0-0x0000000189A58900
    private bool LoadDataByPath(string path, ref IDictionary<uint, string> dataDic)
    {
        return TextMapConfigLoader.FromBinary(path, ref dataDic);
    }// 0x00000001836F1F00-0x00000001836F1FF0
     // [XID] // 0x0000000189A603C0-0x0000000189A603E0
    public void ReloadTextMap() { } // 0x00000001836F3C40-0x00000001836F3CF0
                                    // [XID] // 0x0000000189A67F50-0x0000000189A67F70
    private void ClearLRUTextMap() { } // 0x00000001836F26D0-0x00000001836F29B0
                                       // [XID] // 0x0000000189A6F320-0x0000000189A6F340
    private void PushUnuseDic(IDictionary<uint, string> unuseDic) { } // 0x00000001836F40B0-0x00000001836F41A0
                                                                      // [XID] // 0x0000000189A76B60-0x0000000189A76B80
    private IDictionary<uint, string> PopUnuseDic() => default; // 0x00000001836F31A0-0x00000001836F32B0
                                                                // [XID] // 0x0000000189A7E4C0-0x0000000189A7E4E0
    public void GetDataAsync(uint textMapId, Action<string> callback) { } // 0x00000001836F1FF0-0x00000001836F20F0
                                                                          // [XID] // 0x0000000189A85DD0-0x0000000189A85DF0
    private void GetDataWithLRUAsync(uint textMapId, Action<string> callback) { } // 0x00000001836F41A0-0x00000001836F45B0
                                                                                  // [XID] // 0x0000000189A8D6B0-0x0000000189A8D6D0
    private void OnLoadDataFinish(uint fileId, uint textMapId, IDictionary<uint, string> dataDic) { } // 0x00000001836F21B0-0x00000001836F2620
                                                                                                      // [XID] // 0x0000000189A94C70-0x0000000189A94C90
    private void LoadDataByPathAsync(string path, Action<IDictionary<uint, string>> callback) { } // 0x00000001836F3B50-0x00000001836F3C40
}

