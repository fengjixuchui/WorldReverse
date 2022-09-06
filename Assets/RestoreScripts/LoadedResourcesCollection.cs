/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public class LoadedResourcesCollection // TypeDefIndex: 7531
    {
        // Fields
        public static Func<bool> inOherPage; // 0x00
        private static StreamWriter _logger; // 0x08
        public static bool needRecord; // 0x10
        private static HashSet<string> set; // 0x18
        private readonly Dictionary<int, LoadedBundle> _loadedAssetBundles; // 0x10
        private readonly MResLruList<int> _unusedBundles; // 0x18
        public static Action<int, int, float> Resize; // 0x20

        // Properties
        public Dictionary<int, LoadedBundle> allLoadedBundles { /* [XID] */ /* 0x0000000189BBD640-0x0000000189BBD660 */ get => default; } // 0x0000000189BFAC60-0x0000000189BFAD00 
        public bool idle { /* [XID] */ /* 0x0000000189859150-0x0000000189859170 */ get => default; } // 0x0000000189BFAD00-0x0000000189BFADC0 

        // Constructors
        public LoadedResourcesCollection() { } // 0x0000000189BFAA70-0x0000000189BFAC60
        static LoadedResourcesCollection() { } // 0x0000000189BFA9D0-0x0000000189BFAA70

        // Methods
        // [XID] // 0x0000000189BA7590-0x0000000189BA75B0
        private static StreamWriter OpenLogFile() => default; // 0x0000000189BF89B0-0x0000000189BF8B30
                                                              // [XID] // 0x0000000189BAE820-0x0000000189BAE840
        public void RecordSyncLoad(ResourceIdentifier res) { } // 0x0000000189BF8B30-0x0000000189BF8E80
                                                               // [XID] // 0x000000018994F330-0x000000018994F350
        public static void AddSyncLoadAsse(string path) { } // 0x0000000189BF70D0-0x0000000189BF7440
                                                            // [XID] // 0x0000000189BC5300-0x0000000189BC5320
        public void UnloadBundleExplicitly(int bundlehash) { } // 0x0000000189BF9EC0-0x0000000189BF9FA0
                                                               // [XID] // 0x0000000189BD4440-0x0000000189BD4460
        public void ReplaceIndex(ResourceIndex oldOne, ResourceIndex newOne, IEnumerable<ulong> hashes) { } // 0x0000000189BF9080-0x0000000189BF98D0
                                                                                                            // [XID] // 0x00000001899B1620-0x00000001899B1640
        public void Deallocate(ulong path, int bundle) { } // 0x0000000189BF7440-0x0000000189BF7520
                                                           // [IDTag] // 0x00000001895E8630-0x00000001895E8670
                                                           // [XID] // 0x00000001895E8630-0x00000001895E8670
        private void UnloadBundle(int bundleHash) { } // 0x0000000189BF9FA0-0x0000000189BFA290
                                                      // [IDTag] // 0x00000001895F2BB0-0x00000001895F2BF0
                                                      // [XID] // 0x00000001895F2BB0-0x00000001895F2BF0
        public void UnloadBundle(IEnumerable<int> bundles) { } // 0x0000000189BFA6B0-0x0000000189BFA8E0
                                                               // [XID] // 0x00000001898A28B0-0x00000001898A28D0
        public byte[] LoadBinData(ResourceIdentifier resource, int offset, int length)
        {
            var loaded = GetLoadedBundle(resource);
            if (loaded != null)
            {
                if (GlobalVars.dumpSyncLoad)
                {
                    if (!ExternalResourceProvider.unlimited)
                    {
                        AddSyncLoadAsse(resource.pathInResource);
                    }
                }
                return loaded.LoadBinData(resource.assetPathHash, offset, length);
            }
            else
            {
                return null;
            }


        }// 0x0000000189BF8540-0x0000000189BF87D0
         // [XID] // 0x0000000189A550D0-0x0000000189A550F0
        public int GetBinDataLength(ResourceIdentifier resource) => default; // 0x0000000189BF7CB0-0x0000000189BF7DA0
                                                                             // [XID] // 0x000000018960C540-0x000000018960C560
        public ulong LoadBinDataASync(ResourceIdentifier resource, int offset, int length) => default; // 0x0000000189BF8420-0x0000000189BF8540
                                                                                                       // [XID] // 0x0000000189A89D80-0x0000000189A89DA0
        public UnityEngine.Object UseLoadedResource(ResourceIdentifier resource) => default; // 0x0000000189BFA8E0-0x0000000189BFA9D0
                                                                                             // [XID] // 0x0000000189867950-0x0000000189867970
        public uint LoadFromBundle(ResourceIdentifier resource) => default; // 0x0000000189BF87D0-0x0000000189BF88C0
                                                                            // [XID] // 0x00000001899405D0-0x00000001899405F0
        public uint LoadPrefabFromBundle(ResourceIdentifier resource) => default; // 0x0000000189BF88C0-0x0000000189BF89B0
                                                                                  // [XID] // 0x000000018990BF60-0x000000018990BF80
        public GameObject Instantiate(ResourceIdentifier resource) => default; // 0x0000000189BF8330-0x0000000189BF8420
                                                                               // [XID] // 0x0000000189947C50-0x0000000189947C70
        public UnityEngine.Object SyncLoadFromBundle(ResourceIdentifier resource) => default; // 0x0000000189BF9B30-0x0000000189BF9DC0
                                                                                              // [XID] // 0x00000001898E6430-0x00000001898E6450
        public void ReportCurrentInfo(StringBuilder buffer) { } // 0x0000000189BF98D0-0x0000000189BF9B30
                                                                // [XID] // 0x0000000189640AD0-0x0000000189640AF0
        public void AddAsset(ResourceIdentifier resource, UnityEngine.Object asset) { } // 0x0000000189BF6D40-0x0000000189BF6E40
                                                                                        // [XID] // 0x00000001896A8250-0x00000001896A8270
        public void AddBundle(int bundleHash, AssetBundle bundle) { } // 0x0000000189BF6E40-0x0000000189BF70D0
                                                                      // [XID] // 0x000000018964FA50-0x000000018964FA70
        public void Tick() { } // 0x0000000189BF9DC0-0x0000000189BF9EC0
                               // [XID] // 0x0000000189657360-0x0000000189657380
        public void ForceUnload() { } // 0x0000000189BF7C00-0x0000000189BF7CB0
                                      // [XID] // 0x000000018965E9D0-0x000000018965E9F0
        public void IncreaseBundleUsageCount(int bundleHash, int times) { } // 0x0000000189BF8190-0x0000000189BF8330
                                                                            // [XID] // 0x0000000189666080-0x00000001896660A0
        public void DumpLoadedAssset() { } // 0x0000000189BF7940-0x0000000189BF7C00
                                           // [IDTag] // 0x000000018966D830-0x000000018966D870
                                           // [XID] // 0x000000018966D830-0x000000018966D870
        public void UnloadBundle(Dictionary<int, int> independentBundles) { } // 0x0000000189BFA290-0x0000000189BFA6B0
                                                                              // [XID] // 0x00000001896BDF40-0x00000001896BDF60
        public void DecreaseBundleUsageCount(int bundleHash, bool async = true /* Metadata: 0x00ADEC50 */) { } // 0x0000000189BF7520-0x0000000189BF7940
                                                                                                               // [XID] // 0x0000000189761DC0-0x0000000189761DE0
        public void ReleaseAll() { } // 0x0000000189BF8E80-0x0000000189BF9080
                                     // [XID] // 0x0000000189687560-0x0000000189687580
        public bool HasAssetLoaded(ResourceIdentifier resource) => default; // 0x0000000189BF7FD0-0x0000000189BF80C0
                                                                            // [XID] // 0x000000018968F380-0x000000018968F3A0
        public bool HasBundleLoaded(int bundleHash) => default; // 0x0000000189BF80C0-0x0000000189BF8190
                                                                // [IDTag] // 0x0000000189696DF0-0x0000000189696E30
                                                                // [XID] // 0x0000000189696DF0-0x0000000189696E30
        private LoadedBundle GetLoadedBundle(ResourceIdentifier resource) => default; // 0x0000000189BF7DA0-0x0000000189BF7E70
                                                                                      // [IDTag] // 0x00000001896A0FD0-0x00000001896A1010
                                                                                      // [XID] // 0x00000001896A0FD0-0x00000001896A1010
        private LoadedBundle GetLoadedBundle(int bundleHash) => default; // 0x0000000189BF7E70-0x0000000189BF7FD0
    }
}
