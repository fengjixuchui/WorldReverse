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
public class OfferingLevelUpExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15918
{
	// Fields
	protected SimpleSafeUInt32 offeringIdRawNum; // 0x10
	protected SimpleSafeUInt32 levelRawNum; // 0x14
	protected IdCountConfig _consumeItemConfig; // 0x18
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected OfferingActionContent[] _actionVec; // 0x28
	protected SimpleSafeUInt32 cutSceneIdRawNum; // 0x30

	// Properties
	public uint offeringId { /* [XID] */ /* 0x0000000189A1BF90-0x0000000189A1BFB0 */ get => default; /* [XID] */ /* 0x0000000189A237E0-0x0000000189A23800 */ protected set {} } // 0x0000000182380660-0x0000000182380730 0x0000000182381E30-0x0000000182381F10
	public uint level { /* [XID] */ /* 0x0000000189A2AC60-0x0000000189A2AC80 */ get => default; /* [XID] */ /* 0x0000000189A321A0-0x0000000189A321C0 */ protected set {} } // 0x0000000182381CC0-0x0000000182381D90 0x0000000182381BE0-0x0000000182381CC0
	public IdCountConfig consumeItemConfig { /* [XID] */ /* 0x0000000189A39B50-0x0000000189A39B70 */ get => default; /* [XID] */ /* 0x0000000189A413D0-0x0000000189A413F0 */ protected set {} } // 0x0000000182381D90-0x0000000182381E30 0x0000000182381F10-0x0000000182381FC0
	public uint rewardId { /* [XID] */ /* 0x0000000189A48A90-0x0000000189A48AB0 */ get => default; /* [XID] */ /* 0x0000000189A50220-0x0000000189A50240 */ protected set {} } // 0x0000000182381B10-0x0000000182381BE0 0x0000000182380580-0x0000000182380660
	public OfferingActionContent[] actionVec { /* [XID] */ /* 0x0000000189A577B0-0x0000000189A577D0 */ get => default; /* [XID] */ /* 0x0000000189A5F310-0x0000000189A5F330 */ protected set {} } // 0x0000000182381470-0x0000000182381510 0x0000000182381FC0-0x0000000182382070
	public uint cutSceneId { /* [XID] */ /* 0x0000000189A66C00-0x0000000189A66C20 */ get => default; /* [XID] */ /* 0x0000000189A6E4C0-0x0000000189A6E4E0 */ protected set {} } // 0x0000000182380730-0x0000000182380800 0x0000000182381390-0x0000000182381470

	// Constructors
	public OfferingLevelUpExcelConfig() {} // 0x0000000182382250-0x00000001823822B0

	// Methods
	// [IDTag] // 0x0000000189A75B90-0x0000000189A75BD0
	// [XID] // 0x0000000189A75B90-0x0000000189A75BD0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001823809C0-0x0000000182380F00
	// [IDTag] // 0x0000000189A80260-0x0000000189A802A0
	// [XID] // 0x0000000189A80260-0x0000000189A802A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182380F00-0x0000000182381390
	// [XID] // 0x0000000189A8AF60-0x0000000189A8AF80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B25 */, bool useObjectPool = false /* Metadata: 0x00AF2B29 */) => default; // 0x0000000182381510-0x0000000182381B10
	[BlackList] // 0x0000000189A92710-0x0000000189A92750
	// [XID] // 0x0000000189A92710-0x0000000189A92750
	public virtual void AutoAllocTypeFields() {} // 0x0000000182380800-0x00000001823808A0
	[BlackList] // 0x0000000189A9CDB0-0x0000000189A9CDF0
	// [XID] // 0x0000000189A9CDB0-0x0000000189A9CDF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823808A0-0x00000001823809C0
	[BlackList] // 0x0000000189AA7400-0x0000000189AA7440
	// [XID] // 0x0000000189AA7400-0x0000000189AA7440
	public virtual void ReturnToObjectPool() {} // 0x00000001823821B0-0x0000000182382250
	[BlackList] // 0x0000000189AB1EA0-0x0000000189AB1EE0
	// [XID] // 0x0000000189AB1EA0-0x0000000189AB1EE0
	public virtual void OnPoolAllocated() {} // 0x0000000182382110-0x00000001823821B0
	[BlackList] // 0x0000000189ABC920-0x0000000189ABC960
	// [XID] // 0x0000000189ABC920-0x0000000189ABC960
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182382070-0x0000000182382110
}

