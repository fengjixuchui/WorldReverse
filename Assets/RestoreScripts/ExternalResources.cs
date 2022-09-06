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
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public class ExternalResources // TypeDefIndex: 7521
    {
        // Fields
        private readonly Runtime _runtime; // 0x10

        // Properties
        public Dictionary<int, LoadedBundle> allLoadedBundles { /* [XID] */ /* 0x00000001898A9E20-0x00000001898A9E40 */ get => default; } // 0x00000001858FA3F0-0x00000001858FA4B0 
        public List<string> allLoadedAsset { /* [XID] */ /* 0x00000001898CF720-0x00000001898CF740 */ get => default; } // 0x00000001858FA340-0x00000001858FA3F0 
        public int assetJobCount { /* [XID] */ /* 0x000000018970CAD0-0x000000018970CAF0 */ get => default; } // 0x00000001858FA560-0x00000001858FA610 
        public int assetJobActiveCount { /* [XID] */ /* 0x000000018992A000-0x000000018992A020 */ get => default; } // 0x00000001858FA4B0-0x00000001858FA560 
        public int assetJobQueueCount { /* [XID] */ /* 0x000000018971BD20-0x000000018971BD40 */ get => default; } // 0x00000001858FA610-0x00000001858FA6C0 
        public int bundleJobCount { /* [XID] */ /* 0x000000018996D270-0x000000018996D290 */ get => default; } // 0x00000001858FA770-0x00000001858FA820 
        public int bundleJobActiveCount { /* [XID] */ /* 0x000000018972A8C0-0x000000018972A8E0 */ get => default; } // 0x00000001858FA6C0-0x00000001858FA770 
        public int bundleJobQueueCount { /* [XID] */ /* 0x0000000189731F80-0x0000000189731FA0 */ get => default; } // 0x00000001858FA820-0x00000001858FA8D0 
        public int unloadJobCount { /* [XID] */ /* 0x000000018999AC10-0x000000018999AC30 */ get => default; } // 0x00000001858FAC50-0x00000001858FAD00 
        public int unloadJobActiveCount { /* [XID] */ /* 0x0000000189741240-0x0000000189741260 */ get => default; } // 0x00000001858FABA0-0x00000001858FAC50 
        public int unloadJobQueueCount { /* [XID] */ /* 0x0000000189A7AE90-0x0000000189A7AEB0 */ get => default; } // 0x00000001858FAD00-0x00000001858FADB0 
        public string[] undergoingAssetJobNames { /* [XID] */ /* 0x0000000189AE74E0-0x0000000189AE7500 */ get => default; } // 0x00000001858FA990-0x00000001858FAA40 
        public string[] undergoingUnloadedAssetJobNames { /* [XID] */ /* 0x0000000189B12B70-0x0000000189B12B90 */ get => default; } // 0x00000001858FAAF0-0x00000001858FABA0 
        public string[] undergoingBundleJobNames { /* [XID] */ /* 0x000000018975EFF0-0x000000018975F010 */ get => default; } // 0x00000001858FAA40-0x00000001858FAAF0 
        public string activeJobAndJobQueueInfo { /* [XID] */ /* 0x0000000189766350-0x0000000189766370 */ get => default; } // 0x00000001858FA290-0x00000001858FA340 
        public bool useAssetBundlesInEditor { /* [XID] */ /* 0x0000000189792F10-0x0000000189792F30 */ get => default; /* [XID] */ /* 0x00000001896480C0-0x00000001896480E0 */ set { } } // 0x00000001858FADB0-0x00000001858FAE70 0x00000001858FAE70-0x00000001858FB090
        public bool idle { /* [XID] */ /* 0x0000000189762A30-0x0000000189762A50 */ get => default; } // 0x00000001858FA8D0-0x00000001858FA990 

        // Nested types
        public abstract class Runtime // TypeDefIndex: 7522
        {
            // Fields
            private readonly ExternalResourceProvider _provider; // 0x10

            // Properties
            public virtual Dictionary<int, LoadedBundle> allLoadedBundles { /* [XID] */ /* 0x000000018986AC60-0x000000018986AC80 */ get; } // 0x0000000189C00090-0x0000000189C00160 
            public List<string> allLoadedAsset { /* [XID] */ /* 0x00000001898D7030-0x00000001898D7050 */ get; } // 0x0000000189BFFFC0-0x0000000189C00090 
            public int assetJobCount { /* [XID] */ /* 0x00000001898798C0-0x00000001898798E0 */ get; } // 0x0000000189C00230-0x0000000189C00300 
            public int assetJobActiveCount { /* [XID] */ /* 0x00000001899316D0-0x00000001899316F0 */ get; } // 0x0000000189C00160-0x0000000189C00230 
            public int assetJobQueueCount { /* [XID] */ /* 0x0000000189888230-0x0000000189888250 */ get; } // 0x0000000189C00300-0x0000000189C003D0 
            public int bundleJobCount { /* [XID] */ /* 0x0000000189974B30-0x0000000189974B50 */ get; } // 0x0000000189C004A0-0x0000000189C00570 
            public int bundleJobActiveCount { /* [XID] */ /* 0x0000000189983C90-0x0000000189983CB0 */ get; } // 0x0000000189C003D0-0x0000000189C004A0 
            public int bundleJobQueueCount { /* [XID] */ /* 0x0000000189993180-0x00000001899931A0 */ get; } // 0x0000000189C00570-0x0000000189C00640 
            public int unloadJobCount { /* [XID] */ /* 0x00000001898A5C90-0x00000001898A5CB0 */ get; } // 0x0000000189C00AE0-0x0000000189C00BB0 
            public int unloadJobActiveCount { /* [XID] */ /* 0x0000000189A733A0-0x0000000189A733C0 */ get; } // 0x0000000189C00A10-0x0000000189C00AE0 
            public int unloadJobQueueCount { /* [XID] */ /* 0x00000001898B45E0-0x00000001898B4600 */ get; } // 0x0000000189C00BB0-0x0000000189C00C80 
            public string[] undergoingAssetJobNames { /* [XID] */ /* 0x0000000189AEF270-0x0000000189AEF290 */ get; } // 0x0000000189C007A0-0x0000000189C00870 
            public string[] undergoingUnloadedAssetJobNames { /* [XID] */ /* 0x00000001898C3810-0x00000001898C3830 */ get; } // 0x0000000189C00940-0x0000000189C00A10 
            public string[] undergoingBundleJobNames { /* [XID] */ /* 0x0000000189B28C00-0x0000000189B28C20 */ get; } // 0x0000000189C00870-0x0000000189C00940 
            public string activeJobAndJobQueueInfo { /* [XID] */ /* 0x0000000189B378A0-0x0000000189B378C0 */ get; } // 0x0000000189BFFEF0-0x0000000189BFFFC0 
            public abstract bool useAssetBundles { get; set; }
            public virtual bool idle { /* [XID] */ /* 0x0000000189771870-0x0000000189771890 */ get; } // 0x0000000189C00640-0x0000000189C00700 
            public ExternalResourceProvider provider { /* [XID] */ /* 0x00000001898F8A30-0x00000001898F8A50 */ get; } // 0x0000000189C00700-0x0000000189C007A0 

            // Constructors
            public Runtime() { } // 0x0000000189BFFE70-0x0000000189BFFEF0

            // Methods
            // [XID] // 0x00000001898DA250-0x00000001898DA270
            public virtual void UnloadBundleExplicitly(int bundleHash) { } // 0x0000000189BFFC10-0x0000000189BFFCE0
                                                                           // [XID] // 0x00000001898E1E70-0x00000001898E1E90
            public void ForceUnload() { } // 0x0000000189BFEB00-0x0000000189BFEBC0
                                          // [XID] // 0x0000000189B55900-0x0000000189B55920
            public string HashToPath(ulong hash) => default; // 0x0000000189BFEBC0-0x0000000189BFECA0
                                                             // [XID] // 0x0000000189900350-0x0000000189900370
            public virtual void Init() { } // 0x0000000189BFECA0-0x0000000189BFED40
            public bool CheckPathExists<T>(string path, out ulong hash)
            {
                hash = default;
                return default;
            }
            public bool CheckHashExists<T>(ulong hash) => default;
            [DebuggerHidden] // 0x0000000189907A10-0x0000000189907A50
                             // [XID] // 0x0000000189907A10-0x0000000189907A50
            public IEnumerator BlockWarmUp(Action<float> progressCB = null) => default; // 0x0000000189BFE520-0x0000000189BFE640
                                                                                        // [XID] // 0x0000000189912190-0x00000001899121B0
            public void ShaderBlockWarmUp() { } // 0x0000000189BFF8E0-0x0000000189BFF9A0
                                                // [XID] // 0x0000000189919D50-0x0000000189919D70
            public void RefreshBlockFile() { } // 0x0000000189BFF170-0x0000000189BFF230
                                               // [XID] // 0x0000000189921230-0x0000000189921250
            public virtual bool LoadResourceIndex(string indexFilePath, bool onlyStreaming) => default; // 0x0000000189BFF060-0x0000000189BFF170
                                                                                                        // [XID] // 0x0000000189705190-0x00000001897051B0
            public virtual void Tick() { } // 0x0000000189BFFB40-0x0000000189BFFC10
                                           // [XID] // 0x000000018977F5C0-0x000000018977F5E0
            public virtual void LateTick() { } // 0x0000000189BFED40-0x0000000189BFEE10
                                               // [XID] // 0x00000001897ACB00-0x00000001897ACB20
            public void UnloadDataBundle() { } // 0x0000000189BFFDB0-0x0000000189BFFE70
                                               // [XID] // 0x000000018993F080-0x000000018993F0A0
            public void Deallocate(GameObject obj, uint handle, bool usePool, bool deActive) { } // 0x0000000189BFE720-0x0000000189BFE860
                                                                                                 // [XID] // 0x000000018966B500-0x000000018966B520
            public virtual void DropUnstartedLoad() { } // 0x0000000189BFEA30-0x0000000189BFEB00
                                                        // [XID] // 0x000000018994DE00-0x000000018994DE20
            public virtual void Destroy() { } // 0x0000000189BFE860-0x0000000189BFE930
                                              // [XID] // 0x0000000189955460-0x0000000189955480
            public void UnloadBundle() { } // 0x0000000189BFFCE0-0x0000000189BFFDB0
                                           // [XID] // 0x000000018995CC60-0x000000018995CC80
            public void CollectBatchLoad(Action<float> progress) { } // 0x0000000189BFE640-0x0000000189BFE720
                                                                     // [XID] // 0x0000000189743CE0-0x0000000189743D00
            public void StartBatchLoad() { } // 0x0000000189BFF9A0-0x0000000189BFFA60
                                             // [XID] // 0x000000018996BD00-0x000000018996BD20
            public virtual void RequestScene(string scenePathInResource, out uint handle)
            {
                handle = default;
            } // 0x0000000189BFF7E0-0x0000000189BFF8E0
              // [IDTag] // 0x0000000189973750-0x0000000189973790
              // [XID] // 0x0000000189973750-0x0000000189973790
            public byte[] LoadBinData(ulong pathHash, int offset, int length)  // 0x0000000189BFEF50-0x0000000189BFF060
            {
                return provider.LoadBinData(pathHash, offset, length);
            }
            public virtual void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles)
                where T : UnityEngine.Object
            { }
            public virtual T RequestResource<T>(ulong pathHash, out uint handle)
                where T : UnityEngine.Object
            {
                handle = default;
                return default;
            }
            public virtual void RequestResource<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
                where T : UnityEngine.Object
            { }
            // [IDTag] // 0x000000018997D810-0x000000018997D850
            // [XID] // 0x000000018997D810-0x000000018997D850
            public virtual GameObject RequestPrefab(ulong pathHash, ref uint handle) => default; // 0x0000000189BFF230-0x0000000189BFF340
                                                                                                 // [IDTag] // 0x00000001899884A0-0x00000001899884E0
                                                                                                 // [XID] // 0x00000001899884A0-0x00000001899884E0
            public virtual void RequestPrefab(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
            {
                job = default;
            } // 0x0000000189BFF5C0-0x0000000189BFF7E0
            public virtual T RequestResource<T>(string assetPathInResource, out uint handle)
                where T : UnityEngine.Object
            {
                handle = default;
                return default;
            }
            public T LoadIndependentResource<T>(string assetPathInResource, out uint handle)
                where T : UnityEngine.Object
            {
                handle = default;
                return default;
            }
            public T LoadIndependentResource<T>(ulong pathHash, out uint handle)
                where T : UnityEngine.Object
            {
                handle = default;
                return default;
            }
            // [IDTag] // 0x00000001899933D0-0x0000000189993410
            // [XID] // 0x00000001899933D0-0x0000000189993410
            public void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length) { } // 0x0000000189BFEE10-0x0000000189BFEF50
            public ulong GetAssetPathHash<T>(string path)
                where T : UnityEngine.Object => default;
            public virtual void RequestResource<T>(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
                where T : UnityEngine.Object
            { }
            // [IDTag] // 0x000000018999DCE0-0x000000018999DD20
            // [XID] // 0x000000018999DCE0-0x000000018999DD20
            public virtual GameObject RequestPrefab(string assetPathInResource, ref uint handle) => default; // 0x0000000189BFF4B0-0x0000000189BFF5C0
                                                                                                             // [IDTag] // 0x00000001899A8780-0x00000001899A87C0
                                                                                                             // [XID] // 0x00000001899A8780-0x00000001899A87C0
            public virtual void RequestPrefab(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
            {
                job = default;
            } // 0x0000000189BFF340-0x0000000189BFF4B0
              // [XID] // 0x00000001899B3270-0x00000001899B3290
            public virtual void DismissResource(uint handle, bool async) { } // 0x0000000189BFE930-0x0000000189BFEA30
                                                                             // [XID] // 0x00000001897BC810-0x00000001897BC830
            public void SwitchUnlimitedMode(bool on)
            {
                if (provider != null)
                {
                    provider.SwitchUnlimitedMode(on);
                }
            } // 0x0000000189BFFA60-0x0000000189BFFB40
            protected abstract ExternalResourceProvider CreateProvider();
        }

        private class StandaloneRuntime : Runtime // TypeDefIndex: 7524
        {
            // Properties
            public override bool useAssetBundles { /* [XID] */ /* 0x0000000189A04EE0-0x0000000189A04F00 */ get => default; /* [XID] */ /* 0x0000000189A0C5D0-0x0000000189A0C5F0 */ set { } } // 0x0000000189C012A0-0x0000000189C01340 0x0000000189C01340-0x0000000189C014A0

            // Constructors
            public StandaloneRuntime() { } // 0x0000000189C01240-0x0000000189C012A0

            // Methods
            // [XID] // 0x0000000189A13F30-0x0000000189A13F50
            protected override ExternalResourceProvider CreateProvider() => default; // 0x0000000189C01180-0x0000000189C01240
        }

        // Constructors
        public ExternalResources() { } // 0x00000001858FA200-0x00000001858FA290

        // Methods
        // [XID] // 0x0000000189B3F230-0x0000000189B3F250
        public void DumpLoadedAssets() { } // 0x00000001858F8EB0-0x00000001858F90A0
                                           // [XID] // 0x0000000189775130-0x0000000189775150
        public string HashToPath(ulong hash) => default; // 0x00000001858F9150-0x00000001858F9220
                                                         // [XID] // 0x000000018960AD00-0x000000018960AD20
        public void UnloadBundleExplicitly(int bundleHash) { } // 0x00000001858F9FD0-0x00000001858FA0A0
                                                               // [XID] // 0x0000000189784390-0x00000001897843B0
        public void ForceUnload() { } // 0x00000001858F90A0-0x00000001858F9150
                                      // [XID] // 0x000000018978BA10-0x000000018978BA30
        private string BuildLoadedResourcesManifest() => default; // 0x00000001858F8670-0x00000001858F8A70
        [DebuggerHidden] // 0x00000001897A2560-0x00000001897A25A0
                         // [XID] // 0x00000001897A2560-0x00000001897A25A0
        public IEnumerator BlockWarmUp(Action<float> progressCB = null) => default; // 0x00000001858F8590-0x00000001858F8670
                                                                                    // [XID] // 0x0000000189A4B640-0x0000000189A4B660
        public void ShaderBlockWarmUp() { } // 0x00000001858F9CE0-0x00000001858F9D90
                                            // [XID] // 0x00000001897B4AB0-0x00000001897B4AD0
        public void RefreshBlockFile() { } // 0x00000001858F96B0-0x00000001858F9760
        public bool CheckPathExists<T>(string path, out ulong hash)
        {
            hash = default;
            return default;
        }
        public bool CheckHashExists<T>(ulong hash) => default;
        // [XID] // 0x00000001897C3E50-0x00000001897C3E70
        public void Init() { } // 0x00000001858F9220-0x00000001858F92E0
                               // [XID] // 0x00000001897CB6A0-0x00000001897CB6C0
        public bool LoadResourceIndex(string indexFilePath, bool onlyStreaming) => default; // 0x00000001858F95C0-0x00000001858F96B0
                                                                                            // [XID] // 0x00000001896EEC60-0x00000001896EEC80
        public void Tick() { } // 0x00000001858F9F10-0x00000001858F9FD0
                               // [XID] // 0x0000000189A5A650-0x0000000189A5A670
        public void Deallocate(GameObject obj, uint handle, bool usePool, bool deActive) { } // 0x00000001858F8B30-0x00000001858F8C40
                                                                                             // [XID] // 0x00000001897E2100-0x00000001897E2120
        public void LateTick() { } // 0x00000001858F92E0-0x00000001858F93A0
                                   // [XID] // 0x00000001897E9900-0x00000001897E9920
        public void DropUnstartedLoads() { } // 0x00000001858F8DF0-0x00000001858F8EB0
                                             // [XID] // 0x00000001897F1540-0x00000001897F1560
        public void UnloadDataBundle() { } // 0x00000001858FA150-0x00000001858FA200
                                           // [XID] // 0x00000001897F8C90-0x00000001897F8CB0
        public void Destroy() { } // 0x00000001858F8C40-0x00000001858F8D00
                                  // [XID] // 0x000000018978E600-0x000000018978E620
        public void UnloadBundle() { } // 0x00000001858FA0A0-0x00000001858FA150
                                       // [XID] // 0x0000000189807A20-0x0000000189807A40
        public void CollectBatchLoad(Action<float> progress) { } // 0x00000001858F8A70-0x00000001858F8B30
                                                                 // [XID] // 0x000000018980F0B0-0x000000018980F0D0
        public void StartBatchLoad() { } // 0x00000001858F9D90-0x00000001858F9E40
                                         // [XID] // 0x0000000189816860-0x0000000189816880
        public void RequestScene(string scenePathInResource, out uint handle)
        {
            handle = default;
        } // 0x00000001858F9BA0-0x00000001858F9CE0
        public void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles)
            where T : UnityEngine.Object
        { }
        // [IDTag] // 0x000000018981E140-0x000000018981E180
        // [XID] // 0x000000018981E140-0x000000018981E180
        public byte[] LoadBinData(ulong pathHash, int offset, int length)
        {
            _runtime.LoadBinData(pathHash, offset, length);
        }// 0x00000001858F93A0-0x00000001858F94A0
         // [IDTag] // 0x00000001898288E0-0x0000000189828920
         // [XID] // 0x00000001898288E0-0x0000000189828920
        public void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length) { } // 0x00000001858F94A0-0x00000001858F95C0
        public T RequestResource<T>(ulong pathHash, out uint handle)
            where T : UnityEngine.Object
        {
            handle = default;
            return default;
        }
        public void RequestResource<T>(ulong pathHash, ILoadedResourceReceiver<T> receiver)
            where T : UnityEngine.Object
        { }
        public void RequestResource<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
            where T : UnityEngine.Object
        { }
        // [IDTag] // 0x0000000189832CE0-0x0000000189832D20
        // [XID] // 0x0000000189832CE0-0x0000000189832D20
        public void RequestPrefab(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
        {
            job = default;
        } // 0x00000001858F9A70-0x00000001858F9BA0
          // [IDTag] // 0x000000018983D370-0x000000018983D3B0
          // [XID] // 0x000000018983D370-0x000000018983D3B0
        public GameObject RequestPrefab(ulong pathHash, ref uint handle) => default; // 0x00000001858F9890-0x00000001858F9980
        public T RequestResource<T>(string assetPathInResource, out uint handle)
            where T : UnityEngine.Object
        {
            handle = default;
            return default;
        }
        public T LoadIndependentResource<T>(string assetPathInResource, out uint handle)
            where T : UnityEngine.Object
        {
            handle = default;
            return default;
        }
        public T LoadIndependentResource<T>(ulong pathHash, out uint handle)
            where T : UnityEngine.Object
        {
            handle = default;
            return default;
        }
        public void RequestResource<T>(string assetPathInResource, ILoadedResourceReceiver<T> receiver)
            where T : UnityEngine.Object
        { }
        public ulong GetAssetPathHash<T>(string path)
            where T : UnityEngine.Object => default;
        public void RequestResource<T>(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
            where T : UnityEngine.Object
        { }
        // [IDTag] // 0x0000000189847780-0x00000001898477C0
        // [XID] // 0x0000000189847780-0x00000001898477C0
        public void RequestPrefab(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
        {
            job = default;
        } // 0x00000001858F9760-0x00000001858F9890
          // [IDTag] // 0x0000000189851B60-0x0000000189851BA0
          // [XID] // 0x0000000189851B60-0x0000000189851BA0
        public GameObject RequestPrefab(string assetPathInResource, ref uint handle) => default; // 0x00000001858F9980-0x00000001858F9A70
                                                                                                 // [XID] // 0x000000018985C100-0x000000018985C120
        public void DismissResource(uint handle, bool async) { } // 0x00000001858F8D00-0x00000001858F8DF0
                                                                 // [XID] // 0x00000001896B3DF0-0x00000001896B3E10
        public void SwitchUnlimitedMode(bool on)
        {
            _runtime.SwitchUnlimitedMode(on);
        } // 0x00000001858F9E40-0x00000001858F9F10
    }
}
