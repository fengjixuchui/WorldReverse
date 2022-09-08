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
public class ConfigWindSeed : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17992
{
	// Fields
	private SimpleSafeFloat athuorityRadiusRawNum; // 0x10

	// Properties
	public float athuorityRadius { /* [XID] */ /* 0x00000001899834B0-0x00000001899834D0 */ get => default; /* [XID] */ /* 0x000000018998ACC0-0x000000018998ACE0 */ private set {} } // 0x0000000183375420-0x0000000183375500 0x00000001833751D0-0x00000001833752B0

	// Constructors
	public ConfigWindSeed() {} // 0x00000001833762A0-0x0000000183376340

	// Methods
	// [XID] // 0x00000001899925B0-0x00000001899925D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183375FD0-0x00000001833760C0
	// [XID] // 0x000000018999A2D0-0x000000018999A2F0
	public void InitEmpty() {} // 0x0000000183375A50-0x0000000183375B20
	[BlackList] // 0x00000001899A1990-0x00000001899A19D0
	// [XID] // 0x00000001899A1990-0x00000001899A19D0
	public bool FromJson(JSONNode node) => default; // 0x00000001833756D0-0x0000000183375A50
	// [XID] // 0x00000001899AC4F0-0x00000001899AC510
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183374CF0-0x0000000183374F00
	// [XID] // 0x00000001899B3C80-0x00000001899B3CA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85F3 */, bool useObjectPool = false /* Metadata: 0x00AF85F7 */) => default; // 0x0000000183375B20-0x0000000183375E20
	// [XID] // 0x00000001899BB090-0x00000001899BB0B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85F8 */, bool useObjectPool = false /* Metadata: 0x00AF85FC */) => default; // 0x0000000183375500-0x00000001833756D0
	[BlackList] // 0x00000001899C2A40-0x00000001899C2A80
	// [XID] // 0x00000001899C2A40-0x00000001899C2A80
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183374F00-0x00000001833751D0
	// [XID] // 0x00000001899CD1D0-0x00000001899CD1F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183375E20-0x0000000183375FD0
	[BlackList] // 0x00000001899D4730-0x00000001899D4770
	// [XID] // 0x00000001899D4730-0x00000001899D4770
	public virtual void AutoAllocTypeFields() {} // 0x00000001833752B0-0x0000000183375350
	[BlackList] // 0x00000001899DEB90-0x00000001899DEBD0
	// [XID] // 0x00000001899DEB90-0x00000001899DEBD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183375350-0x0000000183375420
	[BlackList] // 0x00000001899E95A0-0x00000001899E95E0
	// [XID] // 0x00000001899E95A0-0x00000001899E95E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183376200-0x00000001833762A0
	[BlackList] // 0x00000001899F4290-0x00000001899F42D0
	// [XID] // 0x00000001899F4290-0x00000001899F42D0
	public virtual void OnPoolAllocated() {} // 0x0000000183376160-0x0000000183376200
	[BlackList] // 0x00000001899FE590-0x00000001899FE5D0
	// [XID] // 0x00000001899FE590-0x00000001899FE5D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833760C0-0x0000000183376160
}

