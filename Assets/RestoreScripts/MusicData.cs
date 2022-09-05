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
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MusicData // TypeDefIndex: 19382
{
    // Fields
    private const string FINISH_CALLBACK_IDENTIFIER = "MusicData"; // Metadata: 0x00AFC7DE
    private static readonly ConfigMetaConfig.PathHash _minConditionsPathHash; // 0x00
    private static readonly ConfigMetaConfig.PathHash _minSongsPathHash; // 0x10
    private static readonly ConfigMetaConfig.PathHash _minMusicPathHash; // 0x20
    private static readonly ConfigMetaConfig.PathHash _fullMusicPathHash; // 0x30
    private static readonly Dictionary<int, ConfigMusicCondition> _conditions; // 0x40
    private static readonly Dictionary<int, ConfigSong> _songs; // 0x48

    // Properties
    public static ConfigMusic homeSceneMusicConfig { /* [XID] */ /* 0x000000018981EAA0-0x000000018981EAE0 */ get; /* [XID] */ /* 0x00000001898290E0-0x0000000189829120 */ private set; } // 0x0000000182C67B20-0x0000000182C67BB0 0x0000000182C67ED0-0x0000000182C67F60
    public static ConfigMusic gameSceneMusicConfig { /* [XID] */ /* 0x00000001898337A0-0x00000001898337E0 */ get; /* [XID] */ /* 0x000000018983DA60-0x000000018983DAA0 */ private set; } // 0x0000000182C680A0-0x0000000182C68130 0x0000000182C67E40-0x0000000182C67ED0

    // Nested types
    private class ConfigSongTransitionConditionAbstraction : ConfigObjectArrayAbstraction<ConfigMusicCondition> // TypeDefIndex: 19383
    {
        // Constructors
        public ConfigSongTransitionConditionAbstraction() { } // 0x0000000182C6FAE0-0x0000000182C6FB50

        // Methods
        // [XID] // 0x0000000189885F40-0x0000000189885F60
        public override int GetIdFromInstance(ConfigMusicCondition instance) => default; // 0x0000000182C6F830-0x0000000182C6F8F0
                                                                                         // [XID] // 0x000000018988D200-0x000000018988D220
        protected override void ListFromBinary(ByteArray bytes, out ConfigMusicCondition[] list)
        {
            list = default;
        } // 0x0000000182C6F8F0-0x0000000182C6F9F0
          // [XID] // 0x0000000189894850-0x0000000189894870
        protected override void ListFromJson(JSONNode json, out ConfigMusicCondition[] list)
        {
            list = default;
        } // 0x0000000182C6F9F0-0x0000000182C6FAE0
    }

    private class ConfigSongAbstraction : ConfigObjectArrayAbstraction<ConfigSong> // TypeDefIndex: 19384
    {
        // Constructors
        public ConfigSongAbstraction() { } // 0x0000000182C70100-0x0000000182C70170

        // Methods
        // [XID] // 0x000000018989BE20-0x000000018989BE40
        public override int GetIdFromInstance(ConfigSong instance) => default; // 0x0000000182C6FE50-0x0000000182C6FF10
                                                                               // [XID] // 0x00000001898A3400-0x00000001898A3420
        protected override void ListFromBinary(ByteArray bytes, out ConfigSong[] list)
        {
            list = default;
        } // 0x0000000182C6FF10-0x0000000182C70010
          // [XID] // 0x00000001898AA860-0x00000001898AA880
        protected override void ListFromJson(JSONNode json, out ConfigSong[] list)
        {
            list = default;
        } // 0x0000000182C70010-0x0000000182C70100
    }

    private class ConfigMusicAbstraction : ConfigObjectAbstraction<ConfigMusic> // TypeDefIndex: 19385
    {
        // Constructors
        public ConfigMusicAbstraction() { } // 0x0000000182C6FDE0-0x0000000182C6FE50

        // Methods
        // [XID] // 0x00000001898B2230-0x00000001898B2250
        protected override ConfigMusic CreateInstance() => default; // 0x0000000182C6FB50-0x0000000182C6FC10
                                                                    // [XID] // 0x00000001898B9F40-0x00000001898B9F60
        protected override bool FromBinary(ConfigMusic instance, ByteArray bytes) => default; // 0x0000000182C6FC10-0x0000000182C6FD00
                                                                                              // [XID] // 0x00000001898C1280-0x00000001898C12A0
        protected override bool FromJson(ConfigMusic instance, JSONNode json) => default; // 0x0000000182C6FD00-0x0000000182C6FDE0
    }

    // Constructors
    static MusicData() { } // 0x0000000182C68210-0x0000000182C68420

    // Methods
    // [XID] // 0x0000000189847F60-0x0000000189847F80
    public static void LoadEmbeddedConfig()
    {
        if (GlobalVars.musicSystem == GlobalVars.MusicSystem.Experimental)
        {
            var configSong1 = new ConfigSongTransitionConditionAbstraction();
            MusicData.DeserializeConfigArrayIntoDictionary(MusicData._minConditionsPathHash, MusicData._conditions, configSong1);
            var configSong2 = new ConfigSongAbstraction();
            MusicData.DeserializeConfigArrayIntoDictionary(MusicData._minSongsPathHash, MusicData._songs, configSong2);

            var configSong3 = new ConfigMusicAbstraction();
            MusicData.homeSceneMusicConfig = configSong3.DeserializeFromFile(_minMusicPathHash);
            MusicData.BuildGameParamMasks();
        }
    } // 0x0000000182C671D0-0x0000000182C673F0
      // [XID] // 0x000000018984F6A0-0x000000018984F6C0
    public static void ReloadFromFile() { } // 0x0000000182C67BB0-0x0000000182C67E40
    [DebuggerHidden] // 0x0000000189856860-0x00000001898568A0
                     // [XID] // 0x0000000189856860-0x00000001898568A0
    public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC7D6 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182C67F60-0x0000000182C680A0
                                                                                                                                                                                                  // [XID] // 0x0000000189860D10-0x0000000189860D30
    public static ConfigMusicCondition GetTransitionConditionById(int id) => default; // 0x0000000182C67890-0x0000000182C67970
                                                                                      // [XID] // 0x0000000189A7DD20-0x0000000189A7DD40
    public static ConfigSong GetSongById(int id) => default; // 0x0000000182C68130-0x0000000182C68210
    private static void DeserializeConfigArrayIntoDictionary<TConf>(ConfigMetaConfig.PathHash filePathHash, Dictionary<int, TConf> dictionary, IConfigObjectArrayAbstraction<TConf> abstraction) { }
    private static void DeserializeMultipleConfigArraysIntoDictionary<TConf>(ConfigMetaConfig.PathHash[] filePathHashes, Dictionary<int, TConf> dictionary, bool clearDictionary, IConfigObjectArrayAbstraction<TConf> abstraction) { }
    private static bool CheckPreloopRequisites<TConf>(ConfigMetaConfig.PathHash[] filePathHashes, Dictionary<int, TConf> dictionary, bool clearDictionary, IConfigObjectArrayAbstraction<TConf> abstraction) => default;
    private static int GetArrayLength<T>(T[] array) => default;
    // [XID] // 0x000000018986F9C0-0x000000018986F9E0
    private static void EarlyReturnAsync(float progressSpan = 0f /* Metadata: 0x00AFC7DA */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) { } // 0x0000000182C673F0-0x0000000182C674E0
                                                                                                                                                                                 // [XID] // 0x00000001898770B0-0x00000001898770D0
    private static void BuildGameParamMasks() { } // 0x0000000182C674E0-0x0000000182C67890
    private static T GetDictionaryValueById<T>(int id, Dictionary<int, T> dictionary) => default;
    // [XID] // 0x000000018987EAA0-0x000000018987EAC0
    private static bool Deserialize(out bool asBinary, ref ByteArray bytes, ref JSONNode json, ConfigMetaConfig.PathHash filePathHash)
    {
        asBinary = default;
        return default;
    } // 0x0000000182C67970-0x0000000182C67B20
}

