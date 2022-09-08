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
public class ConfigAIProfilingSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17505
{
	// Fields
	private AILodStrategyType _lodStrategy; // 0x10
	private SimpleSafeInt32[] _staticPoses; // 0x18
	private SimpleSafeInt32 moveCullingLevelRawNum; // 0x20

	// Properties
	public AILodStrategyType lodStrategy { /* [XID] */ /* 0x0000000189A01B80-0x0000000189A01BA0 */ get => default; /* [XID] */ /* 0x0000000189864430-0x0000000189864450 */ private set {} } // 0x0000000184A24180-0x0000000184A24220 0x0000000184A24220-0x0000000184A242D0
	public SimpleSafeInt32[] staticPoses { /* [XID] */ /* 0x0000000189A22960-0x0000000189A22980 */ get => default; /* [XID] */ /* 0x0000000189872C10-0x0000000189872C30 */ private set {} } // 0x0000000184A23DE0-0x0000000184A23E80 0x0000000184A24920-0x0000000184A249D0
	public int moveCullingLevel { /* [XID] */ /* 0x0000000189B43CF0-0x0000000189B43D10 */ get => default; /* [XID] */ /* 0x0000000189881A40-0x0000000189881A60 */ private set {} } // 0x0000000184A245F0-0x0000000184A246C0 0x0000000184A22D70-0x0000000184A22E50

	// Constructors
	public ConfigAIProfilingSetting() {} // 0x0000000184A24A70-0x0000000184A24B10

	// Methods
	// [XID] // 0x0000000189889080-0x00000001898890A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A246C0-0x0000000184A247E0
	// [XID] // 0x0000000189890400-0x0000000189890420
	public void InitEmpty() {} // 0x0000000184A23CE0-0x0000000184A23DE0
	[BlackList] // 0x00000001898978E0-0x0000000189897920
	// [XID] // 0x00000001898978E0-0x0000000189897920
	public bool FromJson(JSONNode node) => default; // 0x0000000184A23960-0x0000000184A23CE0
	// [XID] // 0x00000001898A1E60-0x00000001898A1E80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A22E50-0x0000000184A23210
	// [XID] // 0x00000001898A9690-0x00000001898A96B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7107 */, bool useObjectPool = false /* Metadata: 0x00AF710B */) => default; // 0x0000000184A23E80-0x0000000184A24180
	// [XID] // 0x00000001898B0EA0-0x00000001898B0EC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF710C */, bool useObjectPool = false /* Metadata: 0x00AF7110 */) => default; // 0x0000000184A23660-0x0000000184A23960
	[BlackList] // 0x00000001898B85E0-0x00000001898B8620
	// [XID] // 0x00000001898B85E0-0x00000001898B8620
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A23210-0x0000000184A234E0
	// [XID] // 0x00000001898C2C00-0x00000001898C2C20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A242D0-0x0000000184A245F0
	[BlackList] // 0x00000001898CA600-0x00000001898CA640
	// [XID] // 0x00000001898CA600-0x00000001898CA640
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A234E0-0x0000000184A23580
	[BlackList] // 0x00000001898D4E10-0x00000001898D4E50
	// [XID] // 0x00000001898D4E10-0x00000001898D4E50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A23580-0x0000000184A23660
	[BlackList] // 0x00000001898DFB20-0x00000001898DFB60
	// [XID] // 0x00000001898DFB20-0x00000001898DFB60
	public virtual void ReturnToObjectPool() {} // 0x0000000184A249D0-0x0000000184A24A70
	[BlackList] // 0x00000001898EA750-0x00000001898EA790
	// [XID] // 0x00000001898EA750-0x00000001898EA790
	public virtual void OnPoolAllocated() {} // 0x0000000184A24880-0x0000000184A24920
	[BlackList] // 0x00000001898F4D80-0x00000001898F4DC0
	// [XID] // 0x00000001898F4D80-0x00000001898F4DC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A247E0-0x0000000184A24880
}

