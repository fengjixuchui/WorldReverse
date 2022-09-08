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
public class ConfigDebuffResistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16849
{
	// Fields
	private AbilityState[] _ImmuneStates; // 0x10
	private SimpleSafeFloat ResistanceRatioRawNum; // 0x18
	private SimpleSafeFloat DurationRatioRawNum; // 0x1C

	// Properties
	public AbilityState[] ImmuneStates { /* [XID] */ /* 0x00000001899B3EA0-0x00000001899B3EC0 */ get => default; /* [XID] */ /* 0x00000001899BB2F0-0x00000001899BB310 */ private set {} } // 0x0000000182BDA820-0x0000000182BDA8C0 0x0000000182BD99E0-0x0000000182BD9A90
	public float ResistanceRatio { /* [XID] */ /* 0x00000001899C2E20-0x00000001899C2E40 */ get => default; /* [XID] */ /* 0x00000001899CA240-0x00000001899CA260 */ private set {} } // 0x0000000182BDA250-0x0000000182BDA330 0x0000000182BDA740-0x0000000182BDA820
	public float DurationRatio { /* [XID] */ /* 0x00000001899D1AA0-0x00000001899D1AC0 */ get => default; /* [XID] */ /* 0x00000001899D8FD0-0x00000001899D8FF0 */ private set {} } // 0x0000000182BD9DF0-0x0000000182BD9ED0 0x0000000182BD9770-0x0000000182BD9850

	// Constructors
	public ConfigDebuffResistance() {} // 0x0000000182BDAED0-0x0000000182BDAF30

	// Methods
	// [XID] // 0x00000001899E07A0-0x00000001899E07C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182BDABD0-0x0000000182BDACF0
	// [XID] // 0x00000001899E8220-0x00000001899E8240
	public void InitEmpty() {} // 0x0000000182BDA330-0x0000000182BDA440
	[BlackList] // 0x00000001899EF710-0x00000001899EF750
	// [XID] // 0x00000001899EF710-0x00000001899EF750
	public bool FromJson(JSONNode node) => default; // 0x0000000182BD9ED0-0x0000000182BDA250
	// [XID] // 0x00000001899F9ED0-0x00000001899F9EF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182BD9060-0x0000000182BD94A0
	// [XID] // 0x0000000189A012B0-0x0000000189A012D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4884 */, bool useObjectPool = false /* Metadata: 0x00AF4888 */) => default; // 0x0000000182BDA440-0x0000000182BDA740
	// [XID] // 0x0000000189A08C50-0x0000000189A08C70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4889 */, bool useObjectPool = false /* Metadata: 0x00AF488D */) => default; // 0x0000000182BD9A90-0x0000000182BD9DF0
	[BlackList] // 0x0000000189A10130-0x0000000189A10170
	// [XID] // 0x0000000189A10130-0x0000000189A10170
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182BD94A0-0x0000000182BD9770
	// [XID] // 0x0000000189A1A5B0-0x0000000189A1A5D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182BDA8C0-0x0000000182BDABD0
	[BlackList] // 0x0000000189A21D70-0x0000000189A21DB0
	// [XID] // 0x0000000189A21D70-0x0000000189A21DB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182BD9850-0x0000000182BD98F0
	[BlackList] // 0x0000000189A2C110-0x0000000189A2C150
	// [XID] // 0x0000000189A2C110-0x0000000189A2C150
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182BD98F0-0x0000000182BD99E0
	[BlackList] // 0x0000000189A36BD0-0x0000000189A36C10
	// [XID] // 0x0000000189A36BD0-0x0000000189A36C10
	public virtual void ReturnToObjectPool() {} // 0x0000000182BDAE30-0x0000000182BDAED0
	[BlackList] // 0x0000000189A41230-0x0000000189A41270
	// [XID] // 0x0000000189A41230-0x0000000189A41270
	public virtual void OnPoolAllocated() {} // 0x0000000182BDAD90-0x0000000182BDAE30
	[BlackList] // 0x0000000189A4B8A0-0x0000000189A4B8E0
	// [XID] // 0x0000000189A4B8A0-0x0000000189A4B8E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182BDACF0-0x0000000182BDAD90
}

