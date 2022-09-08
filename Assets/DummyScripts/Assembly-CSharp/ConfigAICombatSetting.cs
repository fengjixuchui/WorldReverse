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
public class ConfigAICombatSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17491
{
	// Fields
	private Dictionary<ConfigAICombatPhase, SimpleSafeInt32[]> _combatPhases; // 0x10
	private ConfigAICombatRole _combatRole; // 0x18
	private bool _broadcastFearOnDeath; // 0x1C

	// Properties
	public Dictionary<ConfigAICombatPhase, SimpleSafeInt32[]> combatPhases { /* [XID] */ /* 0x0000000189649160-0x0000000189649180 */ get => default; /* [XID] */ /* 0x0000000189650810-0x0000000189650830 */ private set {} } // 0x0000000183E581E0-0x0000000183E58280 0x0000000183E58130-0x0000000183E581E0
	public ConfigAICombatRole combatRole { /* [XID] */ /* 0x0000000189728DC0-0x0000000189728DE0 */ get => default; /* [XID] */ /* 0x000000018965F680-0x000000018965F6A0 */ private set {} } // 0x0000000183E58600-0x0000000183E586A0 0x0000000183E586A0-0x0000000183E58750
	public bool broadcastFearOnDeath { /* [XID] */ /* 0x0000000189666FF0-0x0000000189667010 */ get => default; /* [XID] */ /* 0x000000018966E700-0x000000018966E720 */ private set {} } // 0x0000000183E58820-0x0000000183E588C0 0x0000000183E58BC0-0x0000000183E58C70

	// Constructors
	public ConfigAICombatSetting() {} // 0x0000000183E59260-0x0000000183E592D0

	// Methods
	// [XID] // 0x000000018998CD20-0x000000018998CD40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E58F60-0x0000000183E59080
	// [XID] // 0x000000018967DB20-0x000000018967DB40
	public void InitEmpty() {} // 0x0000000183E58750-0x0000000183E58820
	[BlackList] // 0x0000000189685220-0x0000000189685260
	// [XID] // 0x0000000189685220-0x0000000189685260
	public bool FromJson(JSONNode node) => default; // 0x0000000183E58280-0x0000000183E58600
	// [XID] // 0x0000000189690080-0x00000001896900A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E57690-0x0000000183E57A10
	// [XID] // 0x0000000189697A00-0x0000000189697A20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7077 */, bool useObjectPool = false /* Metadata: 0x00AF707B */) => default; // 0x0000000183E588C0-0x0000000183E58BC0
	// [XID] // 0x000000018969EE30-0x000000018969EE50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF707C */, bool useObjectPool = false /* Metadata: 0x00AF7080 */) => default; // 0x0000000183E57E30-0x0000000183E58130
	[BlackList] // 0x00000001896A61B0-0x00000001896A61F0
	// [XID] // 0x00000001896A61B0-0x00000001896A61F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E57A10-0x0000000183E57CE0
	// [XID] // 0x00000001896B0390-0x00000001896B03B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E58C70-0x0000000183E58F60
	[BlackList] // 0x00000001896B7D70-0x00000001896B7DB0
	// [XID] // 0x00000001896B7D70-0x00000001896B7DB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E57CE0-0x0000000183E57D80
	[BlackList] // 0x00000001896C1C80-0x00000001896C1CC0
	// [XID] // 0x00000001896C1C80-0x00000001896C1CC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E57D80-0x0000000183E57E30
	[BlackList] // 0x00000001896CC450-0x00000001896CC490
	// [XID] // 0x00000001896CC450-0x00000001896CC490
	public virtual void ReturnToObjectPool() {} // 0x0000000183E591C0-0x0000000183E59260
	[BlackList] // 0x00000001896D6A60-0x00000001896D6AA0
	// [XID] // 0x00000001896D6A60-0x00000001896D6AA0
	public virtual void OnPoolAllocated() {} // 0x0000000183E59120-0x0000000183E591C0
	[BlackList] // 0x00000001896E1270-0x00000001896E12B0
	// [XID] // 0x00000001896E1270-0x00000001896E12B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E59080-0x0000000183E59120
}

