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
public class ConfigUIIndicator : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18489
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TemplateParamString _icon; // 0x10
	private IndicatorDistanceInfoType _distance_Show; // 0x18
	private bool _followMove; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private IndicatorLogic[] _indicator; // 0x20

	// Properties
	public TemplateParamString icon { /* [XID] */ /* 0x000000018970A700-0x000000018970A720 */ get => default; /* [XID] */ /* 0x00000001897121B0-0x00000001897121D0 */ private set {} } // 0x0000000180E4E5D0-0x0000000180E4E670 0x0000000180E4FA60-0x0000000180E4FB10
	public IndicatorDistanceInfoType distance_Show { /* [XID] */ /* 0x0000000189719830-0x0000000189719850 */ get => default; /* [XID] */ /* 0x0000000189720DB0-0x0000000189720DD0 */ private set {} } // 0x0000000180E4F480-0x0000000180E4F520 0x0000000180E4F050-0x0000000180E4F100
	public bool followMove { /* [XID] */ /* 0x0000000189728470-0x0000000189728490 */ get => default; /* [XID] */ /* 0x000000018972FBB0-0x000000018972FBD0 */ private set {} } // 0x0000000180E4EFB0-0x0000000180E4F050 0x0000000180E4EB20-0x0000000180E4EBD0
	public IndicatorLogic[] indicator { /* [XID] */ /* 0x0000000189737600-0x0000000189737620 */ get => default; /* [XID] */ /* 0x000000018973F080-0x000000018973F0A0 */ private set {} } // 0x0000000180E4F9C0-0x0000000180E4FA60 0x0000000180E4F520-0x0000000180E4F5D0

	// Constructors
	public ConfigUIIndicator() {} // 0x0000000180E501E0-0x0000000180E50250

	// Methods
	// [XID] // 0x0000000189746320-0x0000000189746340
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180E4FEB0-0x0000000180E50000
	// [XID] // 0x000000018974DDF0-0x000000018974DE10
	public void InitEmpty() {} // 0x0000000180E4F5D0-0x0000000180E4F6C0
	[BlackList] // 0x00000001897554F0-0x0000000189755530
	// [XID] // 0x00000001897554F0-0x0000000189755530
	public bool FromJson(JSONNode node) => default; // 0x0000000180E4F100-0x0000000180E4F480
	// [XID] // 0x000000018975FA50-0x000000018975FA70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180E4E160-0x0000000180E4E5D0
	// [XID] // 0x0000000189766F80-0x0000000189766FA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F27 */, bool useObjectPool = false /* Metadata: 0x00AF9F2B */) => default; // 0x0000000180E4F6C0-0x0000000180E4F9C0
	// [XID] // 0x000000018976E480-0x000000018976E4A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F2C */, bool useObjectPool = false /* Metadata: 0x00AF9F30 */) => default; // 0x0000000180E4EBD0-0x0000000180E4EFB0
	[BlackList] // 0x0000000189775E20-0x0000000189775E60
	// [XID] // 0x0000000189775E20-0x0000000189775E60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180E4E670-0x0000000180E4E940
	// [XID] // 0x00000001897804C0-0x00000001897804E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180E4FB10-0x0000000180E4FEB0
	[BlackList] // 0x0000000189787C80-0x0000000189787CC0
	// [XID] // 0x0000000189787C80-0x0000000189787CC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000180E4E940-0x0000000180E4E9E0
	[BlackList] // 0x0000000189792300-0x0000000189792340
	// [XID] // 0x0000000189792300-0x0000000189792340
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180E4E9E0-0x0000000180E4EB20
	[BlackList] // 0x000000018979D5B0-0x000000018979D5F0
	// [XID] // 0x000000018979D5B0-0x000000018979D5F0
	public virtual void ReturnToObjectPool() {} // 0x0000000180E50140-0x0000000180E501E0
	[BlackList] // 0x00000001897A7780-0x00000001897A77C0
	// [XID] // 0x00000001897A7780-0x00000001897A77C0
	public virtual void OnPoolAllocated() {} // 0x0000000180E500A0-0x0000000180E50140
	[BlackList] // 0x00000001897B20D0-0x00000001897B2110
	// [XID] // 0x00000001897B20D0-0x00000001897B2110
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180E50000-0x0000000180E500A0
}

