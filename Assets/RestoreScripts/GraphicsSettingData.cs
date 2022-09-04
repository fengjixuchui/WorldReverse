/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using SimpleJSON;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GraphicsSettingData // TypeDefIndex: 19236
{
    // Fields
    private static string DEFAULT_SETTING_NAME; // 0x00
    private static Dictionary<string, Dictionary<string, ConfigGraphicsRecommendSetting>> _recommendSettingGroupMap; // 0x08
    private static List<VolatileType> _candidateVolatiles; // 0x10
    private static Dictionary<string, ConfigPlatformGrahpicsSetting> _platformSettingsDic; // 0x18
    private static ConfigGlobalToken _globalToken; // 0x20
    private static SettingCache _cache; // 0x28
    private static Dictionary<GraphicsSettingEntryType, int> _volatileSettingEntry2gradeDic; // 0x80
    private static SaveData _saveData; // 0x88

    // Properties
    public static List<VolatileType> candidateVolatiles { /* [XID] */ /* 0x00000001896475F0-0x0000000189647610 */ get; } // 0x000000018265EFE0-0x000000018265F0B0 
    public static ConfigGlobalToken globalToken { /* [XID] */ /* 0x000000018967C1A0-0x000000018967C1C0 */ get; } // 0x0000000182668240-0x0000000182668310 
    public static ConfigPlatformGrahpicsSetting platformSetting { /* [XID] */ /* 0x00000001896836B0-0x00000001896836D0 */ get; /* [XID] */ /* 0x0000000189610DC0-0x0000000189610DE0 */ private set; } // 0x0000000182665D50-0x0000000182665E20 0x0000000182666410-0x00000001826664E0
    public static ConfigGraphicsRecommendSetting deviceSetting { /* [XID] */ /* 0x0000000189693080-0x00000001896930A0 */ get; /* [XID] */ /* 0x000000018969A290-0x000000018969A2B0 */ private set; } // 0x000000018265D190-0x000000018265D260 0x000000018265FFE0-0x00000001826600B0
    public static ConfigGraphicsVolatileSetting volatileSetting { /* [XID] */ /* 0x00000001896A1B60-0x00000001896A1B80 */ get; /* [XID] */ /* 0x00000001896A8F40-0x00000001896A8F60 */ private set; } // 0x0000000182664010-0x00000001826640E0 0x0000000182666B30-0x0000000182666C00
    public static ConfigPostprocessEffectSetting postprocessSetting { /* [XID] */ /* 0x00000001896B0110-0x00000001896B0130 */ get; /* [XID] */ /* 0x00000001896B7990-0x00000001896B79B0 */ private set; } // 0x0000000182668070-0x0000000182668140 0x0000000182662E70-0x0000000182662F40
    public static ConfigParticleEffectSetting particleEffectSetting { /* [XID] */ /* 0x00000001896BEA70-0x00000001896BEA90 */ get; /* [XID] */ /* 0x00000001896C6410-0x00000001896C6430 */ private set; } // 0x00000001826687E0-0x00000001826688B0 0x000000018265FF10-0x000000018265FFE0
    public static ConfigComprehensiveQualitySetting comprehensiveQualitySetting { /* [XID] */ /* 0x00000001896CDA30-0x00000001896CDA50 */ get; /* [XID] */ /* 0x00000001899D0E70-0x00000001899D0E90 */ private set; } // 0x0000000182660640-0x0000000182660710 0x000000018265D0C0-0x000000018265D190
    public static int defaultVolatileIndex { /* [XID] */ /* 0x00000001896DC600-0x00000001896DC620 */ get; /* [XID] */ /* 0x00000001896E3DB0-0x00000001896E3DD0 */ private set; } // 0x0000000182667420-0x00000001826674F0 0x000000018265EF10-0x000000018265EFE0
    public static int currentVolatileIndex { /* [XID] */ /* 0x00000001896EB1A0-0x00000001896EB1C0 */ get; /* [XID] */ /* 0x00000001896F2570-0x00000001896F2590 */ private set; } // 0x0000000182663920-0x00000001826639F0 0x000000018265E7A0-0x000000018265E870
    public static bool hasCustom { /* [XID] */ /* 0x00000001896F9EF0-0x00000001896F9F10 */ get; /* [XID] */ /* 0x00000001897015C0-0x00000001897015E0 */ private set; } // 0x000000018265CC00-0x000000018265CCD0 0x00000001826600B0-0x0000000182660180
    public static float terrainDistance { /* [XID] */ /* 0x0000000189708E00-0x0000000189708E20 */ get; } // 0x00000001826621E0-0x00000001826622F0 
    public static string platformSettingName { /* [XID] */ /* 0x0000000189722220-0x0000000189722260 */ get; /* [XID] */ /* 0x000000018972C9E0-0x000000018972CA20 */ private set; } // 0x0000000182668D00-0x0000000182668D90 0x000000018265F1C0-0x000000018265F250
    public static string deviceSettingName { /* [XID] */ /* 0x0000000189737440-0x0000000189737480 */ get; /* [XID] */ /* 0x0000000189741B80-0x0000000189741BC0 */ private set; } // 0x000000018265CB70-0x000000018265CC00 0x000000018265C9E0-0x000000018265CA70
    public static VolatileType volatileSettingName { /* [XID] */ /* 0x00000001897802A0-0x00000001897802E0 */ get; /* [XID] */ /* 0x000000018978AB00-0x000000018978AB40 */ private set; } // 0x000000018265E980-0x000000018265EA10 0x00000001826695C0-0x0000000182669650
    public static int targetFrameRate { /* [XID] */ /* 0x0000000189813FD0-0x0000000189813FF0 */ get; } // 0x0000000182667BD0-0x0000000182667F30 
    public static MotionBlurQuality motionBlurQuality { /* [XID] */ /* 0x000000018981BB60-0x000000018981BB80 */ get; } // 0x000000018265CA70-0x000000018265CB70 
    public static bool enableMotionBlur { /* [XID] */ /* 0x0000000189839480-0x00000001898394A0 */ get; } // 0x0000000182663F00-0x0000000182664010 
    public static AntialiasingMethod antialiasingMethod { /* [XID] */ /* 0x0000000189840AC0-0x0000000189840AE0 */ get; } // 0x0000000182667980-0x0000000182667B10 
    public static TAAQuality taaQuality { /* [XID] */ /* 0x0000000189847F80-0x0000000189847FA0 */ get; } // 0x00000001826674F0-0x00000001826675F0 
    public static SMAAQuality smaaQuality { /* [XID] */ /* 0x000000018984F6C0-0x000000018984F6E0 */ get; } // 0x0000000182660180-0x0000000182660280 
    public static int volumetricFogGrade { /* [XID] */ /* 0x00000001898568A0-0x00000001898568C0 */ get; } // 0x0000000182668310-0x0000000182668450 
    public static int reflectionGrade { /* [XID] */ /* 0x000000018985DB30-0x000000018985DB50 */ get; } // 0x0000000182666C00-0x0000000182666D00 
    public static int motionBlurGrade { /* [XID] */ /* 0x00000001898655F0-0x0000000189865610 */ get; } // 0x0000000182668140-0x0000000182668240 
    public static int bloomGrade { /* [XID] */ /* 0x000000018986CA90-0x000000018986CAB0 */ get; } // 0x0000000182660A90-0x0000000182660B90 
    public static int crowdDensityGrade { /* [XID] */ /* 0x0000000189873F40-0x0000000189873F60 */ get; } // 0x0000000182660710-0x0000000182660810 
    public static int sssGrade { /* [XID] */ /* 0x000000018987BA00-0x000000018987BA20 */ get; } // 0x0000000182667880-0x0000000182667980 
    public static OnlineEffectQuality onlineEffectQuality { /* [XID] */ /* 0x00000001898F8970-0x00000001898F8990 */ get; } // 0x0000000182660B90-0x0000000182660C90 
    public static float innerResolutionScale { /* [XID] */ /* 0x000000018988A2D0-0x000000018988A2F0 */ get; } // 0x000000018265CCD0-0x000000018265CFF0 
    public static bool textureStreamingEnabled { /* [XID] */ /* 0x00000001898A02B0-0x00000001898A02D0 */ get; } // 0x000000018265F0B0-0x000000018265F1C0 
    public static bool disableDoF { /* [XID] */ /* 0x00000001898A7A10-0x00000001898A7A30 */ get; } // 0x000000018265F4E0-0x000000018265F5F0 
    public static bool useMHYDepthOfField { /* [XID] */ /* 0x00000001898AF530-0x00000001898AF550 */ get; } // 0x000000018265F5F0-0x000000018265F690 
    public static bool subPassEnable { /* [XID] */ /* 0x00000001898B6990-0x00000001898B69B0 */ get; } // 0x000000018265EDF0-0x000000018265EF10 
    public static float textureStreamingBudget { /* [XID] */ /* 0x00000001898BE180-0x00000001898BE1A0 */ get; } // 0x00000001826675F0-0x00000001826677E0 
    public static bool enableCutsceneTextureStreaming { /* [XID] */ /* 0x00000001898C5A30-0x00000001898C5A50 */ get; } // 0x0000000182660E70-0x0000000182660F80 

    // Nested types
    private struct SettingCache // TypeDefIndex: 19237
    {
        // Fields
        public ConfigPlatformGrahpicsSetting platformSetting; // 0x00
        public ConfigGraphicsRecommendSetting deviceSetting; // 0x08
        public ConfigGraphicsVolatileSetting volatileSetting; // 0x10
        public ConfigPostprocessEffectSetting postprocessSetting; // 0x18
        public ConfigParticleEffectSetting particleEffectSetting; // 0x20
        public ConfigComprehensiveQualitySetting comprehensiveQualitySetting; // 0x28
        public bool hasCustom; // 0x30
        public int defaultVolatileIndex; // 0x34
        public int currentVolatileIndex; // 0x38
    }

    public enum OnlineEffectQuality // TypeDefIndex: 19238
    {
        High = 1,
        Middle = 2,
        Low = 3
    }

    [Serializable]
    private struct Pair // TypeDefIndex: 19239
    {
        // Fields
        public GraphicsSettingEntryType key; // 0x00
        public int value; // 0x04

        // Constructors
        public Pair(KeyValuePair<GraphicsSettingEntryType, int> pair)
        {
            key = default;
            value = default;
        } // 0x0000000182675D50-0x0000000182675D70
    }

    [Serializable]
    private class SaveData // TypeDefIndex: 19240
    {
        // Fields
        public int currentVolatielGrade; // 0x10
        public List<Pair> customVolatileGrades; // 0x18
        public string volatileVersion; // 0x20

        // Constructors
        public SaveData() { } // 0x0000000182675D70-0x0000000182675E10
    }

    // Constructors
    static GraphicsSettingData() { } // 0x0000000182669C20-0x0000000182669D70

    // Methods
    // [XID] // 0x0000000189629570-0x0000000189629590
    public static string GetTargetPlatform() => default; // 0x0000000182664450-0x00000001826644F0
                                                         // [XID] // 0x0000000189630EA0-0x0000000189630EC0
    private static void ReadConfigSettings() { } // 0x00000001826669A0-0x0000000182666A30
                                                 // [XID] // 0x0000000189638990-0x00000001896389B0
    public static string DumpSystemInfo() => default; // 0x000000018265D550-0x000000018265DBF0
                                                      // [XID] // 0x000000018963FD30-0x000000018963FD50
    public static string GetDeviceModel() => default; // 0x00000001826677E0-0x0000000182667880
                                                      // [XID] // 0x000000018964EC40-0x000000018964EC60
    public static string GetGraphicsDeviceName() => default; // 0x000000018265F370-0x000000018265F4E0
    public static bool Str2Enum<T>(string changeStr, ref T ans) => default;
    // [XID] // 0x00000001896564B0-0x00000001896564D0
    public static bool DeviceMatchRequirements(ConfigGraphicsRequirement[] requirements) => default; // 0x0000000182662F40-0x00000001826636D0
                                                                                                     // [XID] // 0x000000018965DC30-0x000000018965DC50
    private static string GetGraphicsRecommendConfig(string platformName, string deviceModel) => default; // 0x0000000182664DE0-0x0000000182665260
                                                                                                          // [XID] // 0x00000001896652B0-0x00000001896652D0
    public static ConfigPlatformGrahpicsSetting GetPlatformSetting(string platform) => default; // 0x0000000182667F30-0x0000000182668070
                                                                                                // [XID] // 0x000000018966CA60-0x000000018966CA80
    public static void GetPlatformNames(IList<string> list) { } // 0x0000000182661F70-0x00000001826621E0
                                                                // [XID] // 0x0000000189B45680-0x0000000189B456A0
    private static void Clear() { } // 0x0000000182660C90-0x0000000182660E70
                                    // [XID] // 0x00000001897106F0-0x0000000189710710
    public static void ReloadFromFile()
    {
        Clear();
        SuperDebug.Log("Start Reload Graphic Setting from File");
        string[] str = new string[5];
        str[0] = "Data/_BinOutput/GraphicsSetting/Android";
        str[1] = "Data/_BinOutput/GraphicsSetting/IOS";
        str[2] = "Data/_BinOutput/GraphicsSetting/PC";
        str[3] = "Data/_BinOutput/GraphicsSetting/PS4";
        str[4] = "Data/_BinOutput/GraphicsSetting/PS5";
        int i = 0;
        string platform = "";
        while (true)
        {
            if (i >= str.Length)
            {
                ResolveDeviceSetting();
                return;
            }
            var strList = str[i].Split('/');
            if (strList.Length >= 4)
            {
                platform = strList[3];
            }
            JSONNode setJson = null;
            if (platform != "")
            {
                string filePath = Application.persistentDataPath + "/GraphicsSetting/" + platform + ".json";
                string fileText = null;
                if (File.Exists(filePath))
                {
                    var file = File.ReadAllBytes(filePath);
                    fileText = Encoding.UTF8.GetString(file);
                }
                if (fileText != null)
                {
                    if (fileText != "") setJson = JSONNode.Parse(fileText);
                }
            }
            var configPlatformGrahpicsSetting = new ConfigPlatformGrahpicsSetting();
            if (setJson == null)
            {
                UnityEngine.Debug.Log("Persist Config Data Exist for {0}, use persist data" + platform);
                configPlatformGrahpicsSetting.FromJson(JsonTool.LoadJSONConfig(SerializationUtils.ToJsonPath(str[i])));
            }
            else
            {
                if (!InLevelData.loadInLevelFromBin)
                {
                    configPlatformGrahpicsSetting.FromJson(JsonTool.LoadJSONConfig(SerializationUtils.ToJsonPath(str[i])));
                }
                else
                {
                    configPlatformGrahpicsSetting.FromBinary(SerializationUtils.ReadPackedBin(str[i]));
                }
            }
            if (configPlatformGrahpicsSetting.deviceSettings != null)
            {
                if (configPlatformGrahpicsSetting.deviceSettings.Count > 0)
                {
                    _platformSettingsDic.Add(platform, configPlatformGrahpicsSetting);
                }
            }
            i++;
        }

    } // 0x00000001826616B0-0x0000000182661F70
    [DebuggerHidden] // 0x0000000189717AD0-0x0000000189717B10
                     // [XID] // 0x0000000189717AD0-0x0000000189717B10
    public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC62D */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182664CA0-0x0000000182664DE0
                                                                                                                                                                                                  // [XID] // 0x000000018974C5A0-0x000000018974C5C0
    private static void ResolveDeviceSetting() { } // 0x000000018265DBF0-0x000000018265E7A0
                                                   // [XID] // 0x00000001897537C0-0x00000001897537E0
    private static void VerifyDefaultSetting(ConfigGraphicsRecommendSetting defaultSet) { } // 0x000000018265F880-0x000000018265FE50
                                                                                            // [XID] // 0x0000000189662F20-0x0000000189662F40
    private static void MapTemplateSettingToDevice(ConfigGraphicsRecommendSetting templateSet, ConfigGraphicsRecommendSetting deviceSet) { } // 0x0000000182665F00-0x0000000182666410
                                                                                                                                             // [XID] // 0x00000001898A8620-0x00000001898A8640
    public static void RefreshPerformanceSetting() { } // 0x00000001826656C0-0x0000000182665D50
                                                       // [XID] // 0x0000000189769E10-0x0000000189769E30
    private static void RefreshGlobalTokenSetting() { } // 0x000000018265D470-0x000000018265D550
                                                        // [XID] // 0x0000000189771530-0x0000000189771550
    public static void TestDeviceSetting(string platform, string device) { } // 0x00000001826644F0-0x0000000182664910
                                                                             // [XID] // 0x0000000189778D00-0x0000000189778D20
    private static void RefreshCandidateVolatiles() { } // 0x0000000182666D00-0x0000000182667420
                                                        // [XID] // 0x0000000189795000-0x0000000189795020
    public static void ChangeVolatile(VolatileType level) { } // 0x000000018265CFF0-0x000000018265D0C0
                                                              // [XID] // 0x000000018979D430-0x000000018979D450
    public static void ChangeToVolatileGrade(int index) { } // 0x000000018265F250-0x000000018265F370
                                                            // [XID] // 0x00000001897A4710-0x00000001897A4730
    public static void ChangeToCustomVolatile() { } // 0x0000000182667B10-0x0000000182667BD0
                                                    // [IDTag] // 0x00000001897ABBA0-0x00000001897ABBE0
                                                    // [XID] // 0x00000001897ABBA0-0x00000001897ABBE0
    private static void SetVolatile(VolatileType level, bool candidateOnly = true /* Metadata: 0x00AFC631 */) { } // 0x0000000182669650-0x0000000182669A10
                                                                                                                  // [IDTag] // 0x00000001897B6DF0-0x00000001897B6E30
                                                                                                                  // [XID] // 0x00000001897B6DF0-0x00000001897B6E30
    private static bool SetVolatile(int index) => default; // 0x0000000182669A10-0x0000000182669C20
                                                           // [XID] // 0x00000001897C19B0-0x00000001897C19D0
    private static void LoadVolatileGrade(ConfigGraphicsVolatileSetting setting) { } // 0x00000001826639F0-0x0000000182663F00
                                                                                     // [XID] // 0x00000001897C9380-0x00000001897C93A0
    private static void LoadCustomVolatile() { } // 0x0000000182660810-0x0000000182660A90
                                                 // [XID] // 0x00000001897D09B0-0x00000001897D09D0
    private static void EvaluateAfterSetVolatile() { } // 0x0000000182666A30-0x0000000182666B30
                                                       // [XID] // 0x00000001897D8750-0x00000001897D8770
    private static void TryOverrideResolutionSetting() { } // 0x0000000182668450-0x00000001826687E0
                                                           // [XID] // 0x00000001897DF830-0x00000001897DF850
    private static void EvaluateVolatileSettingEntryGrade() { } // 0x000000018265EA10-0x000000018265EDF0
                                                                // [XID] // 0x0000000189B423F0-0x0000000189B42410
    private static uint GetConfigGrade(ConfigGraphicsVolatileSetting volatileSetting, GraphicsSettingEntryType entryType) => default; // 0x000000018265F690-0x000000018265F880
                                                                                                                                      // [XID] // 0x00000001897EECF0-0x00000001897EED10
    public static void UpdateCustomVolatile(GraphicsSettingEntryType entryType, int grade) { } // 0x00000001826664E0-0x00000001826669A0
                                                                                               // [XID] // 0x00000001897F63A0-0x00000001897F63C0
    public static void ApplySettingConfig() { } // 0x0000000182665E20-0x0000000182665F00
                                                // [XID] // 0x00000001897FDA80-0x00000001897FDAA0
    public static void ApplyCameraSettingConfig(StageType stageType = StageType.World /* Metadata: 0x00AFC632 */) { } // 0x000000018265D260-0x000000018265D470
                                                                                                                      // [XID] // 0x0000000189805270-0x0000000189805290
    public static void Reset() { } // 0x000000018265FE50-0x000000018265FF10
                                   // [XID] // 0x000000018980C7F0-0x000000018980C810
    public static bool IsEnableGyroscope() => default; // 0x0000000182665260-0x0000000182665300
                                                       // [XID] // 0x0000000189822FB0-0x0000000189822FD0
    private static ConfigPostprocessEffectSetting EvaluatePostprocessSetting() => default; // 0x0000000182664910-0x0000000182664CA0
                                                                                           // [XID] // 0x000000018982A9D0-0x000000018982A9F0
    private static ConfigParticleEffectSetting EvaluateParticleEffectSetting() => default; // 0x0000000182665300-0x00000001826656C0
                                                                                           // [XID] // 0x0000000189831E50-0x0000000189831E70
    private static ConfigComprehensiveQualitySetting EvaluateComprehensiveQualitySetting() => default; // 0x0000000182660280-0x0000000182660640
                                                                                                       // [XID] // 0x0000000189891760-0x0000000189891780
    public static bool TryGetRenderResolution(out ConfigRenderResolution result)
    {
        result = default;
        return default;
    } // 0x0000000182669100-0x00000001826695C0
      // [XID] // 0x00000001898990D0-0x00000001898990F0
    public static bool TryGetShadowQuality(out ShadowQuality shadowQuality)
    {
        shadowQuality = default;
        return default;
    } // 0x0000000182668D90-0x0000000182669100
      // [XID] // 0x0000000189994B60-0x0000000189994B80
    public static int GetVolatileSettingEntryGrade(GraphicsSettingEntryType entryType) => default; // 0x00000001826640E0-0x0000000182664450
                                                                                                   // [XID] // 0x00000001898D4A70-0x00000001898D4A90
    private static void ApplyQualityLevel() { } // 0x00000001826636D0-0x0000000182663920
                                                // [XID] // 0x00000001898DC490-0x00000001898DC4B0
    private static float GetPerfRatioSafe(SimpleSafeFloat[] costRatioGrade, int gradeIndex) => default; // 0x000000018265E870-0x000000018265E980
                                                                                                        // [XID] // 0x00000001898E3EE0-0x00000001898E3F00
    public static float GetDefaultPerfCost() => default; // 0x0000000182660F80-0x00000001826616B0
                                                         // [XID] // 0x00000001898EB9F0-0x00000001898EBA10
    public static float GetCurrentPerfCost(out PerfCostRatioGrade perfGrade, out float minCost, out float maxCost)
    {
        perfGrade = default;
        minCost = default;
        maxCost = default;
        return default;
    } // 0x0000000182662590-0x0000000182662B10
      // [XID] // 0x00000001898F31A0-0x00000001898F31C0
    public static PerfCostRatioGrade GetPerfCostGrade(float currentCost, out float minCost, out float maxCost)
    {
        minCost = default;
        maxCost = default;
        return default;
    } // 0x0000000182662B10-0x0000000182662E70
      // [XID] // 0x00000001898FA860-0x00000001898FA880
    private static void LoadSaveData() { } // 0x00000001826622F0-0x0000000182662590
                                           // [XID] // 0x0000000189902460-0x0000000189902480
    public static void UploadSaveData() { } // 0x00000001826688B0-0x0000000182668D00
}

