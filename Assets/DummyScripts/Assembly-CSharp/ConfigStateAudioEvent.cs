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
public class ConfigStateAudioEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19016
{
	// Fields
	private string _currentStateName; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _audioEvent; // 0x18
	private string[] _otherStateNames; // 0x20
	private StateAudioEventUsage _usage; // 0x28

	// Properties
	public string currentStateName { /* [XID] */ /* 0x0000000189AB2E20-0x0000000189AB2E40 */ get => default; /* [XID] */ /* 0x0000000189ABAB30-0x0000000189ABAB50 */ private set {} } // 0x0000000184998160-0x0000000184998200 0x0000000184998200-0x00000001849982B0
	public ConfigWwiseString audioEvent { /* [XID] */ /* 0x0000000189AC22B0-0x0000000189AC22D0 */ get => default; /* [XID] */ /* 0x0000000189AC99C0-0x0000000189AC99E0 */ private set {} } // 0x0000000184997340-0x00000001849973E0 0x00000001849973E0-0x0000000184997490
	public string[] otherStateNames { /* [XID] */ /* 0x0000000189AD12B0-0x0000000189AD12D0 */ get => default; /* [XID] */ /* 0x0000000189AD9090-0x0000000189AD90B0 */ private set {} } // 0x0000000184997200-0x00000001849972A0 0x0000000184997CC0-0x0000000184997D70
	public StateAudioEventUsage usage { /* [XID] */ /* 0x0000000189AE0B20-0x0000000189AE0B40 */ get => default; /* [XID] */ /* 0x0000000189AE7FD0-0x0000000189AE7FF0 */ private set {} } // 0x00000001849972A0-0x0000000184997340 0x0000000184997890-0x0000000184997940

	// Constructors
	public ConfigStateAudioEvent() {} // 0x0000000184998970-0x00000001849989D0

	// Methods
	// [XID] // 0x0000000189AEFDA0-0x0000000189AEFDC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184998640-0x0000000184998790
	// [XID] // 0x0000000189AF72E0-0x0000000189AF7300
	public void InitEmpty() {} // 0x0000000184997D70-0x0000000184997E60
	[BlackList] // 0x0000000189AFE930-0x0000000189AFE970
	// [XID] // 0x0000000189AFE930-0x0000000189AFE970
	public bool FromJson(JSONNode node) => default; // 0x0000000184997940-0x0000000184997CC0
	// [XID] // 0x0000000189B08EF0-0x0000000189B08F10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001849968E0-0x0000000184996D70
	// [XID] // 0x0000000189B10970-0x0000000189B10990
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB771 */, bool useObjectPool = false /* Metadata: 0x00AFB775 */) => default; // 0x0000000184997E60-0x0000000184998160
	// [XID] // 0x0000000189B17A60-0x0000000189B17A80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB776 */, bool useObjectPool = false /* Metadata: 0x00AFB77A */) => default; // 0x0000000184997490-0x0000000184997890
	[BlackList] // 0x0000000189B1F420-0x0000000189B1F460
	// [XID] // 0x0000000189B1F420-0x0000000189B1F460
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184996D70-0x0000000184997040
	// [XID] // 0x0000000189B29800-0x0000000189B29820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849982B0-0x0000000184998640
	[BlackList] // 0x0000000189B30D70-0x0000000189B30DB0
	// [XID] // 0x0000000189B30D70-0x0000000189B30DB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184997040-0x00000001849970E0
	[BlackList] // 0x0000000189B3B550-0x0000000189B3B590
	// [XID] // 0x0000000189B3B550-0x0000000189B3B590
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849970E0-0x0000000184997200
	[BlackList] // 0x0000000189B46080-0x0000000189B460C0
	// [XID] // 0x0000000189B46080-0x0000000189B460C0
	public virtual void ReturnToObjectPool() {} // 0x00000001849988D0-0x0000000184998970
	[BlackList] // 0x0000000189B50700-0x0000000189B50740
	// [XID] // 0x0000000189B50700-0x0000000189B50740
	public virtual void OnPoolAllocated() {} // 0x0000000184998830-0x00000001849988D0
	[BlackList] // 0x0000000189B5AED0-0x0000000189B5AF10
	// [XID] // 0x0000000189B5AED0-0x0000000189B5AF10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184998790-0x0000000184998830
}

