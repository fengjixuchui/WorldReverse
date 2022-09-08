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
public class ConfigAudioEmitter : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17570
{
	// Fields
	private SimpleSafeFloat emitterLifetimeRawNum; // 0x10
	private SimpleSafeFloat emitIntervalRawNum; // 0x14
	private SimpleSafeFloat instLifetimeRawNum; // 0x18
	private SimpleSafeFloat endingDurationRawNum; // 0x1C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _emitEventName; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _endEventName; // 0x28
	private AudioEmitterMultiPositionType _multiPositionType; // 0x30

	// Properties
	public float emitterLifetime { /* [XID] */ /* 0x00000001896947C0-0x00000001896947E0 */ get => default; /* [XID] */ /* 0x000000018969BE20-0x000000018969BE40 */ private set {} } // 0x00000001833D4B20-0x00000001833D4C00 0x00000001833D5420-0x00000001833D5500
	public float emitInterval { /* [XID] */ /* 0x00000001896A3380-0x00000001896A33A0 */ get => default; /* [XID] */ /* 0x00000001896AA8B0-0x00000001896AA8D0 */ private set {} } // 0x00000001833D55A0-0x00000001833D5680 0x00000001833D44B0-0x00000001833D4590
	public float instLifetime { /* [XID] */ /* 0x00000001899D8350-0x00000001899D8370 */ get => default; /* [XID] */ /* 0x00000001896B92B0-0x00000001896B92D0 */ private set {} } // 0x00000001833D4050-0x00000001833D4130 0x00000001833D3EC0-0x00000001833D3FA0
	public float endingDuration { /* [XID] */ /* 0x00000001896C06C0-0x00000001896C06E0 */ get => default; /* [XID] */ /* 0x00000001896C7DB0-0x00000001896C7DD0 */ private set {} } // 0x00000001833D3430-0x00000001833D3510 0x00000001833D3DE0-0x00000001833D3EC0
	public ConfigWwiseString emitEventName { /* [XID] */ /* 0x0000000189BDBD60-0x0000000189BDBD80 */ get => default; /* [XID] */ /* 0x00000001896D69C0-0x00000001896D69E0 */ private set {} } // 0x00000001833D4590-0x00000001833D4630 0x00000001833D2850-0x00000001833D2900
	public ConfigWwiseString endEventName { /* [XID] */ /* 0x00000001895E8610-0x00000001895E8630 */ get => default; /* [XID] */ /* 0x00000001896E5570-0x00000001896E5590 */ private set {} } // 0x00000001833D4630-0x00000001833D46D0 0x00000001833D5680-0x00000001833D5730
	public AudioEmitterMultiPositionType multiPositionType { /* [XID] */ /* 0x00000001896ECC20-0x00000001896ECC40 */ get => default; /* [XID] */ /* 0x00000001896F43C0-0x00000001896F43E0 */ private set {} } // 0x00000001833D5500-0x00000001833D55A0 0x00000001833D3FA0-0x00000001833D4050

	// Constructors
	public ConfigAudioEmitter() {} // 0x00000001833D57D0-0x00000001833D5830

	// Methods
	// [XID] // 0x00000001896FBCB0-0x00000001896FBCD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833D5130-0x00000001833D52E0
	// [XID] // 0x0000000189703190-0x00000001897031B0
	public void InitEmpty() {} // 0x00000001833D46D0-0x00000001833D4820
	[BlackList] // 0x000000018970A8A0-0x000000018970A8E0
	// [XID] // 0x000000018970A8A0-0x000000018970A8E0
	public bool FromJson(JSONNode node) => default; // 0x00000001833D4130-0x00000001833D44B0
	// [XID] // 0x0000000189714D10-0x0000000189714D30
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833D2900-0x00000001833D3160
	// [XID] // 0x000000018971C800-0x000000018971C820
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7341 */, bool useObjectPool = false /* Metadata: 0x00AF7345 */) => default; // 0x00000001833D4820-0x00000001833D4B20
	// [XID] // 0x0000000189723C30-0x0000000189723C50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7346 */, bool useObjectPool = false /* Metadata: 0x00AF734A */) => default; // 0x00000001833D37C0-0x00000001833D3DE0
	[BlackList] // 0x000000018972B370-0x000000018972B3B0
	// [XID] // 0x000000018972B370-0x000000018972B3B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833D3160-0x00000001833D3430
	// [XID] // 0x0000000189735B60-0x0000000189735B80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833D4C00-0x00000001833D5130
	[BlackList] // 0x000000018973D6D0-0x000000018973D710
	// [XID] // 0x000000018973D6D0-0x000000018973D710
	public virtual void AutoAllocTypeFields() {} // 0x00000001833D3510-0x00000001833D35B0
	[BlackList] // 0x0000000189747DC0-0x0000000189747E00
	// [XID] // 0x0000000189747DC0-0x0000000189747E00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833D35B0-0x00000001833D37C0
	[BlackList] // 0x0000000189752290-0x00000001897522D0
	// [XID] // 0x0000000189752290-0x00000001897522D0
	public virtual void ReturnToObjectPool() {} // 0x00000001833D5730-0x00000001833D57D0
	[BlackList] // 0x000000018975C850-0x000000018975C890
	// [XID] // 0x000000018975C850-0x000000018975C890
	public virtual void OnPoolAllocated() {} // 0x00000001833D5380-0x00000001833D5420
	[BlackList] // 0x00000001897671A0-0x00000001897671E0
	// [XID] // 0x00000001897671A0-0x00000001897671E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833D52E0-0x00000001833D5380
}

