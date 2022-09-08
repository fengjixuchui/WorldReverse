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
public class BornRandom : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17849
{
	// Constructors
	public BornRandom() {} // 0x0000000183AEED70-0x0000000183AEEDD0

	// Methods
	// [XID] // 0x00000001899DEBF0-0x00000001899DEC10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AEEAE0-0x0000000183AEEB90
	// [XID] // 0x00000001899E6810-0x00000001899E6830
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AEE980-0x0000000183AEEA30
	// [XID] // 0x00000001899EDE00-0x00000001899EDE20
	public virtual BornRandom Clone(bool useObjectPool = false /* Metadata: 0x00AF7EF9 */) => default; // 0x0000000183AEE6A0-0x0000000183AEE780
	// [XID] // 0x00000001899F5630-0x00000001899F5650
	public virtual int GetHashNum() => default; // 0x0000000183AEDB10-0x0000000183AEDBE0
	// [XID] // 0x00000001899FCDD0-0x00000001899FCDF0
	public virtual void InitEmpty() {} // 0x0000000183AEE210-0x0000000183AEE2B0
	[BlackList] // 0x0000000189A041F0-0x0000000189A04230
	// [XID] // 0x0000000189A041F0-0x0000000189A04230
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183AEDCC0-0x0000000183AEE040
	// [XID] // 0x0000000189A0E890-0x0000000189A0E8B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AED650-0x0000000183AED700
	[BlackList] // 0x0000000189A15F20-0x0000000189A15F60
	// [XID] // 0x0000000189A15F20-0x0000000189A15F60
	public static BornRandom ParseFromJson(JSONNode node) => default; // 0x0000000183AEE780-0x0000000183AEE980
	// [XID] // 0x0000000189A20470-0x0000000189A20490
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EFA */, bool useObjectPool = false /* Metadata: 0x00AF7EFE */) => default; // 0x0000000183AEE3A0-0x0000000183AEE6A0
	// [XID] // 0x0000000189A278A0-0x0000000189A278C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7EFF */, bool useObjectPool = false /* Metadata: 0x00AF7F03 */) => default; // 0x0000000183AEDBE0-0x0000000183AEDCC0
	// [XID] // 0x0000000189A2F010-0x0000000189A2F030
	public static BornRandom ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F04 */, bool useObjectPool = false /* Metadata: 0x00AF7F08 */) => default; // 0x0000000183AEE040-0x0000000183AEE210
	[BlackList] // 0x0000000189A369D0-0x0000000189A36A10
	// [XID] // 0x0000000189A369D0-0x0000000189A36A10
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AED700-0x0000000183AED9D0
	// [XID] // 0x0000000189A41090-0x0000000189A410B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AEEA30-0x0000000183AEEAE0
	[BlackList] // 0x0000000189A486D0-0x0000000189A48710
	// [XID] // 0x0000000189A486D0-0x0000000189A48710
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AEE2B0-0x0000000183AEE3A0
	[BlackList] // 0x0000000189A52C80-0x0000000189A52CC0
	// [XID] // 0x0000000189A52C80-0x0000000189A52CC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AED9D0-0x0000000183AEDA70
	[BlackList] // 0x0000000189A5D8C0-0x0000000189A5D900
	// [XID] // 0x0000000189A5D8C0-0x0000000189A5D900
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AEDA70-0x0000000183AEDB10
	[BlackList] // 0x0000000189A68430-0x0000000189A68470
	// [XID] // 0x0000000189A68430-0x0000000189A68470
	public virtual void ReturnToObjectPool() {} // 0x0000000183AEECD0-0x0000000183AEED70
	[BlackList] // 0x0000000189A729A0-0x0000000189A729E0
	// [XID] // 0x0000000189A729A0-0x0000000189A729E0
	public virtual void OnPoolAllocated() {} // 0x0000000183AEEC30-0x0000000183AEECD0
	[BlackList] // 0x0000000189A7D2F0-0x0000000189A7D330
	// [XID] // 0x0000000189A7D2F0-0x0000000189A7D330
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AEEB90-0x0000000183AEEC30
}

