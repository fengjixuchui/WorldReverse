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
	public class SimulatedExternalResourceProvider : ExternalResourceProvider // TypeDefIndex: 7533
	{
		// Fields
		private static bool isBatchLoad; // 0x00
		private readonly IEditorRuntimeSimulator _editorRuntimeSimulator; // 0x20
	
		// Properties
		public static IEditorRuntimeSimulator editorRuntimeSimulator { get; private set; } // 0x00000001868A4300-0x00000001868A4370 0x00000001868A4430-0x00000001868A44A0
		public override bool idle { /* [XID] */ /* 0x00000001896FADB0-0x00000001896FADD0 */ get => default; } // 0x00000001868A4370-0x00000001868A4430 
		public override bool IsBatchCollect { /* [XID] */ /* 0x0000000189718C30-0x0000000189718C50 */ get => default; } // 0x00000001868A4250-0x00000001868A4300 
	
		// Nested types
		public interface IEditorRuntimeSimulator // TypeDefIndex: 7534
		{
			// Properties
			bool idle { get; }
	
			// Methods
			void Tick();
			void Destroy();
			void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles)
				where T : UnityEngine.Object;
			void Unload(uint handle);
			void ClearType(System.Type type);
			bool CheckPathExists<T>(string path, out ulong hash);
			bool CheckHashExists<T>(ulong hash);
			void Refresh();
			void DropUnstartedLoads();
			ulong GetAssetPathHash<T>(string path);
			T Load<T>(string assetPathInResource, out uint resourceHandle)
				where T : UnityEngine.Object;
			void Load<T>(string assetPathInResource, ILoadedResourceReceiver<T> receiver)
				where T : UnityEngine.Object;
			AsyncJob LoadPrefabAsync(string assetPathInResource, ILoadedResourceReceiver<GameObject> receiver, uint handle);
			GameObject LoadPrefab(string assetPathInResource, ref uint handle);
			byte[] LoadBinData(string scenePathInResource);
			byte[] LoadBinData(ulong pathHash, int offset, int length);
			T Load<T>(ulong pathHash, out uint resourceHandle)
				where T : UnityEngine.Object;
			void Load<T>(ulong pathHash, ILoadedResourceReceiver<T> receiver)
				where T : UnityEngine.Object;
			AsyncJob LoadPrefabAsync(ulong pathHash, ILoadedResourceReceiver<GameObject> receiver, uint handle);
			GameObject LoadPrefab(ulong pathHash, ref uint handle);
			string HashToPath(ulong hash);
			byte[] LoadBinData(ulong hash);
			void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length);
		}
	
		public interface IResourceHandleDealer // TypeDefIndex: 7535
		{
			// Methods
			bool TryGetAssetByHandle(uint handle, out ulong internalAsset);
			uint InsertNewResourceHandle(ulong internalAsset);
			bool RemoveResourceHandle(uint handle);
		}
	
		protected class ResourceHandleDealer : ExternalResourceProvider.PrivateProxy<SimulatedExternalResourceProvider>, IResourceHandleDealer // TypeDefIndex: 7536
		{
			// Constructors
			public ResourceHandleDealer() {} // Dummy constructor
			public ResourceHandleDealer(SimulatedExternalResourceProvider resources) {} // 0x000000018689F010-0x000000018689F090
	
			// Methods
			// [XID] // 0x000000018978E880-0x000000018978E8A0
			public bool TryGetAssetByHandle(uint handle, out ulong internalAsset) {
				internalAsset = default;
				return default;
			} // 0x000000018689EF00-0x000000018689F010
			// [XID] // 0x00000001897BEF70-0x00000001897BEF90
			public uint InsertNewResourceHandle(ulong internalAsset) => default; // 0x000000018689ED60-0x000000018689EE30
			// [XID] // 0x000000018979E250-0x000000018979E270
			public bool RemoveResourceHandle(uint handle) => default; // 0x000000018689EE30-0x000000018689EF00
		}
	
		// Constructors
		public SimulatedExternalResourceProvider() {} // 0x00000001868A4160-0x00000001868A4250
	
		// Methods
		// [XID] // 0x00000001896CB660-0x00000001896CB680
		public override void UnloadBundleExplicitly(int bundleHash) {} // 0x00000001868A40B0-0x00000001868A4160
		// [XID] // 0x00000001896D2C10-0x00000001896D2C30
		public override string HashToPath(ulong hash) => default; // 0x00000001868A30A0-0x00000001868A3170
		// [XID] // 0x0000000189B8BE80-0x0000000189B8BEA0
		public static void SetBatchLoad(bool batch) {} // 0x00000001868A3DA0-0x00000001868A3E50
		// [IDTag] // 0x00000001896F0440-0x00000001896F0480
		// [XID] // 0x00000001896F0440-0x00000001896F0480
		public override void LoadBinData(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiverOfBinData receiver, int offset, int length) {} // 0x00000001868A3540-0x00000001868A3670
		// [XID] // 0x000000018985D0C0-0x000000018985D0E0
		public override void Tick() {} // 0x00000001868A3E50-0x00000001868A3F10
		// [XID] // 0x0000000189864B70-0x0000000189864B90
		public override void LateTick() {} // 0x00000001868A34A0-0x00000001868A3540
		// [XID] // 0x000000018986C0D0-0x000000018986C0F0
		public override void DropUnstartedLoads() {} // 0x00000001868A2FE0-0x00000001868A30A0
		public override bool CheckHashExists<T>(ulong hash) => default;
		public override bool CheckPathExists<T>(string path, out ulong hash) {
			hash = default;
			return default;
		}
		public override ulong GetAssetPathHash<T>(string path) => default;
		[DebuggerHidden] // 0x0000000189720460-0x00000001897204A0
		// [XID] // 0x0000000189720460-0x00000001897204A0
		public override IEnumerator BlockWarmUp(Action<float> progressCB = null) => default; // 0x00000001868A2B60-0x00000001868A2C70
		// [XID] // 0x000000018972A8A0-0x000000018972A8C0
		public override void Destroy() {} // 0x00000001868A2D40-0x00000001868A2E30
		// [IDTag] // 0x0000000189731F40-0x0000000189731F80
		// [XID] // 0x0000000189731F40-0x0000000189731F80
		public override byte[] LoadBinData(ulong pathHash, int offset, int count) => default; // 0x00000001868A3670-0x00000001868A3770
		// [XID] // 0x000000018973CAF0-0x000000018973CB10
		public void ClearType(System.Type type) {} // 0x00000001868A2C70-0x00000001868A2D40
		// [XID] // 0x0000000189743FC0-0x0000000189743FE0
		public override void RequestScene(string scenePathInResource, out uint handle) {
			handle = default;
		} // 0x00000001868A3C70-0x00000001868A3DA0
		public override void RequestAllResourcesUnder<T>(ulong[] hashes, IList<T> results, IList<uint> handles) {}
		public override T RequestResource<T>(string assetPathInResource, out uint handle) {
			handle = default;
			return default;
		}
		public override void RequestResource<T>(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver) {}
		// [IDTag] // 0x000000018974BC30-0x000000018974BC70
		// [XID] // 0x000000018974BC30-0x000000018974BC70
		public override GameObject RequestPrefab(string assetPathInResource, ref uint handle) => default; // 0x00000001868A3900-0x00000001868A39F0
		// [IDTag] // 0x00000001897560B0-0x00000001897560F0
		// [XID] // 0x00000001897560B0-0x00000001897560F0
		public override void RequestPrefab(string assetPathInResource, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle) {
			job = default;
		} // 0x00000001868A3770-0x00000001868A3900
		// [IDTag] // 0x0000000189760770-0x00000001897607B0
		// [XID] // 0x0000000189760770-0x00000001897607B0
		public override void RequestPrefab(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<GameObject> receiver, out AsyncJob job, uint handle) {
			job = default;
		} // 0x00000001868A3AE0-0x00000001868A3C70
		// [IDTag] // 0x000000018976AE10-0x000000018976AE50
		// [XID] // 0x000000018976AE10-0x000000018976AE50
		public override GameObject RequestPrefab(ulong pathHash, ref uint handle) => default; // 0x00000001868A39F0-0x00000001868A3AE0
		public override void RequestResource<T>(ulong pathHash, AssetJobPriority priority, ILoadedResourceReceiver<T> receiver) {}
		public override T RequestResource<T>(ulong pathHash, out uint handle) {
			handle = default;
			return default;
		}
		// [XID] // 0x0000000189775110-0x0000000189775130
		public override void DismissResource(uint handle, bool async) {} // 0x00000001868A2E30-0x00000001868A2FE0
		// [XID] // 0x000000018977CA40-0x000000018977CA60
		private IEditorRuntimeSimulator InstantiateSimulator() => default; // 0x00000001868A3170-0x00000001868A34A0
	}
}
