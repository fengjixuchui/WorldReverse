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
public class HuntingGroupInfoExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15748
{
	// Fields
	protected SimpleSafeUInt32 groupIdRawNum; // 0x10
	protected SimpleSafeUInt32 regionIdRawNum; // 0x14
	protected HuntingCluePointType _pointType; // 0x18
	protected SimpleSafeUInt32[] _refIndex; // 0x20
	protected HuntingMonsterCreatePosType _posType; // 0x28

	// Properties
	public uint groupId { /* [XID] */ /* 0x00000001899CECC0-0x00000001899CECE0 */ get => default; /* [XID] */ /* 0x00000001899D6430-0x00000001899D6450 */ protected set {} } // 0x0000000183892E90-0x0000000183892F60 0x0000000183892F60-0x0000000183893040
	public uint regionId { /* [XID] */ /* 0x00000001899DD8E0-0x00000001899DD900 */ get => default; /* [XID] */ /* 0x00000001899E5720-0x00000001899E5740 */ protected set {} } // 0x00000001838925D0-0x00000001838926A0 0x0000000183893180-0x0000000183893260
	public HuntingCluePointType pointType { /* [XID] */ /* 0x00000001899EC890-0x00000001899EC8B0 */ get => default; /* [XID] */ /* 0x00000001899F4670-0x00000001899F4690 */ protected set {} } // 0x0000000183892D40-0x0000000183892DE0 0x00000001838926A0-0x0000000183892750
	public SimpleSafeUInt32[] refIndex { /* [XID] */ /* 0x00000001899FBC70-0x00000001899FBC90 */ get => default; /* [XID] */ /* 0x0000000189A03070-0x0000000189A03090 */ protected set {} } // 0x0000000183892750-0x00000001838927F0 0x0000000183892DE0-0x0000000183892E90
	public HuntingMonsterCreatePosType posType { /* [XID] */ /* 0x0000000189A0A5A0-0x0000000189A0A5C0 */ get => default; /* [XID] */ /* 0x0000000189A11EA0-0x0000000189A11EC0 */ protected set {} } // 0x0000000183892530-0x00000001838925D0 0x00000001838918E0-0x0000000183891990

	// Constructors
	public HuntingGroupInfoExcelConfig() {} // 0x0000000183893300-0x0000000183893360

	// Methods
	// [IDTag] // 0x0000000189A19170-0x0000000189A191B0
	// [XID] // 0x0000000189A19170-0x0000000189A191B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183891990-0x0000000183891F70
	// [IDTag] // 0x0000000189A23820-0x0000000189A23860
	// [XID] // 0x0000000189A23820-0x0000000189A23860
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183891F70-0x0000000183892530
	// [XID] // 0x0000000189A2D990-0x0000000189A2D9B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24F4 */, bool useObjectPool = false /* Metadata: 0x00AF24F8 */) => default; // 0x00000001838927F0-0x0000000183892D40
	[BlackList] // 0x0000000189A35550-0x0000000189A35590
	// [XID] // 0x0000000189A35550-0x0000000189A35590
	public virtual void AutoAllocTypeFields() {} // 0x0000000183891750-0x00000001838917F0
	[BlackList] // 0x0000000189A3FC20-0x0000000189A3FC60
	// [XID] // 0x0000000189A3FC20-0x0000000189A3FC60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001838917F0-0x00000001838918E0
	[BlackList] // 0x0000000189A4A100-0x0000000189A4A140
	// [XID] // 0x0000000189A4A100-0x0000000189A4A140
	public virtual void ReturnToObjectPool() {} // 0x0000000183893260-0x0000000183893300
	[BlackList] // 0x0000000189A549D0-0x0000000189A54A10
	// [XID] // 0x0000000189A549D0-0x0000000189A54A10
	public virtual void OnPoolAllocated() {} // 0x00000001838930E0-0x0000000183893180
	[BlackList] // 0x0000000189A5F370-0x0000000189A5F3B0
	// [XID] // 0x0000000189A5F370-0x0000000189A5F3B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183893040-0x00000001838930E0
}

