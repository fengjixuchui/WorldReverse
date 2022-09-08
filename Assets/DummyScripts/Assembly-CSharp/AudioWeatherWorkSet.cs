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
public class AudioWeatherWorkSet : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17635
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateGroupName; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _activenessRtpcName; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _worksetSwitchValue; // 0x20

	// Properties
	public ConfigWwiseString stateGroupName { /* [XID] */ /* 0x00000001897AF350-0x00000001897AF370 */ get => default; /* [XID] */ /* 0x00000001897B71F0-0x00000001897B7210 */ private set {} } // 0x00000001858B1300-0x00000001858B13A0 0x00000001858B17A0-0x00000001858B1850
	public ConfigWwiseString activenessRtpcName { /* [XID] */ /* 0x00000001897BEFF0-0x00000001897BF010 */ get => default; /* [XID] */ /* 0x00000001897C65C0-0x00000001897C65E0 */ private set {} } // 0x00000001858B0A50-0x00000001858B0AF0 0x00000001858B0410-0x00000001858B04C0
	public ConfigWwiseString worksetSwitchValue { /* [XID] */ /* 0x00000001897CDE20-0x00000001897CDE40 */ get => default; /* [XID] */ /* 0x00000001897D5330-0x00000001897D5350 */ private set {} } // 0x00000001858B1260-0x00000001858B1300 0x00000001858B1B80-0x00000001858B1C30

	// Constructors
	public AudioWeatherWorkSet() {} // 0x00000001858B1F40-0x00000001858B1FA0

	// Methods
	// [XID] // 0x00000001897DCA50-0x00000001897DCA70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001858B1C30-0x00000001858B1D60
	// [XID] // 0x00000001897E4470-0x00000001897E4490
	public void InitEmpty() {} // 0x00000001858B13A0-0x00000001858B14A0
	[BlackList] // 0x00000001897EBFA0-0x00000001897EBFE0
	// [XID] // 0x00000001897EBFA0-0x00000001897EBFE0
	public bool FromJson(JSONNode node) => default; // 0x00000001858B0EE0-0x00000001858B1260
	// [XID] // 0x00000001897F6560-0x00000001897F6580
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001858B0020-0x00000001858B0410
	// [XID] // 0x00000001897FDCE0-0x00000001897FDD00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7595 */, bool useObjectPool = false /* Metadata: 0x00AF7599 */) => default; // 0x00000001858B14A0-0x00000001858B17A0
	// [XID] // 0x0000000189805490-0x00000001898054B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF759A */, bool useObjectPool = false /* Metadata: 0x00AF759E */) => default; // 0x00000001858B0AF0-0x00000001858B0EE0
	[BlackList] // 0x000000018980CA50-0x000000018980CA90
	// [XID] // 0x000000018980CA50-0x000000018980CA90
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001858B04C0-0x00000001858B0790
	// [XID] // 0x0000000189817460-0x0000000189817480
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001858B1850-0x00000001858B1B80
	[BlackList] // 0x000000018981EE20-0x000000018981EE60
	// [XID] // 0x000000018981EE20-0x000000018981EE60
	public virtual void AutoAllocTypeFields() {} // 0x00000001858B0790-0x00000001858B0830
	[BlackList] // 0x0000000189829270-0x00000001898292B0
	// [XID] // 0x0000000189829270-0x00000001898292B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001858B0830-0x00000001858B0A50
	[BlackList] // 0x0000000189833A00-0x0000000189833A40
	// [XID] // 0x0000000189833A00-0x0000000189833A40
	public virtual void ReturnToObjectPool() {} // 0x00000001858B1EA0-0x00000001858B1F40
	[BlackList] // 0x000000018983DCE0-0x000000018983DD20
	// [XID] // 0x000000018983DCE0-0x000000018983DD20
	public virtual void OnPoolAllocated() {} // 0x00000001858B1E00-0x00000001858B1EA0
	[BlackList] // 0x00000001898481A0-0x00000001898481E0
	// [XID] // 0x00000001898481A0-0x00000001898481E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001858B1D60-0x00000001858B1E00
}

