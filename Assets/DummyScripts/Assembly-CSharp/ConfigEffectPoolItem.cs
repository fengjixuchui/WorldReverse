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
public class ConfigEffectPoolItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17918
{
	// Fields
	private SimpleSafeUInt32 preinstantiateNumWhenPreloadRawNum; // 0x10
	private SimpleSafeUInt32 maxUsedSizeRawNum; // 0x14

	// Properties
	public uint preinstantiateNumWhenPreload { /* [XID] */ /* 0x0000000189853AC0-0x0000000189853AE0 */ get => default; /* [XID] */ /* 0x000000018985B570-0x000000018985B590 */ private set {} } // 0x00000001836E8F40-0x00000001836E9010 0x00000001836E8890-0x00000001836E8970
	public uint maxUsedSize { /* [XID] */ /* 0x0000000189862AF0-0x0000000189862B10 */ get => default; /* [XID] */ /* 0x0000000189869FC0-0x0000000189869FE0 */ private set {} } // 0x00000001836E7DD0-0x00000001836E7EA0 0x00000001836E8970-0x00000001836E8A50

	// Constructors
	public ConfigEffectPoolItem() {} // 0x00000001836E90B0-0x00000001836E9140

	// Methods
	// [XID] // 0x0000000189871330-0x0000000189871350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836E8CF0-0x00000001836E8E00
	// [XID] // 0x0000000189878CF0-0x0000000189878D10
	public void InitEmpty() {} // 0x00000001836E84B0-0x00000001836E8590
	[BlackList] // 0x00000001898802E0-0x0000000189880320
	// [XID] // 0x00000001898802E0-0x0000000189880320
	public bool FromJson(JSONNode node) => default; // 0x00000001836E8130-0x00000001836E84B0
	// [XID] // 0x000000018988A550-0x000000018988A570
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836E7670-0x00000001836E7980
	// [XID] // 0x00000001898919E0-0x0000000189891A00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81F5 */, bool useObjectPool = false /* Metadata: 0x00AF81F9 */) => default; // 0x00000001836E8590-0x00000001836E8890
	// [XID] // 0x0000000189899330-0x0000000189899350
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81FA */, bool useObjectPool = false /* Metadata: 0x00AF81FE */) => default; // 0x00000001836E7EA0-0x00000001836E8130
	[BlackList] // 0x00000001898A0550-0x00000001898A0590
	// [XID] // 0x00000001898A0550-0x00000001898A0590
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836E7980-0x00000001836E7C50
	// [XID] // 0x00000001898AAA60-0x00000001898AAA80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836E8A50-0x00000001836E8CF0
	[BlackList] // 0x00000001898B23B0-0x00000001898B23F0
	// [XID] // 0x00000001898B23B0-0x00000001898B23F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001836E7C50-0x00000001836E7CF0
	[BlackList] // 0x00000001898BCE20-0x00000001898BCE60
	// [XID] // 0x00000001898BCE20-0x00000001898BCE60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836E7CF0-0x00000001836E7DD0
	[BlackList] // 0x00000001898C75C0-0x00000001898C7600
	// [XID] // 0x00000001898C75C0-0x00000001898C7600
	public virtual void ReturnToObjectPool() {} // 0x00000001836E9010-0x00000001836E90B0
	[BlackList] // 0x00000001898D1CF0-0x00000001898D1D30
	// [XID] // 0x00000001898D1CF0-0x00000001898D1D30
	public virtual void OnPoolAllocated() {} // 0x00000001836E8EA0-0x00000001836E8F40
	[BlackList] // 0x00000001898DC6D0-0x00000001898DC710
	// [XID] // 0x00000001898DC6D0-0x00000001898DC710
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836E8E00-0x00000001836E8EA0
}

