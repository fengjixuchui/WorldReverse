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
public class ConfigAIPatrolFollowData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17435
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat innerDistanceRawNum; // 0x14
	private SimpleSafeInt32 speedLevelInnerRawNum; // 0x18
	private SimpleSafeFloat outDistanceRawNum; // 0x1C
	private SimpleSafeFloat stopDistanceRawNum; // 0x20

	// Properties
	public int speedLevel { /* [XID] */ /* 0x000000018967DB40-0x000000018967DB60 */ get => default; /* [XID] */ /* 0x00000001896852A0-0x00000001896852C0 */ private set {} } // 0x000000018158FB90-0x000000018158FC60 0x000000018158FD40-0x000000018158FE20
	public float innerDistance { /* [XID] */ /* 0x000000018968CD00-0x000000018968CD20 */ get => default; /* [XID] */ /* 0x0000000189694820-0x0000000189694840 */ private set {} } // 0x0000000181590B60-0x0000000181590C40 0x0000000181591400-0x00000001815914E0
	public int speedLevelInner { /* [XID] */ /* 0x000000018969BEC0-0x000000018969BEE0 */ get => default; /* [XID] */ /* 0x00000001896A33A0-0x00000001896A33C0 */ private set {} } // 0x0000000181590790-0x0000000181590860 0x0000000181590C40-0x0000000181590D20
	public float outDistance { /* [XID] */ /* 0x00000001896AA8D0-0x00000001896AA8F0 */ get => default; /* [XID] */ /* 0x00000001896B18F0-0x00000001896B1910 */ private set {} } // 0x0000000181590570-0x0000000181590650 0x00000001815914E0-0x00000001815915C0
	public float stopDistance { /* [XID] */ /* 0x00000001896B92F0-0x00000001896B9310 */ get => default; /* [XID] */ /* 0x00000001896C0700-0x00000001896C0720 */ private set {} } // 0x00000001815915C0-0x00000001815916A0 0x000000018158FC60-0x000000018158FD40

	// Constructors
	public ConfigAIPatrolFollowData() {} // 0x0000000181591740-0x0000000181591840

	// Methods
	// [XID] // 0x00000001896C7E10-0x00000001896C7E30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181591160-0x00000001815912C0
	// [XID] // 0x00000001896CF750-0x00000001896CF770
	public void InitEmpty() {} // 0x0000000181590650-0x0000000181590790
	[BlackList] // 0x00000001896D6AA0-0x00000001896D6AE0
	// [XID] // 0x00000001896D6AA0-0x00000001896D6AE0
	public bool FromJson(JSONNode node) => default; // 0x00000001815901F0-0x0000000181590570
	// [XID] // 0x00000001896E12B0-0x00000001896E12D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018158F100-0x000000018158F6E0
	// [XID] // 0x00000001896E84E0-0x00000001896E8500
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E87 */, bool useObjectPool = false /* Metadata: 0x00AF6E8B */) => default; // 0x0000000181590860-0x0000000181590B60
	// [XID] // 0x00000001896EFA60-0x00000001896EFA80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E8C */, bool useObjectPool = false /* Metadata: 0x00AF6E90 */) => default; // 0x000000018158FE20-0x00000001815901F0
	[BlackList] // 0x00000001896F7450-0x00000001896F7490
	// [XID] // 0x00000001896F7450-0x00000001896F7490
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018158F6E0-0x000000018158F9B0
	// [XID] // 0x0000000189701A20-0x0000000189701A40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181590D20-0x0000000181591160
	[BlackList] // 0x0000000189709320-0x0000000189709360
	// [XID] // 0x0000000189709320-0x0000000189709360
	public virtual void AutoAllocTypeFields() {} // 0x000000018158F9B0-0x000000018158FA50
	[BlackList] // 0x0000000189713A60-0x0000000189713AA0
	// [XID] // 0x0000000189713A60-0x0000000189713AA0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018158FA50-0x000000018158FB90
	[BlackList] // 0x000000018971E0C0-0x000000018971E100
	// [XID] // 0x000000018971E0C0-0x000000018971E100
	public virtual void ReturnToObjectPool() {} // 0x00000001815916A0-0x0000000181591740
	[BlackList] // 0x00000001897285F0-0x0000000189728630
	// [XID] // 0x00000001897285F0-0x0000000189728630
	public virtual void OnPoolAllocated() {} // 0x0000000181591360-0x0000000181591400
	[BlackList] // 0x0000000189732C00-0x0000000189732C40
	// [XID] // 0x0000000189732C00-0x0000000189732C40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001815912C0-0x0000000181591360
}

