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
public class ConfigFootprint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18017
{
	// Fields
	private string _defaultEffectPatternName; // 0x10
	private Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> _specialSurfaces; // 0x18

	// Properties
	public string defaultEffectPatternName { /* [XID] */ /* 0x0000000189A10030-0x0000000189A10050 */ get => default; /* [XID] */ /* 0x0000000189A174B0-0x0000000189A174D0 */ private set {} } // 0x00000001819EB020-0x00000001819EB0C0 0x00000001819EB8C0-0x00000001819EB970
	public Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> specialSurfaces { /* [XID] */ /* 0x0000000189A1EC10-0x0000000189A1EC30 */ get => default; /* [XID] */ /* 0x0000000189A262C0-0x0000000189A262E0 */ private set {} } // 0x00000001819EB440-0x00000001819EB4E0 0x00000001819EACB0-0x00000001819EAD60

	// Constructors
	public ConfigFootprint() {} // 0x00000001819EBED0-0x00000001819EBF30

	// Methods
	// [XID] // 0x0000000189A2D5B0-0x0000000189A2D5D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001819EBBE0-0x00000001819EBCF0
	// [XID] // 0x0000000189A35050-0x0000000189A35070
	public void InitEmpty() {} // 0x00000001819EB4E0-0x00000001819EB5C0
	[BlackList] // 0x0000000189A3C4B0-0x0000000189A3C4F0
	// [XID] // 0x0000000189A3C4B0-0x0000000189A3C4F0
	public bool FromJson(JSONNode node) => default; // 0x00000001819EB0C0-0x00000001819EB440
	// [XID] // 0x0000000189A46E50-0x0000000189A46E70
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001819EA5D0-0x00000001819EA8A0
	// [XID] // 0x0000000189A4E790-0x0000000189A4E7B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86CB */, bool useObjectPool = false /* Metadata: 0x00AF86CF */) => default; // 0x00000001819EB5C0-0x00000001819EB8C0
	// [XID] // 0x0000000189A55E80-0x0000000189A55EA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86D0 */, bool useObjectPool = false /* Metadata: 0x00AF86D4 */) => default; // 0x00000001819EAD60-0x00000001819EB020
	[BlackList] // 0x0000000189A5D7E0-0x0000000189A5D820
	// [XID] // 0x0000000189A5D7E0-0x0000000189A5D820
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001819EA8A0-0x00000001819EAB70
	// [XID] // 0x0000000189A683B0-0x0000000189A683D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001819EB970-0x00000001819EBBE0
	[BlackList] // 0x0000000189A6F740-0x0000000189A6F780
	// [XID] // 0x0000000189A6F740-0x0000000189A6F780
	public virtual void AutoAllocTypeFields() {} // 0x00000001819EAB70-0x00000001819EAC10
	[BlackList] // 0x0000000189A7A470-0x0000000189A7A4B0
	// [XID] // 0x0000000189A7A470-0x0000000189A7A4B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819EAC10-0x00000001819EACB0
	[BlackList] // 0x0000000189A84B20-0x0000000189A84B60
	// [XID] // 0x0000000189A84B20-0x0000000189A84B60
	public virtual void ReturnToObjectPool() {} // 0x00000001819EBE30-0x00000001819EBED0
	[BlackList] // 0x0000000189A8F450-0x0000000189A8F490
	// [XID] // 0x0000000189A8F450-0x0000000189A8F490
	public virtual void OnPoolAllocated() {} // 0x00000001819EBD90-0x00000001819EBE30
	[BlackList] // 0x0000000189A99D60-0x0000000189A99DA0
	// [XID] // 0x0000000189A99D60-0x0000000189A99DA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819EBCF0-0x00000001819EBD90
}

