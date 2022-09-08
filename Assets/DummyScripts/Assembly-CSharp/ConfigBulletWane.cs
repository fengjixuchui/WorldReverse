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
public class ConfigBulletWane : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17677
{
	// Fields
	private SimpleSafeFloat waneDelayRawNum; // 0x10
	private SimpleSafeFloat damageWaneIntervalRawNum; // 0x14
	private SimpleSafeFloat damageWaneRatioRawNum; // 0x18
	private SimpleSafeFloat damageWaneMinRatioRawNum; // 0x1C
	private SimpleSafeFloat elementDurabilityWaneIntervalRawNum; // 0x20
	private SimpleSafeFloat elementDurabilityWaneRatioRawNum; // 0x24
	private SimpleSafeFloat elementDurabilityWaneMinRatioRawNum; // 0x28
	private SimpleSafeFloat hitLevelWaneIntervalRawNum; // 0x2C
	private HitLevel _hitLevelWaneMin; // 0x30

	// Properties
	public float waneDelay { /* [XID] */ /* 0x00000001895F6CE0-0x00000001895F6D00 */ get => default; /* [XID] */ /* 0x00000001895FE080-0x00000001895FE0A0 */ private set {} } // 0x0000000183B1DAE0-0x0000000183B1DBC0 0x0000000183B1DF80-0x0000000183B1E060
	public float damageWaneInterval { /* [XID] */ /* 0x0000000189605850-0x0000000189605870 */ get => default; /* [XID] */ /* 0x000000018960D1A0-0x000000018960D1C0 */ private set {} } // 0x0000000183B1DC70-0x0000000183B1DD50 0x0000000183B1E7C0-0x0000000183B1E8A0
	public float damageWaneRatio { /* [XID] */ /* 0x00000001896148A0-0x00000001896148C0 */ get => default; /* [XID] */ /* 0x000000018961C220-0x000000018961C240 */ private set {} } // 0x0000000183B1CFD0-0x0000000183B1D0B0 0x0000000183B1E520-0x0000000183B1E600
	public float damageWaneMinRatio { /* [XID] */ /* 0x0000000189A04DE0-0x0000000189A04E00 */ get => default; /* [XID] */ /* 0x000000018962AFA0-0x000000018962AFC0 */ private set {} } // 0x0000000183B1E6E0-0x0000000183B1E7C0 0x0000000183B1F140-0x0000000183B1F220
	public float elementDurabilityWaneInterval { /* [XID] */ /* 0x0000000189838B60-0x0000000189838B80 */ get => default; /* [XID] */ /* 0x000000018963A190-0x000000018963A1B0 */ private set {} } // 0x0000000183B1E600-0x0000000183B1E6E0 0x0000000183B1DD50-0x0000000183B1DE30
	public float elementDurabilityWaneRatio { /* [XID] */ /* 0x0000000189641780-0x00000001896417A0 */ get => default; /* [XID] */ /* 0x0000000189649120-0x0000000189649140 */ private set {} } // 0x0000000183B1E440-0x0000000183B1E520 0x0000000183B1D680-0x0000000183B1D760
	public float elementDurabilityWaneMinRatio { /* [XID] */ /* 0x0000000189650750-0x0000000189650770 */ get => default; /* [XID] */ /* 0x00000001896580B0-0x00000001896580D0 */ private set {} } // 0x0000000183B1E8A0-0x0000000183B1E980 0x0000000183B1E060-0x0000000183B1E140
	public float hitLevelWaneInterval { /* [XID] */ /* 0x000000018965F660-0x000000018965F680 */ get => default; /* [XID] */ /* 0x0000000189666F50-0x0000000189666F70 */ private set {} } // 0x0000000183B1F060-0x0000000183B1F140 0x0000000183B1EF80-0x0000000183B1F060
	public HitLevel hitLevelWaneMin { /* [XID] */ /* 0x0000000189A22A00-0x0000000189A22A20 */ get => default; /* [XID] */ /* 0x00000001896762C0-0x00000001896762E0 */ private set {} } // 0x0000000183B1CF30-0x0000000183B1CFD0 0x0000000183B1DBC0-0x0000000183B1DC70

	// Constructors
	public ConfigBulletWane() {} // 0x0000000183B1F5C0-0x0000000183B1F6E0

	// Methods
	// [XID] // 0x000000018967DAE0-0x000000018967DB00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B1F220-0x0000000183B1F3E0
	// [XID] // 0x00000001896851A0-0x00000001896851C0
	public void InitEmpty() {} // 0x0000000183B1DE30-0x0000000183B1DF80
	[BlackList] // 0x000000018968CC20-0x000000018968CC60
	// [XID] // 0x000000018968CC20-0x000000018968CC60
	public bool FromJson(JSONNode node) => default; // 0x0000000183B1D760-0x0000000183B1DAE0
	// [XID] // 0x0000000189697920-0x0000000189697940
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B1C0C0-0x0000000183B1CA70
	// [XID] // 0x000000018969EDB0-0x000000018969EDD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7757 */, bool useObjectPool = false /* Metadata: 0x00AF775B */) => default; // 0x0000000183B1E140-0x0000000183B1E440
	// [XID] // 0x00000001896A60D0-0x00000001896A60F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF775C */, bool useObjectPool = false /* Metadata: 0x00AF7760 */) => default; // 0x0000000183B1D0B0-0x0000000183B1D680
	[BlackList] // 0x00000001896AD5B0-0x00000001896AD5F0
	// [XID] // 0x00000001896AD5B0-0x00000001896AD5F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B1CA70-0x0000000183B1CD40
	// [XID] // 0x00000001896B7C90-0x00000001896B7CB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B1E980-0x0000000183B1EF80
	[BlackList] // 0x00000001896BEC30-0x00000001896BEC70
	// [XID] // 0x00000001896BEC30-0x00000001896BEC70
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B1CD40-0x0000000183B1CDE0
	[BlackList] // 0x00000001896C9230-0x00000001896C9270
	// [XID] // 0x00000001896C9230-0x00000001896C9270
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B1CDE0-0x0000000183B1CF30
	[BlackList] // 0x00000001896D3540-0x00000001896D3580
	// [XID] // 0x00000001896D3540-0x00000001896D3580
	public virtual void ReturnToObjectPool() {} // 0x0000000183B1F520-0x0000000183B1F5C0
	[BlackList] // 0x00000001896DE060-0x00000001896DE0A0
	// [XID] // 0x00000001896DE060-0x00000001896DE0A0
	public virtual void OnPoolAllocated() {} // 0x0000000183B1F480-0x0000000183B1F520
	[BlackList] // 0x00000001896E8480-0x00000001896E84C0
	// [XID] // 0x00000001896E8480-0x00000001896E84C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B1F3E0-0x0000000183B1F480
}

