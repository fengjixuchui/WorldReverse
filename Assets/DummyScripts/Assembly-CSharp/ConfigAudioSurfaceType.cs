/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAudioSurfaceType : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17630
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _switchKey; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _tallGrassRtpcId; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _waterDepthRtpcId; // 0x20
	private Dictionary<string, string> _switchMap; // 0x28
	private Dictionary<string, string> _rtpcMap; // 0x30
	private EnumToHash _surfaceTypeRtpc; // 0x38
	private EnumToHash _surfaceTypeSwitch; // 0x40

	// Properties
	public ConfigWwiseString switchKey { /* [XID] */ /* 0x00000001898A2A20-0x00000001898A2A40 */ get => default; /* [XID] */ /* 0x000000018964EE20-0x000000018964EE40 */ private set {} } // 0x0000000183DE10D0-0x0000000183DE1170 0x0000000183DE1170-0x0000000183DE1220
	public ConfigWwiseString tallGrassRtpcId { /* [XID] */ /* 0x00000001896566B0-0x00000001896566D0 */ get => default; /* [XID] */ /* 0x000000018965DDD0-0x000000018965DDF0 */ private set {} } // 0x0000000183DE2520-0x0000000183DE25C0 0x0000000183DE1020-0x0000000183DE10D0
	public ConfigWwiseString waterDepthRtpcId { /* [XID] */ /* 0x0000000189B32FF0-0x0000000189B33010 */ get => default; /* [XID] */ /* 0x000000018966CC60-0x000000018966CC80 */ private set {} } // 0x0000000183DE0F80-0x0000000183DE1020 0x0000000183DE1EE0-0x0000000183DE1F90
	public Dictionary<string, string> switchMap { /* [XID] */ /* 0x0000000189674B70-0x0000000189674B90 */ get => default; /* [XID] */ /* 0x000000018967C400-0x000000018967C420 */ private set {} } // 0x0000000183DE2DD0-0x0000000183DE2E70 0x0000000183DE18A0-0x0000000183DE1950
	public Dictionary<string, string> rtpcMap { /* [XID] */ /* 0x00000001896839F0-0x0000000189683A10 */ get => default; /* [XID] */ /* 0x000000018968B7B0-0x000000018968B7D0 */ private set {} } // 0x0000000183DE2D30-0x0000000183DE2DD0 0x0000000183DE2470-0x0000000183DE2520

	// Constructors
	public ConfigAudioSurfaceType() {} // 0x0000000183DE2F10-0x0000000183DE2F70

	// Methods
	// [XID] // 0x0000000189693340-0x0000000189693360
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DE2A50-0x0000000183DE2BF0
	// [XID] // 0x000000018969A590-0x000000018969A5B0
	public void InitEmpty() {} // 0x0000000183DE1F90-0x0000000183DE20B0
	[BlackList] // 0x00000001896A1E40-0x00000001896A1E80
	// [XID] // 0x00000001896A1E40-0x00000001896A1E80
	public bool FromJson(JSONNode node) => default; // 0x0000000183DE1AA0-0x0000000183DE1E20
	// [XID] // 0x00000001896AC130-0x00000001896AC150
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183DE0460-0x0000000183DE0A00
	// [XID] // 0x00000001896B3410-0x00000001896B3430
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7563 */, bool useObjectPool = false /* Metadata: 0x00AF7567 */) => default; // 0x0000000183DE2170-0x0000000183DE2470
	// [XID] // 0x00000001896BABD0-0x00000001896BABF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7568 */, bool useObjectPool = false /* Metadata: 0x00AF756C */) => default; // 0x0000000183DE1370-0x0000000183DE18A0
	[BlackList] // 0x00000001896C1BA0-0x00000001896C1BE0
	// [XID] // 0x00000001896C1BA0-0x00000001896C1BE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DE0A00-0x0000000183DE0CD0
	// [XID] // 0x00000001896CC390-0x00000001896CC3B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DE25C0-0x0000000183DE2A50
	// [XID] // 0x00000001896D3580-0x00000001896D35A0
	public void SetupSurfaceTypeRtpc() {} // 0x0000000183DE1950-0x0000000183DE1AA0
	// [XID] // 0x00000001896DB140-0x00000001896DB160
	public void SetupSurfaceTypeSwitch() {} // 0x0000000183DE1220-0x0000000183DE1370
	// [XID] // 0x00000001896E2860-0x00000001896E2880
	public uint GetSurfaceTypeRtpcId(int surface) => default; // 0x0000000183DE20B0-0x0000000183DE2170
	// [XID] // 0x00000001896E9EA0-0x00000001896E9EC0
	public uint GetSurfaceTypeSwitchValue(MoleMole.SceneSurfaceMaterial surface) => default; // 0x0000000183DE1E20-0x0000000183DE1EE0
	[BlackList] // 0x00000001896F0F80-0x00000001896F0FC0
	// [XID] // 0x00000001896F0F80-0x00000001896F0FC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DE0CD0-0x0000000183DE0D70
	[BlackList] // 0x00000001896FBC10-0x00000001896FBC50
	// [XID] // 0x00000001896FBC10-0x00000001896FBC50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DE0D70-0x0000000183DE0F80
	[BlackList] // 0x0000000189705F60-0x0000000189705FA0
	// [XID] // 0x0000000189705F60-0x0000000189705FA0
	public virtual void ReturnToObjectPool() {} // 0x0000000183DE2E70-0x0000000183DE2F10
	[BlackList] // 0x0000000189710B50-0x0000000189710B90
	// [XID] // 0x0000000189710B50-0x0000000189710B90
	public virtual void OnPoolAllocated() {} // 0x0000000183DE2C90-0x0000000183DE2D30
	[BlackList] // 0x000000018971B2C0-0x000000018971B300
	// [XID] // 0x000000018971B2C0-0x000000018971B300
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DE2BF0-0x0000000183DE2C90
}

