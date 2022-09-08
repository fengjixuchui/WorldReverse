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
public class ConfigGuideTask : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18196
{
	// Fields
	private string _name; // 0x10
	private bool _isFreshmanGuide; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideCondition[] _predicates; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideCondition[] _onCheck; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _onGuide; // 0x30
	private ConfigGuideCondition[][] _finishCondition; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _onFinish; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideAction[] _onQuit; // 0x48

	// Properties
	public string name { /* [XID] */ /* 0x00000001896D6920-0x00000001896D6940 */ get => default; /* [XID] */ /* 0x00000001896DDF60-0x00000001896DDF80 */ set {} } // 0x0000000183088C50-0x0000000183088CF0 0x00000001830877A0-0x0000000183087850
	public bool isFreshmanGuide { /* [XID] */ /* 0x00000001896E5510-0x00000001896E5530 */ get => default; /* [XID] */ /* 0x00000001896ECB40-0x00000001896ECB60 */ private set {} } // 0x0000000183087A30-0x0000000183087AD0 0x0000000183087640-0x00000001830876F0
	public ConfigGuideCondition[] predicates { /* [XID] */ /* 0x00000001896F4320-0x00000001896F4340 */ get => default; /* [XID] */ /* 0x00000001896FBB30-0x00000001896FBB50 */ private set {} } // 0x0000000183088130-0x00000001830881D0 0x0000000183087F20-0x0000000183087FD0
	public ConfigGuideCondition[] onCheck { /* [XID] */ /* 0x0000000189703090-0x00000001897030B0 */ get => default; /* [XID] */ /* 0x000000018970A7C0-0x000000018970A7E0 */ private set {} } // 0x00000001830864A0-0x0000000183086540 0x0000000183086AF0-0x0000000183086BA0
	public ConfigGuideAction[] onGuide { /* [XID] */ /* 0x0000000189712210-0x0000000189712230 */ get => default; /* [XID] */ /* 0x00000001897198D0-0x00000001897198F0 */ private set {} } // 0x0000000183087B80-0x0000000183087C20 0x0000000183086A40-0x0000000183086AF0
	public ConfigGuideCondition[][] finishCondition { /* [XID] */ /* 0x0000000189720E30-0x0000000189720E50 */ get => default; /* [XID] */ /* 0x00000001897284D0-0x00000001897284F0 */ private set {} } // 0x0000000183087850-0x00000001830878F0 0x00000001830876F0-0x00000001830877A0
	public ConfigGuideAction[] onFinish { /* [XID] */ /* 0x000000018972FC50-0x000000018972FC70 */ get => default; /* [XID] */ /* 0x00000001897376C0-0x00000001897376E0 */ private set {} } // 0x00000001830881D0-0x0000000183088270 0x0000000183087AD0-0x0000000183087B80
	public ConfigGuideAction[] onQuit { /* [XID] */ /* 0x000000018973F160-0x000000018973F180 */ get => default; /* [XID] */ /* 0x0000000189746380-0x00000001897463A0 */ private set {} } // 0x00000001830888E0-0x0000000183088980 0x0000000183087210-0x00000001830872C0
	public string rootTask { /* [XID] */ /* 0x000000018978F280-0x000000018978F2C0 */ get; /* [XID] */ /* 0x0000000189799930-0x0000000189799970 */ private set; } // 0x00000001830869E0-0x0000000183086A40 0x0000000183087FD0-0x0000000183088030

	// Constructors
	public ConfigGuideTask() {} // 0x0000000183088D90-0x0000000183088DF0

	// Methods
	// [XID] // 0x000000018974DE70-0x000000018974DE90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183088980-0x0000000183088B10
	// [XID] // 0x0000000189755590-0x00000001897555B0
	public void InitEmpty() {} // 0x00000001830878F0-0x0000000183087A30
	[BlackList] // 0x000000018975C710-0x000000018975C750
	// [XID] // 0x000000018975C710-0x000000018975C750
	public bool FromJson(JSONNode node) => default; // 0x00000001830872C0-0x0000000183087640
	// [XID] // 0x0000000189767060-0x0000000189767080
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183085CD0-0x00000001830864A0
	// [XID] // 0x000000018976E5C0-0x000000018976E5E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FE9 */, bool useObjectPool = false /* Metadata: 0x00AF8FED */) => default; // 0x0000000183087C20-0x0000000183087F20
	// [XID] // 0x0000000189775FA0-0x0000000189775FC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FEE */, bool useObjectPool = false /* Metadata: 0x00AF8FF2 */) => default; // 0x0000000183086BA0-0x0000000183087210
	[BlackList] // 0x000000018977D640-0x000000018977D680
	// [XID] // 0x000000018977D640-0x000000018977D680
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183086540-0x0000000183086810
	// [XID] // 0x0000000189787D80-0x0000000189787DA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183088270-0x00000001830888E0
	// [XID] // 0x00000001897A48D0-0x00000001897A48F0
	public void RefreshSelfRootTask(string rootTaskFromParent) {} // 0x0000000183088030-0x0000000183088130
	[BlackList] // 0x00000001897ABE80-0x00000001897ABEC0
	// [XID] // 0x00000001897ABE80-0x00000001897ABEC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183086810-0x00000001830868B0
	[BlackList] // 0x00000001897B6FF0-0x00000001897B7030
	// [XID] // 0x00000001897B6FF0-0x00000001897B7030
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830868B0-0x00000001830869E0
	[BlackList] // 0x00000001897C1BB0-0x00000001897C1BF0
	// [XID] // 0x00000001897C1BB0-0x00000001897C1BF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183088CF0-0x0000000183088D90
	[BlackList] // 0x00000001897CC130-0x00000001897CC170
	// [XID] // 0x00000001897CC130-0x00000001897CC170
	public virtual void OnPoolAllocated() {} // 0x0000000183088BB0-0x0000000183088C50
	[BlackList] // 0x00000001897D6AA0-0x00000001897D6AE0
	// [XID] // 0x00000001897D6AA0-0x00000001897D6AE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183088B10-0x0000000183088BB0
}

