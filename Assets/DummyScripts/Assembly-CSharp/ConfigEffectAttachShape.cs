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
public class ConfigEffectAttachShape : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17700
{
	// Constructors
	public ConfigEffectAttachShape() {} // 0x0000000183FC1AF0-0x0000000183FC1B50

	// Methods
	// [XID] // 0x000000018989D660-0x000000018989D680
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183FC1860-0x0000000183FC1910
	// [XID] // 0x00000001898A5060-0x00000001898A5080
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183FC1700-0x0000000183FC17B0
	// [XID] // 0x00000001898AC4A0-0x00000001898AC4C0
	public virtual ConfigEffectAttachShape Clone(bool useObjectPool = false /* Metadata: 0x00AF783B */) => default; // 0x0000000183FC1420-0x0000000183FC1500
	// [XID] // 0x00000001898B3A80-0x00000001898B3AA0
	public virtual int GetHashNum() => default; // 0x0000000183FC0890-0x0000000183FC0960
	// [XID] // 0x00000001898BB870-0x00000001898BB890
	public virtual void InitEmpty() {} // 0x0000000183FC0F90-0x0000000183FC1030
	[BlackList] // 0x00000001898C2B20-0x00000001898C2B60
	// [XID] // 0x00000001898C2B20-0x00000001898C2B60
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183FC0A40-0x0000000183FC0DC0
	// [XID] // 0x00000001898CD420-0x00000001898CD440
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183FC03D0-0x0000000183FC0480
	[BlackList] // 0x00000001898D4C70-0x00000001898D4CB0
	// [XID] // 0x00000001898D4C70-0x00000001898D4CB0
	public static ConfigEffectAttachShape ParseFromJson(JSONNode node) => default; // 0x0000000183FC1500-0x0000000183FC1700
	// [XID] // 0x00000001898DFA40-0x00000001898DFA60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF783C */, bool useObjectPool = false /* Metadata: 0x00AF7840 */) => default; // 0x0000000183FC1120-0x0000000183FC1420
	// [XID] // 0x00000001898E7570-0x00000001898E7590
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7841 */, bool useObjectPool = false /* Metadata: 0x00AF7845 */) => default; // 0x0000000183FC0960-0x0000000183FC0A40
	// [XID] // 0x00000001898EED60-0x00000001898EED80
	public static ConfigEffectAttachShape ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7846 */, bool useObjectPool = false /* Metadata: 0x00AF784A */) => default; // 0x0000000183FC0DC0-0x0000000183FC0F90
	[BlackList] // 0x00000001898F6620-0x00000001898F6660
	// [XID] // 0x00000001898F6620-0x00000001898F6660
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183FC0480-0x0000000183FC0750
	// [XID] // 0x0000000189900F50-0x0000000189900F70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183FC17B0-0x0000000183FC1860
	[BlackList] // 0x00000001899086F0-0x0000000189908730
	// [XID] // 0x00000001899086F0-0x0000000189908730
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183FC1030-0x0000000183FC1120
	[BlackList] // 0x00000001899130E0-0x0000000189913120
	// [XID] // 0x00000001899130E0-0x0000000189913120
	public virtual void AutoAllocTypeFields() {} // 0x0000000183FC0750-0x0000000183FC07F0
	[BlackList] // 0x000000018991D7D0-0x000000018991D810
	// [XID] // 0x000000018991D7D0-0x000000018991D810
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183FC07F0-0x0000000183FC0890
	[BlackList] // 0x0000000189927EF0-0x0000000189927F30
	// [XID] // 0x0000000189927EF0-0x0000000189927F30
	public virtual void ReturnToObjectPool() {} // 0x0000000183FC1A50-0x0000000183FC1AF0
	[BlackList] // 0x0000000189932520-0x0000000189932560
	// [XID] // 0x0000000189932520-0x0000000189932560
	public virtual void OnPoolAllocated() {} // 0x0000000183FC19B0-0x0000000183FC1A50
	[BlackList] // 0x000000018993CDD0-0x000000018993CE10
	// [XID] // 0x000000018993CDD0-0x000000018993CE10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183FC1910-0x0000000183FC19B0
}

