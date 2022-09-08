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
public class ConfigBaseContext : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14984
{
	// Fields
	public bool actionEventConfigResolved; // 0x10
	public ConfigUI configUI; // 0x18
	private Dictionary<string, InputActionEvent[]> _actionGroups; // 0x20
	private Dictionary<SimpleSafeInt32, DeviceAction> _stateActions; // 0x28
	private bool _enableInputPenetrate; // 0x30
	private bool _enableJoypadVirtualCursor; // 0x31

	// Properties
	public Dictionary<string, InputActionEvent[]> actionGroups { /* [XID] */ /* 0x0000000189A97850-0x0000000189A97870 */ get => default; /* [XID] */ /* 0x0000000189725B20-0x0000000189725B40 */ private set {} } // 0x00000001826ADCF0-0x00000001826ADD90 0x00000001826AC970-0x00000001826ACA20
	public Dictionary<SimpleSafeInt32, DeviceAction> stateActions { /* [XID] */ /* 0x000000018972D0A0-0x000000018972D0C0 */ get => default; /* [XID] */ /* 0x0000000189734890-0x00000001897348B0 */ private set {} } // 0x00000001826ADE30-0x00000001826ADED0 0x00000001826ADFC0-0x00000001826AE070
	public bool enableInputPenetrate { /* [XID] */ /* 0x000000018973C220-0x000000018973C240 */ get => default; /* [XID] */ /* 0x00000001897439B0-0x00000001897439D0 */ private set {} } // 0x00000001826ADD90-0x00000001826ADE30 0x00000001826AD280-0x00000001826AD330
	public bool enableJoypadVirtualCursor { /* [XID] */ /* 0x000000018972BFB0-0x000000018972BFD0 */ get => default; /* [XID] */ /* 0x00000001897526F0-0x0000000189752710 */ private set {} } // 0x00000001826AD330-0x00000001826AD3D0 0x00000001826AE370-0x00000001826AE420

	// Constructors
	public ConfigBaseContext() {} // 0x00000001826AEAF0-0x00000001826AEB60

	// Methods
	// [XID] // 0x0000000189716AC0-0x0000000189716AE0
	public InputActionEvent[] GetActionGroup(string name) => default; // 0x00000001826AD3D0-0x00000001826AD5C0
	// [XID] // 0x0000000189759CE0-0x0000000189759D00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001826AE7D0-0x00000001826AE910
	// [XID] // 0x00000001897618F0-0x0000000189761910
	public void InitEmpty() {} // 0x00000001826ADED0-0x00000001826ADFC0
	[BlackList] // 0x0000000189768D20-0x0000000189768D60
	// [XID] // 0x0000000189768D20-0x0000000189768D60
	public bool FromJson(JSONNode node) => default; // 0x00000001826AD970-0x00000001826ADCF0
	// [XID] // 0x0000000189773360-0x0000000189773380
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001826ACA20-0x00000001826ACE60
	// [XID] // 0x000000018977AA40-0x000000018977AA60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDA8 */, bool useObjectPool = false /* Metadata: 0x00AEFDAC */) => default; // 0x00000001826AE070-0x00000001826AE370
	// [XID] // 0x00000001897825E0-0x0000000189782600
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDAD */, bool useObjectPool = false /* Metadata: 0x00AEFDB1 */) => default; // 0x00000001826AD5C0-0x00000001826AD970
	[BlackList] // 0x00000001897898E0-0x0000000189789920
	// [XID] // 0x00000001897898E0-0x0000000189789920
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001826ACE60-0x00000001826AD130
	// [XID] // 0x0000000189793D60-0x0000000189793D80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001826AE420-0x00000001826AE7D0
	[BlackList] // 0x000000018979C150-0x000000018979C190
	// [XID] // 0x000000018979C150-0x000000018979C190
	public virtual void AutoAllocTypeFields() {} // 0x00000001826AD130-0x00000001826AD1D0
	[BlackList] // 0x00000001897A6740-0x00000001897A6780
	// [XID] // 0x00000001897A6740-0x00000001897A6780
	public virtual void AutoRecycleTypeFields() {} // 0x00000001826AD1D0-0x00000001826AD280
	[BlackList] // 0x00000001897B0E40-0x00000001897B0E80
	// [XID] // 0x00000001897B0E40-0x00000001897B0E80
	public virtual void ReturnToObjectPool() {} // 0x00000001826AEA50-0x00000001826AEAF0
	[BlackList] // 0x00000001897BC370-0x00000001897BC3B0
	// [XID] // 0x00000001897BC370-0x00000001897BC3B0
	public virtual void OnPoolAllocated() {} // 0x00000001826AE9B0-0x00000001826AEA50
	[BlackList] // 0x00000001897C6C00-0x00000001897C6C40
	// [XID] // 0x00000001897C6C00-0x00000001897C6C40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001826AE910-0x00000001826AE9B0
}

