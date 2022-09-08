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
public class ConfigAIPickActionPointCriteria : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17431
{
	// Fields
	private ActionPointType _pointType; // 0x10
	private SimpleSafeFloat detectDistanceRawNum; // 0x14
	private SimpleSafeInt32 speedLevelRawNum; // 0x18
	private SimpleSafeInt32[] _pose; // 0x20
	private NeuronName[] _nerveTrigger; // 0x28
	private SimpleSafeInt32 skillIDRawNum; // 0x30

	// Properties
	public ActionPointType pointType { /* [XID] */ /* 0x0000000189A44190-0x0000000189A441B0 */ get => default; /* [XID] */ /* 0x0000000189A4B680-0x0000000189A4B6A0 */ private set {} } // 0x0000000183E34890-0x0000000183E34930 0x0000000183E344E0-0x0000000183E34590
	public float detectDistance { /* [XID] */ /* 0x0000000189A52DE0-0x0000000189A52E00 */ get => default; /* [XID] */ /* 0x0000000189A5A690-0x0000000189A5A6B0 */ private set {} } // 0x0000000183E33750-0x0000000183E33830 0x0000000183E349E0-0x0000000183E34AC0
	public int speedLevel { /* [XID] */ /* 0x0000000189A61DF0-0x0000000189A61E10 */ get => default; /* [XID] */ /* 0x0000000189A69CD0-0x0000000189A69CF0 */ private set {} } // 0x0000000183E33680-0x0000000183E33750 0x0000000183E33830-0x0000000183E33910
	public SimpleSafeInt32[] pose { /* [XID] */ /* 0x0000000189A70FA0-0x0000000189A70FC0 */ get => default; /* [XID] */ /* 0x0000000189A78BA0-0x0000000189A78BC0 */ private set {} } // 0x0000000183E342E0-0x0000000183E34380 0x0000000183E33DE0-0x0000000183E33E90
	public NeuronName[] nerveTrigger { /* [XID] */ /* 0x0000000189A7FFE0-0x0000000189A80000 */ get => default; /* [XID] */ /* 0x0000000189A87D00-0x0000000189A87D20 */ private set {} } // 0x0000000183E35370-0x0000000183E35410 0x0000000183E34930-0x0000000183E349E0
	public int skillID { /* [XID] */ /* 0x0000000189A8F570-0x0000000189A8F590 */ get => default; /* [XID] */ /* 0x0000000189A96AC0-0x0000000189A96AE0 */ private set {} } // 0x0000000183E34210-0x0000000183E342E0 0x0000000183E34FE0-0x0000000183E350C0

	// Constructors
	public ConfigAIPickActionPointCriteria() {} // 0x0000000183E354B0-0x0000000183E35580

	// Methods
	// [XID] // 0x0000000189A9DF30-0x0000000189A9DF50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E350C0-0x0000000183E35230
	// [XID] // 0x0000000189AA59C0-0x0000000189AA59E0
	public void InitEmpty() {} // 0x0000000183E34380-0x0000000183E344E0
	[BlackList] // 0x0000000189AAD000-0x0000000189AAD040
	// [XID] // 0x0000000189AAD000-0x0000000189AAD040
	public bool FromJson(JSONNode node) => default; // 0x0000000183E33E90-0x0000000183E34210
	// [XID] // 0x0000000189AB7910-0x0000000189AB7930
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E32B30-0x0000000183E331F0
	// [XID] // 0x0000000189ABF370-0x0000000189ABF390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E63 */, bool useObjectPool = false /* Metadata: 0x00AF6E67 */) => default; // 0x0000000183E34590-0x0000000183E34890
	// [XID] // 0x0000000189AC6E20-0x0000000189AC6E40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E68 */, bool useObjectPool = false /* Metadata: 0x00AF6E6C */) => default; // 0x0000000183E33910-0x0000000183E33DE0
	[BlackList] // 0x0000000189ACE5B0-0x0000000189ACE5F0
	// [XID] // 0x0000000189ACE5B0-0x0000000189ACE5F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E331F0-0x0000000183E334C0
	// [XID] // 0x0000000189AD9350-0x0000000189AD9370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E34AC0-0x0000000183E34FE0
	[BlackList] // 0x0000000189AE0E40-0x0000000189AE0E80
	// [XID] // 0x0000000189AE0E40-0x0000000189AE0E80
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E334C0-0x0000000183E33560
	[BlackList] // 0x0000000189AEB530-0x0000000189AEB570
	// [XID] // 0x0000000189AEB530-0x0000000189AEB570
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E33560-0x0000000183E33680
	[BlackList] // 0x0000000189AF5D90-0x0000000189AF5DD0
	// [XID] // 0x0000000189AF5D90-0x0000000189AF5DD0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E35410-0x0000000183E354B0
	[BlackList] // 0x0000000189B003F0-0x0000000189B00430
	// [XID] // 0x0000000189B003F0-0x0000000189B00430
	public virtual void OnPoolAllocated() {} // 0x0000000183E352D0-0x0000000183E35370
	[BlackList] // 0x0000000189B0AB40-0x0000000189B0AB80
	// [XID] // 0x0000000189B0AB40-0x0000000189B0AB80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E35230-0x0000000183E352D0
}

