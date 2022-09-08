/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class PrefabLoadJob : ResourceJob, IJobProxy, ComplexAsyncJobProxy // TypeDefIndex: 7400
	{
		// Fields
		public static int jobCount; // 0x08
		public static int requestCount; // 0x0C
		public static float maxWaitInterval; // 0x10
		public static float maxLoadInterval; // 0x14
		public static float maxRequestInterval; // 0x18
		private float _waitTime; // 0x18
		private float _asssetLoadTime; // 0x1C
		private float _requestTime; // 0x20
		private float _loadTime; // 0x24
		public static Action<string, float> onLoadFinish; // 0x20
		private uint _assetHandle; // 0x28
		private ILoadedResourceReceiver<GameObject> _receiver; // 0x40
		private uint _assetRequest; // 0x48
		private uint _signIndx; // 0x4C
		private AsyncJob _assetReceiver; // 0x50
	
		// Properties
		public static AssetBundleExternalResourceProvider.IAssetLoadProxy resourcesProxy { /* [XID] */ /* 0x0000000189A886E0-0x0000000189A88720 */ get; set; } // 0x0000000186C35490-0x0000000186C35520 0x0000000186C35890-0x0000000186C35920
		protected ResourceIdentifier _request { /* [XID] */ /* 0x0000000189A9A9E0-0x0000000189A9AA20 */ get; /* [XID] */ /* 0x0000000189AA4CF0-0x0000000189AA4D30 */ set; } // 0x0000000186C35090-0x0000000186C35100 0x0000000186C35520-0x0000000186C35590
		private ulong pathHash { /* [XID] */ /* 0x0000000189AB6D60-0x0000000189AB6D80 */ get => default; } // 0x0000000186C35300-0x0000000186C353F0 
		private AssetJobPriority priority { /* [XID] */ /* 0x0000000189AC62D0-0x0000000189AC62F0 */ get => default; /* [XID] */ /* 0x0000000189ACD9C0-0x0000000189ACD9E0 */ set {} } // 0x0000000186C353F0-0x0000000186C35490 0x0000000186C357D0-0x0000000186C35890
		private bool addHandle { /* [XID] */ /* 0x0000000189ADD150-0x0000000189ADD170 */ get => default; /* [XID] */ /* 0x0000000189AD5810-0x0000000189AD5830 */ set {} } // 0x0000000186C35100-0x0000000186C351A0 0x0000000186C35590-0x0000000186C35650
		private bool isAborted { /* [XID] */ /* 0x0000000189AE4760-0x0000000189AE4780 */ get => default; /* [XID] */ /* 0x0000000189AEBFD0-0x0000000189AEBFF0 */ set {} } // 0x0000000186C351A0-0x0000000186C35250 0x0000000186C35650-0x0000000186C35710
		private bool loadSucceeded { /* [XID] */ /* 0x0000000189AF39F0-0x0000000189AF3A10 */ get => default; /* [XID] */ /* 0x0000000189AFB220-0x0000000189AFB240 */ set {} } // 0x0000000186C35250-0x0000000186C35300 0x0000000186C35710-0x0000000186C357D0
	
		// Nested types
		public class Spawner : ISpawner<PrefabLoadJob, ResourceIdentifier, ILoadedResourceReceiver<GameObject>, AssetJobPriority, uint> // TypeDefIndex: 7401
		{
			// Constructors
			public Spawner() {} // 0x0000000186C41B60-0x0000000186C41BC0
	
			// Methods
			// [XID] // 0x0000000189B6AD70-0x0000000189B6AD90
			public PrefabLoadJob Spawn(ResourceIdentifier param1, ILoadedResourceReceiver<GameObject> param2, AssetJobPriority param3, uint param4) => default; // 0x0000000186C41A20-0x0000000186C41B60
		}
	
		public class Polisher : IPolisher<PrefabLoadJob, ResourceIdentifier, ILoadedResourceReceiver<GameObject>, AssetJobPriority, uint> // TypeDefIndex: 7402
		{
			// Constructors
			public Polisher() {} // 0x0000000186C32CB0-0x0000000186C32D10
	
			// Methods
			// [XID] // 0x0000000189B72480-0x0000000189B724A0
			public void Polish(PrefabLoadJob reused, ResourceIdentifier param1, ILoadedResourceReceiver<GameObject> param2, AssetJobPriority param3, uint param4) {} // 0x0000000186C32AC0-0x0000000186C32CB0
		}
	
		// Constructors
		public PrefabLoadJob() {} // Dummy constructor
		private PrefabLoadJob(ResourceIdentifier request, ILoadedResourceReceiver<GameObject> receiver, AssetJobPriority priority, uint handle) {} // 0x0000000186C34EF0-0x0000000186C35090
		static PrefabLoadJob() {} // 0x0000000186C34E60-0x0000000186C34EF0
	
		// Methods
		// [XID] // 0x0000000189AAF550-0x0000000189AAF570
		public bool CheckVoucher(object voucher) => default; // 0x0000000186C33450-0x0000000186C33510
		// [XID] // 0x0000000189ABE7E0-0x0000000189ABE800
		public AsyncJob GetAbortJob() => default; // 0x0000000186C336B0-0x0000000186C337A0
		// [XID] // 0x0000000189B02890-0x0000000189B028B0
		public void SetNeedDismiss(bool value) {} // 0x0000000186C34110-0x0000000186C341D0
		// [XID] // 0x0000000189B09EF0-0x0000000189B09F10
		public override void Start() {} // 0x0000000186C341D0-0x0000000186C34330
		// [XID] // 0x0000000189B11840-0x0000000189B11860
		private void SyncLoad() {} // 0x0000000186C34330-0x0000000186C344B0
		// [XID] // 0x0000000189B18A90-0x0000000189B18AB0
		private void QuickFinishWithLoaded() {} // 0x0000000186C33DE0-0x0000000186C34050
		// [XID] // 0x0000000189B20150-0x0000000189B20170
		private void LoadAsset() {} // 0x0000000186C337A0-0x0000000186C33B50
		// [XID] // 0x0000000189B27740-0x0000000189B27760
		private void AsyncLoadGameObjectCallback(ulong pathHash, bool loadSucceeded, uint handle, GameObject asset = null) {} // 0x0000000186C32E20-0x0000000186C33020
		// [XID] // 0x0000000189B2EAD0-0x0000000189B2EAF0
		public override void Abort(bool byUser) {} // 0x0000000186C32D10-0x0000000186C32E20
		// [XID] // 0x0000000189B362C0-0x0000000189B362E0
		private void Finish() {} // 0x0000000186C335E0-0x0000000186C336B0
		// [XID] // 0x0000000189B3D870-0x0000000189B3D890
		public override void Tick() {} // 0x0000000186C344B0-0x0000000186C34E00
		// [XID] // 0x0000000189B45720-0x0000000189B45740
		public override void Recycle() {} // 0x0000000186C34050-0x0000000186C34110
		// [XID] // 0x0000000189B4CD10-0x0000000189B4CD30
		public bool CheckHandle(uint handle) => default; // 0x0000000186C33370-0x0000000186C33450
		// [XID] // 0x0000000189B54340-0x0000000189B54360
		public override void BeforeRecycle() {} // 0x0000000186C33020-0x0000000186C33370
		// [XID] // 0x0000000189B5BF70-0x0000000189B5BF90
		private void QuickFailAborted(bool drop = false /* Metadata: 0x00ADE9A3 */) {} // 0x0000000186C33B50-0x0000000186C33DE0
		// [XID] // 0x0000000189B63430-0x0000000189B63450
		public void Dismiss(object callback) {} // 0x0000000186C33510-0x0000000186C335E0
	}
}
