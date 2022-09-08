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
public class ConfigAIFollowServerRouteData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17425
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideWalkRawNum; // 0x14
	private SimpleSafeFloat turnSpeedOverrideRunRawNum; // 0x18
	private SimpleSafeFloat checkRangeRawNum; // 0x1C
	private bool _special; // 0x20

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189740A40-0x0000000189740A60 */ get => default; /* [XID] */ /* 0x0000000189747E40-0x0000000189747E60 */ private set {} } // 0x000000018265ADE0-0x000000018265AEB0 0x000000018265B040-0x000000018265B120
	public float turnSpeedOverrideWalk { /* [XID] */ /* 0x000000018974F530-0x000000018974F550 */ get => default; /* [XID] */ /* 0x0000000189756BC0-0x0000000189756BE0 */ private set {} } // 0x000000018265BE20-0x000000018265BF00 0x000000018265C3F0-0x000000018265C4D0
	public float turnSpeedOverrideRun { /* [XID] */ /* 0x000000018975E0B0-0x000000018975E0D0 */ get => default; /* [XID] */ /* 0x00000001897657F0-0x0000000189765810 */ private set {} } // 0x000000018265AF60-0x000000018265B040 0x000000018265B870-0x000000018265B950
	public float checkRange { /* [XID] */ /* 0x000000018976D040-0x000000018976D060 */ get => default; /* [XID] */ /* 0x0000000189774510-0x0000000189774530 */ private set {} } // 0x000000018265C4D0-0x000000018265C5B0 0x000000018265BF00-0x000000018265BFE0
	public bool special { /* [XID] */ /* 0x000000018977BF00-0x000000018977BF20 */ get => default; /* [XID] */ /* 0x0000000189783790-0x00000001897837B0 */ private set {} } // 0x000000018265BD80-0x000000018265BE20 0x000000018265AEB0-0x000000018265AF60

	// Constructors
	public ConfigAIFollowServerRouteData() {} // 0x000000018265C8F0-0x000000018265C9E0

	// Methods
	// [XID] // 0x000000018978AF20-0x000000018978AF40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018265C5B0-0x000000018265C710
	// [XID] // 0x00000001897924A0-0x00000001897924C0
	public void InitEmpty() {} // 0x000000018265B950-0x000000018265BA80
	[BlackList] // 0x0000000189799AB0-0x0000000189799AF0
	// [XID] // 0x0000000189799AB0-0x0000000189799AF0
	public bool FromJson(JSONNode node) => default; // 0x000000018265B4F0-0x000000018265B870
	// [XID] // 0x00000001897A4AB0-0x00000001897A4AD0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018265A370-0x000000018265A940
	// [XID] // 0x00000001897AC0C0-0x00000001897AC0E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E2F */, bool useObjectPool = false /* Metadata: 0x00AF6E33 */) => default; // 0x000000018265BA80-0x000000018265BD80
	// [XID] // 0x00000001897B4010-0x00000001897B4030
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E34 */, bool useObjectPool = false /* Metadata: 0x00AF6E38 */) => default; // 0x000000018265B120-0x000000018265B4F0
	[BlackList] // 0x00000001897BBD10-0x00000001897BBD50
	// [XID] // 0x00000001897BBD10-0x00000001897BBD50
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018265A940-0x000000018265AC10
	// [XID] // 0x00000001897C6660-0x00000001897C6680
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018265BFE0-0x000000018265C3F0
	[BlackList] // 0x00000001897CDEA0-0x00000001897CDEE0
	// [XID] // 0x00000001897CDEA0-0x00000001897CDEE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018265AC10-0x000000018265ACB0
	[BlackList] // 0x00000001897D8AD0-0x00000001897D8B10
	// [XID] // 0x00000001897D8AD0-0x00000001897D8B10
	public virtual void AutoRecycleTypeFields() {} // 0x000000018265ACB0-0x000000018265ADE0
	[BlackList] // 0x00000001897E2DE0-0x00000001897E2E20
	// [XID] // 0x00000001897E2DE0-0x00000001897E2E20
	public virtual void ReturnToObjectPool() {} // 0x000000018265C850-0x000000018265C8F0
	[BlackList] // 0x00000001897ED7F0-0x00000001897ED830
	// [XID] // 0x00000001897ED7F0-0x00000001897ED830
	public virtual void OnPoolAllocated() {} // 0x000000018265C7B0-0x000000018265C850
	[BlackList] // 0x00000001897F80A0-0x00000001897F80E0
	// [XID] // 0x00000001897F80A0-0x00000001897F80E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018265C710-0x000000018265C7B0
}

