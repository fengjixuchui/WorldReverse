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
public class ConfigUI : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14985
{
	// Fields
	public bool actionEventConfigResolved; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<InputEventType, ConfigBaseInputEvent> _inputEvents; // 0x18
	private Dictionary<string, InputActionEvent[]> _actionGroups; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigBaseContext> _context; // 0x28

	// Properties
	public Dictionary<InputEventType, ConfigBaseInputEvent> inputEvents { /* [XID] */ /* 0x00000001897E7870-0x00000001897E7890 */ get => default; /* [XID] */ /* 0x00000001897EF490-0x00000001897EF4B0 */ private set {} } // 0x0000000181A59AE0-0x0000000181A59B80 0x0000000181A59560-0x0000000181A59610
	public Dictionary<string, InputActionEvent[]> actionGroups { /* [XID] */ /* 0x00000001897F6B00-0x00000001897F6B20 */ get => default; /* [XID] */ /* 0x00000001897FE160-0x00000001897FE180 */ private set {} } // 0x0000000181A59990-0x0000000181A59A30 0x0000000181A58940-0x0000000181A589F0
	public Dictionary<string, ConfigBaseContext> context { /* [XID] */ /* 0x0000000189805890-0x00000001898058B0 */ get => default; /* [XID] */ /* 0x000000018980CF70-0x000000018980CF90 */ private set {} } // 0x0000000181A5A2E0-0x0000000181A5A380 0x0000000181A59A30-0x0000000181A59AE0

	// Constructors
	public ConfigUI() {} // 0x0000000181A5A680-0x0000000181A5A6F0

	// Methods
	// [XID] // 0x0000000189814770-0x0000000189814790
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A5A380-0x0000000181A5A4A0
	// [XID] // 0x000000018981C1A0-0x000000018981C1C0
	public void InitEmpty() {} // 0x0000000181A59B80-0x0000000181A59C80
	[BlackList] // 0x00000001898236D0-0x0000000189823710
	// [XID] // 0x00000001898236D0-0x0000000189823710
	public bool FromJson(JSONNode node) => default; // 0x0000000181A59610-0x0000000181A59990
	// [XID] // 0x000000018982DF60-0x000000018982DF80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181A589F0-0x0000000181A58DA0
	// [XID] // 0x0000000189835590-0x00000001898355B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDB2 */, bool useObjectPool = false /* Metadata: 0x00AEFDB6 */) => default; // 0x0000000181A59C80-0x0000000181A59F80
	// [XID] // 0x000000018993F000-0x000000018993F020
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDB7 */, bool useObjectPool = false /* Metadata: 0x00AEFDBB */) => default; // 0x0000000181A59200-0x0000000181A59560
	[BlackList] // 0x00000001898443E0-0x0000000189844420
	// [XID] // 0x00000001898443E0-0x0000000189844420
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A58DA0-0x0000000181A59070
	// [XID] // 0x000000018984E8C0-0x000000018984E8E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A59F80-0x0000000181A5A2E0
	[BlackList] // 0x0000000189855930-0x0000000189855970
	// [XID] // 0x0000000189855930-0x0000000189855970
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A59070-0x0000000181A59110
	[BlackList] // 0x000000018985FDF0-0x000000018985FE30
	// [XID] // 0x000000018985FDF0-0x000000018985FE30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A59110-0x0000000181A59200
	[BlackList] // 0x000000018986A5C0-0x000000018986A600
	// [XID] // 0x000000018986A5C0-0x000000018986A600
	public virtual void ReturnToObjectPool() {} // 0x0000000181A5A5E0-0x0000000181A5A680
	[BlackList] // 0x0000000189874640-0x0000000189874680
	// [XID] // 0x0000000189874640-0x0000000189874680
	public virtual void OnPoolAllocated() {} // 0x0000000181A5A540-0x0000000181A5A5E0
	[BlackList] // 0x000000018987F0A0-0x000000018987F0E0
	// [XID] // 0x000000018987F0A0-0x000000018987F0E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A5A4A0-0x0000000181A5A540
}

