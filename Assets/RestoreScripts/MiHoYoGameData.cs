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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MiHoYoGameData // TypeDefIndex: 19577
{
    // Fields
    private const string GENERAL_DATA_KEY = "GENERAL_DATA"; // Metadata: 0x00AFCB12
    private string _generalDataKey; // 0x10
    private GeneralLocalDataItem _generalData; // 0x18
    private UserLocalDataItem _userLocalData; // 0x20
    private bool _needSaveUserLocalData; // 0x28
    private bool _needSaveGeneralData; // 0x29
    private float _lastSaveUserLocalDataTime; // 0x2C
    private float _lastSaveGeneralDataTime; // 0x30
    private Dictionary<string, string> _cloudSaveData; // 0x38
    public const string CLOUD_DATA_TAG = "CloudLocalData"; // Metadata: 0x00AFCB22

    // Properties
    public UserLocalDataItem LocalData { /* [XID] */ /* 0x0000000189B200F0-0x0000000189B20110 */ get => default; } // 0x0000000182127450-0x00000001821275A0 
    public GeneralLocalDataItem GeneralLocalData { /* [XID] */ /* 0x000000018988E860-0x000000018988E880 */ get => default; } // 0x00000001821275A0-0x00000001821276E0 

    // Constructors
    private MiHoYoGameData() { } // 0x0000000182128FC0-0x0000000182129050

    // Methods
    // [XID] // 0x0000000189B723C0-0x0000000189B723E0
    private void InitUserLocalData() { } // 0x00000001821289E0-0x0000000182128AB0
                                         // [XID] // 0x0000000189895D40-0x0000000189895D60
    private void InitGeneralData() { } // 0x0000000182127800-0x00000001821278D0
                                       // [XID] // 0x000000018989D360-0x000000018989D380
    public void Save(bool force = false /* Metadata: 0x00AFCB0F */) { } // 0x0000000182128DF0-0x0000000182128FC0
                                                                        // [XID] // 0x00000001898A4D20-0x00000001898A4D40
    public void SaveGeneralData(bool force = false /* Metadata: 0x00AFCB10 */)
    {
        if (force)
        {
            if (GlobalVars.AfterAgreement)
            {
                CheckThreadSafe();
                if (_generalData == null)
                {
                    SuperDebug.Assert(false, "_generalData is null!");
                }
                _generalData.OnSaving();
                string generalDataKey = ConfigUtil.SaveJSONStrConfig(_generalData, true);
                PlayerPrefsSetString(_generalDataKey, generalDataKey);
                PlayerPrefsSave();
                _needSaveGeneralData = false;
                _lastSaveGeneralDataTime = Time.realtimeSinceStartup;
            }
        }
        else
        {
            _needSaveGeneralData = true;
        }
    } // 0x0000000182128240-0x0000000182128400
      // [XID] // 0x00000001898AC1E0-0x00000001898AC200
    public void SaveIfNeeded(bool force = false /* Metadata: 0x00AFCB11 */) { } // 0x0000000182127990-0x0000000182127AA0
                                                                                // [XID] // 0x00000001898B38C0-0x00000001898B38E0
    public static void DeleteAllData() { } // 0x0000000182128780-0x00000001821288C0
                                           // [XID] // 0x00000001898BB670-0x00000001898BB690
    public void DeleteCurrentUserData() { } // 0x0000000182127C90-0x0000000182127D70
                                            // [XID] // 0x00000001898C2940-0x00000001898C2960
    public void Reset() { } // 0x00000001821273A0-0x0000000182127450
                            // [XID] // 0x00000001898CA340-0x00000001898CA360
    public void ResetLocalData() { } // 0x0000000182127300-0x00000001821273A0
                                     // [XID] // 0x0000000189AEBF30-0x0000000189AEBF50
    private string GetPrefsKey() => default; // 0x0000000182127AA0-0x0000000182127C90
                                             // [XID] // 0x00000001898D9350-0x00000001898D9370
    private void CheckThreadSafe() { } // 0x0000000182128400-0x00000001821284B0
                                       // [XID] // 0x00000001898E0F60-0x00000001898E0F80
    private void CheckVersionAndClearIfNeed() { } // 0x0000000182128AB0-0x0000000182128C90
                                                  // [XID] // 0x00000001898E8A40-0x00000001898E8A60
    public void InitCloudData(string responseString) { } // 0x00000001821284B0-0x0000000182128780
                                                         // [XID] // 0x00000001898F01A0-0x00000001898F01C0
    private bool PlayerPrefsHasKey(string key) => default; // 0x0000000182127D70-0x0000000182127E80
                                                           // [XID] // 0x00000001898854D0-0x00000001898854F0
    private string PlayerPrefsGetString(string key) => default; // 0x0000000182128C90-0x0000000182128DF0
                                                                // [XID] // 0x00000001898FF1D0-0x00000001898FF1F0
    private void PlayerPrefsDeleteKey(string key) { } // 0x00000001821276E0-0x0000000182127800
                                                      // [XID] // 0x0000000189A80DF0-0x0000000189A80E10
    private static void PlayerPrefsDeleteAll() { } // 0x00000001821278D0-0x0000000182127990
                                                   // [XID] // 0x000000018990E4D0-0x000000018990E4F0
    private void PlayerPrefsSave() { } // 0x0000000182127E80-0x0000000182128240
                                       // [XID] // 0x0000000189915BA0-0x0000000189915BC0
    private void PlayerPrefsSetString(string key, string val)
    {
        if (Miscs.IsCloudGame())
        {
            if (_cloudSaveData != null)
            {
                _cloudSaveData[key] = val;
            }
        }
        else
        {
            PlayerPrefs.SetString(key, val);
        }
    } // 0x00000001821288C0-0x00000001821289E0
}

