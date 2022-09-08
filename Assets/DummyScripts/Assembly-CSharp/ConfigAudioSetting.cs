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
public class ConfigAudioSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17627
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioSettingSlider_PostEvent _globalVolume; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioSettingSlider_PostEvent _sfxVolume; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioSettingSlider_PostEvent _musicVolume; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioSettingSlider_PostVoice _voiceVolume; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private VibrationSetting _vibration; // 0x30

	// Properties
	public AudioSettingSlider_PostEvent globalVolume { /* [XID] */ /* 0x00000001899C4420-0x00000001899C4440 */ get => default; /* [XID] */ /* 0x00000001899CBCA0-0x00000001899CBCC0 */ private set {} } // 0x0000000181181A90-0x0000000181181B30 0x0000000181182BF0-0x0000000181182CA0
	public AudioSettingSlider_PostEvent sfxVolume { /* [XID] */ /* 0x0000000189A886A0-0x0000000189A886C0 */ get => default; /* [XID] */ /* 0x00000001899DA780-0x00000001899DA7A0 */ private set {} } // 0x0000000181181B30-0x0000000181181BD0 0x0000000181181660-0x0000000181181710
	public AudioSettingSlider_PostEvent musicVolume { /* [XID] */ /* 0x00000001899E2180-0x00000001899E21A0 */ get => default; /* [XID] */ /* 0x00000001899E9660-0x00000001899E9680 */ private set {} } // 0x0000000181182730-0x00000001811827D0 0x0000000181182250-0x0000000181182300
	public AudioSettingSlider_PostVoice voiceVolume { /* [XID] */ /* 0x0000000189A80E10-0x0000000189A80E30 */ get => default; /* [XID] */ /* 0x00000001899F8550-0x00000001899F8570 */ private set {} } // 0x0000000181182CA0-0x0000000181182D40 0x0000000181182300-0x00000001811823B0
	public VibrationSetting vibration { /* [XID] */ /* 0x00000001899FFB60-0x00000001899FFB80 */ get => default; /* [XID] */ /* 0x0000000189A07370-0x0000000189A07390 */ private set {} } // 0x00000001811831E0-0x0000000181183280 0x00000001811821A0-0x0000000181182250

	// Constructors
	public ConfigAudioSetting() {} // 0x00000001811835F0-0x0000000181183650

	// Methods
	// [XID] // 0x0000000189A0E8F0-0x0000000189A0E910
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181183280-0x0000000181183410
	// [XID] // 0x0000000189A16020-0x0000000189A16040
	public void InitEmpty() {} // 0x00000001811827D0-0x00000001811828F0
	[BlackList] // 0x0000000189A1D540-0x0000000189A1D580
	// [XID] // 0x0000000189A1D540-0x0000000189A1D580
	public bool FromJson(JSONNode node) => default; // 0x00000001811823B0-0x0000000181182730
	// [XID] // 0x0000000189A27920-0x0000000189A27940
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181180DA0-0x0000000181181390
	// [XID] // 0x0000000189A2F0B0-0x0000000189A2F0D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7545 */, bool useObjectPool = false /* Metadata: 0x00AF7549 */) => default; // 0x00000001811828F0-0x0000000181182BF0
	// [XID] // 0x0000000189A36A70-0x0000000189A36A90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF754A */, bool useObjectPool = false /* Metadata: 0x00AF754E */) => default; // 0x0000000181181BD0-0x00000001811821A0
	[BlackList] // 0x0000000189A3E0F0-0x0000000189A3E130
	// [XID] // 0x0000000189A3E0F0-0x0000000189A3E130
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181181390-0x0000000181181660
	// [XID] // 0x0000000189A487F0-0x0000000189A48810
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181182D40-0x00000001811831E0
	[BlackList] // 0x0000000189A4FF60-0x0000000189A4FFA0
	// [XID] // 0x0000000189A4FF60-0x0000000189A4FFA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181181710-0x00000001811817B0
	[BlackList] // 0x0000000189A5A610-0x0000000189A5A650
	// [XID] // 0x0000000189A5A610-0x0000000189A5A650
	public virtual void AutoRecycleTypeFields() {} // 0x00000001811817B0-0x0000000181181A90
	[BlackList] // 0x0000000189A650E0-0x0000000189A65120
	// [XID] // 0x0000000189A650E0-0x0000000189A65120
	public virtual void ReturnToObjectPool() {} // 0x0000000181183550-0x00000001811835F0
	[BlackList] // 0x0000000189A6F8A0-0x0000000189A6F8E0
	// [XID] // 0x0000000189A6F8A0-0x0000000189A6F8E0
	public virtual void OnPoolAllocated() {} // 0x00000001811834B0-0x0000000181183550
	[BlackList] // 0x0000000189A7A550-0x0000000189A7A590
	// [XID] // 0x0000000189A7A550-0x0000000189A7A590
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181183410-0x00000001811834B0
}

