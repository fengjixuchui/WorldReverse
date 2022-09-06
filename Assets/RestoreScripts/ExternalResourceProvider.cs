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
	public abstract class ExternalResourceProvider // TypeDefIndex: 7519
	{
		// Fields
		public static bool baseLevelLoading; // 0x00
		protected uint _autoIncrement; // 0x10
		protected static bool _unlimited; // 0x01
		protected static bool _loadData; // 0x02
		protected static List<uint> _dataHandles; // 0x08
		protected static HashSet<int> _binBundles; // 0x10
		private readonly Dictionary<uint, ulong> _loadedResourceHandles; // 0x18
		public static ExternalResourceProvider instance; // 0x18
	
		// Properties
		public virtual Dictionary<int, LoadedBundle> allLoadedBundles { /* [XID] */ /* 0x0000000189BBD660-0x0000000189BBD680 */ get; } // 0x00000001858F7B90-0x00000001858F7C30 
		public virtual int assetJobCount { /* [XID] */ /* 0x0000000189B18810-0x0000000189B18830 */ get; } // 0x00000001858F7CD0-0x00000001858F7D70 
		public virtual int assetJobActiveCount { /* [XID] */ /* 0x0000000189B2E900-0x0000000189B2E920 */ get; } // 0x00000001858F7C30-0x00000001858F7CD0 
		public virtual int assetJobQueueCount { /* [XID] */ /* 0x0000000189B3D680-0x0000000189B3D6A0 */ get; } // 0x00000001858F7D70-0x00000001858F7E10 
		public virtual int bundleJobCount { /* [XID] */ /* 0x0000000189BDBDC0-0x0000000189BDBDE0 */ get; } // 0x00000001858F7EB0-0x00000001858F7F50 
		public virtual int bundleJobActiveCount { /* [XID] */ /* 0x00000001895E8670-0x00000001895E8690 */ get; } // 0x00000001858F7E10-0x00000001858F7EB0 
		public virtual int bundleJobQueueCount { /* [XID] */ /* 0x0000000189BACEA0-0x0000000189BACEC0 */ get; } // 0x00000001858F7F50-0x00000001858F7FF0 
		public virtual int unloadJobCount { /* [XID] */ /* 0x0000000189BB4790-0x0000000189BB47B0 */ get; } // 0x00000001858F8450-0x00000001858F84F0 
		public virtual int unloadJobActiveCount { /* [XID] */ /* 0x00000001895FEB70-0x00000001895FEB90 */ get; } // 0x00000001858F83B0-0x00000001858F8450 
		public virtual int unloadJobQueueCount { /* [XID] */ /* 0x00000001896065D0-0x00000001896065F0 */ get; } // 0x00000001858F84F0-0x00000001858F8590 
		public virtual string[] undergoingAssetJobNames { /* [XID] */ /* 0x0000000189628800-0x0000000189628820 */ get; } // 0x00000001858F8090-0x00000001858F8130 
		public virtual string[] undergoingUnloadedAssetJobNames { /* [XID] */ /* 0x0000000189630170-0x0000000189630190 */ get; } // 0x00000001858F81D0-0x00000001858F8270 
		public virtual string[] undergoingBundleJobNames { /* [XID] */ /* 0x000000018961CCC0-0x000000018961CCE0 */ get; } // 0x00000001858F8130-0x00000001858F81D0 
		public virtual List<string> allLoadedAsset { /* [XID] */ /* 0x000000018963F090-0x000000018963F0B0 */ get; } // 0x00000001858F7AF0-0x00000001858F7B90 
		public virtual string activeJobAndJobQueueInfo { /* [XID] */ /* 0x000000018962B9B0-0x000000018962B9D0 */ get; } // 0x00000001858F7A50-0x00000001858F7AF0 
		public static bool unlimited { /* [XID] */ /* 0x00000001896423D0-0x00000001896423F0 */ get; } // 0x00000001858F8270-0x00000001858F83B0 
		public Dictionary<uint, ulong> loadedResourceHandles { /* [XID] */ /* 0x0000000189649C00-0x0000000189649C20 */ get; } // 0x00000001858F7FF0-0x00000001858F8090 
		public virtual bool IsBatchCollect { /* [XID] */ /* 0x00000001896559D0-0x00000001896559F0 */ get; } // 0x00000001858F7900-0x00000001858F79A0 
		public virtual bool IsWaitBatch { /* [XID] */ /* 0x000000018965D160-0x000000018965D180 */ get; } // 0x00000001858F79A0-0x00000001858F7A50 
		public abstract bool idle { get; }
	
		// Nested types
		protected abstract class PrivateProxy<T> // TypeDefIndex: 7520
			where T : ExternalResourceProvider
		{
			// Properties
			protected T _resources { get; private set; }
	
			// Constructors
			protected PrivateProxy() {} // Dummy constructor
			public PrivateProxy(T resources) {}
		}
	
		// Constructors
		public ExternalResourceProvider() {} // 0x00000001858F7800-0x00000001858F7900
		static ExternalResourceProvider() {} // 0x00000001858F7710-0x00000001858F7800
	
		// Methods
		// [XID] // 0x0000000189633480-0x00000001896334A0
		public virtual void ForceUnload() {} // 0x00000001858F6C60-0x00000001858F6D00
		public abstract void UnloadBundleExplicitly(int bundleFileRelativePath);
		// [XID] // 0x0000000189AB23F0-0x0000000189AB2410
		public virtual string HashToPath(ulong hash) => default; // 0x00000001858F6D00-0x00000001858F6DE0
		// [XID] // 0x00000001896C5810-0x00000001896C5830
		public virtual string ReportCurrentInfo(string tag) => default; // 0x00000001858F7250-0x00000001858F7300
		public abstract bool CheckPathExists<T>(string path, out ulong hash);
		public abstract bool CheckHashExists<T>(ulong hash);
		// [XID] // 0x0000000189667B30-0x0000000189667B50
		public static void BeginDataRefresh() {} // 0x00000001858F67C0-0x00000001858F6880
		// [XID] // 0x000000018966F360-0x000000018966F380
		public static void FinishDataRefresh() {} // 0x00000001858F6BA0-0x00000001858F6C60
		// [XID] // 0x0000000189676E50-0x0000000189676E70
		public void Init() {} // 0x00000001858F6DE0-0x00000001858F6E80
		// [XID] // 0x000000018977F5E0-0x000000018977F600
		public virtual bool LoadResourceIndex(string indexFilePath, bool onlystreaming) => default; // 0x00000001858F7010-0x00000001858F70E0
		public abstract T RequestResource<T>(ulong pathHash, out uint handle)
			where T : UnityEngine.Object;
		public abstract void RequestResource<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
			where T : UnityEngine.Object;
		public abstract void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length);
		public abstract GameObject RequestPrefab(ulong pathHash, ref uint handle);
		public abstract void RequestPrefab(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle);
		public virtual T LoadIndependentResource<T>(ulong pathHash, out uint handle)
			where T : UnityEngine.Object {
			handle = default;
			return default;
		}
		public abstract void Tick();
		public abstract void LateTick();
		public abstract void DropUnstartedLoads();
		public abstract void Destroy();
		public abstract IEnumerator BlockWarmUp(Action<float> progressCB = null);
		// [XID] // 0x0000000189795D80-0x0000000189795DA0
		public virtual void ShaderBlockWarmUp() {} // 0x00000001858F7300-0x00000001858F73A0
		// [XID] // 0x000000018968D7A0-0x000000018968D7C0
		public virtual void RefreshBlockFile() {} // 0x00000001858F70E0-0x00000001858F7180
		// [IDTag] // 0x0000000189695390-0x00000001896953D0
		// [XID] // 0x0000000189695390-0x00000001896953D0
		public virtual void UnloadBundle() {} // 0x00000001858F7520-0x00000001858F75C0
		// [XID] // 0x0000000189807800-0x0000000189807820
		public virtual void UnloadDataBundle() {} // 0x00000001858F7670-0x00000001858F7710
		public abstract byte[] LoadBinData(ulong pathHash, int offset = 0 /* Metadata: 0x00ADEC43 */, int length = 0 /* Metadata: 0x00ADEC47 */);
		// [XID] // 0x00000001896DB9E0-0x00000001896DBA00
		public virtual void CollectBatchLoad(Action<float> progress) {} // 0x00000001858F6940-0x00000001858F69F0
		// [XID] // 0x00000001896CCEA0-0x00000001896CCEC0
		public virtual void StartBatchLoad() {} // 0x00000001858F73A0-0x00000001858F7440
		public abstract void RequestScene(string scenePathInResource, out uint handle);
		public abstract void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles)
			where T : UnityEngine.Object;
		public abstract T RequestResource<T>(string assetPathInResource, out uint handle)
			where T : UnityEngine.Object;
		public virtual T LoadIndependentResource<T>(string assetPathInResource, out uint handle)
			where T : UnityEngine.Object {
			handle = default;
			return default;
		}
		public abstract void RequestResource<T>(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver)
			where T : UnityEngine.Object;
		public abstract void RequestPrefab(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle = 0 /* Metadata: 0x00ADEC4B */);
		public abstract ulong GetAssetPathHash<T>(string path)
			where T : UnityEngine.Object;
		public abstract GameObject RequestPrefab(string assetPathInResource, ref uint handle);
		public abstract void DismissResource(uint handle, bool async = true /* Metadata: 0x00ADEC4F */);
		// [IDTag] // 0x00000001896B59A0-0x00000001896B59E0
		// [XID] // 0x00000001896B59A0-0x00000001896B59E0
		public virtual void UnloadBundle(ulong pathHash) {} // 0x00000001858F75C0-0x00000001858F7670
		// [XID] // 0x00000001896BF8B0-0x00000001896BF8D0
		public void SwitchUnlimitedMode(bool on) {} // 0x00000001858F7440-0x00000001858F7520
		// [XID] // 0x0000000189893CD0-0x0000000189893CF0
		public virtual void Deallocate(GameObject obj, uint handle, bool usePool, bool deActive) {} // 0x00000001858F69F0-0x00000001858F6BA0
		// [XID] // 0x00000001896CE980-0x00000001896CE9A0
		protected uint InsertNewResourceHandle(ulong internalAsset) => default; // 0x00000001858F6E80-0x00000001858F7010
		// [XID] // 0x0000000189885230-0x0000000189885250
		protected bool RemoveResourceHandle(uint handle) => default; // 0x00000001858F7180-0x00000001858F7250
		// [XID] // 0x00000001896DD310-0x00000001896DD330
		protected void ClearResourceHandles() {} // 0x00000001858F6880-0x00000001858F6940
	}
}
