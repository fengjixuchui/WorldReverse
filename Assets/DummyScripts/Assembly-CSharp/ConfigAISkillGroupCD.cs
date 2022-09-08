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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAISkillGroupCD : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17500
{
	// Fields
	private SimpleSafeInt32 skillGroupCDIDRawNum; // 0x10
	private SimpleSafeFloat skillGroupCDTimeRawNum; // 0x14

	// Properties
	public int skillGroupCDID { /* [XID] */ /* 0x000000018994DCC0-0x000000018994DCE0 */ get => default; /* [XID] */ /* 0x0000000189A7D3F0-0x0000000189A7D410 */ private set {} } // 0x0000000182EEFD00-0x0000000182EEFDD0 0x0000000182EEFC20-0x0000000182EEFD00
	public float skillGroupCDTime { /* [XID] */ /* 0x00000001895F76F0-0x00000001895F7710 */ get => default; /* [XID] */ /* 0x0000000189A8C490-0x0000000189A8C4B0 */ private set {} } // 0x0000000182EEF090-0x0000000182EEF170 0x0000000182EEF740-0x0000000182EEF820

	// Constructors
	public ConfigAISkillGroupCD() {} // 0x0000000182EF0330-0x0000000182EF0400

	// Methods
	// [XID] // 0x0000000189A938D0-0x0000000189A938F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EF0040-0x0000000182EF0150
	// [XID] // 0x0000000189A9B4E0-0x0000000189A9B500
	public void InitEmpty() {} // 0x0000000182EEF820-0x0000000182EEF920
	[BlackList] // 0x0000000189AA2800-0x0000000189AA2840
	// [XID] // 0x0000000189AA2800-0x0000000189AA2840
	public bool FromJson(JSONNode node) => default; // 0x0000000182EEF3C0-0x0000000182EEF740
	// [XID] // 0x0000000189AACFC0-0x0000000189AACFE0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182EEE910-0x0000000182EEEC20
	// [XID] // 0x0000000189AB4950-0x0000000189AB4970
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70D1 */, bool useObjectPool = false /* Metadata: 0x00AF70D5 */) => default; // 0x0000000182EEF920-0x0000000182EEFC20
	// [XID] // 0x0000000189ABC6A0-0x0000000189ABC6C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70D6 */, bool useObjectPool = false /* Metadata: 0x00AF70DA */) => default; // 0x0000000182EEF170-0x0000000182EEF3C0
	[BlackList] // 0x0000000189AC3FC0-0x0000000189AC4000
	// [XID] // 0x0000000189AC3FC0-0x0000000189AC4000
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182EEEC20-0x0000000182EEEEF0
	// [XID] // 0x0000000189ACE530-0x0000000189ACE550
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182EEFDD0-0x0000000182EF0040
	[BlackList] // 0x0000000189AD63E0-0x0000000189AD6420
	// [XID] // 0x0000000189AD63E0-0x0000000189AD6420
	public virtual void AutoAllocTypeFields() {} // 0x0000000182EEEEF0-0x0000000182EEEF90
	[BlackList] // 0x0000000189AE0DE0-0x0000000189AE0E20
	// [XID] // 0x0000000189AE0DE0-0x0000000189AE0E20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182EEEF90-0x0000000182EEF090
	[BlackList] // 0x0000000189AEB4F0-0x0000000189AEB530
	// [XID] // 0x0000000189AEB4F0-0x0000000189AEB530
	public virtual void ReturnToObjectPool() {} // 0x0000000182EF0290-0x0000000182EF0330
	[BlackList] // 0x0000000189AF5D50-0x0000000189AF5D90
	// [XID] // 0x0000000189AF5D50-0x0000000189AF5D90
	public virtual void OnPoolAllocated() {} // 0x0000000182EF01F0-0x0000000182EF0290
	[BlackList] // 0x0000000189B00390-0x0000000189B003D0
	// [XID] // 0x0000000189B00390-0x0000000189B003D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182EF0150-0x0000000182EF01F0
}

