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
public class ConfigAIFleeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17460
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat cdRawNum; // 0x18
	private SimpleSafeFloat triggerDistanceRawNum; // 0x1C
	private SimpleSafeFloat fleeAngleRawNum; // 0x20
	private SimpleSafeInt32 fleeNumberMinRawNum; // 0x24
	private SimpleSafeInt32 fleeNumberMaxRawNum; // 0x28
	private SimpleSafeFloat fleeDistanceMinRawNum; // 0x2C
	private SimpleSafeFloat fleeDistanceMaxRawNum; // 0x30
	private bool _turnToTarget; // 0x34
	private bool _restrictedByDefendArea; // 0x35
	private bool _expandFleeAngleWhenBlocked; // 0x36
	private SimpleSafeFloat killSelfTimeRawNum; // 0x38

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189951CB0-0x0000000189951CD0 */ get => default; /* [XID] */ /* 0x00000001899591D0-0x00000001899591F0 */ private set {} } // 0x0000000184729D10-0x0000000184729DE0 0x000000018472A070-0x000000018472A150
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189960A40-0x0000000189960A60 */ get => default; /* [XID] */ /* 0x0000000189968200-0x0000000189968220 */ private set {} } // 0x0000000184729EB0-0x0000000184729F90 0x000000018472A9F0-0x000000018472AAD0
	public float cd { /* [XID] */ /* 0x000000018996F600-0x000000018996F620 */ get => default; /* [XID] */ /* 0x0000000189977320-0x0000000189977340 */ private set {} } // 0x000000018472BBC0-0x000000018472BCA0 0x000000018472B090-0x000000018472B170
	public float triggerDistance { /* [XID] */ /* 0x000000018997D6F0-0x000000018997D710 */ get => default; /* [XID] */ /* 0x00000001899860D0-0x00000001899860F0 */ private set {} } // 0x000000018472CC30-0x000000018472CD10 0x000000018472CB50-0x000000018472CC30
	public float fleeAngle { /* [XID] */ /* 0x000000018998DD60-0x000000018998DD80 */ get => default; /* [XID] */ /* 0x0000000189995870-0x0000000189995890 */ private set {} } // 0x000000018472BAE0-0x000000018472BBC0 0x000000018472AAD0-0x000000018472ABB0
	public int fleeNumberMin { /* [XID] */ /* 0x000000018999D190-0x000000018999D1B0 */ get => default; /* [XID] */ /* 0x00000001899A4B70-0x00000001899A4B90 */ private set {} } // 0x0000000184729DE0-0x0000000184729EB0 0x000000018472B7D0-0x000000018472B8B0
	public int fleeNumberMax { /* [XID] */ /* 0x00000001899AC5F0-0x00000001899AC610 */ get => default; /* [XID] */ /* 0x00000001899B3DA0-0x00000001899B3DC0 */ private set {} } // 0x000000018472A920-0x000000018472A9F0 0x000000018472CA70-0x000000018472CB50
	public float fleeDistanceMin { /* [XID] */ /* 0x00000001899BB1D0-0x00000001899BB1F0 */ get => default; /* [XID] */ /* 0x00000001899C2CC0-0x00000001899C2CE0 */ private set {} } // 0x0000000184729F90-0x000000018472A070 0x000000018472B170-0x000000018472B250
	public float fleeDistanceMax { /* [XID] */ /* 0x00000001899CA180-0x00000001899CA1A0 */ get => default; /* [XID] */ /* 0x00000001899D19E0-0x00000001899D1A00 */ private set {} } // 0x000000018472B8B0-0x000000018472B990 0x000000018472BCA0-0x000000018472BD80
	public bool turnToTarget { /* [XID] */ /* 0x00000001899D8ED0-0x00000001899D8EF0 */ get => default; /* [XID] */ /* 0x00000001899E0580-0x00000001899E05A0 */ private set {} } // 0x000000018472C9D0-0x000000018472CA70 0x000000018472BA30-0x000000018472BAE0
	public bool restrictedByDefendArea { /* [XID] */ /* 0x00000001899E8140-0x00000001899E8160 */ get => default; /* [XID] */ /* 0x00000001899EF5F0-0x00000001899EF610 */ private set {} } // 0x0000000184729A20-0x0000000184729AC0 0x000000018472AFE0-0x000000018472B090
	public bool expandFleeAngleWhenBlocked { /* [XID] */ /* 0x00000001899F6ED0-0x00000001899F6EF0 */ get => default; /* [XID] */ /* 0x00000001899FE6B0-0x00000001899FE6D0 */ private set {} } // 0x000000018472B990-0x000000018472BA30 0x000000018472AF30-0x000000018472AFE0
	public float killSelfTime { /* [XID] */ /* 0x0000000189A05ED0-0x0000000189A05EF0 */ get => default; /* [XID] */ /* 0x0000000189A0D300-0x0000000189A0D320 */ private set {} } // 0x000000018472B250-0x000000018472B330 0x0000000184729670-0x0000000184729750

	// Constructors
	public ConfigAIFleeData() {} // 0x000000018472CDB0-0x000000018472CF20

	// Methods
	// [XID] // 0x0000000189A14B20-0x0000000189A14B40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018472C660-0x000000018472C890
	// [XID] // 0x0000000189A1BDB0-0x0000000189A1BDD0
	public void InitEmpty() {} // 0x000000018472B330-0x000000018472B4D0
	[BlackList] // 0x0000000189A235C0-0x0000000189A23600
	// [XID] // 0x0000000189A235C0-0x0000000189A23600
	public bool FromJson(JSONNode node) => default; // 0x000000018472ABB0-0x000000018472AF30
	// [XID] // 0x0000000189A2D670-0x0000000189A2D690
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001847289C0-0x0000000184729670
	// [XID] // 0x0000000189A351B0-0x0000000189A351D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F61 */, bool useObjectPool = false /* Metadata: 0x00AF6F65 */) => default; // 0x000000018472B4D0-0x000000018472B7D0
	// [XID] // 0x0000000189A3C6C0-0x0000000189A3C6E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F66 */, bool useObjectPool = false /* Metadata: 0x00AF6F6A */) => default; // 0x000000018472A150-0x000000018472A920
	[BlackList] // 0x0000000189A44150-0x0000000189A44190
	// [XID] // 0x0000000189A44150-0x0000000189A44190
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184729750-0x0000000184729A20
	// [XID] // 0x0000000189A4E8F0-0x0000000189A4E910
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018472BD80-0x000000018472C660
	[BlackList] // 0x0000000189A55FE0-0x0000000189A56020
	// [XID] // 0x0000000189A55FE0-0x0000000189A56020
	public virtual void AutoAllocTypeFields() {} // 0x0000000184729AC0-0x0000000184729B60
	[BlackList] // 0x0000000189A607A0-0x0000000189A607E0
	// [XID] // 0x0000000189A607A0-0x0000000189A607E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184729B60-0x0000000184729D10
	[BlackList] // 0x0000000189A6B290-0x0000000189A6B2D0
	// [XID] // 0x0000000189A6B290-0x0000000189A6B2D0
	public virtual void ReturnToObjectPool() {} // 0x000000018472CD10-0x000000018472CDB0
	[BlackList] // 0x0000000189A756B0-0x0000000189A756F0
	// [XID] // 0x0000000189A756B0-0x0000000189A756F0
	public virtual void OnPoolAllocated() {} // 0x000000018472C930-0x000000018472C9D0
	[BlackList] // 0x0000000189A7FFA0-0x0000000189A7FFE0
	// [XID] // 0x0000000189A7FFA0-0x0000000189A7FFE0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018472C890-0x000000018472C930
}

