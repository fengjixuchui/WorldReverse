/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TickObjectProxyLODManagerEntity : TickObjectProxyLODManager, IEntityTickLODManager // TypeDefIndex: 21299
{
	// Fields
	private BalanceTickGroupEntity _legacyBalanceTickManager; // 0x60
	private BoundsOccluder _boundsOccluder; // 0x68

	// Nested types
	public class LODEventTickStrategyDistance : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21300
	{
		// Fields
		private float halfTickVisibleDistRatio; // 0x18
		private float halfTickInvisibleDistRatio; // 0x1C
		private float eighthTickInvisibleDistRatio; // 0x20

		// Constructors
		public LODEventTickStrategyDistance() {} // Dummy constructor
		public LODEventTickStrategyDistance(float inHalfTickVisibleDistRatio, float inHalfTickInvisibleDistRatio, float inEighthTickInvisibleDistRatio) {} // 0x00000001823E5E00-0x00000001823E5F80

		// Methods
		// [XID] // 0x0000000189A87860-0x0000000189A87880
		public void Execute() {} // 0x00000001823E5C50-0x00000001823E5D60
		// [XID] // 0x0000000189A8F050-0x0000000189A8F070
		public override void Dispose() {} // 0x00000001823E5D60-0x00000001823E5E00
	}

	public class LODEventEntityActive : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21301
	{
		// Properties
		public bool isActive { get; /* [XID] */ /* 0x0000000189AA8040-0x0000000189AA8080 */ private set; } // 0x00000001824063A0-0x0000000182406400 0x00000001824061F0-0x0000000182406250

		// Constructors
		public LODEventEntityActive() {} // 0x0000000182406400-0x0000000182406460

		// Methods
		// [XID] // 0x0000000189811E30-0x0000000189811E50
		public LODEventEntityActive Polish(bool inIsActive) => default; // 0x00000001824062B0-0x00000001824063A0
		// [XID] // 0x0000000189ABA7A0-0x0000000189ABA7C0
		public override void BeforeRecycle() {} // 0x0000000182406020-0x0000000182406100
		// [XID] // 0x0000000189AC2070-0x0000000189AC2090
		public override void Dispose() {} // 0x0000000182406100-0x00000001824061F0
	}

	public class LODEventEntityRelatedGameObjectVisibleChange : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21302
	{
		// Properties
		public bool isVisible { get; /* [XID] */ /* 0x0000000189ADBCE0-0x0000000189ADBD20 */ private set; } // 0x0000000182405970-0x00000001824059D0 0x00000001824059D0-0x0000000182405A30

		// Constructors
		public LODEventEntityRelatedGameObjectVisibleChange() {} // 0x0000000182405B80-0x0000000182405BE0

		// Methods
		// [XID] // 0x0000000189AE67C0-0x0000000189AE67E0
		public LODEventEntityRelatedGameObjectVisibleChange Polish(bool inIsVisible) => default; // 0x0000000182405A90-0x0000000182405B80
		// [XID] // 0x0000000189AEE0E0-0x0000000189AEE100
		public override void BeforeRecycle() {} // 0x00000001824057A0-0x0000000182405880
		// [XID] // 0x0000000189AF5870-0x0000000189AF5890
		public override void Dispose() {} // 0x0000000182405880-0x0000000182405970
	}

	public class LODEventEntitySyncSharedPosition : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21303
	{
		// Properties
		public Vector3 sharePos { get; /* [XID] */ /* 0x0000000189B0ECB0-0x0000000189B0ECF0 */ private set; } // 0x00000001823E56A0-0x00000001823E5710 0x00000001823E5800-0x00000001823E5870

		// Constructors
		public LODEventEntitySyncSharedPosition() {} // 0x00000001823E59E0-0x00000001823E5A40

		// Methods
		// [XID] // 0x0000000189B18FF0-0x0000000189B19010
		public LODEventEntitySyncSharedPosition Polish(Vector3 inPos) => default; // 0x00000001823E58D0-0x00000001823E59E0
		// [XID] // 0x0000000189B206F0-0x0000000189B20710
		public override void BeforeRecycle() {} // 0x00000001823E5570-0x00000001823E56A0
		// [XID] // 0x0000000189B27DF0-0x0000000189B27E10
		public override void Dispose() {} // 0x00000001823E5710-0x00000001823E5800
	}

	public class LODEventEntitySyncCachedRendering : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21304
	{
		// Properties
		public bool isRendering { get; /* [XID] */ /* 0x0000000189B413B0-0x0000000189B413F0 */ private set; } // 0x0000000182405E10-0x0000000182405E70 0x0000000182405BE0-0x0000000182405C40

		// Constructors
		public LODEventEntitySyncCachedRendering() {} // 0x0000000182405FC0-0x0000000182406020

		// Methods
		// [XID] // 0x0000000189B4BE40-0x0000000189B4BE60
		public LODEventEntitySyncCachedRendering Polish(bool inIsRendering) => default; // 0x0000000182405ED0-0x0000000182405FC0
		// [XID] // 0x0000000189B532F0-0x0000000189B53310
		public override void BeforeRecycle() {} // 0x0000000182405C40-0x0000000182405D20
		// [XID] // 0x0000000189B5AC90-0x0000000189B5ACB0
		public override void Dispose() {} // 0x0000000182405D20-0x0000000182405E10
	}

	public class LODEventEntityPostReady : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21305
	{
		// Constructors
		public LODEventEntityPostReady() {} // 0x00000001824055F0-0x0000000182405650

		// Methods
		// [XID] // 0x0000000189B62090-0x0000000189B620B0
		public override void BeforeRecycle() {} // 0x0000000182405400-0x00000001824054A0
		// [XID] // 0x0000000189B69CF0-0x0000000189B69D10
		public override void Dispose() {} // 0x00000001824054A0-0x0000000182405590
	}

	public class LODEventEntityStructureChange : TickObjectProxyLODManager.LODEventBase // TypeDefIndex: 21306
	{
		// Constructors
		public LODEventEntityStructureChange() {} // 0x0000000182405740-0x00000001824057A0

		// Methods
		// [XID] // 0x0000000189B71260-0x0000000189B71280
		public override void Dispose() {} // 0x0000000182405650-0x0000000182405740
	}

	public struct ScopeStatWhenLockScene : IDisposable // TypeDefIndex: 21307
	{
		// Constructors
		public ScopeStatWhenLockScene(string inContent) {} // 0x00000001823E6030-0x00000001823E6040

		// Methods
		// [XID] // 0x00000001896589C0-0x00000001896589E0
		public void Dispose() {} // 0x00000001823E5F80-0x00000001823E6030
	}

	// Constructors
	public TickObjectProxyLODManagerEntity() {} // 0x00000001823F1D00-0x00000001823F2030

	// Methods
	// [XID] // 0x00000001899D4320-0x00000001899D4340
	private void InitObjectPoolClusterForEntityEvent() {} // 0x00000001823F0CA0-0x00000001823F1020
	// [XID] // 0x00000001899DB9F0-0x00000001899DBA10
	public void OnChangeTickStrategyDistance(float halfTickVisibleDistRatio, float halfTickInvisibleDistRatio, float eighthTickInvisibleDistRatio) {} // 0x00000001823EF840-0x00000001823EF970
	// [XID] // 0x00000001899E3250-0x00000001899E3270
	public void OnEntitySetActive(BaseEntity entity, bool isActive) {} // 0x00000001823F1020-0x00000001823F1200
	// [XID] // 0x00000001896A53A0-0x00000001896A53C0
	public void OnEntityRelatedGameObjectVisibleChange(BaseEntity entity, bool isVisible) {} // 0x00000001823F18E0-0x00000001823F1A00
	// [XID] // 0x000000018985D220-0x000000018985D240
	public void OnEntitySetCachedRendering(BaseEntity entity, bool isRendering) {} // 0x00000001823F0910-0x00000001823F0A30
	// [XID] // 0x00000001899F9910-0x00000001899F9930
	public void OnEntitySetSharedPosition(BaseEntity entity, Vector3 sharedPos) {} // 0x00000001823EFEC0-0x00000001823F0050
	// [XID] // 0x0000000189A00CF0-0x0000000189A00D10
	public void OnEntityReady(BaseEntity entity) {} // 0x00000001823F0B90-0x00000001823F0CA0
	// [XID] // 0x0000000189A085D0-0x0000000189A085F0
	public void OnEntityStructureChanged(BaseEntity entity) {} // 0x00000001823F17F0-0x00000001823F18E0
	public override T AllocateTickBalanceProxy<T, TSpawner>() => default;
	// [XID] // 0x0000000189A0FBD0-0x0000000189A0FBF0
	public void CollectDataUnityThread() {} // 0x00000001823F0650-0x00000001823F07C0
	// [XID] // 0x0000000189A17050-0x0000000189A17070
	public override void UpdateComputeThread(float inGlobalTime, float deltaTime) {} // 0x00000001823F1BF0-0x00000001823F1D00
	// [XID] // 0x0000000189A1E760-0x0000000189A1E780
	public void OnJobFlushEveryFrame() {} // 0x00000001823EF970-0x00000001823EFD60
	// [XID] // 0x0000000189A25E90-0x0000000189A25EB0
	public void UpdateProxies(double inGlobalTime, float deltaTime) {} // 0x00000001823F0050-0x00000001823F0650
	// [XID] // 0x0000000189A2D290-0x0000000189A2D2B0
	public void RefreshMainCameraMatrixUnityThread(Camera InCamera) {} // 0x00000001823F1200-0x00000001823F12C0
	// [XID] // 0x0000000189A34CF0-0x0000000189A34D10
	public void SyncCullAndToLocalAvatarDistance(ref Bounds inBounds, out bool bCulled, out float distance) {
		bCulled = default;
		distance = default;
	} // 0x00000001823F1650-0x00000001823F17F0
	// [XID] // 0x0000000189A3C060-0x0000000189A3C080
	public override void Flush() {} // 0x00000001823EFD60-0x00000001823EFEC0
	// [XID] // 0x0000000189A78580-0x0000000189A785A0
	void MoleMole.IEntityTickLODManager.RegisterTickBalanceProxy(BalanceTickObjectProxy proxy) {} // 0x00000001823F13C0-0x00000001823F1470
	// [XID] // 0x0000000189A7FB10-0x0000000189A7FB30
	void MoleMole.IEntityTickLODManager.UnregisterTickBalanceProxy(BalanceTickObjectProxy proxy) {} // 0x00000001823F1470-0x00000001823F1520
	void MoleMole.IEntityTickLODManager.DeallocateTickBalanceProxy<T>(ref T proxy, bool bForceDeallocate) {}
}

