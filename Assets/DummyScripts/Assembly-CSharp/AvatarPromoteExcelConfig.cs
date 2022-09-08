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
public class AvatarPromoteExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15211
{
	// Fields
	protected SimpleSafeUInt32 avatarPromoteIdRawNum; // 0x10
	protected SimpleSafeUInt32 promoteLevelRawNum; // 0x14
	protected string _promoteAudio; // 0x18
	protected SimpleSafeUInt32 scoinCostRawNum; // 0x20
	protected IdCountConfig[] _costItems; // 0x28
	protected SimpleSafeUInt32 unlockMaxLevelRawNum; // 0x30
	protected PropValConfig[] _addProps; // 0x38
	protected SimpleSafeUInt32 requiredPlayerLevelRawNum; // 0x40

	// Properties
	public uint avatarPromoteId { /* [XID] */ /* 0x000000018977A920-0x000000018977A940 */ get => default; /* [XID] */ /* 0x0000000189782540-0x0000000189782560 */ protected set {} } // 0x000000018512D1A0-0x000000018512D270 0x000000018512D3F0-0x000000018512D4D0
	public uint promoteLevel { /* [XID] */ /* 0x0000000189789880-0x00000001897898A0 */ get => default; /* [XID] */ /* 0x0000000189791030-0x0000000189791050 */ protected set {} } // 0x000000018512DCE0-0x000000018512DDB0 0x000000018512C080-0x000000018512C160
	public string promoteAudio { /* [XID] */ /* 0x00000001897988E0-0x0000000189798900 */ get => default; /* [XID] */ /* 0x00000001897A0630-0x00000001897A0650 */ protected set {} } // 0x000000018512C160-0x000000018512C200 0x000000018512DDB0-0x000000018512DE60
	public uint scoinCost { /* [XID] */ /* 0x00000001897A7C60-0x00000001897A7C80 */ get => default; /* [XID] */ /* 0x00000001897AF6D0-0x00000001897AF6F0 */ protected set {} } // 0x000000018512D320-0x000000018512D3F0 0x000000018512DF00-0x000000018512DFE0
	public IdCountConfig[] costItems { /* [XID] */ /* 0x00000001897B75B0-0x00000001897B75D0 */ get => default; /* [XID] */ /* 0x00000001897BF430-0x00000001897BF450 */ protected set {} } // 0x000000018512DFE0-0x000000018512E080 0x000000018512D270-0x000000018512D320
	public uint unlockMaxLevel { /* [XID] */ /* 0x00000001897C6B40-0x00000001897C6B60 */ get => default; /* [XID] */ /* 0x00000001897CE2E0-0x00000001897CE300 */ protected set {} } // 0x000000018512D4D0-0x000000018512D5A0 0x000000018512C2D0-0x000000018512C3B0
	public PropValConfig[] addProps { /* [XID] */ /* 0x00000001897D5830-0x00000001897D5850 */ get => default; /* [XID] */ /* 0x00000001897DCF30-0x00000001897DCF50 */ protected set {} } // 0x000000018512DE60-0x000000018512DF00 0x000000018512D0F0-0x000000018512D1A0
	public uint requiredPlayerLevel { /* [XID] */ /* 0x00000001897E4850-0x00000001897E4870 */ get => default; /* [XID] */ /* 0x00000001897EC4E0-0x00000001897EC500 */ protected set {} } // 0x000000018512C200-0x000000018512C2D0 0x000000018512BDD0-0x000000018512BEB0

	// Constructors
	public AvatarPromoteExcelConfig() {} // 0x000000018512E260-0x000000018512E2C0

	// Methods
	// [IDTag] // 0x00000001897F3DF0-0x00000001897F3E30
	// [XID] // 0x00000001897F3DF0-0x00000001897F3E30
	public virtual bool ParseFromLine(string line) => default; // 0x000000018512C9F0-0x000000018512D0F0
	// [IDTag] // 0x00000001897FE0A0-0x00000001897FE0E0
	// [XID] // 0x00000001897FE0A0-0x00000001897FE0E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018512C3B0-0x000000018512C9F0
	// [XID] // 0x00000001898088C0-0x00000001898088E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03F3 */, bool useObjectPool = false /* Metadata: 0x00AF03F7 */) => default; // 0x000000018512D5A0-0x000000018512DCE0
	[BlackList] // 0x00000001898102B0-0x00000001898102F0
	// [XID] // 0x00000001898102B0-0x00000001898102F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018512BEB0-0x000000018512BF50
	[BlackList] // 0x000000018981AAA0-0x000000018981AAE0
	// [XID] // 0x000000018981AAA0-0x000000018981AAE0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018512BF50-0x000000018512C080
	[BlackList] // 0x0000000189824EE0-0x0000000189824F20
	// [XID] // 0x0000000189824EE0-0x0000000189824F20
	public virtual void ReturnToObjectPool() {} // 0x000000018512E1C0-0x000000018512E260
	[BlackList] // 0x000000018982F560-0x000000018982F5A0
	// [XID] // 0x000000018982F560-0x000000018982F5A0
	public virtual void OnPoolAllocated() {} // 0x000000018512E120-0x000000018512E1C0
	[BlackList] // 0x0000000189839BA0-0x0000000189839BE0
	// [XID] // 0x0000000189839BA0-0x0000000189839BE0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018512E080-0x000000018512E120
}

