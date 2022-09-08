/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AIOrderKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 19960
{
	// Fields
	public MasterInfo masterInfo; // 0x18
	public ServantInfo servantInfo; // 0x20
	public List<int> commandConfig; // 0x28
	public AICommandInfo activeCommandInfo; // 0x30

	// Nested types
	public class MasterInfo // TypeDefIndex: 19961
	{
		// Fields
		public List<Vector3> availableSlots; // 0x10
		public List<Transform> availableSlotsTransform; // 0x18

		// Constructors
		public MasterInfo() {} // 0x0000000182ABC860-0x0000000182ABC9F0

		// Methods
		// [XID] // 0x0000000189A217D0-0x0000000189A217F0
		public void UpdateServantSlotPositions() {} // 0x0000000182ABC600-0x0000000182ABC860
	}

	public class ServantInfo // TypeDefIndex: 19962
	{
		// Fields
		public Vector3? attachToMasterPos; // 0x10
		public BaseEntity masterEntity; // 0x20
		public int slotIndex; // 0x28

		// Constructors
		public ServantInfo() {} // 0x0000000182A9ABA0-0x0000000182A9AC20

		// Methods
		// [XID] // 0x0000000189AADA70-0x0000000189AADA90
		public void UpdateServantAttachPos() {} // 0x0000000182A9A9D0-0x0000000182A9ABA0
		// [XID] // 0x0000000189A303F0-0x0000000189A30410
		public void RefreshMaster(uint runtimeID) {} // 0x0000000182A9A8B0-0x0000000182A9A9D0
	}

	public class AICommandInfo // TypeDefIndex: 19963
	{
		// Fields
		public int commandID; // 0x10
		public float commandExpireTick; // 0x14

		// Constructors
		public AICommandInfo() {} // 0x0000000182ABC590-0x0000000182ABC600

		// Methods
		// [XID] // 0x000000018987E350-0x000000018987E370
		public void ClearCommand() {} // 0x0000000182ABC410-0x0000000182ABC4C0
		// [XID] // 0x0000000189B84220-0x0000000189B84240
		public void SetCommandActive(int initCommandID, float expireTime) {} // 0x0000000182ABC4C0-0x0000000182ABC590
	}

	// Constructors
	public AIOrderKnowledge() {} // 0x0000000182AA3650-0x0000000182AA36D0

	// Methods
	[BlackList] // 0x00000001899D5D90-0x00000001899D5DD0
	// [XID] // 0x00000001899D5D90-0x00000001899D5DD0
	public override void AutoAllocTypeFields() {} // 0x0000000182AA25C0-0x0000000182AA2660
	[BlackList] // 0x00000001899E0280-0x00000001899E02C0
	// [XID] // 0x00000001899E0280-0x00000001899E02C0
	public override void AutoRecycleTypeFields() {} // 0x0000000182AA2660-0x0000000182AA2720
	[BlackList] // 0x00000001899EA840-0x00000001899EA880
	// [XID] // 0x00000001899EA840-0x00000001899EA880
	public override void ReturnToObjectPool() {} // 0x0000000182AA35B0-0x0000000182AA3650
	// [XID] // 0x00000001897F7120-0x00000001897F7140
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, BaseEntity self, ConfigAIOrderSetting orderSetting, LCAIBetaData aiCreationData) {} // 0x0000000182AA2FF0-0x0000000182AA3410
	// [XID] // 0x00000001897B2E00-0x00000001897B2E20
	public void InitOrder(BaseEntity self, ConfigAIOrderSetting orderSetting, LCAIBetaData aiCreationData) {} // 0x0000000182AA2780-0x0000000182AA2D50
	// [XID] // 0x0000000189A03FE0-0x0000000189A04000
	public bool ReceiveCommand(int commandID, float expireTimeTick) => default; // 0x0000000182AA2DB0-0x0000000182AA2EC0
	// [XID] // 0x00000001895ECE40-0x00000001895ECE60
	public bool IsCommandActive(int commandID) => default; // 0x0000000182AA34F0-0x0000000182AA35B0
	// [XID] // 0x0000000189876630-0x0000000189876650
	public void ConsumeCommand(int commandID) {} // 0x0000000182AA2EC0-0x0000000182AA2F90
	// [XID] // 0x0000000189A1A230-0x0000000189A1A250
	public void UpdateCommandDuration(float aiTime) {} // 0x0000000182AA3410-0x0000000182AA34F0
}

