/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ChannellerSlabPreviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15040
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected SimpleSafeUInt32 activityStayTimeRawNum; // 0x18
	protected SimpleSafeUInt32 unlockQuestIDRawNum; // 0x1C
	protected SimpleSafeUInt32 slabQuestIDRawNum; // 0x20
	protected SimpleSafeUInt32 unlockPlayerLevelRawNum; // 0x24
	protected SimpleSafeUInt32 levelRewardGadgetIDRawNum; // 0x28
	protected bool _isMaskAvatarReward; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A24F90-0x0000000189A24FB0 */ get => default; /* [XID] */ /* 0x0000000189A2C4D0-0x0000000189A2C4F0 */ protected set {} } // 0x000000018220ADF0-0x000000018220AEC0 0x000000018220A230-0x000000018220A310
	public uint activityId { /* [XID] */ /* 0x0000000189A33BC0-0x0000000189A33BE0 */ get => default; /* [XID] */ /* 0x0000000189A3B2E0-0x0000000189A3B300 */ protected set {} } // 0x000000018220AB00-0x000000018220ABD0 0x000000018220A150-0x000000018220A230
	public uint activityStayTime { /* [XID] */ /* 0x0000000189A42DB0-0x0000000189A42DD0 */ get => default; /* [XID] */ /* 0x0000000189A4A280-0x0000000189A4A2A0 */ protected set {} } // 0x0000000182209C90-0x0000000182209D60 0x0000000182208EC0-0x0000000182208FA0
	public uint unlockQuestID { /* [XID] */ /* 0x0000000189A51C50-0x0000000189A51C70 */ get => default; /* [XID] */ /* 0x0000000189A59380-0x0000000189A593A0 */ protected set {} } // 0x0000000182209E00-0x0000000182209ED0 0x0000000182209FA0-0x000000018220A080
	public uint slabQuestID { /* [XID] */ /* 0x0000000189A60D20-0x0000000189A60D40 */ get => default; /* [XID] */ /* 0x0000000189A68990-0x0000000189A689B0 */ protected set {} } // 0x0000000182209190-0x0000000182209260 0x000000018220AEC0-0x000000018220AFA0
	public uint unlockPlayerLevel { /* [XID] */ /* 0x0000000189A6FDA0-0x0000000189A6FDC0 */ get => default; /* [XID] */ /* 0x0000000189A77530-0x0000000189A77550 */ protected set {} } // 0x0000000182209ED0-0x0000000182209FA0 0x000000018220ABD0-0x000000018220ACB0
	public uint levelRewardGadgetID { /* [XID] */ /* 0x0000000189A7EDE0-0x0000000189A7EE00 */ get => default; /* [XID] */ /* 0x0000000189A865F0-0x0000000189A86610 */ protected set {} } // 0x000000018220A080-0x000000018220A150 0x000000018220AFA0-0x000000018220B080
	public bool isMaskAvatarReward { /* [XID] */ /* 0x0000000189A8E1F0-0x0000000189A8E210 */ get => default; /* [XID] */ /* 0x0000000189A95670-0x0000000189A95690 */ protected set {} } // 0x0000000182209D60-0x0000000182209E00 0x000000018220AA50-0x000000018220AB00

	// Constructors
	public ChannellerSlabPreviewExcelConfig() {} // 0x000000018220B120-0x000000018220B180

	// Methods
	// [IDTag] // 0x0000000189A9CF90-0x0000000189A9CFD0
	// [XID] // 0x0000000189A9CF90-0x0000000189A9CFD0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182209770-0x0000000182209C90
	// [IDTag] // 0x0000000189AA7580-0x0000000189AA75C0
	// [XID] // 0x0000000189AA7580-0x0000000189AA75C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182209260-0x0000000182209770
	// [XID] // 0x0000000189AB2060-0x0000000189AB2080
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF37 */, bool useObjectPool = false /* Metadata: 0x00AEFF3B */) => default; // 0x000000018220A310-0x000000018220AA50
	[BlackList] // 0x0000000189AB92B0-0x0000000189AB92F0
	// [XID] // 0x0000000189AB92B0-0x0000000189AB92F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182208FA0-0x0000000182209040
	[BlackList] // 0x0000000189AC4320-0x0000000189AC4360
	// [XID] // 0x0000000189AC4320-0x0000000189AC4360
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182209040-0x0000000182209190
	[BlackList] // 0x0000000189ACE850-0x0000000189ACE890
	// [XID] // 0x0000000189ACE850-0x0000000189ACE890
	public virtual void ReturnToObjectPool() {} // 0x000000018220B080-0x000000018220B120
	[BlackList] // 0x0000000189AD9690-0x0000000189AD96D0
	// [XID] // 0x0000000189AD9690-0x0000000189AD96D0
	public virtual void OnPoolAllocated() {} // 0x000000018220AD50-0x000000018220ADF0
	[BlackList] // 0x0000000189AE4190-0x0000000189AE41D0
	// [XID] // 0x0000000189AE4190-0x0000000189AE41D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018220ACB0-0x000000018220AD50
}

