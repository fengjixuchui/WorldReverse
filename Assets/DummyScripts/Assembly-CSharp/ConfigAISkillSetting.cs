/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAISkillSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17499
{
	// Fields
	private Dictionary<SimpleSafeUInt8, SimpleSafeUInt32[]> _skillEliteSet; // 0x10

	// Properties
	public Dictionary<SimpleSafeUInt8, SimpleSafeUInt32[]> skillEliteSet { /* [XID] */ /* 0x00000001899E96A0-0x00000001899E96C0 */ get => default; /* [XID] */ /* 0x00000001899F0D10-0x00000001899F0D30 */ private set {} } // 0x000000018413D780-0x000000018413D820 0x000000018413DA30-0x000000018413DAE0

	// Constructors
	public ConfigAISkillSetting() {} // 0x000000018413E6E0-0x000000018413E740

	// Methods
	// [XID] // 0x00000001899F85B0-0x00000001899F85D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018413E420-0x000000018413E500
	// [XID] // 0x00000001899FFBA0-0x00000001899FFBC0
	public void InitEmpty() {} // 0x000000018413DE60-0x000000018413DF30
	[BlackList] // 0x0000000189A07410-0x0000000189A07450
	// [XID] // 0x0000000189A07410-0x0000000189A07450
	public bool FromJson(JSONNode node) => default; // 0x000000018413DAE0-0x000000018413DE60
	// [XID] // 0x0000000189A11C00-0x0000000189A11C20
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018413D190-0x000000018413D370
	// [XID] // 0x0000000189A18E10-0x0000000189A18E30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70C7 */, bool useObjectPool = false /* Metadata: 0x00AF70CB */) => default; // 0x000000018413DF30-0x000000018413E230
	// [XID] // 0x0000000189A20530-0x0000000189A20550
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70CC */, bool useObjectPool = false /* Metadata: 0x00AF70D0 */) => default; // 0x000000018413D820-0x000000018413DA30
	[BlackList] // 0x0000000189A279C0-0x0000000189A27A00
	// [XID] // 0x0000000189A279C0-0x0000000189A27A00
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018413D370-0x000000018413D640
	// [XID] // 0x0000000189A31E80-0x0000000189A31EA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018413E230-0x000000018413E420
	[BlackList] // 0x0000000189A39850-0x0000000189A39890
	// [XID] // 0x0000000189A39850-0x0000000189A39890
	public virtual void AutoAllocTypeFields() {} // 0x000000018413D640-0x000000018413D6E0
	[BlackList] // 0x0000000189A44110-0x0000000189A44150
	// [XID] // 0x0000000189A44110-0x0000000189A44150
	public virtual void AutoRecycleTypeFields() {} // 0x000000018413D6E0-0x000000018413D780
	[BlackList] // 0x0000000189A4E8B0-0x0000000189A4E8F0
	// [XID] // 0x0000000189A4E8B0-0x0000000189A4E8F0
	public virtual void ReturnToObjectPool() {} // 0x000000018413E640-0x000000018413E6E0
	[BlackList] // 0x0000000189A58E40-0x0000000189A58E80
	// [XID] // 0x0000000189A58E40-0x0000000189A58E80
	public virtual void OnPoolAllocated() {} // 0x000000018413E5A0-0x000000018413E640
	[BlackList] // 0x0000000189A639F0-0x0000000189A63A30
	// [XID] // 0x0000000189A639F0-0x0000000189A63A30
	public virtual void OnBeforePoolRecycled() {} // 0x000000018413E500-0x000000018413E5A0
}

