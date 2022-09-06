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
    public class AssetBundleExternalResourceProvider : ExternalResourceProvider // TypeDefIndex: 7504
    {
        // Fields
        public static Action<ResourceTickDump> onTickFinish; // 0x00
        private readonly MultiLaneResourceWorkLine<AssetLoadJob> _assetJobs; // 0x20
        private readonly MonoLaneResourceWorkLine<BundleLoadJob> _bundleJobs; // 0x28
        private readonly QueueResourceWorkLine<AssetUnloadJob> _unloadJobs; // 0x30
        private readonly MultiLaneResourceWorkLine<PrefabLoadJob> _prefabJobs; // 0x38
        public static int max_count; // 0x08
        public static int max_request; // 0x0C
        public static int max_active; // 0x10
        private ResourceTickDump _dump; // 0x40
        private readonly List<AssetBatch> _assetBatchList; // 0x58
        private readonly Dictionary<int, ulong> _identifierDict; // 0x60
        private readonly Dictionary<ulong, List<AssetLoadBase>> _batchLoadDict; // 0x68
        private readonly HashSet<int> _batchLoadedBundle; // 0x70
        private readonly SliceFrameWatch _assetBatchWatcher; // 0x78
        public bool isBatchLoading; // 0x80
        private bool _dropBatch; // 0x81
        private readonly IDictionary<uint, ulong> _independentHandles; // 0x88
        private readonly IDictionary<ResourceIdentifier, AssetLoadJob> _loadingAssets; // 0x90
        private readonly IDictionary<int, BundleLoadJob> _loadingBundles; // 0x98
        private readonly LoadedResourcesCollection _loadedResources; // 0xA0
        private bool _useUnload; // 0xA8
        public static AssetBundleExternalResourceProvider Instance; // 0x18
        private ResourceIndex _localResourceIndex; // 0xB0
        private HashSet<ulong> _lostAssetSet; // 0xB8
        private static string GameObjectFullName; // 0x20

        // Properties
        public override Dictionary<int, LoadedBundle> allLoadedBundles { /* [XID] */ /* 0x0000000189750020-0x0000000189750040 */ get => default; } // 0x00000001853F8E40-0x00000001853F8F00 
        public override List<string> allLoadedAsset { /* [XID] */ /* 0x0000000189757700-0x0000000189757720 */ get => default; } // 0x00000001853F8470-0x00000001853F8E40 
        public override int assetJobCount { /* [XID] */ /* 0x000000018975F010-0x000000018975F030 */ get => default; } // 0x00000001853F8FC0-0x00000001853F9080 
        public override int assetJobActiveCount { /* [XID] */ /* 0x0000000189766370-0x0000000189766390 */ get => default; } // 0x00000001853F8F00-0x00000001853F8FC0 
        public override int assetJobQueueCount { /* [XID] */ /* 0x000000018976DBA0-0x000000018976DBC0 */ get => default; } // 0x00000001853F9080-0x00000001853F9140 
        public override int bundleJobCount { /* [XID] */ /* 0x0000000189775150-0x0000000189775170 */ get => default; } // 0x00000001853F9200-0x00000001853F92C0 
        public override int bundleJobActiveCount { /* [XID] */ /* 0x000000018977CA60-0x000000018977CA80 */ get => default; } // 0x00000001853F9140-0x00000001853F9200 
        public override int bundleJobQueueCount { /* [XID] */ /* 0x00000001897843B0-0x00000001897843D0 */ get => default; } // 0x00000001853F92C0-0x00000001853F9380 
        public override int unloadJobCount { /* [XID] */ /* 0x000000018978BA30-0x000000018978BA50 */ get => default; } // 0x00000001853F9C80-0x00000001853F9D40 
        public override int unloadJobActiveCount { /* [XID] */ /* 0x00000001898F6F80-0x00000001898F6FA0 */ get => default; } // 0x00000001853F9BC0-0x00000001853F9C80 
        public override int unloadJobQueueCount { /* [XID] */ /* 0x000000018979A5D0-0x000000018979A5F0 */ get => default; } // 0x00000001853F9D40-0x00000001853F9E00 
        public override string[] undergoingAssetJobNames { /* [XID] */ /* 0x00000001897A25A0-0x00000001897A25C0 */ get => default; } // 0x00000001853F9710-0x00000001853F98A0 
        public override string[] undergoingUnloadedAssetJobNames { /* [XID] */ /* 0x00000001897A9BD0-0x00000001897A9BF0 */ get => default; } // 0x00000001853F9A30-0x00000001853F9BC0 
        public override string[] undergoingBundleJobNames { /* [XID] */ /* 0x00000001897B13F0-0x00000001897B1410 */ get => default; } // 0x00000001853F98A0-0x00000001853F9A30 
        public override string activeJobAndJobQueueInfo { /* [XID] */ /* 0x00000001897B8FC0-0x00000001897B8FE0 */ get => default; } // 0x00000001853F8140-0x00000001853F8470 
        public override bool IsBatchCollect { /* [XID] */ /* 0x000000018980D750-0x000000018980D770 */ get => default; } // 0x00000001853F7F60-0x00000001853F8080 
        public override bool IsWaitBatch { /* [XID] */ /* 0x0000000189814E30-0x0000000189814E50 */ get => default; } // 0x00000001853F8080-0x00000001853F8140 
        private bool needBatch { /* [XID] */ /* 0x000000018983A220-0x000000018983A240 */ get => default; } // 0x00000001853F95F0-0x00000001853F9710 
        protected ResourceIndex localResourceIndex { /* [XID] */ /* 0x0000000189866110-0x0000000189866130 */ get => default; } // 0x00000001853F9540-0x00000001853F95F0 
        public override bool idle { /* [XID] */ /* 0x00000001898A1220-0x00000001898A1240 */ get => default; } // 0x00000001853F9380-0x00000001853F9540 

        // Nested types
        public struct ResourceTickDump // TypeDefIndex: 7505
        {
            // Fields
            public int bundleJobsCount; // 0x00
            public int assetJobCount; // 0x04
            public int prefabJobCount; // 0x08
            public int bundleTickHandleCount; // 0x0C
            public int assetTickHandleCount; // 0x10
            public int prefabTickHandleCount; // 0x14
        }

        public interface IBundleLoadProxy // TypeDefIndex: 7506
        {
            // Methods
            bool HasBundleLoaded(int bundleHash);
            void AddLoadedBundle(int bundleHash, AssetBundle bundle);
            void IncreaseBundleUsageCount(int bundleHash, int times);
            bool GetBlockInfo(int bundleHash, out BlockInfo info, out BlockFile file);
        }

        public interface IAssetLoadProxy // TypeDefIndex: 7507
        {
            // Properties
            ResourceIndex LocalResourceIndex { get; }

            // Methods
            ulong GetPathHash(uint handle);
            bool IsAssetBeingLoaded(ResourceIdentifier identifier);
            bool HasAssetLoaded(ResourceIdentifier identifier);
            void ReportAssetBeingLoaded(ResourceIdentifier identifier, AssetLoadJob job);
            void ReportAssetFinishedLoading(ResourceIdentifier identifier);
            uint LoadFromBundle(ResourceIdentifier identifier);
            UnityEngine.Object SyncLoadAsset(ResourceIdentifier identifier);
            GameObject SyncLoadPrefab(uint handle, bool addHandle);
            uint LoadPrefabFromBundle(ResourceIdentifier identifier);
            bool GetPrefabFromBundle(uint handle, out GameObject obj);
            void AddBundleLoadJob(int bundleHash, out BundleLoadResultReceiver receiver);
            void RequestResource<T>(AssetJobPriority priority, ILoadedResourceReceiver<T> receiver, uint handle)
                where T : UnityEngine.Object;
            void IncreaseBundleUsageCounts(ResourceIdentifier identifier);
            void DecreaseBundleUsageCount(ResourceIdentifier identifier);
            void DecreaseBundleUsageCount(int bundleHash);
            void AddLoadedAsset(ResourceIdentifier identifier, UnityEngine.Object asset);
            UnityEngine.Object UseLoadedAsset(ResourceIdentifier identifier);
            void RemoveResourceHandle(uint handle);
            AssetLoadJob GetAssetLoadJob(ResourceIdentifier identifier);
            byte[] LoadBinData(ResourceIdentifier identifier, int offset, int length);
            ulong LoadBinDataASync(ResourceIdentifier resource, int offset, int length);
            int GetBinDataLength(ResourceIdentifier resource);
        }

        public interface IAssetReleaseProxy // TypeDefIndex: 7508
        {
            // Properties
            ResourceIndex LocalResourceIndex { get; }

            // Methods
            void DecreaseBundleUsageCount(int bundleHash);
        }

        private class BundleLoadProxy : ExternalResourceProvider.PrivateProxy<AssetBundleExternalResourceProvider>, IBundleLoadProxy // TypeDefIndex: 7509
        {
            // Constructors
            public BundleLoadProxy() { } // Dummy constructor
            public BundleLoadProxy(AssetBundleExternalResourceProvider resources) { } // 0x00000001868F6F80-0x00000001868F7000

            // Methods
            // [XID] // 0x00000001899B8C90-0x00000001899B8CB0
            public bool HasBundleLoaded(int bundleHash) => default; // 0x00000001868F6DA0-0x00000001868F6E80
                                                                    // [XID] // 0x000000018982CCB0-0x000000018982CCD0
            public void AddLoadedBundle(int bundleHash, AssetBundle bundle) { } // 0x00000001868F6A90-0x00000001868F6BD0
                                                                                // [XID] // 0x0000000189A37340-0x0000000189A37360
            public void IncreaseBundleUsageCount(int bundleHash, int times) { } // 0x00000001868F6E80-0x00000001868F6F80
                                                                                // [XID] // 0x00000001898343E0-0x0000000189834400
            public bool GetBlockInfo(int bundleHash, out BlockInfo info, out BlockFile file)
            {
                info = default;
                file = default;
                return default;
            } // 0x00000001868F6BD0-0x00000001868F6DA0
        }

        private class AssetLoadProxy : ExternalResourceProvider.PrivateProxy<AssetBundleExternalResourceProvider>, IAssetLoadProxy // TypeDefIndex: 7510
        {
            // Properties
            public ResourceIndex LocalResourceIndex { /* [XID] */ /* 0x00000001899E5F20-0x00000001899E5F40 */ get => default; } // 0x00000001868E9D00-0x00000001868E9DC0 

            // Constructors
            public AssetLoadProxy() { } // Dummy constructor
            public AssetLoadProxy(AssetBundleExternalResourceProvider resources) { } // 0x00000001868E9C80-0x00000001868E9D00

            // Methods
            // [XID] // 0x0000000189A3EA50-0x0000000189A3EA70
            public byte[] LoadBinData(ResourceIdentifier identifier, int offset, int length) => default; // 0x00000001868E90A0-0x00000001868E91C0
                                                                                                         // [XID] // 0x000000018983B770-0x000000018983B790
            public ulong GetPathHash(uint handle) => default; // 0x00000001868E8A10-0x00000001868E8B20
                                                              // [XID] // 0x00000001899ED080-0x00000001899ED0A0
            public bool IsAssetBeingLoaded(ResourceIdentifier identifier) => default; // 0x00000001868E8E00-0x00000001868E8F80
                                                                                      // [XID] // 0x00000001899F4D60-0x00000001899F4D80
            public bool HasAssetLoaded(ResourceIdentifier identifier) => default; // 0x00000001868E8C10-0x00000001868E8D10
                                                                                  // [XID] // 0x000000018984A3F0-0x000000018984A410
            public int GetBinDataLength(ResourceIdentifier resource) => default; // 0x00000001868E8910-0x00000001868E8A10
                                                                                 // [XID] // 0x0000000189A5C9E0-0x0000000189A5CA00
            public GameObject SyncLoadPrefab(uint handle, bool addHandle) => default; // 0x00000001868E9960-0x00000001868E9B80
                                                                                      // [XID] // 0x0000000189A642D0-0x0000000189A642F0
            public void ReportAssetBeingLoaded(ResourceIdentifier identifier, AssetLoadJob job) { } // 0x00000001868E9490-0x00000001868E9610
                                                                                                    // [XID] // 0x0000000189860350-0x0000000189860370
            public void ReportAssetFinishedLoading(ResourceIdentifier identifier) { } // 0x00000001868E9610-0x00000001868E9790
                                                                                      // [XID] // 0x0000000189A19A40-0x0000000189A19A60
            public uint LoadFromBundle(ResourceIdentifier identifier) => default; // 0x00000001868E91C0-0x00000001868E92C0
                                                                                  // [XID] // 0x0000000189A210A0-0x0000000189A210C0
            public UnityEngine.Object SyncLoadAsset(ResourceIdentifier identifier) => default; // 0x00000001868E9790-0x00000001868E9960
                                                                                               // [XID] // 0x0000000189A28410-0x0000000189A28430
            public void AddBundleLoadJob(int bundleHash, out BundleLoadResultReceiver resultReceiver)
            {
                resultReceiver = default;
            } // 0x00000001868E8240-0x00000001868E8330
              // [XID] // 0x0000000189A2FC50-0x0000000189A2FC70
            public void IncreaseBundleUsageCounts(ResourceIdentifier identifier) { } // 0x00000001868E8D10-0x00000001868E8E00
                                                                                     // [IDTag] // 0x0000000189A37580-0x0000000189A375C0
                                                                                     // [XID] // 0x0000000189A37580-0x0000000189A375C0
            public void DecreaseBundleUsageCount(int bundleHash) { } // 0x00000001868E85B0-0x00000001868E8680
                                                                     // [XID] // 0x0000000189A41C20-0x0000000189A41C40
            public void AddLoadedAsset(ResourceIdentifier identifier, UnityEngine.Object asset) { } // 0x00000001868E8330-0x00000001868E8440
                                                                                                    // [XID] // 0x0000000189A49230-0x0000000189A49250
            public UnityEngine.Object UseLoadedAsset(ResourceIdentifier identifier) => default; // 0x00000001868E9B80-0x00000001868E9C80
                                                                                                // [XID] // 0x000000018988C780-0x000000018988C7A0
            public void RemoveResourceHandle(uint handle) { } // 0x00000001868E93C0-0x00000001868E9490
                                                              // [XID] // 0x0000000189A99070-0x0000000189A99090
            public uint LoadPrefabFromBundle(ResourceIdentifier identifier) => default; // 0x00000001868E92C0-0x00000001868E93C0
            public void RequestResource<T>(AssetJobPriority priority, ILoadedResourceReceiver<T> receiver, uint handle)
                where T : UnityEngine.Object
            { }
            // [XID] // 0x0000000189947C30-0x0000000189947C50
            public bool GetPrefabFromBundle(uint handle, out GameObject obj)
            {
                obj = default;
                return default;
            } // 0x00000001868E8B20-0x00000001868E8C10
              // [XID] // 0x0000000189A676E0-0x0000000189A67700
            public AssetLoadJob GetAssetLoadJob(ResourceIdentifier identifier) => default; // 0x00000001868E8680-0x00000001868E8910
                                                                                           // [XID] // 0x0000000189A6EBE0-0x0000000189A6EC00
            public ulong LoadBinDataASync(ResourceIdentifier resource, int offset, int length) => default; // 0x00000001868E8F80-0x00000001868E90A0
                                                                                                           // [IDTag] // 0x0000000189A76480-0x0000000189A764C0
                                                                                                           // [XID] // 0x0000000189A76480-0x0000000189A764C0
            public void DecreaseBundleUsageCount(ResourceIdentifier identifier) { } // 0x00000001868E8440-0x00000001868E85B0
        }

        private class AssetReleaseProxy : ExternalResourceProvider.PrivateProxy<AssetBundleExternalResourceProvider>, IAssetReleaseProxy // TypeDefIndex: 7511
        {
            // Properties
            public ResourceIndex LocalResourceIndex { /* [XID] */ /* 0x0000000189AB6B50-0x0000000189AB6B70 */ get => default; } // 0x00000001868EAD90-0x00000001868EAE50 

            // Constructors
            public AssetReleaseProxy() { } // Dummy constructor
            public AssetReleaseProxy(AssetBundleExternalResourceProvider resources) { } // 0x00000001868EAD10-0x00000001868EAD90

            // Methods
            // [XID] // 0x000000018980EEA0-0x000000018980EEC0
            public void DecreaseBundleUsageCount(int bundleHash) { } // 0x00000001868EAC30-0x00000001868EAD10
        }

        private class AssetBatch // TypeDefIndex: 7512
        {
            // Fields
            private float time; // 0x20
            private float startTime; // 0x24

            // Properties
            public AssetBatchLoader assetBatchLoader { /* [XID] */ /* 0x0000000189AA4CB0-0x0000000189AA4CF0 */ get; /* [XID] */ /* 0x0000000189AAF510-0x0000000189AAF550 */ private set; } // 0x00000001853ECEB0-0x00000001853ECF10 0x00000001853ED060-0x00000001853ED0C0
            public Action<float> progress { /* [XID] */ /* 0x0000000189AB9B40-0x0000000189AB9B80 */ get; /* [XID] */ /* 0x00000001895FD210-0x00000001895FD250 */ set; } // 0x00000001853ECF10-0x00000001853ECF70 0x00000001853ED0C0-0x00000001853ED120
            public bool start { /* [XID] */ /* 0x0000000189ACEF90-0x0000000189ACEFB0 */ get => default; } // 0x00000001853ECF70-0x00000001853ED060 

            // Constructors
            public AssetBatch() { } // 0x00000001853ECE40-0x00000001853ECEB0

            // Methods
            // [XID] // 0x00000001898DEE50-0x00000001898DEE70
            public void Start() { } // 0x00000001853ECBE0-0x00000001853ECE40
                                    // [XID] // 0x0000000189ADE7A0-0x0000000189ADE7C0
            public void Init(Action<float> progress) { } // 0x00000001853EC9C0-0x00000001853ECBE0
                                                         // [XID] // 0x0000000189AE60C0-0x0000000189AE60E0
            public void Destroy() { } // 0x00000001853EC670-0x00000001853EC9C0
                                      // [XID] // 0x0000000189AED650-0x0000000189AED670
            public void AddTime(float t) { } // 0x00000001853EC5B0-0x00000001853EC670
        }

        private abstract class AssetLoadBase : IJobProxy, ComplexAsyncJobProxy // TypeDefIndex: 7513
        {
            // Fields
            protected bool _drop; // 0x10

            // Constructors
            protected AssetLoadBase() { } // 0x00000001868E7B00-0x00000001868E7B70

            // Methods
            public abstract void Load();
            // [XID] // 0x0000000189AF5040-0x0000000189AF5060
            public virtual void Destroy() { } // 0x00000001868E7A60-0x00000001868E7B00
            public abstract string Dump();
            // [XID] // 0x00000001897C3CB0-0x00000001897C3CD0
            public void Abort(bool byUser) { } // 0x00000001868E79B0-0x00000001868E7A60
            public abstract void Dismiss(object voucher);
            public abstract AsyncJob GetAbortJob();
            public abstract bool CheckVoucher(object voucher);
        }

        private class BinLoadItem : AssetLoadBase // TypeDefIndex: 7514
        {
            // Fields
            protected ulong _hash; // 0x18
            private ILoadedResourceReceiverOfBinData _receiver; // 0x20
            private int _offset; // 0x28
            private int _length; // 0x2C

            // Constructors
            public BinLoadItem() { } // 0x00000001868F3B40-0x00000001868F3BF0

            // Methods
            // [XID] // 0x0000000189B03DD0-0x0000000189B03DF0
            public override bool CheckVoucher(object voucher) => default; // 0x00000001868F3390-0x00000001868F3450
                                                                          // [XID] // 0x0000000189ABE5E0-0x0000000189ABE600
            public override void Dismiss(object voucher) { } // 0x00000001868F3550-0x00000001868F3600
                                                             // [XID] // 0x0000000189B12CE0-0x0000000189B12D00
            public override void Load() { } // 0x00000001868F38E0-0x00000001868F3AE0
                                            // [XID] // 0x0000000189B1A1B0-0x0000000189B1A1D0
            public void Init(ulong hash, ILoadedResourceReceiverOfBinData receiver, int offset, int length) { } // 0x00000001868F37E0-0x00000001868F38E0
                                                                                                                // [XID] // 0x0000000189B21660-0x0000000189B21680
            public override void Destroy() { } // 0x00000001868F3450-0x00000001868F3550
                                               // [XID] // 0x0000000189B28E30-0x0000000189B28E50
            public override string Dump() => default; // 0x00000001868F3600-0x00000001868F36B0
                                                      // [XID] // 0x0000000189ACD6A0-0x0000000189ACD6C0
            public override AsyncJob GetAbortJob() => default; // 0x00000001868F36B0-0x00000001868F37E0
        }

        private class AssetLoadItem<T> : AssetLoadBase // TypeDefIndex: 7515
            where T : UnityEngine.Object
        {
            // Fields
            protected ulong _hash;
            private ILoadedResourceReceiver<T> _receiver;

            // Constructors
            public AssetLoadItem() { }

            // Methods
            public override bool CheckVoucher(object voucher) => default;
            public override void Dismiss(object voucher) { }
            public override AsyncJob GetAbortJob() => default;
            public override void Load() { }
            public void Init(ulong hash, ILoadedResourceReceiver<T> receiver) { }
            public override void Destroy() { }
            public override string Dump() => default;
        }

        private class PrefabLoadItem : AssetLoadBase // TypeDefIndex: 7516
        {
            // Fields
            protected ulong _hash; // 0x18
            protected uint _handle; // 0x20
            private ILoadedResourceReceiver<GameObject> _receiver; // 0x28

            // Constructors
            public PrefabLoadItem() { } // 0x0000000186904920-0x00000001869049D0

            // Methods
            // [XID] // 0x0000000189B37A60-0x0000000189B37A80
            public override bool CheckVoucher(object voucher) => default; // 0x0000000186904100-0x00000001869041C0
                                                                          // [XID] // 0x0000000189B3F3E0-0x0000000189B3F400
            public override void Dismiss(object voucher) { } // 0x00000001869042C0-0x0000000186904370
                                                             // [XID] // 0x0000000189B46D80-0x0000000189B46DA0
            public override AsyncJob GetAbortJob() => default; // 0x0000000186904420-0x0000000186904550
                                                               // [XID] // 0x0000000189B4E5F0-0x0000000189B4E610
            public override void Load() { } // 0x0000000186904630-0x00000001869048C0
                                            // [XID] // 0x0000000189AF3800-0x0000000189AF3820
            public void Init(ulong hash, ILoadedResourceReceiver<GameObject> receiver, uint handle) { } // 0x0000000186904550-0x0000000186904630
                                                                                                        // [XID] // 0x0000000189B02640-0x0000000189B02660
            public override void Destroy() { } // 0x00000001869041C0-0x00000001869042C0
                                               // [XID] // 0x0000000189B64DA0-0x0000000189B64DC0
            public override string Dump() => default; // 0x0000000186904370-0x0000000186904420
        }

        private struct DependencyBundleHolder : IDisposable // TypeDefIndex: 7517
        {
            // Fields
            private readonly List<int> _bundles; // 0x00

            // Properties
            public List<int> bundles { /* [XID] */ /* 0x0000000189B6C250-0x0000000189B6C270 */ get => default; } // 0x0000000186902160-0x0000000186902190 

            // Constructors
            public DependencyBundleHolder(ResourceIdentifier request, ResourceIndex resourceIndex) : this()
            {
                _bundles = default;
            } // 0x00000001869020A0-0x0000000186902160

            // Methods
            // [XID] // 0x0000000189B73950-0x0000000189B73970
            public void Dispose() { } // 0x0000000186901FC0-0x00000001869020A0
        }

        // Constructors
        public AssetBundleExternalResourceProvider() { } // 0x00000001853F79E0-0x00000001853F7F60
        static AssetBundleExternalResourceProvider() { } // 0x00000001853F7920-0x00000001853F79E0

        // Methods
        // [XID] // 0x00000001897C10F0-0x00000001897C1110
        public override void UnloadBundleExplicitly(int bundlehash) { } // 0x00000001853F5F80-0x00000001853F6040
                                                                        // [XID] // 0x00000001897C8A80-0x00000001897C8AA0
        public override void ForceUnload() { } // 0x00000001853EF210-0x00000001853EF2C0
        public override T RequestResource<T>(ulong pathHash, out uint handle)
        {
            handle = default;
            return default;
        }
        public override void RequestResource<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver) { }
        // [IDTag] // 0x00000001897D00F0-0x00000001897D0130
        // [XID] // 0x00000001897D00F0-0x00000001897D0130
        public override void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length) { } // 0x00000001853EFDE0-0x00000001853F00E0
                                                                                                                                                           // [IDTag] // 0x00000001897DAB90-0x00000001897DABD0
                                                                                                                                                           // [XID] // 0x00000001897DAB90-0x00000001897DABD0
        public override void RequestPrefab(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
        {
            job = default;
        } // 0x00000001853F3260-0x00000001853F3770
          // [IDTag] // 0x00000001897E4F50-0x00000001897E4F90
          // [XID] // 0x00000001897E4F50-0x00000001897E4F90
        public override void RequestPrefab(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle)
        {
            job = default;
        } // 0x00000001853F2F20-0x00000001853F3260
          // [XID] // 0x00000001897EFB20-0x00000001897EFB40
        public override void RequestScene(string scenePathInResource, out uint handle)
        {
            handle = default;
        } // 0x00000001853F4120-0x00000001853F43C0
        public override void RequestResource<T>(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver) { }
        public override void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles) { }
        // [XID] // 0x00000001897F7220-0x00000001897F7240
        private void LoadBundle(int bundleHash, out BundleLoadResultReceiver resultReceiver)
        {
            resultReceiver = default;
        } // 0x00000001853F0520-0x00000001853F07F0
          // [XID] // 0x00000001897FE870-0x00000001897FE890
        public ulong LoadBinDataASync(ResourceIdentifier resource, int offset, int length) => default; // 0x00000001853EFCC0-0x00000001853EFDE0
                                                                                                       // [XID] // 0x0000000189673B60-0x0000000189673B80
        public override void CollectBatchLoad(Action<float> progress) { } // 0x00000001853ED850-0x00000001853ED950
                                                                          // [XID] // 0x00000001896BDF60-0x00000001896BDF80
        public override void StartBatchLoad() { } // 0x00000001853F4610-0x00000001853F4700
                                                  // [XID] // 0x0000000189823D60-0x0000000189823D80
        public void WaitForBatch() { } // 0x00000001853F73B0-0x00000001853F7480
                                       // [XID] // 0x000000018982B860-0x000000018982B880
        public string DumpBatch() => default; // 0x00000001853EECC0-0x00000001853EF210
                                              // [XID] // 0x00000001897A54B0-0x00000001897A54D0
        public void ChangeBatchProgress(Action<float> progress) { } // 0x00000001853ED710-0x00000001853ED850
                                                                    // [XID] // 0x00000001898417A0-0x00000001898417C0
        private void RequestBinBatch(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length) { } // 0x00000001853F1CB0-0x00000001853F2590
        private void RequestResourceBatch<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
            where T : UnityEngine.Object
        { }
        // [XID] // 0x0000000189A0C2D0-0x0000000189A0C2F0
        private AsyncJob RequestPrefabBatch(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, uint handle) => default; // 0x00000001853F2590-0x00000001853F2F20
                                                                                                                                                              // [XID] // 0x00000001897ACB20-0x00000001897ACB40
        public bool AssetBatchTick() => default; // 0x00000001853ED120-0x00000001853ED5F0
                                                 // [XID] // 0x0000000189857790-0x00000001898577B0
        public void PostBatch() { } // 0x00000001853F0A70-0x00000001853F1260
                                    // [XID] // 0x000000018985E950-0x000000018985E970
        public void DropBatch() { } // 0x00000001853EE870-0x00000001853EEBE0
                                    // [XID] // 0x000000018986D9C0-0x000000018986D9E0
        private void Work() { } // 0x00000001853F7480-0x00000001853F7920
                                // [XID] // 0x0000000189807820-0x0000000189807840
        private void UnloadTick() { } // 0x00000001853F72F0-0x00000001853F73B0
                                      // [XID] // 0x000000018987C910-0x000000018987C930
        public override void RefreshBlockFile() { } // 0x00000001853F1260-0x00000001853F1320
                                                    // [XID] // 0x0000000189825360-0x0000000189825380
        public bool GetBlockFile(ulong hash, out BlockFile block, out BlockInfo info)
        {
            block = default;
            info = default;
            return default;
        } // 0x00000001853EF2C0-0x00000001853EF470
          // [XID] // 0x000000018988B180-0x000000018988B1A0
        public override string HashToPath(ulong hash) => default; // 0x00000001853EF5C0-0x00000001853EF690
                                                                  // [XID] // 0x0000000189892480-0x00000001898924A0
        public override bool LoadResourceIndex(string indexFilePath, bool onlyStreaming) => default; // 0x00000001853F07F0-0x00000001853F0A70
                                                                                                     // [XID] // 0x0000000189899F10-0x0000000189899F30
        public bool GetPrefab(uint handle, out GameObject g)
        {
            g = default;
            return default;
        } // 0x00000001853EF470-0x00000001853EF5C0
          // [XID] // 0x0000000189860370-0x0000000189860390
        public override void UnloadDataBundle() { } // 0x00000001853F6F40-0x00000001853F72F0
                                                    // [XID] // 0x000000018989B450-0x000000018989B470
        public override string ReportCurrentInfo(string tag) => default; // 0x00000001853F1320-0x00000001853F1CB0
                                                                         // [XID] // 0x00000001898F56D0-0x00000001898F56F0
        public override void Tick() { } // 0x00000001853F4FB0-0x00000001853F50A0
        public override bool CheckHashExists<T>(ulong hash) => default;
        public override bool CheckPathExists<T>(string assetPathInResource, out ulong hash)
        {
            hash = default;
            return default;
        }
        // [XID] // 0x00000001898BEEE0-0x00000001898BEF00
        public override void LateTick() { } // 0x00000001853EFB90-0x00000001853EFCC0
        public override ulong GetAssetPathHash<T>(string assetPathInResource) => default;
        public override T LoadIndependentResource<T>(ulong pathHash, out uint handle)
        {
            handle = default;
            return default;
        }
        // [IDTag] // 0x00000001898C6890-0x00000001898C68D0
        // [XID] // 0x00000001898C6890-0x00000001898C68D0
        public override GameObject RequestPrefab(ulong pathHash, ref uint handle) => default; // 0x00000001853F3A00-0x00000001853F4120
                                                                                              // [XID] // 0x000000018970FC50-0x000000018970FC70
        public override void Deallocate(GameObject obj, uint handle, bool usePool, bool deActive) { } // 0x00000001853ED950-0x00000001853EDB80
                                                                                                      // [IDTag] // 0x00000001898D8810-0x00000001898D8850
                                                                                                      // [XID] // 0x00000001898D8810-0x00000001898D8850
        public override GameObject RequestPrefab(string assetPathInResource, ref uint handle) => default; // 0x00000001853F3770-0x00000001853F3A00
        public override T RequestResource<T>(string assetPathInResource, out uint handle)
        {
            handle = default;
            return default;
        }
        public override T LoadIndependentResource<T>(string assetPathInResource, out uint handle)
        {
            handle = default;
            return default;
        }
        // [XID] // 0x000000018971E800-0x000000018971E820
        public override void ShaderBlockWarmUp() { } // 0x00000001853F43C0-0x00000001853F4610
        [DebuggerHidden] // 0x00000001898EB020-0x00000001898EB060
                         // [XID] // 0x00000001898EB020-0x00000001898EB060
        public override IEnumerator BlockWarmUp(Action<float> progressCB = null) => default; // 0x00000001853ED5F0-0x00000001853ED710
                                                                                             // [IDTag] // 0x00000001898F5870-0x00000001898F58B0
                                                                                             // [XID] // 0x00000001898F5870-0x00000001898F58B0
        public void UnloadBundle(int blockID) { } // 0x00000001853F6040-0x00000001853F6170
                                                  // [XID] // 0x000000018974B930-0x000000018974B950
        public void DeleteBlock(int blockID) { } // 0x00000001853EDE70-0x00000001853EE2A0
                                                 // [IDTag] // 0x0000000189907A50-0x0000000189907A90
                                                 // [XID] // 0x0000000189907A50-0x0000000189907A90
        public override void UnloadBundle() { } // 0x00000001853F62D0-0x00000001853F6F40
                                                // [XID] // 0x0000000189759FC0-0x0000000189759FE0
        public override void DropUnstartedLoads() { } // 0x00000001853EEBE0-0x00000001853EECC0
                                                      // [XID] // 0x0000000189919D70-0x0000000189919D90
        public override void Destroy() { } // 0x00000001853EE2A0-0x00000001853EE4D0
                                           // [IDTag] // 0x0000000189921250-0x0000000189921290
                                           // [XID] // 0x0000000189921250-0x0000000189921290
        public override void UnloadBundle(ulong pathHash) { } // 0x00000001853F6170-0x00000001853F62D0
                                                              // [XID] // 0x0000000189769170-0x0000000189769190
        public override void DismissResource(uint handle, bool async) { } // 0x00000001853EE4D0-0x00000001853EE870
                                                                          // [IDTag] // 0x0000000189933180-0x00000001899331C0
                                                                          // [XID] // 0x0000000189933180-0x00000001899331C0
        public override byte[] LoadBinData(ulong pathHash, int offset = 0 /* Metadata: 0x00ADEC2C */, int length = 0 /* Metadata: 0x00ADEC30 */)
        {
            if (localResourceIndex.CheckIsLegitAssetPath(pathHash))
            {
                var res = localResourceIndex.GetResourceIdentifier(pathHash);
                _binBundles.Add(res.bundleHash);
                return LoadBinData(res, offset, length);
            }
            if (_lostAssetSet.Add(pathHash))
            {
                SuperDebug.LogWarning("Asset " + pathHash + " is not in asset_index");
            }
            return null;
        }// 0x00000001853F0260-0x00000001853F0520
         // [IDTag] // 0x000000018993DA10-0x000000018993DA50
         // [XID] // 0x000000018993DA10-0x000000018993DA50
        private byte[] LoadBinData(ResourceIdentifier request, int offset = 0 /* Metadata: 0x00ADEC34 */, int length = 0 /* Metadata: 0x00ADEC38 */)
        {
            if (_loadedResources.HasBundleLoaded(request.bundleHash) || SyncLoadBundle(request.bundleHash))
            {
                return _loadedResources.LoadBinData(request, offset, length);
            }
            return null;
        }// 0x00000001853F00E0-0x00000001853F0260
         // [XID] // 0x00000001896A0D20-0x00000001896A0D40
        private bool SyncLoadBundle(int bundleHash) => default; // 0x00000001853F4700-0x00000001853F4C90
                                                                // [XID] // 0x0000000189699870-0x0000000189699890
        private bool SyncPrepareAsset(ResourceIdentifier request) => default; // 0x00000001853F4C90-0x00000001853F4FB0
                                                                              // [XID] // 0x0000000189956A80-0x0000000189956AA0
        private void IncreaseBundleUsageCount(int bundleHash, int times = 1 /* Metadata: 0x00ADEC3C */) { } // 0x00000001853EF690-0x00000001853EF770
                                                                                                            // [IDTag] // 0x000000018995E590-0x000000018995E5D0
                                                                                                            // [XID] // 0x000000018995E590-0x000000018995E5D0
        private void IncreaseBundleUsageCounts(List<int> bundleHashs) { } // 0x00000001853EF770-0x00000001853EF880
                                                                          // [XID] // 0x000000018962B810-0x000000018962B830
        private void IncreaseMainBundleUsageCount(ResourceIdentifier request) { } // 0x00000001853EFAC0-0x00000001853EFB90
                                                                                  // [XID] // 0x000000018991B260-0x000000018991B280
        private void IncreaseDependencyBundleUsageCounts(ResourceIdentifier request) { } // 0x00000001853EF960-0x00000001853EFAC0
                                                                                         // [IDTag] // 0x00000001899781A0-0x00000001899781E0
                                                                                         // [XID] // 0x00000001899781A0-0x00000001899781E0
        private void IncreaseBundleUsageCounts(ResourceIdentifier request) { } // 0x00000001853EF880-0x00000001853EF960
                                                                               // [XID] // 0x00000001896B6D40-0x00000001896B6D60
        private void DecreaseBundleUsageCount(int bundleHash, bool async = true /* Metadata: 0x00ADEC40 */) { } // 0x00000001853EDB80-0x00000001853EDC60
                                                                                                                // [XID] // 0x000000018998A0F0-0x000000018998A110
        private void DecreaseBundleUsageCounts(List<int> bundleHashs, bool async = true /* Metadata: 0x00ADEC41 */) { } // 0x00000001853EDC60-0x00000001853EDD80
                                                                                                                        // [XID] // 0x0000000189991A90-0x0000000189991AB0
        private void DecreaseMainBundleUsageCount(ResourceIdentifier request, bool async = true /* Metadata: 0x00ADEC42 */) { } // 0x00000001853EDD80-0x00000001853EDE70
    }
}
