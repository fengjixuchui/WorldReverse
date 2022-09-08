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
public class ConfigSummonTag : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17693
{
	// Fields
	private SimpleSafeUInt32 summonTagRawNum; // 0x10
	private string _name; // 0x18
	private SimpleSafeInt32 maxNumRawNum; // 0x20

	// Properties
	public uint summonTag { /* [XID] */ /* 0x0000000189A4F1B0-0x0000000189A4F1D0 */ get => default; /* [XID] */ /* 0x0000000189A6C860-0x0000000189A6C880 */ private set {} } // 0x0000000184553FE0-0x00000001845540B0 0x00000001845532B0-0x0000000184553390
	public string name { /* [XID] */ /* 0x0000000189A3B900-0x0000000189A3B920 */ get => default; /* [XID] */ /* 0x0000000189A7BA60-0x0000000189A7BA80 */ private set {} } // 0x0000000184554710-0x00000001845547B0 0x0000000184553A30-0x0000000184553AE0
	public int maxNum { /* [XID] */ /* 0x0000000189A94370-0x0000000189A94390 */ get => default; /* [XID] */ /* 0x0000000189A8AC60-0x0000000189A8AC80 */ private set {} } // 0x0000000184553F10-0x0000000184553FE0 0x00000001845543D0-0x00000001845544B0

	// Constructors
	public ConfigSummonTag() {} // 0x0000000184554850-0x00000001845548E0

	// Methods
	// [XID] // 0x0000000189A923D0-0x0000000189A923F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845544B0-0x00000001845545D0
	// [XID] // 0x0000000189A99E00-0x0000000189A99E20
	public void InitEmpty() {} // 0x0000000184553AE0-0x0000000184553C10
	[BlackList] // 0x0000000189AA0D60-0x0000000189AA0DA0
	// [XID] // 0x0000000189AA0D60-0x0000000189AA0DA0
	public bool FromJson(JSONNode node) => default; // 0x00000001845536B0-0x0000000184553A30
	// [XID] // 0x0000000189AAB6D0-0x0000000189AAB6F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184552A50-0x0000000184552E40
	// [XID] // 0x0000000189AB3080-0x0000000189AB30A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77FD */, bool useObjectPool = false /* Metadata: 0x00AF7801 */) => default; // 0x0000000184553C10-0x0000000184553F10
	// [XID] // 0x0000000189ABAD10-0x0000000189ABAD30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7802 */, bool useObjectPool = false /* Metadata: 0x00AF7806 */) => default; // 0x0000000184553390-0x00000001845536B0
	[BlackList] // 0x0000000189AC2600-0x0000000189AC2640
	// [XID] // 0x0000000189AC2600-0x0000000189AC2640
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184552E40-0x0000000184553110
	// [XID] // 0x0000000189ACCAC0-0x0000000189ACCAE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845540B0-0x00000001845543D0
	[BlackList] // 0x0000000189AD48A0-0x0000000189AD48E0
	// [XID] // 0x0000000189AD48A0-0x0000000189AD48E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184553110-0x00000001845531B0
	[BlackList] // 0x0000000189ADF410-0x0000000189ADF450
	// [XID] // 0x0000000189ADF410-0x0000000189ADF450
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845531B0-0x00000001845532B0
	[BlackList] // 0x0000000189AE99B0-0x0000000189AE99F0
	// [XID] // 0x0000000189AE99B0-0x0000000189AE99F0
	public virtual void ReturnToObjectPool() {} // 0x00000001845547B0-0x0000000184554850
	[BlackList] // 0x0000000189AF44D0-0x0000000189AF4510
	// [XID] // 0x0000000189AF44D0-0x0000000189AF4510
	public virtual void OnPoolAllocated() {} // 0x0000000184554670-0x0000000184554710
	[BlackList] // 0x0000000189AFEC30-0x0000000189AFEC70
	// [XID] // 0x0000000189AFEC30-0x0000000189AFEC70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845545D0-0x0000000184554670
}

