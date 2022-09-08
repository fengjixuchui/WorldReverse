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
public class ConfigAIPoseControl : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17404
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIPoseControlItem[] _items; // 0x10

	// Properties
	public ConfigAIPoseControlItem[] items { /* [XID] */ /* 0x000000018995C180-0x000000018995C1A0 */ get => default; /* [XID] */ /* 0x0000000189963B60-0x0000000189963B80 */ private set {} } // 0x0000000182FE7670-0x0000000182FE7710 0x0000000182FE81B0-0x0000000182FE8260

	// Constructors
	public ConfigAIPoseControl() {} // 0x0000000182FE8710-0x0000000182FE8770

	// Methods
	// [XID] // 0x000000018996B0F0-0x000000018996B110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FE8450-0x0000000182FE8530
	// [XID] // 0x0000000189972B90-0x0000000189972BB0
	public void InitEmpty() {} // 0x0000000182FE7DE0-0x0000000182FE7EB0
	[BlackList] // 0x000000018997A490-0x000000018997A4D0
	// [XID] // 0x000000018997A490-0x000000018997A4D0
	public bool FromJson(JSONNode node) => default; // 0x0000000182FE7A60-0x0000000182FE7DE0
	// [XID] // 0x00000001899848F0-0x0000000189984910
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182FE71C0-0x0000000182FE73A0
	// [XID] // 0x000000018998C390-0x000000018998C3B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D73 */, bool useObjectPool = false /* Metadata: 0x00AF6D77 */) => default; // 0x0000000182FE7EB0-0x0000000182FE81B0
	// [XID] // 0x0000000189994090-0x00000001899940B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D78 */, bool useObjectPool = false /* Metadata: 0x00AF6D7C */) => default; // 0x0000000182FE7850-0x0000000182FE7A60
	[BlackList] // 0x000000018999B8C0-0x000000018999B900
	// [XID] // 0x000000018999B8C0-0x000000018999B900
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FE73A0-0x0000000182FE7670
	// [XID] // 0x00000001899A64B0-0x00000001899A64D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FE8260-0x0000000182FE8450
	[BlackList] // 0x00000001899ADBA0-0x00000001899ADBE0
	// [XID] // 0x00000001899ADBA0-0x00000001899ADBE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FE7710-0x0000000182FE77B0
	[BlackList] // 0x00000001899B80F0-0x00000001899B8130
	// [XID] // 0x00000001899B80F0-0x00000001899B8130
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FE77B0-0x0000000182FE7850
	[BlackList] // 0x00000001899C2D00-0x00000001899C2D40
	// [XID] // 0x00000001899C2D00-0x00000001899C2D40
	public virtual void ReturnToObjectPool() {} // 0x0000000182FE8670-0x0000000182FE8710
	[BlackList] // 0x00000001899CD3D0-0x00000001899CD410
	// [XID] // 0x00000001899CD3D0-0x00000001899CD410
	public virtual void OnPoolAllocated() {} // 0x0000000182FE85D0-0x0000000182FE8670
	[BlackList] // 0x00000001899D7850-0x00000001899D7890
	// [XID] // 0x00000001899D7850-0x00000001899D7890
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FE8530-0x0000000182FE85D0
}

