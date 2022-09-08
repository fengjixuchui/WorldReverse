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
public class ConfigAudioListener : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17591
{
	// Fields
	private SimpleSafeFloat fakeAvatarDistanceRawNum; // 0x10
	private SimpleSafeFloat akListenerHeightRawNum; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _obstructionRtpc; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _focusAngleRtpc; // 0x20
	private SimpleSafeFloat obstructionDetectRadiusRawNum; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAudioListenerOutreachCast _outreachCast; // 0x30
	private SimpleSafeFloat firstPersonListenerVolumeOffsetRawNum; // 0x38
	private SimpleSafeFloat thirdPersonListenerVolumeOffsetRawNum; // 0x3C
	private SimpleSafeFloat defaultListenerVolumeOffsetRawNum; // 0x40

	// Properties
	public float fakeAvatarDistance { /* [XID] */ /* 0x00000001898EDF90-0x00000001898EDFB0 */ get => default; /* [XID] */ /* 0x0000000189765770-0x0000000189765790 */ private set {} } // 0x000000018208A0C0-0x000000018208A1A0 0x0000000182087E80-0x0000000182087F60
	public float akListenerHeight { /* [XID] */ /* 0x000000018976D000-0x000000018976D020 */ get => default; /* [XID] */ /* 0x00000001897744D0-0x00000001897744F0 */ private set {} } // 0x00000001820898D0-0x00000001820899B0 0x00000001820880E0-0x00000001820881C0
	public ConfigWwiseString obstructionRtpc { /* [XID] */ /* 0x000000018977BE60-0x000000018977BE80 */ get => default; /* [XID] */ /* 0x0000000189783770-0x0000000189783790 */ private set {} } // 0x0000000182087F60-0x0000000182088000 0x0000000182087DD0-0x0000000182087E80
	public ConfigWwiseString focusAngleRtpc { /* [XID] */ /* 0x000000018978AE80-0x000000018978AEA0 */ get => default; /* [XID] */ /* 0x0000000189792440-0x0000000189792460 */ private set {} } // 0x0000000182088A40-0x0000000182088AE0 0x0000000182088AE0-0x0000000182088B90
	public float obstructionDetectRadius { /* [XID] */ /* 0x00000001898433A0-0x00000001898433C0 */ get => default; /* [XID] */ /* 0x00000001897A1900-0x00000001897A1920 */ private set {} } // 0x0000000182089290-0x0000000182089370 0x00000001820879A0-0x0000000182087A80
	public ConfigAudioListenerOutreachCast outreachCast { /* [XID] */ /* 0x00000001897A9160-0x00000001897A9180 */ get => default; /* [XID] */ /* 0x00000001897B09C0-0x00000001897B09E0 */ private set {} } // 0x00000001820881C0-0x0000000182088260 0x00000001820899B0-0x0000000182089A60
	public float firstPersonListenerVolumeOffset { /* [XID] */ /* 0x0000000189BD4480-0x0000000189BD44A0 */ get => default; /* [XID] */ /* 0x00000001897C0760-0x00000001897C0780 */ private set {} } // 0x00000001820891B0-0x0000000182089290 0x00000001820890D0-0x00000001820891B0
	public float thirdPersonListenerVolumeOffset { /* [XID] */ /* 0x00000001897C7FF0-0x00000001897C8010 */ get => default; /* [XID] */ /* 0x00000001897CF370-0x00000001897CF390 */ private set {} } // 0x0000000182088000-0x00000001820880E0 0x0000000182088FF0-0x00000001820890D0
	public float defaultListenerVolumeOffset { /* [XID] */ /* 0x00000001897D6C40-0x00000001897D6C60 */ get => default; /* [XID] */ /* 0x00000001897DE310-0x00000001897DE330 */ private set {} } // 0x00000001820897F0-0x00000001820898D0 0x0000000182088F10-0x0000000182088FF0

	// Constructors
	public ConfigAudioListener() {} // 0x000000018208A580-0x000000018208A5E0

	// Methods
	// [XID] // 0x00000001897E5DD0-0x00000001897E5DF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018208A1A0-0x000000018208A3A0
	// [XID] // 0x00000001897ED7D0-0x00000001897ED7F0
	public void InitEmpty() {} // 0x0000000182089370-0x00000001820894F0
	[BlackList] // 0x00000001897F5070-0x00000001897F50B0
	// [XID] // 0x00000001897F5070-0x00000001897F50B0
	public bool FromJson(JSONNode node) => default; // 0x0000000182088B90-0x0000000182088F10
	// [XID] // 0x00000001897FF810-0x00000001897FF830
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182086C50-0x00000001820876D0
	// [XID] // 0x0000000189806F90-0x0000000189806FB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7401 */, bool useObjectPool = false /* Metadata: 0x00AF7405 */) => default; // 0x00000001820894F0-0x00000001820897F0
	// [XID] // 0x000000018980E550-0x000000018980E570
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7406 */, bool useObjectPool = false /* Metadata: 0x00AF740A */) => default; // 0x0000000182088260-0x0000000182088A40
	[BlackList] // 0x0000000189815CB0-0x0000000189815CF0
	// [XID] // 0x0000000189815CB0-0x0000000189815CF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001820876D0-0x00000001820879A0
	// [XID] // 0x00000001898207B0-0x00000001898207D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182089A60-0x000000018208A0C0
	[BlackList] // 0x0000000189827DE0-0x0000000189827E20
	// [XID] // 0x0000000189827DE0-0x0000000189827E20
	public virtual void AutoAllocTypeFields() {} // 0x0000000182087A80-0x0000000182087B20
	[BlackList] // 0x00000001898320F0-0x0000000189832130
	// [XID] // 0x00000001898320F0-0x0000000189832130
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182087B20-0x0000000182087DD0
	[BlackList] // 0x000000018983C7B0-0x000000018983C7F0
	// [XID] // 0x000000018983C7B0-0x000000018983C7F0
	public virtual void ReturnToObjectPool() {} // 0x000000018208A4E0-0x000000018208A580
	[BlackList] // 0x0000000189846D90-0x0000000189846DD0
	// [XID] // 0x0000000189846D90-0x0000000189846DD0
	public virtual void OnPoolAllocated() {} // 0x000000018208A440-0x000000018208A4E0
	[BlackList] // 0x00000001898511F0-0x0000000189851230
	// [XID] // 0x00000001898511F0-0x0000000189851230
	public virtual void OnBeforePoolRecycled() {} // 0x000000018208A3A0-0x000000018208A440
}

