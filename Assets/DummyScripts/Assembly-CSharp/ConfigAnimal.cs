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
public class ConfigAnimal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18026
{
	// Fields
	private bool _hasAbility; // 0x10
	private bool _tickAbilityElement; // 0x11
	private bool _simpleCombat; // 0x12
	private bool _hasCharacterRenderering; // 0x13

	// Properties
	public bool hasAbility { /* [XID] */ /* 0x0000000189987850-0x0000000189987870 */ get => default; /* [XID] */ /* 0x000000018998F480-0x000000018998F4A0 */ private set {} } // 0x0000000183E6A150-0x0000000183E6A1F0 0x0000000183E69D20-0x0000000183E69DD0
	public bool tickAbilityElement { /* [XID] */ /* 0x0000000189996E40-0x0000000189996E60 */ get => default; /* [XID] */ /* 0x000000018999EA30-0x000000018999EA50 */ private set {} } // 0x0000000183E69880-0x0000000183E69920 0x0000000183E69920-0x0000000183E699D0
	public bool simpleCombat { /* [XID] */ /* 0x00000001899A6390-0x00000001899A63B0 */ get => default; /* [XID] */ /* 0x00000001899AD9E0-0x00000001899ADA00 */ private set {} } // 0x0000000183E6A640-0x0000000183E6A6E0 0x0000000183E6A780-0x0000000183E6A830
	public bool hasCharacterRenderering { /* [XID] */ /* 0x00000001899B5300-0x00000001899B5320 */ get => default; /* [XID] */ /* 0x00000001899BC970-0x00000001899BC990 */ private set {} } // 0x0000000183E6A6E0-0x0000000183E6A780 0x0000000183E6A1F0-0x0000000183E6A2A0

	// Constructors
	public ConfigAnimal() {} // 0x0000000183E6AE90-0x0000000183E6AF00

	// Methods
	// [XID] // 0x00000001899C43A0-0x00000001899C43C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E6AB70-0x0000000183E6ACB0
	// [XID] // 0x00000001899CBBE0-0x00000001899CBC00
	public void InitEmpty() {} // 0x0000000183E6A2A0-0x0000000183E6A340
	[BlackList] // 0x00000001899D3010-0x00000001899D3050
	// [XID] // 0x00000001899D3010-0x00000001899D3050
	public bool FromJson(JSONNode node) => default; // 0x0000000183E69DD0-0x0000000183E6A150
	// [XID] // 0x00000001899DD4A0-0x00000001899DD4C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E69080-0x0000000183E69470
	// [XID] // 0x00000001899E51C0-0x00000001899E51E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF871D */, bool useObjectPool = false /* Metadata: 0x00AF8721 */) => default; // 0x0000000183E6A340-0x0000000183E6A640
	// [XID] // 0x00000001899EC550-0x00000001899EC570
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8722 */, bool useObjectPool = false /* Metadata: 0x00AF8726 */) => default; // 0x0000000183E699D0-0x0000000183E69D20
	[BlackList] // 0x00000001899F4250-0x00000001899F4290
	// [XID] // 0x00000001899F4250-0x00000001899F4290
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E69470-0x0000000183E69740
	// [XID] // 0x00000001899FE570-0x00000001899FE590
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E6A830-0x0000000183E6AB70
	[BlackList] // 0x0000000189A05E10-0x0000000189A05E50
	// [XID] // 0x0000000189A05E10-0x0000000189A05E50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E69740-0x0000000183E697E0
	[BlackList] // 0x0000000189A0FFF0-0x0000000189A10030
	// [XID] // 0x0000000189A0FFF0-0x0000000189A10030
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E697E0-0x0000000183E69880
	[BlackList] // 0x0000000189A1A410-0x0000000189A1A450
	// [XID] // 0x0000000189A1A410-0x0000000189A1A450
	public virtual void ReturnToObjectPool() {} // 0x0000000183E6ADF0-0x0000000183E6AE90
	[BlackList] // 0x0000000189A24930-0x0000000189A24970
	// [XID] // 0x0000000189A24930-0x0000000189A24970
	public virtual void OnPoolAllocated() {} // 0x0000000183E6AD50-0x0000000183E6ADF0
	[BlackList] // 0x0000000189A2EFB0-0x0000000189A2EFF0
	// [XID] // 0x0000000189A2EFB0-0x0000000189A2EFF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E6ACB0-0x0000000183E6AD50
}

