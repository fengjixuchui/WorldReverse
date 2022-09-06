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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class UIConfigData // TypeDefIndex: 19250
{
    // Fields
    private static List<ConfigUI> _uiConfigs; // 0x00
    private static ConfigUIGlobal _globalConfig; // 0x08

    // Properties
    private static string GLOBAL_CONFIG_PATH { /* [XID] */ /* 0x0000000189AF4290-0x0000000189AF42B0 */ get; } // 0x0000000183148EA0-0x0000000183148F40 
    private static string LOGIN_PAGE_CONFIG_PATH { /* [XID] */ /* 0x0000000189928B70-0x0000000189928B90 */ get; } // 0x0000000183149060-0x0000000183149100 
    public static ConfigUIGlobal globalConfig { /* [XID] */ /* 0x0000000189B03190-0x0000000189B031B0 */ get; } // 0x0000000183149100-0x00000001831491D0 
    public static Vector2 joypadChangeViewScale { /* [XID] */ /* 0x00000001896FAD70-0x00000001896FAD90 */ get; } // 0x0000000183146530-0x00000001831466D0 
    public static float joypadLongPressDuration { /* [XID] */ /* 0x0000000189B6FB80-0x0000000189B6FBA0 */ get; } // 0x0000000183148F40-0x0000000183149060 
    public static SimpleSafeFloat[] joypadSensitivityScales { /* [XID] */ /* 0x0000000189B77050-0x0000000189B77070 */ get; } // 0x0000000183147500-0x0000000183147610 
    public static SimpleSafeFloat[] joypadFocusSensitivityScales { /* [XID] */ /* 0x000000018967E3E0-0x000000018967E400 */ get; } // 0x00000001831491D0-0x00000001831492E0 
    public static SimpleSafeFloat[] mouseSensitivityScales { /* [XID] */ /* 0x000000018996BAB0-0x000000018996BAD0 */ get; } // 0x0000000183147F50-0x0000000183148060 
    public static SimpleSafeFloat[] mouseFocusSensitivityScales { /* [XID] */ /* 0x0000000189B80A90-0x0000000189B80AB0 */ get; } // 0x00000001831492E0-0x00000001831493F0 
    public static SimpleSafeFloat[] touchpadSensitivityScales { /* [XID] */ /* 0x0000000189727A60-0x0000000189727A80 */ get; } // 0x0000000183147610-0x0000000183147720 
    public static SimpleSafeFloat[] touchpadFocusSensitivityScales { /* [XID] */ /* 0x0000000189625850-0x0000000189625870 */ get; } // 0x00000001831468C0-0x00000001831469D0 
    public static SimpleSafeFloat[] touchpadFocusAccelerationScales { /* [XID] */ /* 0x0000000189A73400-0x0000000189A73420 */ get; } // 0x00000001831469D0-0x0000000183146AE0 
    public static TouchpadFocusAccelerationSigmoidPara tuchpadFocusAccelerationSigmoidPara { /* [XID] */ /* 0x0000000189BAAD00-0x0000000189BAAD20 */ get; } // 0x0000000183148D90-0x0000000183148EA0 

    // Constructors
    static UIConfigData() { } // 0x0000000183149650-0x00000001831496F0

    // Methods
    // [XID] // 0x0000000189B0A890-0x0000000189B0A8B0
    public static void LoadEmbededConfig()
    {
        _globalConfig = new ConfigUIGlobal();
        bool loaded = false;
        if (InLevelData.loadInLevelFromBin)
        {
            loaded = _globalConfig.FromBinary(SerializationUtils.ReadPackedBin(GLOBAL_CONFIG_PATH));
        }
        else
        {
            loaded = _globalConfig.FromJson(JsonTool.LoadJSONConfig(SerializationUtils.ToJsonPath(GLOBAL_CONFIG_PATH)));
        }
        if (!loaded)
        {
            SuperDebug.VeryImportantError("Load Embeded GlobalUIConfig Fail!", ErrorLevel.High, ErrorCategory.UI);
        }
        ResolveGlobalActionEventConfig();
        ConfigUI configUI = new ConfigUI();
        if (InLevelData.loadInLevelFromBin)
        {
            loaded = configUI.FromBinary(SerializationUtils.ReadPackedBin(LOGIN_PAGE_CONFIG_PATH));
        }
        else
        {
            loaded = configUI.FromJson(JsonTool.LoadJSONConfig(SerializationUtils.ToJsonPath(LOGIN_PAGE_CONFIG_PATH)));
        }
        if (configUI.context != null)
        {
            foreach (var context in configUI.context)
            {
                ResolveActionEventConfig(context.Value, configUI);
                context.Value.actionEventConfigResolved = true;
                context.Value.configUI = configUI;
            }
        }
        if (loaded)
        {
            _uiConfigs.Add(configUI);
        }
        else
        {
            SuperDebug.VeryImportantError("Load LoginPage Config Fail!", ErrorLevel.High, ErrorCategory.UI);
        }
        Singleton<InputManager>.Instance.UpdateJoypadChangeViewScale(joypadChangeViewScale);
    } // 0x0000000183148060-0x0000000183148790
      // [XID] // 0x0000000189B11F80-0x0000000189B11FA0
    public static void ReloadFromFile() { } // 0x0000000183147720-0x0000000183147C10
    [DebuggerHidden] // 0x0000000189B19290-0x0000000189B192D0
                     // [XID] // 0x0000000189B19290-0x0000000189B192D0
    public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC64E */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183148C50-0x0000000183148D90
                                                                                                                                                                                                  // [XID] // 0x0000000189B23C40-0x0000000189B23C60
    public static ConfigUI GetUIConfig(string contextName) => default; // 0x00000001831493F0-0x0000000183149650
                                                                       // [XID] // 0x0000000189B2AF20-0x0000000189B2AF40
    public static InputActionEvent[] GetGlobalActionGrp(string name) => default; // 0x00000001831472E0-0x0000000183147500
                                                                                 // [XID] // 0x0000000189B32500-0x0000000189B32520
    public static void GetContextConfig(string contextName, InputMode inputMode, out ConfigBaseContext configContext)
    {
        configContext = default;
    } // 0x0000000183148790-0x0000000183148C50
      // [XID] // 0x0000000189921190-0x00000001899211B0
    private static void ResolveGlobalActionEventConfig() { } // 0x0000000183147C10-0x0000000183147F50
                                                             // [IDTag] // 0x0000000189B416D0-0x0000000189B41710
                                                             // [XID] // 0x0000000189B416D0-0x0000000189B41710
    private static void ResolveActionEventConfig(ConfigBaseContext contextConfig, ConfigUI uiConfig) { } // 0x0000000183147080-0x00000001831472E0
                                                                                                         // [IDTag] // 0x0000000189B4C080-0x0000000189B4C0C0
                                                                                                         // [XID] // 0x0000000189B4C080-0x0000000189B4C0C0
    public static void ResolveActionEventConfig(List<InputActionEvent> list) { } // 0x0000000183146E10-0x0000000183147080
                                                                                 // [IDTag] // 0x0000000189B567B0-0x0000000189B567F0
                                                                                 // [XID] // 0x0000000189B567B0-0x0000000189B567F0
    public static void ResolveActionEventConfig(Dictionary<string, InputActionEvent[]> actionGroups, Dictionary<InputEventType, ConfigBaseInputEvent> localConfig, Dictionary<InputEventType, ConfigBaseInputEvent> globalConfig) { } // 0x0000000183146AE0-0x0000000183146E10
                                                                                                                                                                                                                                      // [XID] // 0x0000000189B60FB0-0x0000000189B60FD0
    public static ConfigBaseInputAction GetInputActionConfig(InputActionType actionType) => default; // 0x00000001831466D0-0x00000001831468C0
}

