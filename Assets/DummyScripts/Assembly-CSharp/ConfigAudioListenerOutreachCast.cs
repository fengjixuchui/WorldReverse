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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAudioListenerOutreachCast : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17590
{
	// Fields
	private SimpleSafeFloat rangeRawNum; // 0x10
	private SimpleSafeFloat startAngleRawNum; // 0x14
	private SimpleSafeInt32 rayCountRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _rtpcNames; // 0x20
	private MoleMole.Config.Vector _offset; // 0x28

	// Properties
	public float range { /* [XID] */ /* 0x0000000189655CA0-0x0000000189655CC0 */ get => default; /* [XID] */ /* 0x0000000189688700-0x0000000189688720 */ private set {} } // 0x000000018154AE20-0x000000018154AF00 0x000000018154AF00-0x000000018154AFE0
	public float startAngle { /* [XID] */ /* 0x0000000189690020-0x0000000189690040 */ get => default; /* [XID] */ /* 0x0000000189697960-0x0000000189697980 */ private set {} } // 0x000000018154C920-0x000000018154CA00 0x000000018154C020-0x000000018154C100
	public int rayCount { /* [XID] */ /* 0x00000001896D7520-0x00000001896D7540 */ get => default; /* [XID] */ /* 0x00000001896A6110-0x00000001896A6130 */ private set {} } // 0x000000018154C590-0x000000018154C660 0x000000018154BAC0-0x000000018154BBA0
	public ConfigWwiseString[] rtpcNames { /* [XID] */ /* 0x00000001896AD610-0x00000001896AD630 */ get => default; /* [XID] */ /* 0x00000001896B4D70-0x00000001896B4D90 */ private set {} } // 0x000000018154B8D0-0x000000018154B970 0x000000018154BEA0-0x000000018154BF50
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x00000001896BC0C0-0x00000001896BC0E0 */ get => default; /* [XID] */ /* 0x00000001896C35A0-0x00000001896C35C0 */ private set {} } // 0x000000018154B470-0x000000018154B550 0x000000018154BF50-0x000000018154C020

	// Constructors
	public ConfigAudioListenerOutreachCast() {} // 0x000000018154CAA0-0x000000018154CB00

	// Methods
	// [XID] // 0x00000001896CAB10-0x00000001896CAB30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018154C660-0x000000018154C7E0
	// [XID] // 0x00000001896D21C0-0x00000001896D21E0
	public void InitEmpty() {} // 0x000000018154B970-0x000000018154BAC0
	[BlackList] // 0x00000001896D9B10-0x00000001896D9B50
	// [XID] // 0x00000001896D9B10-0x00000001896D9B50
	public bool FromJson(JSONNode node) => default; // 0x000000018154B550-0x000000018154B8D0
	// [XID] // 0x00000001896E40F0-0x00000001896E4110
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018154A370-0x000000018154A980
	// [XID] // 0x00000001896EB5C0-0x00000001896EB5E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73F7 */, bool useObjectPool = false /* Metadata: 0x00AF73FB */) => default; // 0x000000018154BBA0-0x000000018154BEA0
	// [XID] // 0x00000001896F2990-0x00000001896F29B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73FC */, bool useObjectPool = false /* Metadata: 0x00AF7400 */) => default; // 0x000000018154AFE0-0x000000018154B470
	[BlackList] // 0x00000001896FA1F0-0x00000001896FA230
	// [XID] // 0x00000001896FA1F0-0x00000001896FA230
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018154A980-0x000000018154AC50
	// [XID] // 0x00000001897048B0-0x00000001897048D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018154C100-0x000000018154C590
	[BlackList] // 0x000000018970C0B0-0x000000018970C0F0
	// [XID] // 0x000000018970C0B0-0x000000018970C0F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018154AC50-0x000000018154ACF0
	[BlackList] // 0x0000000189716620-0x0000000189716660
	// [XID] // 0x0000000189716620-0x0000000189716660
	public virtual void AutoRecycleTypeFields() {} // 0x000000018154ACF0-0x000000018154AE20
	[BlackList] // 0x0000000189720ED0-0x0000000189720F10
	// [XID] // 0x0000000189720ED0-0x0000000189720F10
	public virtual void ReturnToObjectPool() {} // 0x000000018154CA00-0x000000018154CAA0
	[BlackList] // 0x000000018972B330-0x000000018972B370
	// [XID] // 0x000000018972B330-0x000000018972B370
	public virtual void OnPoolAllocated() {} // 0x000000018154C880-0x000000018154C920
	[BlackList] // 0x0000000189735B20-0x0000000189735B60
	// [XID] // 0x0000000189735B20-0x0000000189735B60
	public virtual void OnBeforePoolRecycled() {} // 0x000000018154C7E0-0x000000018154C880
}

