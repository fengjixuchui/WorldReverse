/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GadgetEntity : BaseEntity, IAutoAllocRecycle // TypeDefIndex: 19875
{
	// Fields
	public uint groupId; // 0x4B8
	public uint markFlag; // 0x4BC
	public uint propOwnerRuntimeID; // 0x4C0
	private bool hasSyncCreate; // 0x4C4
	private static System.Type[] _lcReuseGadgetBlackList; // 0x00
	private static System.Type[] _vcreuseGadgetBlackList; // 0x08
	private static EntityType[] _reuseGadgetEntityTypeBlackList; // 0x10
	private bool _lifeByOwnerLife; // 0x4C5
	private bool _registedLifeToOwner; // 0x4C6
	private uint _ownerRuntimeID; // 0x4C8
	private Action _ownerReadyAction; // 0x4D0
	private uint _originOwnerRuntimeID; // 0x4D8
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private List<uint> _childrenRuntimeIds; // 0x4E0
	private List<string> _tags; // 0x4E8
	[NonSerialized]
	public MPSyncData mpSyncData; // 0x4F0
	[NonSerialized]
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public bool localGadgetNeedSync; // 0x540
	private LevelGadget _levelGadget; // 0x548
	private VCBaseModel _vcBaseModel; // 0x550

	// Properties
	public override EntityReuseType entityReuseType { /* [XID] */ /* 0x0000000189806B10-0x0000000189806B30 */ get => default; } // 0x00000001825E5EE0-0x00000001825E5F80 
	public override bool LifeByOwnerLife { /* [XID] */ /* 0x000000018983ACA0-0x000000018983ACC0 */ get => default; /* [XID] */ /* 0x00000001898422E0-0x0000000189842300 */ set {} } // 0x00000001825E4890-0x00000001825E4940 0x00000001825E3B00-0x00000001825E3C50

	// Nested types
	public struct MPSyncData // TypeDefIndex: 19876
	{
		// Fields
		public uint? campID; // 0x00
		public TargetType? campType; // 0x08
		public Vector3? initPos; // 0x10
		public Quaternion? initRotation; // 0x20
		public ulong guid; // 0x38
		public uint ownerRuntimeID; // 0x40
		public uint targetRuntimeID; // 0x44
		public uint lockPointIndex; // 0x48
		public bool loadPrefabAsync; // 0x4C
		public bool sightGroupWithOwner; // 0x4D
	}

	// Constructors
	public GadgetEntity() {} // 0x00000001825E6730-0x00000001825E67F0
	static GadgetEntity() {} // 0x00000001825E6020-0x00000001825E6730

	// Methods
	// [XID] // 0x00000001897F05A0-0x00000001897F05C0
	protected override bool ShouldFireEntityReady() => default; // 0x00000001825E3C50-0x00000001825E3E70
	// [XID] // 0x00000001897F7CD0-0x00000001897F7CF0
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFCFC1 */, bool runtimeIDChange = false /* Metadata: 0x00AFCFC5 */) {} // 0x00000001825E4360-0x00000001825E4440
	// [XID] // 0x00000001897FF350-0x00000001897FF370
	private void CheckOwnerAndChildrenValid() {} // 0x00000001825E56E0-0x00000001825E58A0
	// [XID] // 0x000000018980E250-0x000000018980E270
	public override bool CanReuseEntity() => default; // 0x00000001825E3260-0x00000001825E3500
	// [XID] // 0x00000001898159B0-0x00000001898159D0
	public override void OnPoolAllocated() {} // 0x00000001825E5A70-0x00000001825E5B40
	public override bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AFCFC6 */, bool isRecoverFromServer = false /* Metadata: 0x00AFCFC7 */) => default;
	// [XID] // 0x000000018981D320-0x000000018981D340
	public bool SetToBeRemovedCleard(ref BaseEntity entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AFCFC8 */, bool isRecoverFromServer = false /* Metadata: 0x00AFCFC9 */) => default; // 0x00000001825E46C0-0x00000001825E47C0
	// [XID] // 0x00000001898247E0-0x0000000189824800
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x00000001825E2910-0x00000001825E2DC0
	// [XID] // 0x000000018982C2D0-0x000000018982C2F0
	public override void Clear(ClearReason clearReason = ClearReason.Invalid /* Metadata: 0x00AFCFCA */) {} // 0x00000001825E4120-0x00000001825E4290
	// [XID] // 0x0000000189833760-0x0000000189833780
	protected override bool ChangeAuthority() => default; // 0x00000001825E49B0-0x00000001825E4EC0
	// [XID] // 0x0000000189849740-0x0000000189849760
	protected override void OnOwnerDie(BaseEntity ownerEntity) {} // 0x00000001825E2DC0-0x00000001825E2EE0
	// [XID] // 0x0000000189850F70-0x0000000189850F90
	public override BaseEntity GetOwnerEntity() => default; // 0x00000001825E23A0-0x00000001825E2540
	// [XID] // 0x00000001898583C0-0x00000001898583E0
	public override void SetOwnerRuntimeId(uint ownerRuntimeId) {} // 0x00000001825E3870-0x00000001825E3B00
	// [XID] // 0x000000018985F450-0x000000018985F470
	public override uint GetOwnerRuntimeID() => default; // 0x00000001825E1AA0-0x00000001825E1B40
	// [XID] // 0x0000000189866C50-0x0000000189866C70
	public override void SetOriginOwnerRuntimeId(uint originOwnerRuntimeID) {} // 0x00000001825E35C0-0x00000001825E3710
	// [XID] // 0x000000018986E4D0-0x000000018986E4F0
	public override BaseEntity GetOriginOwnerEntity() => default; // 0x00000001825E3780-0x00000001825E3870
	// [XID] // 0x0000000189875920-0x0000000189875940
	public override uint GetOriginOwnerRuntimeID() => default; // 0x00000001825E2110-0x00000001825E21B0
	// [XID] // 0x000000018987D490-0x000000018987D4B0
	public override void ClearOwners() {} // 0x00000001825E5520-0x00000001825E55C0
	// [XID] // 0x0000000189884430-0x0000000189884450
	public override void ClearOriginOwners() {} // 0x00000001825E2600-0x00000001825E26F0
	// [XID] // 0x000000018988BB20-0x000000018988BB40
	private void ResetOwners() {} // 0x00000001825E3E70-0x00000001825E4020
	// [XID] // 0x00000001898931D0-0x00000001898931F0
	public override List<uint> GetChildrenRuntimeIds() => default; // 0x00000001825E5630-0x00000001825E56E0
	// [XID] // 0x000000018989A8F0-0x000000018989A910
	public override void AddChild(uint childRuntimeID) {} // 0x00000001825E53F0-0x00000001825E5520
	// [XID] // 0x00000001898A1BA0-0x00000001898A1BC0
	public override void RemoveChild(uint childRuntimeID) {} // 0x00000001825E1B40-0x00000001825E1C30
	// [XID] // 0x00000001898A9410-0x00000001898A9430
	public override void ClearChildren() {} // 0x00000001825E5B40-0x00000001825E5BF0
	// [XID] // 0x00000001898B0C20-0x00000001898B0C40
	private void ResetChildren() {} // 0x00000001825E5BF0-0x00000001825E5D90
	// [XID] // 0x00000001898B8340-0x00000001898B8360
	public override void OnEntityCreated() {} // 0x00000001825E4440-0x00000001825E4650
	// [XID] // 0x00000001898BFA80-0x00000001898BFAA0
	public override void OnEntityRemoved() {} // 0x00000001825E4EC0-0x00000001825E50E0
	// [XID] // 0x00000001898C7360-0x00000001898C7380
	public List<string> GetTags() => default; // 0x00000001825E1DE0-0x00000001825E1E90
	// [XID] // 0x0000000189B1FFF0-0x0000000189B20010
	public void SetTags(string[] tags) {} // 0x00000001825E1CA0-0x00000001825E1D80
	// [XID] // 0x00000001898D62C0-0x00000001898D62E0
	public void AddTag(string tag) {} // 0x00000001825E2540-0x00000001825E2600
	// [XID] // 0x00000001898DDF20-0x00000001898DDF40
	public void RemoveTag(string tag) {} // 0x00000001825E22B0-0x00000001825E23A0
	// [XID] // 0x00000001898E57C0-0x00000001898E57E0
	protected override bool ShouldFireEntityCreated() => default; // 0x00000001825E3010-0x00000001825E30F0
	// [XID] // 0x00000001898ED120-0x00000001898ED140
	protected override bool ShouldFireEntityRemoved() => default; // 0x00000001825E50E0-0x00000001825E51C0
	// [XID] // 0x00000001898F4920-0x00000001898F4940
	public LevelGadget GetLevelGadget() => default; // 0x00000001825E26F0-0x00000001825E28A0
	// [XID] // 0x00000001898FC1D0-0x00000001898FC1F0
	public bool IsBaseModelVisiable() => default; // 0x00000001825E5990-0x00000001825E5A70
	// [XID] // 0x0000000189903C50-0x0000000189903C70
	public override EntityMultiPlayerExcelConfig GetMultiPlayerExcelConfig() => default; // 0x00000001825E4020-0x00000001825E4120
	[BlackList] // 0x000000018990B130-0x000000018990B170
	// [XID] // 0x000000018990B130-0x000000018990B170
	public override void AutoAllocTypeFields() {} // 0x00000001825E1F00-0x00000001825E1FA0
	[BlackList] // 0x0000000189915B20-0x0000000189915B60
	// [XID] // 0x0000000189915B20-0x0000000189915B60
	public override void AutoRecycleTypeFields() {} // 0x00000001825E1FA0-0x00000001825E2110
	[BlackList] // 0x0000000189920310-0x0000000189920350
	// [XID] // 0x0000000189920310-0x0000000189920350
	public override void ReturnToObjectPool() {} // 0x00000001825E5F80-0x00000001825E6020
	// [XID] // 0x000000018992ABA0-0x000000018992ABC0
	public override uint GetGroupIDForStat() => default; // 0x00000001825E3150-0x00000001825E31F0
}

