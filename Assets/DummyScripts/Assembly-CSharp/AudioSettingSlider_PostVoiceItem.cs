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
public class AudioSettingSlider_PostVoiceItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17621
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private VoiceTriggerIdentity _voiceTriggerIdentity; // 0x10
	private SimpleSafeUInt32 repeatCountRawNum; // 0x18

	// Properties
	public VoiceTriggerIdentity voiceTriggerIdentity { /* [XID] */ /* 0x00000001896ECC00-0x00000001896ECC20 */ get => default; /* [XID] */ /* 0x00000001896F4380-0x00000001896F43A0 */ private set {} } // 0x00000001818284E0-0x0000000181828580 0x00000001818281A0-0x0000000181828250
	public uint repeatCount { /* [XID] */ /* 0x00000001896FBC50-0x00000001896FBC70 */ get => default; /* [XID] */ /* 0x0000000189703170-0x0000000189703190 */ private set {} } // 0x00000001818280D0-0x00000001818281A0 0x0000000181827FF0-0x00000001818280D0

	// Constructors
	public AudioSettingSlider_PostVoiceItem() {} // 0x0000000181828870-0x00000001818288D0

	// Methods
	// [XID] // 0x000000018970A880-0x000000018970A8A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181828580-0x0000000181828690
	// [XID] // 0x00000001897123B0-0x00000001897123D0
	public void InitEmpty() {} // 0x0000000181827BF0-0x0000000181827CF0
	[BlackList] // 0x00000001897199B0-0x00000001897199F0
	// [XID] // 0x00000001897199B0-0x00000001897199F0
	public bool FromJson(JSONNode node) => default; // 0x0000000181827870-0x0000000181827BF0
	// [XID] // 0x0000000189723C10-0x0000000189723C30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181826D90-0x00000001818270B0
	// [XID] // 0x000000018972B310-0x000000018972B330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7511 */, bool useObjectPool = false /* Metadata: 0x00AF7515 */) => default; // 0x0000000181827CF0-0x0000000181827FF0
	// [XID] // 0x0000000189732B40-0x0000000189732B60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7516 */, bool useObjectPool = false /* Metadata: 0x00AF751A */) => default; // 0x0000000181827580-0x0000000181827870
	[BlackList] // 0x000000018973A250-0x000000018973A290
	// [XID] // 0x000000018973A250-0x000000018973A290
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001818270B0-0x0000000181827380
	// [XID] // 0x0000000189744B70-0x0000000189744B90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181828250-0x00000001818284E0
	[BlackList] // 0x000000018974C820-0x000000018974C860
	// [XID] // 0x000000018974C820-0x000000018974C860
	public virtual void AutoAllocTypeFields() {} // 0x0000000181827380-0x0000000181827420
	[BlackList] // 0x0000000189756B00-0x0000000189756B40
	// [XID] // 0x0000000189756B00-0x0000000189756B40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181827420-0x0000000181827580
	[BlackList] // 0x0000000189761430-0x0000000189761470
	// [XID] // 0x0000000189761430-0x0000000189761470
	public virtual void ReturnToObjectPool() {} // 0x00000001818287D0-0x0000000181828870
	[BlackList] // 0x000000018976B940-0x000000018976B980
	// [XID] // 0x000000018976B940-0x000000018976B980
	public virtual void OnPoolAllocated() {} // 0x0000000181828730-0x00000001818287D0
	[BlackList] // 0x0000000189776040-0x0000000189776080
	// [XID] // 0x0000000189776040-0x0000000189776080
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181828690-0x0000000181828730
}

