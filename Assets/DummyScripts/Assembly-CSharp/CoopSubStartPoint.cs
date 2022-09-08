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
public class CoopSubStartPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17761
{
	// Fields
	private uint _id; // 0x10
	private uint _coopInteractionId; // 0x14

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A15F60-0x0000000189A15F80 */ get => default; /* [XID] */ /* 0x0000000189A1D500-0x0000000189A1D520 */ private set {} } // 0x000000018220E180-0x000000018220E220 0x000000018220D8A0-0x000000018220D950
	public uint coopInteractionId { /* [XID] */ /* 0x0000000189A249B0-0x0000000189A249D0 */ get => default; /* [XID] */ /* 0x0000000189A2BFB0-0x0000000189A2BFD0 */ private set {} } // 0x000000018220DC50-0x000000018220DCF0 0x000000018220D3D0-0x000000018220D480

	// Constructors
	public CoopSubStartPoint() {} // 0x000000018220E2C0-0x000000018220E320

	// Methods
	// [XID] // 0x0000000189A33680-0x0000000189A336A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018220DF30-0x000000018220E040
	// [XID] // 0x0000000189A3AE20-0x0000000189A3AE40
	public void InitEmpty() {} // 0x000000018220D800-0x000000018220D8A0
	[BlackList] // 0x0000000189A42710-0x0000000189A42750
	// [XID] // 0x0000000189A42710-0x0000000189A42750
	public bool FromJson(JSONNode node) => default; // 0x000000018220D480-0x000000018220D800
	// [XID] // 0x0000000189A4CDA0-0x0000000189A4CDC0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018220CAF0-0x000000018220CD70
	// [XID] // 0x0000000189A54530-0x0000000189A54550
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B43 */, bool useObjectPool = false /* Metadata: 0x00AF7B47 */) => default; // 0x000000018220D950-0x000000018220DC50
	// [XID] // 0x0000000189A5C040-0x0000000189A5C060
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B48 */, bool useObjectPool = false /* Metadata: 0x00AF7B4C */) => default; // 0x000000018220D180-0x000000018220D3D0
	[BlackList] // 0x0000000189A638F0-0x0000000189A63930
	// [XID] // 0x0000000189A638F0-0x0000000189A63930
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018220CD70-0x000000018220D040
	// [XID] // 0x0000000189A6E120-0x0000000189A6E140
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018220DCF0-0x000000018220DF30
	[BlackList] // 0x0000000189A755F0-0x0000000189A75630
	// [XID] // 0x0000000189A755F0-0x0000000189A75630
	public virtual void AutoAllocTypeFields() {} // 0x000000018220D040-0x000000018220D0E0
	[BlackList] // 0x0000000189A7FF00-0x0000000189A7FF40
	// [XID] // 0x0000000189A7FF00-0x0000000189A7FF40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018220D0E0-0x000000018220D180
	[BlackList] // 0x0000000189A8AC20-0x0000000189A8AC60
	// [XID] // 0x0000000189A8AC20-0x0000000189A8AC60
	public virtual void ReturnToObjectPool() {} // 0x000000018220E220-0x000000018220E2C0
	[BlackList] // 0x0000000189A951F0-0x0000000189A95230
	// [XID] // 0x0000000189A951F0-0x0000000189A95230
	public virtual void OnPoolAllocated() {} // 0x000000018220E0E0-0x000000018220E180
	[BlackList] // 0x0000000189A9F870-0x0000000189A9F8B0
	// [XID] // 0x0000000189A9F870-0x0000000189A9F8B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018220E040-0x000000018220E0E0
}

