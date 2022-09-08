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
public class AudioUiEquip : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17632
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _equipOnEvent; // 0x10

	// Properties
	public ConfigWwiseString equipOnEvent { /* [XID] */ /* 0x00000001897D8A50-0x00000001897D8A70 */ get => default; /* [XID] */ /* 0x00000001897DFC30-0x00000001897DFC50 */ private set {} } // 0x0000000184BD6CC0-0x0000000184BD6D60 0x0000000184BD6270-0x0000000184BD6320

	// Constructors
	public AudioUiEquip() {} // 0x0000000184BD7200-0x0000000184BD7260

	// Methods
	// [XID] // 0x00000001897E7210-0x00000001897E7230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BD6F40-0x0000000184BD7020
	// [XID] // 0x00000001897EEEF0-0x00000001897EEF10
	public void InitEmpty() {} // 0x0000000184BD68F0-0x0000000184BD69C0
	[BlackList] // 0x00000001897F6580-0x00000001897F65C0
	// [XID] // 0x00000001897F6580-0x00000001897F65C0
	public bool FromJson(JSONNode node) => default; // 0x0000000184BD6570-0x0000000184BD68F0
	// [XID] // 0x0000000189800E00-0x0000000189800E20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184BD5BE0-0x0000000184BD5DE0
	// [XID] // 0x0000000189808340-0x0000000189808360
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7577 */, bool useObjectPool = false /* Metadata: 0x00AF757B */) => default; // 0x0000000184BD69C0-0x0000000184BD6CC0
	// [XID] // 0x000000018980FE30-0x000000018980FE50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF757C */, bool useObjectPool = false /* Metadata: 0x00AF7580 */) => default; // 0x0000000184BD6320-0x0000000184BD6570
	[BlackList] // 0x0000000189817480-0x00000001898174C0
	// [XID] // 0x0000000189817480-0x00000001898174C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BD5DE0-0x0000000184BD60B0
	// [XID] // 0x0000000189821E30-0x0000000189821E50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BD6D60-0x0000000184BD6F40
	[BlackList] // 0x00000001898292B0-0x00000001898292F0
	// [XID] // 0x00000001898292B0-0x00000001898292F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184BD60B0-0x0000000184BD6150
	[BlackList] // 0x0000000189833A40-0x0000000189833A80
	// [XID] // 0x0000000189833A40-0x0000000189833A80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184BD6150-0x0000000184BD6270
	[BlackList] // 0x000000018983DD20-0x000000018983DD60
	// [XID] // 0x000000018983DD20-0x000000018983DD60
	public virtual void ReturnToObjectPool() {} // 0x0000000184BD7160-0x0000000184BD7200
	[BlackList] // 0x00000001898481E0-0x0000000189848220
	// [XID] // 0x00000001898481E0-0x0000000189848220
	public virtual void OnPoolAllocated() {} // 0x0000000184BD70C0-0x0000000184BD7160
	[BlackList] // 0x0000000189852560-0x00000001898525A0
	// [XID] // 0x0000000189852560-0x00000001898525A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184BD7020-0x0000000184BD70C0
}

