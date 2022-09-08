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
public class AudioSettingSlider_PostVoice : AudioSettingSlider, IAutoAllocRecycle // TypeDefIndex: 17625
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioSettingSlider_PostVoiceItem[] _changeVoiceArray; // 0x30

	// Properties
	public AudioSettingSlider_PostVoiceItem[] changeVoiceArray { /* [XID] */ /* 0x0000000189842740-0x0000000189842760 */ get => default; /* [XID] */ /* 0x0000000189849A70-0x0000000189849A90 */ private set {} } // 0x0000000181340380-0x0000000181340420 0x000000018133F770-0x000000018133F820

	// Constructors
	public AudioSettingSlider_PostVoice() {} // 0x00000001813405B0-0x0000000181340610

	// Methods
	// [XID] // 0x00000001898511D0-0x00000001898511F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181340420-0x0000000181340510
	// [XID] // 0x00000001898586E0-0x0000000189858700
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181340060-0x0000000181340140
	// [XID] // 0x000000018985F7D0-0x000000018985F7F0
	public override AudioSettingSlider Clone(bool useObjectPool = false /* Metadata: 0x00AF752B */) => default; // 0x000000018133FC70-0x000000018133FD50
	// [XID] // 0x0000000189867050-0x0000000189867070
	public override int GetHashNum() => default; // 0x000000018133EAF0-0x000000018133EBC0
	// [XID] // 0x000000018986E830-0x000000018986E850
	public override void InitEmpty() {} // 0x000000018133F620-0x000000018133F6F0
	[BlackList] // 0x0000000189875D00-0x0000000189875D40
	// [XID] // 0x0000000189875D00-0x0000000189875D40
	public override bool FromJson(JSONNode node) => default; // 0x000000018133F010-0x000000018133F390
	// [XID] // 0x00000001898803C0-0x00000001898803E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018133E380-0x000000018133E5B0
	[BlackList] // 0x0000000189887880-0x00000001898878C0
	// [XID] // 0x0000000189887880-0x00000001898878C0
	public static new AudioSettingSlider_PostVoice ParseFromJson(JSONNode node) => default; // 0x000000018133FDB0-0x0000000181340000
	// [XID] // 0x0000000189891A80-0x0000000189891AA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF752C */, bool useObjectPool = false /* Metadata: 0x00AF7530 */) => default; // 0x000000018133F970-0x000000018133FC70
	// [XID] // 0x00000001898993B0-0x00000001898993D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7531 */, bool useObjectPool = false /* Metadata: 0x00AF7535 */) => default; // 0x000000018133ECA0-0x000000018133EF10
	// [XID] // 0x00000001898A0650-0x00000001898A0670
	public static new AudioSettingSlider_PostVoice ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7536 */, bool useObjectPool = false /* Metadata: 0x00AF753A */) => default; // 0x000000018133F390-0x000000018133F5B0
	[BlackList] // 0x00000001898A7CD0-0x00000001898A7D10
	// [XID] // 0x00000001898A7CD0-0x00000001898A7D10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018133E5B0-0x000000018133E880
	// [XID] // 0x00000001898B2490-0x00000001898B24B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181340140-0x0000000181340380
	[BlackList] // 0x00000001898BA200-0x00000001898BA240
	// [XID] // 0x00000001898BA200-0x00000001898BA240
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018133F880-0x000000018133F970
	[BlackList] // 0x00000001898C4660-0x00000001898C46A0
	// [XID] // 0x00000001898C4660-0x00000001898C46A0
	public override void AutoAllocTypeFields() {} // 0x000000018133E880-0x000000018133E920
	[BlackList] // 0x00000001898CEC90-0x00000001898CECD0
	// [XID] // 0x00000001898CEC90-0x00000001898CECD0
	public override void AutoRecycleTypeFields() {} // 0x000000018133E920-0x000000018133E9D0
	[BlackList] // 0x00000001898D95D0-0x00000001898D9610
	// [XID] // 0x00000001898D95D0-0x00000001898D9610
	public override void ReturnToObjectPool() {} // 0x0000000181340510-0x00000001813405B0
}

