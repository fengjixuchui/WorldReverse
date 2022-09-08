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
public class ConfigCrystal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17984
{
	// Fields
	private ElementType _elementType; // 0x10
	private SimpleSafeUInt32 gainSpeedRawNum; // 0x14
	private SimpleSafeUInt32 drainSpeedRawNum; // 0x18
	private SimpleSafeUInt32[] _resonateLevels; // 0x20
	private SimpleSafeUInt32 burstResonateRawNum; // 0x28
	private string _burstSkill; // 0x30
	private SimpleSafeUInt32 burstTimeRawNum; // 0x38
	private SimpleSafeUInt32 respawnTimeRawNum; // 0x3C

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189A58D20-0x0000000189A58D40 */ get => default; /* [XID] */ /* 0x0000000189A606C0-0x0000000189A606E0 */ private set {} } // 0x000000018246CC80-0x000000018246CD20 0x000000018246DB50-0x000000018246DC00
	public uint gainSpeed { /* [XID] */ /* 0x0000000189A68410-0x0000000189A68430 */ get => default; /* [XID] */ /* 0x0000000189A6F7C0-0x0000000189A6F7E0 */ private set {} } // 0x000000018246DCD0-0x000000018246DDA0 0x000000018246D540-0x000000018246D620
	public uint drainSpeed { /* [XID] */ /* 0x0000000189A76F10-0x0000000189A76F30 */ get => default; /* [XID] */ /* 0x0000000189A7EA20-0x0000000189A7EA40 */ private set {} } // 0x000000018246DC00-0x000000018246DCD0 0x000000018246DA70-0x000000018246DB50
	public SimpleSafeUInt32[] resonateLevels { /* [XID] */ /* 0x0000000189A86290-0x0000000189A862B0 */ get => default; /* [XID] */ /* 0x0000000189A8DB90-0x0000000189A8DBB0 */ private set {} } // 0x000000018246D320-0x000000018246D3C0 0x000000018246CBD0-0x000000018246CC80
	public uint burstResonate { /* [XID] */ /* 0x0000000189A95150-0x0000000189A95170 */ get => default; /* [XID] */ /* 0x0000000189A9C9F0-0x0000000189A9CA10 */ private set {} } // 0x000000018246D180-0x000000018246D250 0x000000018246D460-0x000000018246D540
	public string burstSkill { /* [XID] */ /* 0x0000000189AA41C0-0x0000000189AA41E0 */ get => default; /* [XID] */ /* 0x0000000189AAB650-0x0000000189AAB670 */ private set {} } // 0x000000018246D3C0-0x000000018246D460 0x000000018246C4C0-0x000000018246C570
	public uint burstTime { /* [XID] */ /* 0x0000000189AB3040-0x0000000189AB3060 */ get => default; /* [XID] */ /* 0x0000000189ABACB0-0x0000000189ABACD0 */ private set {} } // 0x000000018246E7D0-0x000000018246E8A0 0x000000018246CD20-0x000000018246CE00
	public uint respawnTime { /* [XID] */ /* 0x0000000189AC2540-0x0000000189AC2560 */ get => default; /* [XID] */ /* 0x0000000189AC9C40-0x0000000189AC9C60 */ private set {} } // 0x000000018246D250-0x000000018246D320 0x000000018246DDA0-0x000000018246DE80

	// Constructors
	public ConfigCrystal() {} // 0x000000018246E940-0x000000018246E9A0

	// Methods
	// [XID] // 0x0000000189AD1490-0x0000000189AD14B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018246E4F0-0x000000018246E690
	// [XID] // 0x0000000189AD9210-0x0000000189AD9230
	public void InitEmpty() {} // 0x000000018246D620-0x000000018246D770
	[BlackList] // 0x0000000189AE0C80-0x0000000189AE0CC0
	// [XID] // 0x0000000189AE0C80-0x0000000189AE0CC0
	public bool FromJson(JSONNode node) => default; // 0x000000018246CE00-0x000000018246D180
	// [XID] // 0x0000000189AEB3D0-0x0000000189AEB3F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018246B710-0x000000018246C020
	// [XID] // 0x0000000189AF2D90-0x0000000189AF2DB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85A7 */, bool useObjectPool = false /* Metadata: 0x00AF85AB */) => default; // 0x000000018246D770-0x000000018246DA70
	// [XID] // 0x0000000189AFA620-0x0000000189AFA640
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85AC */, bool useObjectPool = false /* Metadata: 0x00AF85B0 */) => default; // 0x000000018246C570-0x000000018246CBD0
	[BlackList] // 0x0000000189B01B30-0x0000000189B01B70
	// [XID] // 0x0000000189B01B30-0x0000000189B01B70
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018246C020-0x000000018246C2F0
	// [XID] // 0x0000000189B0C1B0-0x0000000189B0C1D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018246DE80-0x000000018246E4F0
	[BlackList] // 0x0000000189B13730-0x0000000189B13770
	// [XID] // 0x0000000189B13730-0x0000000189B13770
	public virtual void AutoAllocTypeFields() {} // 0x000000018246C2F0-0x000000018246C390
	[BlackList] // 0x0000000189B1DB50-0x0000000189B1DB90
	// [XID] // 0x0000000189B1DB50-0x0000000189B1DB90
	public virtual void AutoRecycleTypeFields() {} // 0x000000018246C390-0x000000018246C4C0
	[BlackList] // 0x0000000189B28290-0x0000000189B282D0
	// [XID] // 0x0000000189B28290-0x0000000189B282D0
	public virtual void ReturnToObjectPool() {} // 0x000000018246E8A0-0x000000018246E940
	[BlackList] // 0x0000000189B32740-0x0000000189B32780
	// [XID] // 0x0000000189B32740-0x0000000189B32780
	public virtual void OnPoolAllocated() {} // 0x000000018246E730-0x000000018246E7D0
	[BlackList] // 0x0000000189B3CC80-0x0000000189B3CCC0
	// [XID] // 0x0000000189B3CC80-0x0000000189B3CCC0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018246E690-0x000000018246E730
}

