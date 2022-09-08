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
public class SECTR_PlatformStreamLayer : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18965
{
	// Fields
	private SECTR_PlatformType _type; // 0x10
	private ulong _layerLoaderPathHash; // 0x18

	// Properties
	public SECTR_PlatformType type { /* [XID] */ /* 0x00000001899DBC50-0x00000001899DBC70 */ get => default; /* [XID] */ /* 0x00000001899E3670-0x00000001899E3690 */ private set {} } // 0x0000000184180960-0x0000000184180A00 0x0000000184180420-0x00000001841804D0
	public ulong layerLoaderPathHash { /* [XID] */ /* 0x00000001899EAA40-0x00000001899EAA60 */ get => default; /* [XID] */ /* 0x00000001899F25A0-0x00000001899F25C0 */ private set {} } // 0x000000018417FF30-0x000000018417FFD0 0x0000000184180370-0x0000000184180420

	// Constructors
	public SECTR_PlatformStreamLayer() {} // 0x0000000184180AA0-0x0000000184180B00

	// Methods
	// [XID] // 0x00000001899F9B30-0x00000001899F9B50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184180710-0x0000000184180820
	// [XID] // 0x0000000189A00F50-0x0000000189A00F70
	public void InitEmpty() {} // 0x000000018417FFD0-0x0000000184180070
	[BlackList] // 0x0000000189A08830-0x0000000189A08870
	// [XID] // 0x0000000189A08830-0x0000000189A08870
	public bool FromJson(JSONNode node) => default; // 0x000000018417FBB0-0x000000018417FF30
	// [XID] // 0x0000000189A13000-0x0000000189A13020
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018417F2B0-0x000000018417F550
	// [XID] // 0x0000000189A1A310-0x0000000189A1A330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5B7 */, bool useObjectPool = false /* Metadata: 0x00AFB5BB */) => default; // 0x0000000184180070-0x0000000184180370
	// [XID] // 0x0000000189A218F0-0x0000000189A21910
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5BC */, bool useObjectPool = false /* Metadata: 0x00AFB5C0 */) => default; // 0x000000018417F960-0x000000018417FBB0
	[BlackList] // 0x0000000189A28E60-0x0000000189A28EA0
	// [XID] // 0x0000000189A28E60-0x0000000189A28EA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018417F550-0x000000018417F820
	// [XID] // 0x0000000189A33320-0x0000000189A33340
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841804D0-0x0000000184180710
	[BlackList] // 0x0000000189A3AC40-0x0000000189A3AC80
	// [XID] // 0x0000000189A3AC40-0x0000000189A3AC80
	public virtual void AutoAllocTypeFields() {} // 0x000000018417F820-0x000000018417F8C0
	[BlackList] // 0x0000000189A45520-0x0000000189A45560
	// [XID] // 0x0000000189A45520-0x0000000189A45560
	public virtual void AutoRecycleTypeFields() {} // 0x000000018417F8C0-0x000000018417F960
	[BlackList] // 0x0000000189A4FDA0-0x0000000189A4FDE0
	// [XID] // 0x0000000189A4FDA0-0x0000000189A4FDE0
	public virtual void ReturnToObjectPool() {} // 0x0000000184180A00-0x0000000184180AA0
	[BlackList] // 0x0000000189A5A410-0x0000000189A5A450
	// [XID] // 0x0000000189A5A410-0x0000000189A5A450
	public virtual void OnPoolAllocated() {} // 0x00000001841808C0-0x0000000184180960
	[BlackList] // 0x0000000189A64E80-0x0000000189A64EC0
	// [XID] // 0x0000000189A64E80-0x0000000189A64EC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184180820-0x00000001841808C0
}

