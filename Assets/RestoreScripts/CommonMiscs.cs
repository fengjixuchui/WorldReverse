/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using SimpleJSON;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public static class CommonMiscs // TypeDefIndex: 10528
    {
        // Fields
        public const string COMBAT_NO_TURN_ZONE = "CombatNoTurn"; // Metadata: 0x00AE7764
        public const float VERY_BIG_FLOAT = 100000000f; // Metadata: 0x00AE7774
        public const float EPSILON = 0.0001f; // Metadata: 0x00AE7778
        public const float QUATERNION_EQUAL_THRESHOLD = 0.1f; // Metadata: 0x00AE777C
        private static Dictionary<string, string> _extensionMap; // 0x00
        private static BinDataReceiver.ResultHandler _preloadLuaCallBack; // 0x08
        private static Stopwatch _gStopWatch; // 0x10
        private static double millisecondsOverTick; // 0x18
        public static Action<string, float> onSyncLoadObject; // 0x20
        public static Action<string, float> onAsyncLoadObject; // 0x28
        public static Action<string, float> onSyncLoadEffect; // 0x30
        public static Action<string, float> onAsyncLoadEffect; // 0x38
        public static Action<string, float> onEffectSetActive; // 0x40
        public static Action<string, float> onSetMomorySize; // 0x48
        public static Action<string, Vector3, float> onEffectInit; // 0x50
        public const string BUNDLE_DIRECTORY_NAME = "SRes"; // Metadata: 0x00AE7780
        public const string MOLERES_DIRECTORY_NAME = "MoleRes"; // Metadata: 0x00AE7788
        public const string RELEASE_DIRECTORY_NAME = "Rel"; // Metadata: 0x00AE7793
        public const string ASSET_DIRECTORY_NAME = "Assets"; // Metadata: 0x00AE779A
        public const string RESOURCE_DIRECTORY_NAME = "Resources"; // Metadata: 0x00AE77A4
        private static Dictionary<string, int> _objPath2Count; // 0x58
        private static Dictionary<string, uint> _objPath2Handler; // 0x60
        private static Dictionary<string, UnityEngine.Object> _objPath2Prefab; // 0x68
        private static Dictionary<ulong, int> _objPathHash2Count; // 0x70
        private static Dictionary<ulong, uint> _objPathHash2Handler; // 0x78
        private static Dictionary<ulong, UnityEngine.Object> _objPathHash2Prefab; // 0x80
        private static Dictionary<ulong, byte[]> _luaCache; // 0x88
        private static Dictionary<ulong, byte[]> _luaEternalCache; // 0x90
        private static HashSet<ulong> _requiredLuaFiles; // 0x98
        private static IDictionary<string, string> _obfusTranslationDict; // 0xA0
        private static IDictionary<string, string> _nameObfuscateSet; // 0xA8
        private static readonly char[] translationSeparator; // 0xB0

        // Properties
        public static long CycleTicks { /* [XID] */ /* 0x0000000189B8F900-0x0000000189B8F920 */ get; } // 0x00000001858F4DA0-0x00000001858F4E80 
        private static StringComparer stringComparer { /* [XID] */ /* 0x00000001899C65E0-0x00000001899C6600 */ get; } // 0x00000001858F5020-0x00000001858F50E0 
        public static IDictionary<string, string> obfusTranslationDict { /* [XID] */ /* 0x000000018971BB50-0x000000018971BB70 */ get; } // 0x00000001858F4F50-0x00000001858F5020 
        public static IDictionary<string, string> nameObfuscateSet { /* [XID] */ /* 0x0000000189AA7930-0x0000000189AA7950 */ get; } // 0x00000001858F4E80-0x00000001858F4F50 

        // Nested types
        public struct ScopeSyncLoadSampler : IDisposable // TypeDefIndex: 10529
        {
            // Fields
            private string _prefabPath; // 0x00
            private long _cycleTicks; // 0x08

            // Constructors
            public ScopeSyncLoadSampler(string prefabPath)
            {
                _prefabPath = default;
                _cycleTicks = default;
            } // 0x00000001858FB130-0x00000001858FB1A0

            // Methods
            // [XID] // 0x0000000189919A80-0x0000000189919AA0
            public void Dispose() { } // 0x00000001858FB090-0x00000001858FB130
        }

        // Constructors
        static CommonMiscs() { } // 0x00000001858F4930-0x00000001858F4DA0

        // Methods
        // [IDTag] // 0x0000000189AA1800-0x0000000189AA1840
        // [XID] // 0x0000000189AA1800-0x0000000189AA1840
        public static byte[] LoadBinData(ulong pathHash, int offset = 0 /* Metadata: 0x00AE7711 */, int length = 0 /* Metadata: 0x00AE7715 */)
        {
            return MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().LoadBinData(pathHash, offset, length);
        }// 0x00000001858E3110-0x00000001858E3210
         // [IDTag] // 0x0000000189AAC1F0-0x0000000189AAC230
         // [XID] // 0x0000000189AAC1F0-0x0000000189AAC230
        public static byte[] LoadLua(ulong pathHash, out bool recycleBytes, int offset = 0 /* Metadata: 0x00AE7719 */, int length = 0 /* Metadata: 0x00AE771D */)
        {
            recycleBytes = default;
            return default;
        } // 0x00000001858F1DA0-0x00000001858F2010
          // [IDTag] // 0x0000000189AB6BD0-0x0000000189AB6C10
          // [XID] // 0x0000000189AB6BD0-0x0000000189AB6C10
        public static byte[] LoadLua(string assetPathInResource) => default; // 0x00000001858F2010-0x00000001858F2100
                                                                             // [XID] // 0x0000000189888040-0x0000000189888060
        public static void UnrequireLua(string assetPathInResource) { } // 0x00000001858F4760-0x00000001858F4860
                                                                        // [XID] // 0x0000000189896B40-0x0000000189896B60
        public static bool IsLuaRequired(ulong pathHash) => default; // 0x00000001858E25A0-0x00000001858E2690
                                                                     // [XID] // 0x0000000189AC83D0-0x0000000189AC83F0
        public static void PreloadLuaBytes(ulong pathHash) { } // 0x00000001858F33A0-0x00000001858F34E0
                                                               // [XID] // 0x0000000189AD8270-0x0000000189AD8290
        public static void PreloadLuaCallBack(ulong pathHash, bool success, byte[] bytes) { } // 0x00000001858F34E0-0x00000001858F3600
        public static T LoadExternal<T>(ulong pathHash, out uint resourceHandle)
            where T : UnityEngine.Object
        {
            resourceHandle = default;
            return default;
        }
        public static void LoadExternalAsync<T>(ulong pathHash, UniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object
        { }
        public static void LoadExternalAsync<T>(ulong pathHash, AssetJobPriority priority, UniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object
        { }
        public static AsyncJob LoadExternalAsyncWithJob<T>(ulong pathHash, ComplexUniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        public static AsyncJob LoadExternalAsyncWithJob<T>(ulong pathHash, AssetJobPriority priority, ComplexUniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        // [XID] // 0x000000018989DF50-0x000000018989DF70
        public static void LoadBinDataAsync(ulong pathHash, AssetJobPriority priority, BinDataReceiver.ResultHandler onResult, int offset = 0 /* Metadata: 0x00AE7721 */, int length = 0 /* Metadata: 0x00AE7725 */) { } // 0x00000001858E2F80-0x00000001858E3110
                                                                                                                                                                                                                         // [IDTag] // 0x0000000189AE7540-0x0000000189AE7580
                                                                                                                                                                                                                         // [XID] // 0x0000000189AE7540-0x0000000189AE7580
        public static AsyncJob LoadPrefabAsync(ulong pathHash, AssetJobPriority priority, UniHandlerAssetReceiver<GameObject> onResult, uint handle = 0 /* Metadata: 0x00AE7729 */) => default; // 0x00000001858F24E0-0x00000001858F26C0
                                                                                                                                                                                                // [IDTag] // 0x0000000189AF1EF0-0x0000000189AF1F30
                                                                                                                                                                                                // [XID] // 0x0000000189AF1EF0-0x0000000189AF1F30
        public static GameObject LoadPrefab(ulong pathHash, ref uint handle) => default; // 0x00000001858F28A0-0x00000001858F2980
                                                                                         // [XID] // 0x00000001898D9F10-0x00000001898D9F30
        public static bool QuaternionEqual(Quaternion a, Quaternion b) => default; // 0x00000001858F3600-0x00000001858F37E0
                                                                                   // [XID] // 0x0000000189B03CF0-0x0000000189B03D10
        public static bool IsFloatEqual(float f1, float f2) => default; // 0x00000001858E23D0-0x00000001858E24C0
                                                                        // [IDTag] // 0x0000000189B0B360-0x0000000189B0B3A0
                                                                        // [XID] // 0x0000000189B0B360-0x0000000189B0B3A0
        public static bool IsAlmostZero(float f, float epsilon = 0.0001f /* Metadata: 0x00AE772D */) => default; // 0x00000001858E2300-0x00000001858E23D0
                                                                                                                 // [IDTag] // 0x0000000189B15610-0x0000000189B15650
                                                                                                                 // [XID] // 0x0000000189B15610-0x0000000189B15650
        public static bool IsAlmostZero(double f, double epsilon = 9.999999747378752E-05 /* Metadata: 0x00AE7731 */) => default; // 0x00000001858E20B0-0x00000001858E2180
                                                                                                                                 // [IDTag] // 0x0000000189B1FF30-0x0000000189B1FF70
                                                                                                                                 // [XID] // 0x0000000189B1FF30-0x0000000189B1FF70
        public static bool IsAlmostZero(Vector3 vector, float epsilon = 0.0001f /* Metadata: 0x00AE7739 */) => default; // 0x00000001858E2180-0x00000001858E2300
                                                                                                                        // [XID] // 0x00000001898E9830-0x00000001898E9850
        public static bool IsNaN(Vector3 v) => default; // 0x00000001858E2690-0x00000001858E2780
                                                        // [XID] // 0x00000001898F8720-0x00000001898F8740
        public static bool IsAlmostIdentity(Quaternion quaternion) => default; // 0x00000001858E1F80-0x00000001858E20B0
                                                                               // [XID] // 0x0000000189B38F70-0x0000000189B38F90
        public static bool IsAlmostIdentical(Quaternion a, Quaternion b) => default; // 0x00000001858E1DE0-0x00000001858E1F80
                                                                                     // [XID] // 0x0000000189B40B50-0x0000000189B40B70
        public static void ChangeValueFromTo(ref float input, float target, float range) { } // 0x00000001858DED80-0x00000001858DEE70
                                                                                             // [XID] // 0x0000000189B48390-0x0000000189B483B0
        public static Vector3 SafeXZForwardRotateTowards(Vector3 a, Vector3 b, float maxRadiansDelta) => default; // 0x00000001858F39C0-0x00000001858F3DE0
                                                                                                                  // [XID] // 0x0000000189916880-0x00000001899168A0
        public static float ClampAngle(float angle, float min, float max, bool add) => default; // 0x00000001858DEE70-0x00000001858DF000
                                                                                                // [IDTag] // 0x0000000189B572A0-0x0000000189B572E0
                                                                                                // [XID] // 0x0000000189B572A0-0x0000000189B572E0
        public static string LoadTextFileToString(string filePath, bool noError = false /* Metadata: 0x00AE773D */) => default; // 0x00000001858F2F90-0x00000001858F31C0
                                                                                                                                // [XID] // 0x0000000189B61860-0x0000000189B61880
        public static void LoadTextFileToStringAsync(string filePath, Action<string> callback, bool noError = false /* Metadata: 0x00AE773E */) { } // 0x00000001858F2A60-0x00000001858F2C00
                                                                                                                                                    // [XID] // 0x000000018996B850-0x000000018996B870
        public static string LoadLuaFileToString(string filePath, bool noError = false /* Metadata: 0x00AE773F */) => default; // 0x00000001858F1AD0-0x00000001858F1DA0
                                                                                                                               // [IDTag] // 0x0000000189B708F0-0x0000000189B70930
                                                                                                                               // [XID] // 0x0000000189B708F0-0x0000000189B70930
        public static string LoadTextFileToString(ulong filePathHash, bool noError = false /* Metadata: 0x00AE7740 */) => default; // 0x00000001858F2C00-0x00000001858F2E50
        [DebuggerHidden] // 0x0000000189B7ACB0-0x0000000189B7AD00
                         // [IDTag] // 0x0000000189B7ACB0-0x0000000189B7AD00
                         // [XID] // 0x0000000189B7ACB0-0x0000000189B7AD00
        public static IEnumerator LoadTextFileToString(string filePath, Action<string, string, Action<JSONNode>> loadTextFinishCallback, Action<JSONNode> loadJsonFinishCallback) => default; // 0x00000001858F2E50-0x00000001858F2F90
                                                                                                                                                                                              // [XID] // 0x00000001899342E0-0x0000000189934300
        public static void LoadExternalScene(string path, out uint resourceHandle)
        {
            resourceHandle = default;
        } // 0x00000001858EEAC0-0x00000001858EEB90
          // [XID] // 0x0000000189B96E40-0x0000000189B96E60
        public static double GetDeltaMilliseconds(long inStartTick) => default; // 0x00000001858E0B30-0x00000001858E0C20
                                                                                // [XID] // 0x0000000189B9E2B0-0x0000000189B9E2D0
        public static double GetDeltaSeconds(long inStartTick) => default; // 0x00000001858E0C20-0x00000001858E0D00
        public static T LoadExternal<T>(string path, out uint resourceHandle)
            where T : UnityEngine.Object
        {
            resourceHandle = default;
            return default;
        }
        // [IDTag] // 0x0000000189BA5C50-0x0000000189BA5C90
        // [XID] // 0x0000000189BA5C50-0x0000000189BA5C90
        public static byte[] LoadBinData(string assetPathInResource)
        {
            var pathHash = GetAssetPathHash(assetPathInResource);
            return LoadBinData(pathHash);
        }// 0x00000001858E3210-0x00000001858E3300
        public static T LoadIndependentResource<T>(string path, out uint resourceHandle)
            where T : UnityEngine.Object
        {
            resourceHandle = default;
            return default;
        }
        public static T LoadIndependentResource<T>(ulong hash, out uint resourceHandle)
            where T : UnityEngine.Object
        {
            resourceHandle = default;
            return default;
        }
        public static T[] LoadAllExternal<T>(ulong[] hashes, out uint[] handles)
            where T : UnityEngine.Object
        {
            handles = default;
            return default;
        }
        public static AsyncJob LoadExternalAsyncByIndex<T>(string path, int index, AssetJobPriority priority, IndexAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        public static AsyncJob LoadExternalAsyncByIndex<T>(ulong path, int index, AssetJobPriority priority, IndexAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        // [IDTag] // 0x0000000189BAFCC0-0x0000000189BAFD00
        // [XID] // 0x0000000189BAFCC0-0x0000000189BAFD00
        public static AsyncJob LoadPrefabAsyncByIndex(string path, int index, AssetJobPriority priority, IndexAssetReceiver<GameObject> onResult, uint handle = 0 /* Metadata: 0x00AE7741 */) => default; // 0x00000001858F2100-0x00000001858F22F0
                                                                                                                                                                                                          // [IDTag] // 0x0000000189BBA380-0x0000000189BBA3C0
                                                                                                                                                                                                          // [XID] // 0x0000000189BBA380-0x0000000189BBA3C0
        public static AsyncJob LoadPrefabAsyncByIndex(ulong path, int index, AssetJobPriority priority, IndexAssetReceiver<GameObject> onResult, uint handle = 0 /* Metadata: 0x00AE7745 */) => default; // 0x00000001858F22F0-0x00000001858F24E0
                                                                                                                                                                                                         // [IDTag] // 0x0000000189BC5040-0x0000000189BC5080
                                                                                                                                                                                                         // [XID] // 0x0000000189BC5040-0x0000000189BC5080
        public static AsyncJob LoadBinAsyncByIndex(string path, int index, AssetJobPriority priority, IndexBinDataReceiver.IndexResultHandler onResult, int offset = 0 /* Metadata: 0x00AE7749 */, int length = 0 /* Metadata: 0x00AE774D */) => default; // 0x00000001858E2AA0-0x00000001858E2D10
                                                                                                                                                                                                                                                          // [IDTag] // 0x0000000189BCFA10-0x0000000189BCFA50
                                                                                                                                                                                                                                                          // [XID] // 0x0000000189BCFA10-0x0000000189BCFA50
        public static AsyncJob LoadBinAsyncByIndex(ulong hash, int index, AssetJobPriority priority, IndexBinDataReceiver.IndexResultHandler onResult, int offset = 0 /* Metadata: 0x00AE7751 */, int length = 0 /* Metadata: 0x00AE7755 */) => default; // 0x00000001858E2D10-0x00000001858E2F80
        public static AssetReceiver<T> LoadExternalAsync<T>(string path)
            where T : UnityEngine.Object => default;
        public static AssetReceiver<T> LoadExternalAsync<T>(string path, AssetJobPriority priority)
            where T : UnityEngine.Object => default;
        public static void LoadExternalAsync<T>(string path, UniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object
        { }
        public static void LoadExternalAsync<T>(string path, AssetJobPriority priority, UniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object
        { }
        public static AsyncJob LoadExternalAsyncWithJob<T>(string path, ComplexUniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        public static AsyncJob LoadExternalAsyncWithJob<T>(string path, AssetJobPriority priority, ComplexUniHandlerAssetReceiver<T> onResult)
            where T : UnityEngine.Object => default;
        // [IDTag] // 0x0000000189BD9F90-0x0000000189BD9FD0
        // [XID] // 0x0000000189BD9F90-0x0000000189BD9FD0
        public static AsyncJob LoadPrefabAsync(string path, AssetJobPriority priority, UniHandlerAssetReceiver<GameObject> onResult, uint handle = 0 /* Metadata: 0x00AE7759 */) => default; // 0x00000001858F26C0-0x00000001858F28A0
                                                                                                                                                                                             // [IDTag] // 0x00000001895E9CA0-0x00000001895E9CE0
                                                                                                                                                                                             // [XID] // 0x00000001895E9CA0-0x00000001895E9CE0
        public static GameObject LoadPrefab(string path, ref uint handle) => default; // 0x00000001858F2980-0x00000001858F2A60
        public static bool CheckPathExists<T>(string path, out ulong hash)
        {
            hash = default;
            return default;
        }
        public static bool CheckHashExists<T>(ulong hash) => default;
        // [XID] // 0x00000001895F4450-0x00000001895F4470
        public static void DestroyPrefab(uint handle, GameObject g, bool usepool = true /* Metadata: 0x00AE775D */, bool deActive = true /* Metadata: 0x00AE775E */) { } // 0x00000001858DF930-0x00000001858DFA70
        public static void LoadExternalAsync<T>(string path, DualHandlerAssetReceiver<T> onFailure, DualHandlerAssetReceiver<T> onSuccess)
            where T : UnityEngine.Object
        { }
        public static void LoadExternalAsync<T>(string path, AssetJobPriority priority, DualHandlerAssetReceiver<T> onFailure, DualHandlerAssetReceiver<T> onSuccess)
            where T : UnityEngine.Object
        { }
        // [XID] // 0x00000001895FBBE0-0x00000001895FBC00
        public static void DismissExternal(uint resourceHandle, bool async = true /* Metadata: 0x00AE775F */) { } // 0x00000001858DFD00-0x00000001858DFDD0
                                                                                                                  // [XID] // 0x00000001896034A0-0x00000001896034C0
        public static ulong GetAssetShortPathHash(string path) => default; // 0x00000001858E0510-0x00000001858E0680
                                                                           // [XID] // 0x00000001899BEB80-0x00000001899BEBA0
        public static string HashToPath(ulong hash) => default; // 0x00000001858E12F0-0x00000001858E13B0
                                                                // [XID] // 0x0000000189619C30-0x0000000189619C50
        public static string CutResourceRelativePath(string path) => default; // 0x00000001858DF620-0x00000001858DF930
                                                                              // [XID] // 0x0000000189621070-0x0000000189621090
        public static int GetBlockID(string str) => default; // 0x00000001858E0750-0x00000001858E0820
                                                             // [IDTag] // 0x0000000189628860-0x00000001896288A0
                                                             // [XID] // 0x0000000189628860-0x00000001896288A0
        public static ulong GetAssetPathHash(string path, int length = 5 /* Metadata: 0x00AE7760 */)
        {
            //自定义引擎代码
            //return Application.MiHoYoGetAssetPathHash(path, length);
            return 0;
        }// 0x00000001858E02F0-0x00000001858E03B0
         // [IDTag] // 0x0000000189633110-0x0000000189633150
         // [XID] // 0x0000000189633110-0x0000000189633150
        public static ulong GetAssetPathHash(string path, string extention) => default; // 0x00000001858E03B0-0x00000001858E0510
        public static ulong GetAssetPathHash<T>(string path)
            where T : UnityEngine.Object => default;
        // [XID] // 0x000000018963DB90-0x000000018963DBB0
        public static void ClearObject() { } // 0x00000001858DF0E0-0x00000001858DF300
        public static void LoadObjectByPathAsync<T>(string path, Action<T> onResult)
            where T : UnityEngine.Object
        { }
        // [XID] // 0x0000000189A09470-0x0000000189A09490
        public static GameObject LoadIndependentObject(string path, out uint handler)
        {
            handler = default;
            return default;
        } // 0x00000001858F19F0-0x00000001858F1AD0
        public static T LoadObjectByPath<T>(string path)
            where T : UnityEngine.Object => default;
        // [IDTag] // 0x000000018964CC20-0x000000018964CC60
        // [XID] // 0x000000018964CC20-0x000000018964CC60
        public static void DismissObjectByPath(string path) { } // 0x00000001858E0060-0x00000001858E02F0
        public static void LoadObjectByPathAsync<T>(ulong pathHash, Action<T> onResult)
            where T : UnityEngine.Object
        { }
        public static T LoadObjectByPath<T>(ulong pathHash)
            where T : UnityEngine.Object => default;
        // [IDTag] // 0x00000001896571E0-0x0000000189657220
        // [XID] // 0x00000001896571E0-0x0000000189657220
        public static void DismissObjectByPath(ulong pathHash) { } // 0x00000001858DFDD0-0x00000001858E0060
                                                                   // [XID] // 0x0000000189661640-0x0000000189661660
        public static void SetLuaCache(ulong hash, byte[] b) { } // 0x00000001858F3DE0-0x00000001858F3EE0
                                                                 // [XID] // 0x0000000189669270-0x0000000189669290
        public static void RemoveLuaCache(ulong hash) { } // 0x00000001858F37E0-0x00000001858F38D0
                                                          // [XID] // 0x0000000189A2E000-0x0000000189A2E020
        public static void AddLuaEternalCache(ulong hash, byte[] b) { } // 0x00000001858DE8E0-0x00000001858DE9E0
                                                                        // [XID] // 0x0000000189678470-0x0000000189678490
        public static void RemoveLuaEternalCache(ulong hash) { } // 0x00000001858F38D0-0x00000001858F39C0
                                                                 // [XID] // 0x000000018967FD50-0x000000018967FD70
        public static void ClearLuaEternalCache() { } // 0x00000001858DF000-0x00000001858DF0E0
                                                      // [XID] // 0x0000000189871830-0x0000000189871850
        public static string GetTransformPath(Transform trans) => default; // 0x00000001858E10D0-0x00000001858E12F0
                                                                           // [XID] // 0x00000001898B6970-0x00000001898B6990
        public static void ChangeString(string s, string value, int offset) { } // 0x00000001858DEC20-0x00000001858DED80
        public static void Swap<T>(ref T lhs, ref T rhs) { }
        // [XID] // 0x0000000189A18BD0-0x0000000189A18BF0
        public static Vector3 DirectionRotateRyAngleRandom(Vector3 direction, float angle) => default; // 0x00000001858DFA70-0x00000001858DFD00
                                                                                                       // [XID] // 0x000000018969E1A0-0x000000018969E1C0
        public static bool IsPositonInConvexPolygon(Vector3 position, Vector3[] vertices) => default; // 0x00000001858E2780-0x00000001858E2AA0
                                                                                                      // [XID] // 0x00000001896A52D0-0x00000001896A52F0
        public static float XProduct2(Vector2 a, Vector2 b) => default; // 0x00000001858F4860-0x00000001858F4930
                                                                        // [XID] // 0x0000000189966830-0x0000000189966850
        public static Vector3 ClosestPointOnLine(Vector3 start, Vector3 end, Vector3 point) => default; // 0x00000001858DF300-0x00000001858DF620
        public static bool ArrayContains<T>(T[] array, T element) => default;
        // [XID] // 0x00000001896B3E50-0x00000001896B3E70
        public static string GetBaseName(string path) => default; // 0x00000001858E0680-0x00000001858E0750
                                                                  // [XID] // 0x00000001896C26E0-0x00000001896C2700
        public static bool IsFloatInRange(float value, float lower, float upper) => default; // 0x00000001858E24C0-0x00000001858E25A0
                                                                                             // [XID] // 0x0000000189A3CF50-0x0000000189A3CF70
        public static int CeilPowerOfTwo(int value) => default; // 0x00000001858DEB40-0x00000001858DEC20
                                                                // [XID] // 0x00000001896D1420-0x00000001896D1440
        public static int MostSignificantBitOf(int value) => default; // 0x00000001858F31C0-0x00000001858F32B0
                                                                      // [XID] // 0x00000001896D8B70-0x00000001896D8B90
        public static void AssureDirectoryExists(string directoryPath) { } // 0x00000001858DE9E0-0x00000001858DEB40
        public static void ArrayAppend<T>(ref T[] array, T element) { }
        // [IDTag] // 0x00000001896EA780-0x00000001896EA7C0
        // [XID] // 0x00000001896EA780-0x00000001896EA7C0
        public static void GetBytes(float value, byte[] output) { } // 0x00000001858E0820-0x00000001858E08F0
                                                                    // [IDTag] // 0x00000001896F4E00-0x00000001896F4E40
                                                                    // [XID] // 0x00000001896F4E00-0x00000001896F4E40
        public static void GetBytes(ushort value, byte[] output) { } // 0x00000001858E08F0-0x00000001858E09B0
                                                                     // [IDTag] // 0x00000001896FF5D0-0x00000001896FF610
                                                                     // [XID] // 0x00000001896FF5D0-0x00000001896FF610
        public static void GetBytes(uint value, byte[] output) { } // 0x00000001858E09B0-0x00000001858E0A70
                                                                   // [IDTag] // 0x0000000189709B00-0x0000000189709B40
                                                                   // [XID] // 0x0000000189709B00-0x0000000189709B40
        public static void GetBytes(ulong value, byte[] output) { } // 0x00000001858E0A70-0x00000001858E0B30
        public static void AddRangeToLinkedList<T>(ref LinkedList<T> linkedList, IEnumerable<T> tList) { }
        // [XID] // 0x0000000189A98FB0-0x0000000189A98FD0
        public static string GetObfusSeed() => default; // 0x00000001858E0D00-0x00000001858E0E00
                                                        // [XID] // 0x0000000189AAF170-0x0000000189AAF190
        public static void InitObfusNameTranslation() { } // 0x00000001858E13B0-0x00000001858E1DE0
                                                          // [XID] // 0x000000018995E390-0x000000018995E3B0
        public static string TranslateObfusStacktrace(string stacktrace) => default; // 0x00000001858F4250-0x00000001858F44B0
                                                                                     // [XID] // 0x0000000189739360-0x0000000189739380
        private static string TranslateObfusPhase(string phase) => default; // 0x00000001858F4040-0x00000001858F4250
                                                                            // [XID] // 0x0000000189ACD600-0x0000000189ACD620
        private static string TranslateObfusWord(string word) => default; // 0x00000001858F44B0-0x00000001858F46A0
                                                                          // [XID] // 0x0000000189AD53A0-0x0000000189AD53C0
        public static void TextException(string name) { } // 0x00000001858F3EE0-0x00000001858F3FB0
                                                          // [XID] // 0x000000018974FE10-0x000000018974FE30
        public static void TextForceException() { } // 0x00000001858F3FB0-0x00000001858F4040
                                                    // [XID] // 0x0000000189757500-0x0000000189757520
        public static int[] GetScriptVersionValues() => default; // 0x00000001858E0E00-0x00000001858E10D0
                                                                 // [XID] // 0x000000018975ED50-0x000000018975ED70
        public static UnityEngine.Object LoadExternalObject(ulong path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EC1A0-0x00000001858EC280
          // [XID] // 0x0000000189843DC0-0x0000000189843DE0
        public static AnchoredJoint2D LoadExternalAnchoredJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E33E0-0x00000001858E34C0
          // [XID] // 0x000000018976DA40-0x000000018976DA60
        public static Animation LoadExternalAnimation(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3760-0x00000001858E3840
          // [XID] // 0x0000000189774F00-0x0000000189774F20
        public static AnimationClip LoadExternalAnimationClip(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3680-0x00000001858E3760
          // [XID] // 0x000000018977C7A0-0x000000018977C7C0
        public static Animator LoadExternalAnimator(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3AE0-0x00000001858E3BC0
          // [XID] // 0x000000018962E7E0-0x000000018962E800
        public static AnimatorOverrideController LoadExternalAnimatorOverrideController(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3A00-0x00000001858E3AE0
          // [XID] // 0x000000018978B950-0x000000018978B970
        public static AreaEffector2D LoadExternalAreaEffector2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3CA0-0x00000001858E3D80
          // [XID] // 0x0000000189792C90-0x0000000189792CB0
        public static AssetBundle LoadExternalAssetBundle(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4020-0x00000001858E4100
          // [XID] // 0x0000000189B61760-0x0000000189B61780
        public static AssetBundleManifest LoadExternalAssetBundleManifest(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E3F40-0x00000001858E4020
          // [XID] // 0x0000000189B9FA40-0x0000000189B9FA60
        public static AudioBehaviour LoadExternalAudioBehaviour(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E41E0-0x00000001858E42C0
          // [XID] // 0x0000000189B7F2E0-0x0000000189B7F300
        public static AudioChorusFilter LoadExternalAudioChorusFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E43A0-0x00000001858E4480
          // [XID] // 0x0000000189B77CA0-0x0000000189B77CC0
        public static AudioClip LoadExternalAudioClip(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4560-0x00000001858E4640
          // [XID] // 0x00000001897F73E0-0x00000001897F7400
        public static AudioDistortionFilter LoadExternalAudioDistortionFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4720-0x00000001858E4800
          // [XID] // 0x0000000189B1FE90-0x0000000189B1FEB0
        public static AudioEchoFilter LoadExternalAudioEchoFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E48E0-0x00000001858E49C0
          // [XID] // 0x00000001896B3BD0-0x00000001896B3BF0
        public static AudioHighPassFilter LoadExternalAudioHighPassFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4AA0-0x00000001858E4B80
          // [XID] // 0x00000001897CFEB0-0x00000001897CFED0
        public static AudioListener LoadExternalAudioListener(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4C60-0x00000001858E4D40
          // [XID] // 0x00000001897D76F0-0x00000001897D7710
        public static AudioLowPassFilter LoadExternalAudioLowPassFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E4E20-0x00000001858E4F00
          // [XID] // 0x00000001897DEC80-0x00000001897DECA0
        public static AudioMixer LoadExternalAudioMixer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5360-0x00000001858E5440
          // [XID] // 0x0000000189B912A0-0x0000000189B912C0
        public static AudioMixerGroup LoadExternalAudioMixerGroup(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E50C0-0x00000001858E51A0
          // [XID] // 0x00000001895FA280-0x00000001895FA2A0
        public static AudioMixerSnapshot LoadExternalAudioMixerSnapshot(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5280-0x00000001858E5360
          // [XID] // 0x0000000189B69330-0x0000000189B69350
        public static AudioReverbFilter LoadExternalAudioReverbFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5520-0x00000001858E5600
          // [XID] // 0x0000000189B115C0-0x0000000189B115E0
        public static AudioReverbZone LoadExternalAudioReverbZone(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E56E0-0x00000001858E57C0
          // [XID] // 0x0000000189B707F0-0x0000000189B70810
        public static AudioSource LoadExternalAudioSource(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E58A0-0x00000001858E5980
          // [XID] // 0x000000018980BC60-0x000000018980BC80
        public static Avatar LoadExternalAvatar(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5C20-0x00000001858E5D00
          // [XID] // 0x0000000189813460-0x0000000189813480
        public static AvatarMask LoadExternalAvatarMask(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5B40-0x00000001858E5C20
          // [XID] // 0x0000000189B40910-0x0000000189B40930
        public static Behaviour LoadExternalBehaviour(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5DE0-0x00000001858E5EC0
          // [XID] // 0x0000000189822670-0x0000000189822690
        public static BillboardAsset LoadExternalBillboardAsset(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E5FA0-0x00000001858E6080
          // [XID] // 0x0000000189829C90-0x0000000189829CB0
        public static BillboardRenderer LoadExternalBillboardRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6160-0x00000001858E6240
          // [XID] // 0x00000001898311C0-0x00000001898311E0
        public static BoxCollider LoadExternalBoxCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E64E0-0x00000001858E65C0
          // [XID] // 0x0000000189838A00-0x0000000189838A20
        public static BoxCollider2D LoadExternalBoxCollider2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6320-0x00000001858E6400
          // [XID] // 0x0000000189BCF890-0x0000000189BCF8B0
        public static Camera LoadExternalCamera(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E66A0-0x00000001858E6780
          // [XID] // 0x00000001895F2920-0x00000001895F2940
        public static Canvas LoadExternalCanvas(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6BE0-0x00000001858E6CC0
          // [XID] // 0x0000000189BD6D00-0x0000000189BD6D20
        public static CanvasGroup LoadExternalCanvasGroup(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6940-0x00000001858E6A20
          // [XID] // 0x0000000189855E30-0x0000000189855E50
        public static CanvasRenderer LoadExternalCanvasRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6B00-0x00000001858E6BE0
          // [XID] // 0x000000018985D0E0-0x000000018985D100
        public static CapsuleCollider LoadExternalCapsuleCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6DA0-0x00000001858E6E80
          // [XID] // 0x0000000189864BD0-0x0000000189864BF0
        public static CharacterController LoadExternalCharacterController(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E6F60-0x00000001858E7040
          // [XID] // 0x000000018986C0F0-0x000000018986C110
        public static CharacterJoint LoadExternalCharacterJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7120-0x00000001858E7200
          // [XID] // 0x0000000189873630-0x0000000189873650
        public static CircleCollider2D LoadExternalCircleCollider2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E72E0-0x00000001858E73C0
          // [XID] // 0x00000001896C2460-0x00000001896C2480
        public static Cloth LoadExternalCloth(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E74A0-0x00000001858E7580
          // [XID] // 0x0000000189882160-0x0000000189882180
        public static Collider LoadExternalCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7820-0x00000001858E7900
          // [XID] // 0x00000001898897B0-0x00000001898897D0
        public static Collider2D LoadExternalCollider2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7660-0x00000001858E7740
          // [XID] // 0x0000000189B09B60-0x0000000189B09B80
        public static Component LoadExternalComponent(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E79E0-0x00000001858E7AC0
          // [XID] // 0x0000000189AEBD10-0x0000000189AEBD30
        public static ComputeShader LoadExternalComputeShader(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7BA0-0x00000001858E7C80
          // [XID] // 0x0000000189AF3740-0x0000000189AF3760
        public static ConfigurableJoint LoadExternalConfigurableJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7D60-0x00000001858E7E40
          // [XID] // 0x0000000189B5A2E0-0x0000000189B5A300
        public static ConstantForce LoadExternalConstantForce(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E80E0-0x00000001858E81C0
          // [XID] // 0x000000018961FB70-0x000000018961FB90
        public static ConstantForce2D LoadExternalConstantForce2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E7F20-0x00000001858E8000
          // [XID] // 0x0000000189617E90-0x0000000189617EB0
        public static Cubemap LoadExternalCubemap(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E82A0-0x00000001858E8380
          // [XID] // 0x00000001898BD660-0x00000001898BD680
        public static DistanceJoint2D LoadExternalDistanceJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E8460-0x00000001858E8540
          // [XID] // 0x00000001895EB4B0-0x00000001895EB4D0
        public static EdgeCollider2D LoadExternalEdgeCollider2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E8620-0x00000001858E8700
          // [XID] // 0x0000000189601C10-0x0000000189601C30
        public static Effector2D LoadExternalEffector2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E87E0-0x00000001858E88C0
          // [XID] // 0x00000001898D3E30-0x00000001898D3E50
        public static FixedJoint LoadExternalFixedJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E89A0-0x00000001858E8A80
          // [XID] // 0x00000001898DB650-0x00000001898DB670
        public static Flare LoadExternalFlare(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E8D20-0x00000001858E8E00
          // [XID] // 0x00000001898E3220-0x00000001898E3240
        public static FlareLayer LoadExternalFlareLayer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E8C40-0x00000001858E8D20
          // [XID] // 0x000000018964CAE0-0x000000018964CB00
        public static Font LoadExternalFont(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E8EE0-0x00000001858E8FC0
          // [XID] // 0x0000000189653F10-0x0000000189653F30
        public static GameObject LoadExternalGameObject(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E97A0-0x00000001858E9880
          // [XID] // 0x000000018965B910-0x000000018965B930
        public static ScriptableObject LoadExternalScriptableObject(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EEB90-0x00000001858EEC70
          // [XID] // 0x0000000189901860-0x0000000189901880
        public static GraphicsSettings LoadExternalGraphicsSettings(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9960-0x00000001858E9A40
          // [XID] // 0x0000000189908F30-0x0000000189908F50
        public static GUIElement LoadExternalGUIElement(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E90A0-0x00000001858E9180
          // [XID] // 0x00000001899104D0-0x00000001899104F0
        public static GUILayer LoadExternalGUILayer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9260-0x00000001858E9340
          // [XID] // 0x0000000189688F20-0x0000000189688F40
        public static GUIText LoadExternalGUIText(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9420-0x00000001858E9500
          // [XID] // 0x000000018991F750-0x000000018991F770
        public static GUITexture LoadExternalGUITexture(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E95E0-0x00000001858E96C0
          // [XID] // 0x0000000189927220-0x0000000189927240
        public static HingeJoint LoadExternalHingeJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9CE0-0x00000001858E9DC0
          // [XID] // 0x00000001896E19A0-0x00000001896E19C0
        public static HingeJoint2D LoadExternalHingeJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9B20-0x00000001858E9C00
          // [XID] // 0x00000001896F0130-0x00000001896F0150
        public static Joint LoadExternalJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA060-0x00000001858EA140
          // [XID] // 0x00000001896FF4D0-0x00000001896FF4F0
        public static Joint2D LoadExternalJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858E9EA0-0x00000001858E9F80
          // [XID] // 0x0000000189944D10-0x0000000189944D30
        public static LensFlare LoadExternalLensFlare(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA3E0-0x00000001858EA4C0
          // [XID] // 0x000000018994C3A0-0x000000018994C3C0
        public static Light LoadExternalLight(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA920-0x00000001858EAA00
          // [XID] // 0x0000000189742360-0x0000000189742380
        public static LightmapSettings LoadExternalLightmapSettings(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EAAE0-0x00000001858EABC0
          // [XID] // 0x000000018995B270-0x000000018995B290
        public static LightProbeGroup LoadExternalLightProbeGroup(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA680-0x00000001858EA760
          // [XID] // 0x0000000189962F10-0x0000000189962F30
        public static LightProbes LoadExternalLightProbes(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA840-0x00000001858EA920
          // [XID] // 0x0000000189782AC0-0x0000000189782AE0
        public static LineRenderer LoadExternalLineRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EACA0-0x00000001858EAD80
          // [XID] // 0x0000000189789CD0-0x0000000189789CF0
        public static LODGroup LoadExternalLODGroup(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EA220-0x00000001858EA300
          // [XID] // 0x00000001897914D0-0x00000001897914F0
        public static UnityEngine.Material LoadExternalMaterial(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EAE60-0x00000001858EAF40
          // [XID] // 0x0000000189980A40-0x0000000189980A60
        public static Mesh LoadExternalMesh(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB560-0x00000001858EB640
          // [XID] // 0x00000001897A0A30-0x00000001897A0A50
        public static MeshCollider LoadExternalMeshCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB100-0x00000001858EB1E0
          // [XID] // 0x00000001897A80C0-0x00000001897A80E0
        public static MeshFilter LoadExternalMeshFilter(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB2C0-0x00000001858EB3A0
          // [XID] // 0x00000001899976B0-0x00000001899976D0
        public static MeshRenderer LoadExternalMeshRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB480-0x00000001858EB560
          // [XID] // 0x000000018999F230-0x000000018999F250
        public static MonoBehaviour LoadExternalMonoBehaviour(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB720-0x00000001858EB800
          // [XID] // 0x00000001897BF880-0x00000001897BF8A0
        public static Motion LoadExternalMotion(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EB8E0-0x00000001858EB9C0
          // [XID] // 0x00000001897C7010-0x00000001897C7030
        public static NavMeshAgent LoadExternalNavMeshAgent(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EBAA0-0x00000001858EBB80
          // [XID] // 0x00000001897CE5E0-0x00000001897CE600
        public static NavMeshData LoadExternalNavMeshData(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EBC60-0x00000001858EBD40
          // [XID] // 0x00000001897D5CD0-0x00000001897D5CF0
        public static NavMeshObstacle LoadExternalNavMeshObstacle(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EBE20-0x00000001858EBF00
          // [XID] // 0x00000001899C4DB0-0x00000001899C4DD0
        public static UnityEngine.Networking.NetworkManager LoadExternalNetworkManager(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EBFE0-0x00000001858EC0C0
          // [XID] // 0x00000001899CC390-0x00000001899CC3B0
        public static OcclusionArea LoadExternalOcclusionArea(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EC360-0x00000001858EC440
          // [XID] // 0x00000001897F41E0-0x00000001897F4200
        public static OcclusionPortal LoadExternalOcclusionPortal(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EC520-0x00000001858EC600
          // [XID] // 0x00000001897FBC40-0x00000001897FBC60
        public static OffMeshLink LoadExternalOffMeshLink(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EC6E0-0x00000001858EC7C0
          // [XID] // 0x0000000189803150-0x0000000189803170
        public static ParticleSystem LoadExternalParticleSystem(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ECA60-0x00000001858ECB40
          // [XID] // 0x00000001899E9E10-0x00000001899E9E30
        public static ParticleSystemRenderer LoadExternalParticleSystemRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EC980-0x00000001858ECA60
          // [XID] // 0x00000001899F1630-0x00000001899F1650
        public static PhysicMaterial LoadExternalPhysicMaterial(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ECC20-0x00000001858ECD00
          // [XID] // 0x00000001899F8E90-0x00000001899F8EB0
        public static PhysicsMaterial2D LoadExternalPhysicsMaterial2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ECDE0-0x00000001858ECEC0
          // [XID] // 0x000000018984D3C0-0x000000018984D3E0
        public static PhysicsUpdateBehaviour2D LoadExternalPhysicsUpdateBehaviour2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ECFA0-0x00000001858ED080
          // [XID] // 0x0000000189A07BF0-0x0000000189A07C10
        public static PlatformEffector2D LoadExternalPlatformEffector2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ED160-0x00000001858ED240
          // [XID] // 0x0000000189A0F240-0x0000000189A0F260
        public static PointEffector2D LoadExternalPointEffector2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ED320-0x00000001858ED400
          // [XID] // 0x0000000189A16860-0x0000000189A16880
        public static PolygonCollider2D LoadExternalPolygonCollider2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ED4E0-0x00000001858ED5C0
          // [XID] // 0x0000000189A1DD60-0x0000000189A1DD80
        public static ProceduralMaterial LoadExternalProceduralMaterial(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ED6A0-0x00000001858ED780
          // [XID] // 0x000000018986A9F0-0x000000018986AA10
        public static ProceduralTexture LoadExternalProceduralTexture(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858ED860-0x00000001858ED940
          // [XID] // 0x0000000189871DF0-0x0000000189871E10
        public static Projector LoadExternalProjector(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EDA20-0x00000001858EDB00
          // [XID] // 0x0000000189A340E0-0x0000000189A34100
        public static QualitySettings LoadExternalQualitySettings(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EDBE0-0x00000001858EDCC0
          // [XID] // 0x0000000189A3B7B0-0x0000000189A3B7D0
        public static RectTransform LoadExternalRectTransform(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EDDA0-0x00000001858EDE80
          // [XID] // 0x0000000189A43340-0x0000000189A43360
        public static ReflectionProbe LoadExternalReflectionProbe(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EDF60-0x00000001858EE040
          // [XID] // 0x0000000189A4A820-0x0000000189A4A840
        public static Renderer LoadExternalRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE4A0-0x00000001858EE580
          // [XID] // 0x000000018989C970-0x000000018989C990
        public static RenderSettings LoadExternalRenderSettings(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE120-0x00000001858EE200
          // [XID] // 0x00000001898A41C0-0x00000001898A41E0
        public static RenderTexture LoadExternalRenderTexture(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE2E0-0x00000001858EE3C0
          // [XID] // 0x00000001898B2CA0-0x00000001898B2CC0
        public static Rigidbody LoadExternalRigidbody(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE820-0x00000001858EE900
          // [XID] // 0x0000000189A68F70-0x0000000189A68F90
        public static Rigidbody2D LoadExternalRigidbody2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE660-0x00000001858EE740
          // [XID] // 0x0000000189A70220-0x0000000189A70240
        public static RuntimeAnimatorController LoadExternalRuntimeAnimatorController(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EE9E0-0x00000001858EEAC0
          // [XID] // 0x0000000189A77AA0-0x0000000189A77AC0
        public static Shader LoadExternalShader(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EEF10-0x00000001858EEFF0
          // [XID] // 0x000000018992B820-0x000000018992B840
        public static ShaderVariantCollection LoadExternalShaderVariantCollection(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EEE30-0x00000001858EEF10
          // [XID] // 0x0000000189A86B00-0x0000000189A86B20
        public static SkinnedMeshRenderer LoadExternalSkinnedMeshRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF0D0-0x00000001858EF1B0
          // [XID] // 0x0000000189A8E6D0-0x0000000189A8E6F0
        public static Skybox LoadExternalSkybox(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF290-0x00000001858EF370
          // [XID] // 0x0000000189A95BB0-0x0000000189A95BD0
        public static SliderJoint2D LoadExternalSliderJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF450-0x00000001858EF530
          // [XID] // 0x0000000189A9D3A0-0x0000000189A9D3C0
        public static SparseTexture LoadExternalSparseTexture(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF610-0x00000001858EF6F0
          // [XID] // 0x0000000189AA4B20-0x0000000189AA4B40
        public static SphereCollider LoadExternalSphereCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF7D0-0x00000001858EF8B0
          // [XID] // 0x0000000189AAC1D0-0x0000000189AAC1F0
        public static SpringJoint LoadExternalSpringJoint(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EFB50-0x00000001858EFC30
          // [XID] // 0x0000000189AB3A90-0x0000000189AB3AB0
        public static SpringJoint2D LoadExternalSpringJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EF990-0x00000001858EFA70
          // [XID] // 0x0000000189ABB7B0-0x0000000189ABB7D0
        public static Sprite LoadExternalSprite(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EFED0-0x00000001858EFFB0
          // [XID] // 0x0000000189762990-0x00000001897629B0
        public static SpriteRenderer LoadExternalSpriteRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858EFDF0-0x00000001858EFED0
          // [XID] // 0x0000000189ACA590-0x0000000189ACA5B0
        public static SurfaceEffector2D LoadExternalSurfaceEffector2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0090-0x00000001858F0170
          // [XID] // 0x0000000189AD1F80-0x0000000189AD1FA0
        public static Terrain LoadExternalTerrain(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F05D0-0x00000001858F06B0
          // [XID] // 0x0000000189AD9A30-0x0000000189AD9A50
        public static TerrainCollider LoadExternalTerrainCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0330-0x00000001858F0410
          // [XID] // 0x00000001898D85C0-0x00000001898D85E0
        public static TerrainData LoadExternalTerrainData(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F04F0-0x00000001858F05D0
          // [XID] // 0x00000001898E0440-0x00000001898E0460
        public static TextAsset LoadExternalTextAsset(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0790-0x00000001858F0870
          // [XID] // 0x0000000189AF0980-0x0000000189AF09A0
        public static TextMesh LoadExternalTextMesh(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0950-0x00000001858F0A30
          // [XID] // 0x00000001898EF640-0x00000001898EF660
        public static Texture LoadExternalTexture(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0E90-0x00000001858F0F70
          // [XID] // 0x0000000189932FE0-0x0000000189933000
        public static Texture2D LoadExternalTexture2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0B10-0x00000001858F0BF0
          // [XID] // 0x00000001898F6EF0-0x00000001898F6F10
        public static Texture3D LoadExternalTexture3D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F0CD0-0x00000001858F0DB0
          // [XID] // 0x00000001898FE680-0x00000001898FE6A0
        public static TrailRenderer LoadExternalTrailRenderer(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F1050-0x00000001858F1130
          // [XID] // 0x0000000189905DA0-0x0000000189905DC0
        public static Transform LoadExternalTransform(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F1210-0x00000001858F12F0
          // [XID] // 0x0000000189B1D0D0-0x0000000189B1D0F0
        public static Tree LoadExternalTree(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F13D0-0x00000001858F14B0
          // [XID] // 0x0000000189B246C0-0x0000000189B246E0
        public static WheelCollider LoadExternalWheelCollider(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F1590-0x00000001858F1670
          // [XID] // 0x000000018991CAD0-0x000000018991CAF0
        public static WheelJoint2D LoadExternalWheelJoint2D(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F1750-0x00000001858F1830
          // [XID] // 0x0000000189B32FD0-0x0000000189B32FF0
        public static WindZone LoadExternalWindZone(string path, out uint resourceHandle)
        {
            resourceHandle = default;
            return default;
        } // 0x00000001858F1910-0x00000001858F19F0
          // [XID] // 0x000000018993A8A0-0x000000018993A8C0
        public static void LoadExternalObjectAsync(string path, UniHandlerAssetReceiver<UnityEngine.Object> onResult) { } // 0x00000001858EC0C0-0x00000001858EC1A0
                                                                                                                          // [XID] // 0x0000000189B422B0-0x0000000189B422D0
        public static void LoadExternalAnchoredJoint2DAsync(string path, UniHandlerAssetReceiver<AnchoredJoint2D> onResult) { } // 0x00000001858E3300-0x00000001858E33E0
                                                                                                                                // [XID] // 0x0000000189B49CD0-0x0000000189B49CF0
        public static void LoadExternalAnimationAsync(string path, UniHandlerAssetReceiver<Animation> onResult) { } // 0x00000001858E34C0-0x00000001858E35A0
                                                                                                                    // [XID] // 0x0000000189B51430-0x0000000189B51450
        public static void LoadExternalAnimationClipAsync(string path, UniHandlerAssetReceiver<AnimationClip> onResult) { } // 0x00000001858E35A0-0x00000001858E3680
                                                                                                                            // [XID] // 0x00000001899584F0-0x0000000189958510
        public static void LoadExternalAnimatorAsync(string path, UniHandlerAssetReceiver<Animator> onResult) { } // 0x00000001858E3840-0x00000001858E3920
                                                                                                                  // [XID] // 0x0000000189B60490-0x0000000189B604B0
        public static void LoadExternalAnimatorOverrideControllerAsync(string path, UniHandlerAssetReceiver<AnimatorOverrideController> onResult) { } // 0x00000001858E3920-0x00000001858E3A00
                                                                                                                                                      // [XID] // 0x0000000189B67C90-0x0000000189B67CB0
        public static void LoadExternalAreaEffector2DAsync(string path, UniHandlerAssetReceiver<AreaEffector2D> onResult) { } // 0x00000001858E3BC0-0x00000001858E3CA0
                                                                                                                              // [XID] // 0x0000000189B6EEF0-0x0000000189B6EF10
        public static void LoadExternalAssetBundleAsync(string path, UniHandlerAssetReceiver<AssetBundle> onResult) { } // 0x00000001858E3D80-0x00000001858E3E60
                                                                                                                        // [XID] // 0x00000001899761F0-0x0000000189976210
        public static void LoadExternalAssetBundleManifestAsync(string path, UniHandlerAssetReceiver<AssetBundleManifest> onResult) { } // 0x00000001858E3E60-0x00000001858E3F40
                                                                                                                                        // [XID] // 0x0000000189B7DC40-0x0000000189B7DC60
        public static void LoadExternalAudioBehaviourAsync(string path, UniHandlerAssetReceiver<AudioBehaviour> onResult) { } // 0x00000001858E4100-0x00000001858E41E0
                                                                                                                              // [XID] // 0x0000000189B85940-0x0000000189B85960
        public static void LoadExternalAudioChorusFilterAsync(string path, UniHandlerAssetReceiver<AudioChorusFilter> onResult) { } // 0x00000001858E42C0-0x00000001858E43A0
                                                                                                                                    // [XID] // 0x0000000189B8C730-0x0000000189B8C750
        public static void LoadExternalAudioClipAsync(string path, UniHandlerAssetReceiver<AudioClip> onResult) { } // 0x00000001858E4480-0x00000001858E4560
                                                                                                                    // [XID] // 0x0000000189B940A0-0x0000000189B940C0
        public static void LoadExternalAudioDistortionFilterAsync(string path, UniHandlerAssetReceiver<AudioDistortionFilter> onResult) { } // 0x00000001858E4640-0x00000001858E4720
                                                                                                                                            // [XID] // 0x00000001899A2350-0x00000001899A2370
        public static void LoadExternalAudioEchoFilterAsync(string path, UniHandlerAssetReceiver<AudioEchoFilter> onResult) { } // 0x00000001858E4800-0x00000001858E48E0
                                                                                                                                // [XID] // 0x00000001899A9BA0-0x00000001899A9BC0
        public static void LoadExternalAudioHighPassFilterAsync(string path, UniHandlerAssetReceiver<AudioHighPassFilter> onResult) { } // 0x00000001858E49C0-0x00000001858E4AA0
                                                                                                                                        // [XID] // 0x00000001899FC080-0x00000001899FC0A0
        public static void LoadExternalAudioListenerAsync(string path, UniHandlerAssetReceiver<AudioListener> onResult) { } // 0x00000001858E4B80-0x00000001858E4C60
                                                                                                                            // [XID] // 0x0000000189A03490-0x0000000189A034B0
        public static void LoadExternalAudioLowPassFilterAsync(string path, UniHandlerAssetReceiver<AudioLowPassFilter> onResult) { } // 0x00000001858E4D40-0x00000001858E4E20
                                                                                                                                      // [XID] // 0x0000000189BB8A60-0x0000000189BB8A80
        public static void LoadExternalAudioMixerAsync(string path, UniHandlerAssetReceiver<AudioMixer> onResult) { } // 0x00000001858E4F00-0x00000001858E4FE0
                                                                                                                      // [XID] // 0x0000000189BC03E0-0x0000000189BC0400
        public static void LoadExternalAudioMixerGroupAsync(string path, UniHandlerAssetReceiver<AudioMixerGroup> onResult) { } // 0x00000001858E4FE0-0x00000001858E50C0
                                                                                                                                // [XID] // 0x0000000189BC7DA0-0x0000000189BC7DC0
        public static void LoadExternalAudioMixerSnapshotAsync(string path, UniHandlerAssetReceiver<AudioMixerSnapshot> onResult) { } // 0x00000001858E51A0-0x00000001858E5280
                                                                                                                                      // [XID] // 0x0000000189A19750-0x0000000189A19770
        public static void LoadExternalAudioReverbFilterAsync(string path, UniHandlerAssetReceiver<AudioReverbFilter> onResult) { } // 0x00000001858E5440-0x00000001858E5520
                                                                                                                                    // [XID] // 0x0000000189BD6E70-0x0000000189BD6E90
        public static void LoadExternalAudioReverbZoneAsync(string path, UniHandlerAssetReceiver<AudioReverbZone> onResult) { } // 0x00000001858E5600-0x00000001858E56E0
                                                                                                                                // [XID] // 0x0000000189BDEB60-0x0000000189BDEB80
        public static void LoadExternalAudioSourceAsync(string path, UniHandlerAssetReceiver<AudioSource> onResult) { } // 0x00000001858E57C0-0x00000001858E58A0
                                                                                                                        // [XID] // 0x0000000189A20DD0-0x0000000189A20DF0
        public static void LoadExternalAvatarAsync(string path, UniHandlerAssetReceiver<Avatar> onResult) { } // 0x00000001858E5980-0x00000001858E5A60
                                                                                                              // [XID] // 0x00000001895F29E0-0x00000001895F2A00
        public static void LoadExternalAvatarMaskAsync(string path, UniHandlerAssetReceiver<AvatarMask> onResult) { } // 0x00000001858E5A60-0x00000001858E5B40
                                                                                                                      // [XID] // 0x00000001899C02B0-0x00000001899C02D0
        public static void LoadExternalBehaviourAsync(string path, UniHandlerAssetReceiver<Behaviour> onResult) { } // 0x00000001858E5D00-0x00000001858E5DE0
                                                                                                                    // [XID] // 0x00000001899C7B30-0x00000001899C7B50
        public static void LoadExternalBillboardAssetAsync(string path, UniHandlerAssetReceiver<BillboardAsset> onResult) { } // 0x00000001858E5EC0-0x00000001858E5FA0
                                                                                                                              // [XID] // 0x0000000189609520-0x0000000189609540
        public static void LoadExternalBillboardRendererAsync(string path, UniHandlerAssetReceiver<BillboardRenderer> onResult) { } // 0x00000001858E6080-0x00000001858E6160
                                                                                                                                    // [XID] // 0x00000001899D67F0-0x00000001899D6810
        public static void LoadExternalBoxColliderAsync(string path, UniHandlerAssetReceiver<BoxCollider> onResult) { } // 0x00000001858E6400-0x00000001858E64E0
                                                                                                                        // [XID] // 0x00000001899DDEB0-0x00000001899DDED0
        public static void LoadExternalBoxCollider2DAsync(string path, UniHandlerAssetReceiver<BoxCollider2D> onResult) { } // 0x00000001858E6240-0x00000001858E6320
                                                                                                                            // [XID] // 0x00000001899E5C50-0x00000001899E5C70
        public static void LoadExternalCameraAsync(string path, UniHandlerAssetReceiver<Camera> onResult) { } // 0x00000001858E65C0-0x00000001858E66A0
                                                                                                              // [XID] // 0x00000001899ECCE0-0x00000001899ECD00
        public static void LoadExternalCanvasAsync(string path, UniHandlerAssetReceiver<Canvas> onResult) { } // 0x00000001858E6780-0x00000001858E6860
                                                                                                              // [XID] // 0x00000001899F4A40-0x00000001899F4A60
        public static void LoadExternalCanvasGroupAsync(string path, UniHandlerAssetReceiver<CanvasGroup> onResult) { } // 0x00000001858E6860-0x00000001858E6940
                                                                                                                        // [XID] // 0x0000000189636540-0x0000000189636560
        public static void LoadExternalCanvasRendererAsync(string path, UniHandlerAssetReceiver<CanvasRenderer> onResult) { } // 0x00000001858E6A20-0x00000001858E6B00
                                                                                                                              // [XID] // 0x000000018963DB70-0x000000018963DB90
        public static void LoadExternalCapsuleColliderAsync(string path, UniHandlerAssetReceiver<CapsuleCollider> onResult) { } // 0x00000001858E6CC0-0x00000001858E6DA0
                                                                                                                                // [XID] // 0x0000000189A2F810-0x0000000189A2F830
        public static void LoadExternalCharacterControllerAsync(string path, UniHandlerAssetReceiver<CharacterController> onResult) { } // 0x00000001858E6E80-0x00000001858E6F60
                                                                                                                                        // [XID] // 0x000000018964CC00-0x000000018964CC20
        public static void LoadExternalCharacterJointAsync(string path, UniHandlerAssetReceiver<CharacterJoint> onResult) { } // 0x00000001858E7040-0x00000001858E7120
                                                                                                                              // [XID] // 0x0000000189A3E950-0x0000000189A3E970
        public static void LoadExternalCircleCollider2DAsync(string path, UniHandlerAssetReceiver<CircleCollider2D> onResult) { } // 0x00000001858E7200-0x00000001858E72E0
                                                                                                                                  // [XID] // 0x0000000189A46040-0x0000000189A46060
        public static void LoadExternalClothAsync(string path, UniHandlerAssetReceiver<Cloth> onResult) { } // 0x00000001858E73C0-0x00000001858E74A0
                                                                                                            // [XID] // 0x0000000189A4D750-0x0000000189A4D770
        public static void LoadExternalColliderAsync(string path, UniHandlerAssetReceiver<Collider> onResult) { } // 0x00000001858E7740-0x00000001858E7820
                                                                                                                  // [XID] // 0x000000018966A910-0x000000018966A930
        public static void LoadExternalCollider2DAsync(string path, UniHandlerAssetReceiver<Collider2D> onResult) { } // 0x00000001858E7580-0x00000001858E7660
                                                                                                                      // [XID] // 0x0000000189A5C900-0x0000000189A5C920
        public static void LoadExternalComponentAsync(string path, UniHandlerAssetReceiver<Component> onResult) { } // 0x00000001858E7900-0x00000001858E79E0
                                                                                                                    // [XID] // 0x0000000189A641D0-0x0000000189A641F0
        public static void LoadExternalComputeShaderAsync(string path, UniHandlerAssetReceiver<ComputeShader> onResult) { } // 0x00000001858E7AC0-0x00000001858E7BA0
                                                                                                                            // [XID] // 0x0000000189A6BB80-0x0000000189A6BBA0
        public static void LoadExternalConfigurableJointAsync(string path, UniHandlerAssetReceiver<ConfigurableJoint> onResult) { } // 0x00000001858E7C80-0x00000001858E7D60
                                                                                                                                    // [XID] // 0x0000000189A73340-0x0000000189A73360
        public static void LoadExternalConstantForceAsync(string path, UniHandlerAssetReceiver<ConstantForce> onResult) { } // 0x00000001858E8000-0x00000001858E80E0
                                                                                                                            // [XID] // 0x0000000189A7AE30-0x0000000189A7AE50
        public static void LoadExternalConstantForce2DAsync(string path, UniHandlerAssetReceiver<ConstantForce2D> onResult) { } // 0x00000001858E7E40-0x00000001858E7F20
                                                                                                                                // [XID] // 0x0000000189712550-0x0000000189712570
        public static void LoadExternalCubemapAsync(string path, UniHandlerAssetReceiver<Cubemap> onResult) { } // 0x00000001858E81C0-0x00000001858E82A0
                                                                                                                // [XID] // 0x000000018969F760-0x000000018969F780
        public static void LoadExternalDistanceJoint2DAsync(string path, UniHandlerAssetReceiver<DistanceJoint2D> onResult) { } // 0x00000001858E8380-0x00000001858E8460
                                                                                                                                // [XID] // 0x0000000189A89CE0-0x0000000189A89D00
        public static void LoadExternalEdgeCollider2DAsync(string path, UniHandlerAssetReceiver<EdgeCollider2D> onResult) { } // 0x00000001858E8540-0x00000001858E8620
                                                                                                                              // [XID] // 0x0000000189A913E0-0x0000000189A91400
        public static void LoadExternalEffector2DAsync(string path, UniHandlerAssetReceiver<Effector2D> onResult) { } // 0x00000001858E8700-0x00000001858E87E0
                                                                                                                      // [XID] // 0x00000001896B5720-0x00000001896B5740
        public static void LoadExternalFixedJointAsync(string path, UniHandlerAssetReceiver<FixedJoint> onResult) { } // 0x00000001858E88C0-0x00000001858E89A0
                                                                                                                      // [XID] // 0x00000001896BCA00-0x00000001896BCA20
        public static void LoadExternalFlareAsync(string path, UniHandlerAssetReceiver<Flare> onResult) { } // 0x00000001858E8A80-0x00000001858E8B60
                                                                                                            // [XID] // 0x0000000189AB6A10-0x0000000189AB6A30
        public static void LoadExternalFlareLayerAsync(string path, UniHandlerAssetReceiver<FlareLayer> onResult) { } // 0x00000001858E8B60-0x00000001858E8C40
                                                                                                                      // [XID] // 0x0000000189ABE500-0x0000000189ABE520
        public static void LoadExternalFontAsync(string path, UniHandlerAssetReceiver<Font> onResult) { } // 0x00000001858E8E00-0x00000001858E8EE0
                                                                                                          // [XID] // 0x0000000189AC6070-0x0000000189AC6090
        public static void LoadExternalGameObjectAsync(string path, UniHandlerAssetReceiver<GameObject> onResult) { } // 0x00000001858E96C0-0x00000001858E97A0
                                                                                                                      // [XID] // 0x00000001896DA460-0x00000001896DA480
        public static void LoadExternalGraphicsSettingsAsync(string path, UniHandlerAssetReceiver<GraphicsSettings> onResult) { } // 0x00000001858E9880-0x00000001858E9960
                                                                                                                                  // [XID] // 0x00000001896E1C00-0x00000001896E1C20
        public static void LoadExternalGUIElementAsync(string path, UniHandlerAssetReceiver<GUIElement> onResult) { } // 0x00000001858E8FC0-0x00000001858E90A0
                                                                                                                      // [XID] // 0x0000000189ADCD10-0x0000000189ADCD30
        public static void LoadExternalGUILayerAsync(string path, UniHandlerAssetReceiver<GUILayer> onResult) { } // 0x00000001858E9180-0x00000001858E9260
                                                                                                                  // [XID] // 0x00000001896F01D0-0x00000001896F01F0
        public static void LoadExternalGUITextAsync(string path, UniHandlerAssetReceiver<GUIText> onResult) { } // 0x00000001858E9340-0x00000001858E9420
                                                                                                                // [XID] // 0x0000000189AE4580-0x0000000189AE45A0
        public static void LoadExternalGUITextureAsync(string path, UniHandlerAssetReceiver<GUITexture> onResult) { } // 0x00000001858E9500-0x00000001858E95E0
                                                                                                                      // [XID] // 0x0000000189AEBCF0-0x0000000189AEBD10
        public static void LoadExternalHingeJointAsync(string path, UniHandlerAssetReceiver<HingeJoint> onResult) { } // 0x00000001858E9C00-0x00000001858E9CE0
                                                                                                                      // [XID] // 0x0000000189AF3720-0x0000000189AF3740
        public static void LoadExternalHingeJoint2DAsync(string path, UniHandlerAssetReceiver<HingeJoint2D> onResult) { } // 0x00000001858E9A40-0x00000001858E9B20
                                                                                                                          // [XID] // 0x000000018970E270-0x000000018970E290
        public static void LoadExternalJointAsync(string path, UniHandlerAssetReceiver<Joint> onResult) { } // 0x00000001858E9F80-0x00000001858EA060
                                                                                                            // [XID] // 0x0000000189AFAF80-0x0000000189AFAFA0
        public static void LoadExternalJoint2DAsync(string path, UniHandlerAssetReceiver<Joint2D> onResult) { } // 0x00000001858E9DC0-0x00000001858E9EA0
                                                                                                                // [XID] // 0x000000018971D2B0-0x000000018971D2D0
        public static void LoadExternalLensFlareAsync(string path, UniHandlerAssetReceiver<LensFlare> onResult) { } // 0x00000001858EA300-0x00000001858EA3E0
                                                                                                                    // [XID] // 0x0000000189B09B40-0x0000000189B09B60
        public static void LoadExternalLightAsync(string path, UniHandlerAssetReceiver<Light> onResult) { } // 0x00000001858EA4C0-0x00000001858EA5A0
                                                                                                            // [XID] // 0x000000018972BDE0-0x000000018972BE00
        public static void LoadExternalLightmapSettingsAsync(string path, UniHandlerAssetReceiver<LightmapSettings> onResult) { } // 0x00000001858EAA00-0x00000001858EAAE0
                                                                                                                                  // [XID] // 0x0000000189733450-0x0000000189733470
        public static void LoadExternalLightProbeGroupAsync(string path, UniHandlerAssetReceiver<LightProbeGroup> onResult) { } // 0x00000001858EA5A0-0x00000001858EA680
                                                                                                                                // [XID] // 0x000000018973AC90-0x000000018973ACB0
        public static void LoadExternalLightProbesAsync(string path, UniHandlerAssetReceiver<LightProbes> onResult) { } // 0x00000001858EA760-0x00000001858EA840
                                                                                                                        // [XID] // 0x0000000189B275E0-0x0000000189B27600
        public static void LoadExternalLineRendererAsync(string path, UniHandlerAssetReceiver<LineRenderer> onResult) { } // 0x00000001858EABC0-0x00000001858EACA0
                                                                                                                          // [XID] // 0x000000018974A0B0-0x000000018974A0D0
        public static void LoadExternalLODGroupAsync(string path, UniHandlerAssetReceiver<LODGroup> onResult) { } // 0x00000001858EA140-0x00000001858EA220
                                                                                                                  // [XID] // 0x0000000189B35E70-0x0000000189B35E90
        public static void LoadExternalMaterialAsync(string path, UniHandlerAssetReceiver<UnityEngine.Material> onResult) { } // 0x00000001858EAD80-0x00000001858EAE60
                                                                                                                              // [XID] // 0x0000000189A849A0-0x0000000189A849C0
        public static void LoadExternalMeshAsync(string path, UniHandlerAssetReceiver<Mesh> onResult) { } // 0x00000001858EAF40-0x00000001858EB020
                                                                                                          // [XID] // 0x0000000189B3D5C0-0x0000000189B3D5E0
        public static void LoadExternalMeshColliderAsync(string path, UniHandlerAssetReceiver<MeshCollider> onResult) { } // 0x00000001858EB020-0x00000001858EB100
                                                                                                                          // [XID] // 0x0000000189B45460-0x0000000189B45480
        public static void LoadExternalMeshFilterAsync(string path, UniHandlerAssetReceiver<MeshFilter> onResult) { } // 0x00000001858EB1E0-0x00000001858EB2C0
                                                                                                                      // [XID] // 0x000000018976EF50-0x000000018976EF70
        public static void LoadExternalMeshRendererAsync(string path, UniHandlerAssetReceiver<MeshRenderer> onResult) { } // 0x00000001858EB3A0-0x00000001858EB480
                                                                                                                          // [XID] // 0x0000000189776AC0-0x0000000189776AE0
        public static void LoadExternalMonoBehaviourAsync(string path, UniHandlerAssetReceiver<MonoBehaviour> onResult) { } // 0x00000001858EB640-0x00000001858EB720
                                                                                                                            // [XID] // 0x0000000189B5BC20-0x0000000189B5BC40
        public static void LoadExternalMotionAsync(string path, UniHandlerAssetReceiver<Motion> onResult) { } // 0x00000001858EB800-0x00000001858EB8E0
                                                                                                              // [XID] // 0x00000001897858C0-0x00000001897858E0
        public static void LoadExternalNavMeshAgentAsync(string path, UniHandlerAssetReceiver<NavMeshAgent> onResult) { } // 0x00000001858EB9C0-0x00000001858EBAA0
                                                                                                                          // [XID] // 0x000000018978CDF0-0x000000018978CE10
        public static void LoadExternalNavMeshDataAsync(string path, UniHandlerAssetReceiver<NavMeshData> onResult) { } // 0x00000001858EBB80-0x00000001858EBC60
                                                                                                                        // [XID] // 0x00000001897942C0-0x00000001897942E0
        public static void LoadExternalNavMeshObstacleAsync(string path, UniHandlerAssetReceiver<NavMeshObstacle> onResult) { } // 0x00000001858EBD40-0x00000001858EBE20
                                                                                                                                // [XID] // 0x000000018979C630-0x000000018979C650
        public static void LoadExternalNetworkManagerAsync(string path, UniHandlerAssetReceiver<UnityEngine.Networking.NetworkManager> onResult) { } // 0x00000001858EBF00-0x00000001858EBFE0
                                                                                                                                                     // [XID] // 0x00000001897A3B70-0x00000001897A3B90
        public static void LoadExternalOcclusionAreaAsync(string path, UniHandlerAssetReceiver<OcclusionArea> onResult) { } // 0x00000001858EC280-0x00000001858EC360
                                                                                                                            // [XID] // 0x0000000189BA8860-0x0000000189BA8880
        public static void LoadExternalOcclusionPortalAsync(string path, UniHandlerAssetReceiver<OcclusionPortal> onResult) { } // 0x00000001858EC440-0x00000001858EC520
                                                                                                                                // [XID] // 0x00000001897B2C70-0x00000001897B2C90
        public static void LoadExternalOffMeshLinkAsync(string path, UniHandlerAssetReceiver<OffMeshLink> onResult) { } // 0x00000001858EC600-0x00000001858EC6E0
                                                                                                                        // [XID] // 0x00000001897BA7A0-0x00000001897BA7C0
        public static void LoadExternalParticleSystemAsync(string path, UniHandlerAssetReceiver<ParticleSystem> onResult) { } // 0x00000001858EC7C0-0x00000001858EC8A0
                                                                                                                              // [XID] // 0x0000000189B83E80-0x0000000189B83EA0
        public static void LoadExternalParticleSystemRendererAsync(string path, UniHandlerAssetReceiver<ParticleSystemRenderer> onResult) { } // 0x00000001858EC8A0-0x00000001858EC980
                                                                                                                                              // [XID] // 0x00000001897C9D80-0x00000001897C9DA0
        public static void LoadExternalPhysicMaterialAsync(string path, UniHandlerAssetReceiver<PhysicMaterial> onResult) { } // 0x00000001858ECB40-0x00000001858ECC20
                                                                                                                              // [XID] // 0x0000000189989D10-0x0000000189989D30
        public static void LoadExternalPhysicsMaterial2DAsync(string path, UniHandlerAssetReceiver<PhysicsMaterial2D> onResult) { } // 0x00000001858ECD00-0x00000001858ECDE0
                                                                                                                                    // [XID] // 0x00000001897D9310-0x00000001897D9330
        public static void LoadExternalPhysicsUpdateBehaviour2DAsync(string path, UniHandlerAssetReceiver<PhysicsUpdateBehaviour2D> onResult) { } // 0x00000001858ECEC0-0x00000001858ECFA0
                                                                                                                                                  // [XID] // 0x00000001897E0620-0x00000001897E0640
        public static void LoadExternalPlatformEffector2DAsync(string path, UniHandlerAssetReceiver<PlatformEffector2D> onResult) { } // 0x00000001858ED080-0x00000001858ED160
                                                                                                                                      // [XID] // 0x00000001895F1240-0x00000001895F1260
        public static void LoadExternalPointEffector2DAsync(string path, UniHandlerAssetReceiver<PointEffector2D> onResult) { } // 0x00000001858ED240-0x00000001858ED320
                                                                                                                                // [XID] // 0x00000001897EF980-0x00000001897EF9A0
        public static void LoadExternalPolygonCollider2DAsync(string path, UniHandlerAssetReceiver<PolygonCollider2D> onResult) { } // 0x00000001858ED400-0x00000001858ED4E0
                                                                                                                                    // [XID] // 0x0000000189B92620-0x0000000189B92640
        public static void LoadExternalProceduralMaterialAsync(string path, UniHandlerAssetReceiver<ProceduralMaterial> onResult) { } // 0x00000001858ED5C0-0x00000001858ED6A0
                                                                                                                                      // [XID] // 0x00000001897FE640-0x00000001897FE660
        public static void LoadExternalProceduralTextureAsync(string path, UniHandlerAssetReceiver<ProceduralTexture> onResult) { } // 0x00000001858ED780-0x00000001858ED860
                                                                                                                                    // [XID] // 0x0000000189805D90-0x0000000189805DB0
        public static void LoadExternalProjectorAsync(string path, UniHandlerAssetReceiver<Projector> onResult) { } // 0x00000001858ED940-0x00000001858EDA20
                                                                                                                    // [XID] // 0x000000018980D560-0x000000018980D580
        public static void LoadExternalQualitySettingsAsync(string path, UniHandlerAssetReceiver<QualitySettings> onResult) { } // 0x00000001858EDB00-0x00000001858EDBE0
                                                                                                                                // [XID] // 0x0000000189814BD0-0x0000000189814BF0
        public static void LoadExternalRectTransformAsync(string path, UniHandlerAssetReceiver<RectTransform> onResult) { } // 0x00000001858EDCC0-0x00000001858EDDA0
                                                                                                                            // [XID] // 0x000000018981C720-0x000000018981C740
        public static void LoadExternalReflectionProbeAsync(string path, UniHandlerAssetReceiver<ReflectionProbe> onResult) { } // 0x00000001858EDE80-0x00000001858EDF60
                                                                                                                                // [XID] // 0x00000001899AFC50-0x00000001899AFC70
        public static void LoadExternalRendererAsync(string path, UniHandlerAssetReceiver<Renderer> onResult) { } // 0x00000001858EE3C0-0x00000001858EE4A0
                                                                                                                  // [XID] // 0x0000000189BAFB60-0x0000000189BAFB80
        public static void LoadExternalRenderSettingsAsync(string path, UniHandlerAssetReceiver<RenderSettings> onResult) { } // 0x00000001858EE040-0x00000001858EE120
                                                                                                                              // [XID] // 0x0000000189832A40-0x0000000189832A60
        public static void LoadExternalRenderTextureAsync(string path, UniHandlerAssetReceiver<RenderTexture> onResult) { } // 0x00000001858EE200-0x00000001858EE2E0
                                                                                                                            // [XID] // 0x0000000189BCE240-0x0000000189BCE260
        public static void LoadExternalRigidbodyAsync(string path, UniHandlerAssetReceiver<Rigidbody> onResult) { } // 0x00000001858EE740-0x00000001858EE820
                                                                                                                    // [XID] // 0x0000000189841540-0x0000000189841560
        public static void LoadExternalRigidbody2DAsync(string path, UniHandlerAssetReceiver<Rigidbody2D> onResult) { } // 0x00000001858EE580-0x00000001858EE660
                                                                                                                        // [XID] // 0x0000000189848A20-0x0000000189848A40
        public static void LoadExternalRuntimeAnimatorControllerAsync(string path, UniHandlerAssetReceiver<RuntimeAnimatorController> onResult) { } // 0x00000001858EE900-0x00000001858EE9E0
                                                                                                                                                    // [XID] // 0x00000001898502E0-0x0000000189850300
        public static void LoadExternalShaderAsync(string path, UniHandlerAssetReceiver<Shader> onResult) { } // 0x00000001858EEC70-0x00000001858EED50
                                                                                                              // [XID] // 0x0000000189857580-0x00000001898575A0
        public static void LoadExternalShaderVariantCollectionAsync(string path, UniHandlerAssetReceiver<ShaderVariantCollection> onResult) { } // 0x00000001858EED50-0x00000001858EEE30
                                                                                                                                                // [XID] // 0x000000018960F350-0x000000018960F370
        public static void LoadExternalSkinnedMeshRendererAsync(string path, UniHandlerAssetReceiver<SkinnedMeshRenderer> onResult) { } // 0x00000001858EEFF0-0x00000001858EF0D0
                                                                                                                                        // [XID] // 0x00000001896168F0-0x0000000189616910
        public static void LoadExternalSkyboxAsync(string path, UniHandlerAssetReceiver<Skybox> onResult) { } // 0x00000001858EF1B0-0x00000001858EF290
                                                                                                              // [XID] // 0x000000018961E1E0-0x000000018961E200
        public static void LoadExternalSliderJoint2DAsync(string path, UniHandlerAssetReceiver<SliderJoint2D> onResult) { } // 0x00000001858EF370-0x00000001858EF450
                                                                                                                            // [XID] // 0x000000018962CF30-0x000000018962CF50
        public static void LoadExternalSparseTextureAsync(string path, UniHandlerAssetReceiver<SparseTexture> onResult) { } // 0x00000001858EF530-0x00000001858EF610
                                                                                                                            // [XID] // 0x0000000189634B20-0x0000000189634B40
        public static void LoadExternalSphereColliderAsync(string path, UniHandlerAssetReceiver<SphereCollider> onResult) { } // 0x00000001858EF6F0-0x00000001858EF7D0
                                                                                                                              // [XID] // 0x0000000189643900-0x0000000189643920
        public static void LoadExternalSpringJointAsync(string path, UniHandlerAssetReceiver<SpringJoint> onResult) { } // 0x00000001858EFA70-0x00000001858EFB50
                                                                                                                        // [XID] // 0x000000018964AF00-0x000000018964AF20
        public static void LoadExternalSpringJoint2DAsync(string path, UniHandlerAssetReceiver<SpringJoint2D> onResult) { } // 0x00000001858EF8B0-0x00000001858EF990
                                                                                                                            // [XID] // 0x00000001899985D0-0x00000001899985F0
        public static void LoadExternalSpriteAsync(string path, UniHandlerAssetReceiver<Sprite> onResult) { } // 0x00000001858EFC30-0x00000001858EFD10
                                                                                                              // [XID] // 0x0000000189989340-0x0000000189989360
        public static void LoadExternalSpriteRendererAsync(string path, UniHandlerAssetReceiver<SpriteRenderer> onResult) { } // 0x00000001858EFD10-0x00000001858EFDF0
                                                                                                                              // [XID] // 0x00000001898A0FF0-0x00000001898A1010
        public static void LoadExternalSurfaceEffector2DAsync(string path, UniHandlerAssetReceiver<SurfaceEffector2D> onResult) { } // 0x00000001858EFFB0-0x00000001858F0090
                                                                                                                                    // [XID] // 0x00000001898A94F0-0x00000001898A9510
        public static void LoadExternalTerrainAsync(string path, UniHandlerAssetReceiver<Terrain> onResult) { } // 0x00000001858F0170-0x00000001858F0250
                                                                                                                // [XID] // 0x00000001898B8480-0x00000001898B84A0
        public static void LoadExternalTerrainColliderAsync(string path, UniHandlerAssetReceiver<TerrainCollider> onResult) { } // 0x00000001858F0250-0x00000001858F0330
                                                                                                                                // [XID] // 0x00000001898B7650-0x00000001898B7670
        public static void LoadExternalTerrainDataAsync(string path, UniHandlerAssetReceiver<TerrainData> onResult) { } // 0x00000001858F0410-0x00000001858F04F0
                                                                                                                        // [XID] // 0x00000001898D6400-0x00000001898D6420
        public static void LoadExternalTextAssetAsync(string path, UniHandlerAssetReceiver<TextAsset> onResult) { } // 0x00000001858F06B0-0x00000001858F0790
                                                                                                                    // [XID] // 0x00000001898C6640-0x00000001898C6660
        public static void LoadExternalTextMeshAsync(string path, UniHandlerAssetReceiver<TextMesh> onResult) { } // 0x00000001858F0870-0x00000001858F0950
                                                                                                                  // [XID] // 0x0000000189664610-0x0000000189664630
        public static void LoadExternalTextureAsync(string path, UniHandlerAssetReceiver<Texture> onResult) { } // 0x00000001858F0DB0-0x00000001858F0E90
                                                                                                                // [XID] // 0x00000001898D56D0-0x00000001898D56F0
        public static void LoadExternalTexture2DAsync(string path, UniHandlerAssetReceiver<Texture2D> onResult) { } // 0x00000001858F0A30-0x00000001858F0B10
                                                                                                                    // [XID] // 0x00000001898DD090-0x00000001898DD0B0
        public static void LoadExternalTexture3DAsync(string path, UniHandlerAssetReceiver<Texture3D> onResult) { } // 0x00000001858F0BF0-0x00000001858F0CD0
                                                                                                                    // [XID] // 0x0000000189918F40-0x0000000189918F60
        public static void LoadExternalTrailRendererAsync(string path, UniHandlerAssetReceiver<TrailRenderer> onResult) { } // 0x00000001858F0F70-0x00000001858F1050
                                                                                                                            // [XID] // 0x0000000189677AD0-0x0000000189677AF0
        public static void LoadExternalTransformAsync(string path, UniHandlerAssetReceiver<Transform> onResult) { } // 0x00000001858F1130-0x00000001858F1210
                                                                                                                    // [XID] // 0x00000001896EE210-0x00000001896EE230
        public static void LoadExternalTreeAsync(string path, UniHandlerAssetReceiver<Tree> onResult) { } // 0x00000001858F12F0-0x00000001858F13D0
                                                                                                          // [XID] // 0x00000001896DA760-0x00000001896DA780
        public static void LoadExternalWheelColliderAsync(string path, UniHandlerAssetReceiver<WheelCollider> onResult) { } // 0x00000001858F14B0-0x00000001858F1590
                                                                                                                            // [XID] // 0x0000000189686930-0x0000000189686950
        public static void LoadExternalWheelJoint2DAsync(string path, UniHandlerAssetReceiver<WheelJoint2D> onResult) { } // 0x00000001858F1670-0x00000001858F1750
                                                                                                                          // [XID] // 0x000000018990A5F0-0x000000018990A610
        public static void LoadExternalWindZoneAsync(string path, UniHandlerAssetReceiver<WindZone> onResult) { } // 0x00000001858F1830-0x00000001858F1910
                                                                                                                  // [XID] // 0x0000000189696230-0x0000000189696250
        public static void UnloadBundleExplicitly(int bundleHash) { } // 0x00000001858F46A0-0x00000001858F4760

        // Extension methods
        public static void Shuffle<T>(this IList<T> list) { }
        // [XID] // 0x00000001896E0390-0x00000001896E03D0
        public static float Next(this System.Random random, float min, float max) => default; // 0x00000001858F32B0-0x00000001858F33A0
    }
}
