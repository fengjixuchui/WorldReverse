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
public class SECTR_BakeLayersInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18977
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_BakeLayerInfo[] _list; // 0x10

	// Properties
	public SECTR_BakeLayerInfo[] list { /* [XID] */ /* 0x0000000189612F60-0x0000000189612F80 */ get => default; /* [XID] */ /* 0x000000018961A740-0x000000018961A760 */ set {} } // 0x0000000184CAA040-0x0000000184CAA0E0 0x0000000184CA9630-0x0000000184CA96E0

	// Constructors
	public SECTR_BakeLayersInfo() {} // 0x0000000184CAA560-0x0000000184CAA5C0

	// Methods
	// [XID] // 0x0000000189621C80-0x0000000189621CA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CAA2D0-0x0000000184CAA380
	// [XID] // 0x0000000189629630-0x0000000189629650
	public void InitEmpty() {} // 0x0000000184CA9C70-0x0000000184CA9D40
	[BlackList] // 0x0000000189630F00-0x0000000189630F40
	// [XID] // 0x0000000189630F00-0x0000000189630F40
	public bool FromJson(JSONNode node) => default; // 0x0000000184CA98F0-0x0000000184CA9C70
	// [XID] // 0x000000018963B640-0x000000018963B660
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184CA9040-0x0000000184CA9220
	// [XID] // 0x0000000189642EC0-0x0000000189642EE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB625 */, bool useObjectPool = false /* Metadata: 0x00AFB629 */) => default; // 0x0000000184CA9D40-0x0000000184CAA040
	// [XID] // 0x000000018964A560-0x000000018964A580
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB62A */, bool useObjectPool = false /* Metadata: 0x00AFB62E */) => default; // 0x0000000184CA96E0-0x0000000184CA98F0
	[BlackList] // 0x0000000189651D60-0x0000000189651DA0
	// [XID] // 0x0000000189651D60-0x0000000189651DA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CA9220-0x0000000184CA94F0
	// [XID] // 0x000000018965C5A0-0x000000018965C5C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CAA0E0-0x0000000184CAA2D0
	[BlackList] // 0x0000000189663BA0-0x0000000189663BE0
	// [XID] // 0x0000000189663BA0-0x0000000189663BE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184CA94F0-0x0000000184CA9590
	[BlackList] // 0x000000018966E320-0x000000018966E360
	// [XID] // 0x000000018966E320-0x000000018966E360
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184CA9590-0x0000000184CA9630
	[BlackList] // 0x0000000189679270-0x00000001896792B0
	// [XID] // 0x0000000189679270-0x00000001896792B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184CAA4C0-0x0000000184CAA560
	[BlackList] // 0x0000000189683770-0x00000001896837B0
	// [XID] // 0x0000000189683770-0x00000001896837B0
	public virtual void OnPoolAllocated() {} // 0x0000000184CAA420-0x0000000184CAA4C0
	[BlackList] // 0x000000018968E550-0x000000018968E590
	// [XID] // 0x000000018968E550-0x000000018968E590
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184CAA380-0x0000000184CAA420
}

