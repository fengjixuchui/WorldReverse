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
public class EntityBeHitEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17923
{
	// Fields
	private string _overrideByFrozenState; // 0x10
	private string _overrideByPetrifactionState; // 0x18
	private string _overrideByRockState; // 0x20
	private string _overrideByRockResistState; // 0x28

	// Properties
	public string overrideByFrozenState { /* [XID] */ /* 0x0000000189952590-0x00000001899525B0 */ get => default; /* [XID] */ /* 0x0000000189BA0850-0x0000000189BA0870 */ private set {} } // 0x0000000184AF8F80-0x0000000184AF9020 0x0000000184AF9020-0x0000000184AF90D0
	public string overrideByPetrifactionState { /* [XID] */ /* 0x0000000189BA7F90-0x0000000189BA7FB0 */ get => default; /* [XID] */ /* 0x0000000189BAF400-0x0000000189BAF420 */ private set {} } // 0x0000000184AF9840-0x0000000184AF98E0 0x0000000184AF98E0-0x0000000184AF9990
	public string overrideByRockState { /* [XID] */ /* 0x0000000189968AB0-0x0000000189968AD0 */ get => default; /* [XID] */ /* 0x0000000189BBE130-0x0000000189BBE150 */ private set {} } // 0x0000000184AF9D90-0x0000000184AF9E30 0x0000000184AF9E30-0x0000000184AF9EE0
	public string overrideByRockResistState { /* [XID] */ /* 0x00000001899613F0-0x0000000189961410 */ get => default; /* [XID] */ /* 0x0000000189BCD880-0x0000000189BCD8A0 */ private set {} } // 0x0000000184AF8E30-0x0000000184AF8ED0 0x0000000184AF8ED0-0x0000000184AF8F80

	// Constructors
	public EntityBeHitEffect() {} // 0x0000000184AFA540-0x0000000184AFA5A0

	// Methods
	// [XID] // 0x0000000189BD4D50-0x0000000189BD4D70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AFA220-0x0000000184AFA360
	// [XID] // 0x0000000189BDC8A0-0x0000000189BDC8C0
	public void InitEmpty() {} // 0x0000000184AF9990-0x0000000184AF9A90
	[BlackList] // 0x00000001895E9150-0x00000001895E9190
	// [XID] // 0x00000001895E9150-0x00000001895E9190
	public bool FromJson(JSONNode node) => default; // 0x0000000184AF94C0-0x0000000184AF9840
	// [XID] // 0x00000001895FEB10-0x00000001895FEB30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184AF8590-0x0000000184AF8A10
	// [XID] // 0x000000018985AA30-0x000000018985AA50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8227 */, bool useObjectPool = false /* Metadata: 0x00AF822B */) => default; // 0x0000000184AF9A90-0x0000000184AF9D90
	// [XID] // 0x0000000189602890-0x00000001896028B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF822C */, bool useObjectPool = false /* Metadata: 0x00AF8230 */) => default; // 0x0000000184AF90D0-0x0000000184AF94C0
	[BlackList] // 0x000000018960A210-0x000000018960A250
	// [XID] // 0x000000018960A210-0x000000018960A250
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AF8A10-0x0000000184AF8CE0
	// [XID] // 0x0000000189614860-0x0000000189614880
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AF9EE0-0x0000000184AFA220
	[BlackList] // 0x000000018961C180-0x000000018961C1C0
	// [XID] // 0x000000018961C180-0x000000018961C1C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184AF8CE0-0x0000000184AF8D80
	[BlackList] // 0x00000001896265A0-0x00000001896265E0
	// [XID] // 0x00000001896265A0-0x00000001896265E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184AF8D80-0x0000000184AF8E30
	[BlackList] // 0x0000000189631160-0x00000001896311A0
	// [XID] // 0x0000000189631160-0x00000001896311A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184AFA4A0-0x0000000184AFA540
	[BlackList] // 0x000000018963B8E0-0x000000018963B920
	// [XID] // 0x000000018963B8E0-0x000000018963B920
	public virtual void OnPoolAllocated() {} // 0x0000000184AFA400-0x0000000184AFA4A0
	[BlackList] // 0x0000000189645F00-0x0000000189645F40
	// [XID] // 0x0000000189645F00-0x0000000189645F40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184AFA360-0x0000000184AFA400
}

