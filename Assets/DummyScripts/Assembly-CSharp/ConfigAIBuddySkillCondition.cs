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
public class ConfigAIBuddySkillCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17498
{
	// Fields
	private SimpleSafeFloat selectRangeRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBuddyScoring _buddyScoring; // 0x18

	// Properties
	public float selectRange { /* [XID] */ /* 0x0000000189A44A80-0x0000000189A44AA0 */ get => default; /* [XID] */ /* 0x00000001899548A0-0x00000001899548C0 */ private set {} } // 0x0000000184FC2920-0x0000000184FC2A00 0x0000000184FC3380-0x0000000184FC3460
	public ConfigAIBuddyScoring buddyScoring { /* [XID] */ /* 0x000000018995C140-0x000000018995C160 */ get => default; /* [XID] */ /* 0x0000000189963B20-0x0000000189963B40 */ private set {} } // 0x0000000184FC2230-0x0000000184FC22D0 0x0000000184FC2E10-0x0000000184FC2EC0

	// Constructors
	public ConfigAIBuddySkillCondition() {} // 0x0000000184FC3500-0x0000000184FC35A0

	// Methods
	// [XID] // 0x000000018996B0B0-0x000000018996B0D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FC3120-0x0000000184FC3240
	// [XID] // 0x0000000189972B50-0x0000000189972B70
	public void InitEmpty() {} // 0x0000000184FC2A00-0x0000000184FC2B10
	[BlackList] // 0x000000018997A410-0x000000018997A450
	// [XID] // 0x000000018997A410-0x000000018997A450
	public bool FromJson(JSONNode node) => default; // 0x0000000184FC25A0-0x0000000184FC2920
	// [XID] // 0x00000001899848D0-0x00000001899848F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184FC1A60-0x0000000184FC1D60
	// [XID] // 0x000000018998C330-0x000000018998C350
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70BD */, bool useObjectPool = false /* Metadata: 0x00AF70C1 */) => default; // 0x0000000184FC2B10-0x0000000184FC2E10
	// [XID] // 0x0000000189994070-0x0000000189994090
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70C2 */, bool useObjectPool = false /* Metadata: 0x00AF70C6 */) => default; // 0x0000000184FC22D0-0x0000000184FC25A0
	[BlackList] // 0x000000018999B880-0x000000018999B8C0
	// [XID] // 0x000000018999B880-0x000000018999B8C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FC1D60-0x0000000184FC2030
	// [XID] // 0x00000001899A6470-0x00000001899A6490
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FC2EC0-0x0000000184FC3120
	[BlackList] // 0x00000001899ADB40-0x00000001899ADB80
	// [XID] // 0x00000001899ADB40-0x00000001899ADB80
	public virtual void AutoAllocTypeFields() {} // 0x0000000184FC2030-0x0000000184FC20D0
	[BlackList] // 0x00000001899B8090-0x00000001899B80D0
	// [XID] // 0x00000001899B8090-0x00000001899B80D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184FC20D0-0x0000000184FC2230
	[BlackList] // 0x00000001899C2C80-0x00000001899C2CC0
	// [XID] // 0x00000001899C2C80-0x00000001899C2CC0
	public virtual void ReturnToObjectPool() {} // 0x0000000184FC3460-0x0000000184FC3500
	[BlackList] // 0x00000001899CD370-0x00000001899CD3B0
	// [XID] // 0x00000001899CD370-0x00000001899CD3B0
	public virtual void OnPoolAllocated() {} // 0x0000000184FC32E0-0x0000000184FC3380
	[BlackList] // 0x00000001899D77F0-0x00000001899D7830
	// [XID] // 0x00000001899D77F0-0x00000001899D7830
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184FC3240-0x0000000184FC32E0
}

