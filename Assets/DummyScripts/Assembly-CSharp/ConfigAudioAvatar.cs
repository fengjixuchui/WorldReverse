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
public class ConfigAudioAvatar : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17554
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _voiceSwitchKey; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _bodyTypeSwitchKey; // 0x18
	private string[] _weaponPutAwayAnimStateWhitelist; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _energyRatioRtpc; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _teamHpRTPC; // 0x30
	private SimpleSafeFloat teamHpAliveRatioRawNum; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _avatarAccessTypeSwitchGroup; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _localAvatarSwitchValue; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _remoteAvatarSwitchValue; // 0x50
	private HashSet<int> _weaponPutAwayAnimStateLookupSet; // 0x58

	// Properties
	public ConfigWwiseString voiceSwitchKey { /* [XID] */ /* 0x0000000189AB2590-0x0000000189AB25B0 */ get => default; /* [XID] */ /* 0x00000001896EE330-0x00000001896EE350 */ private set {} } // 0x000000018206D6B0-0x000000018206D750 0x000000018206CE20-0x000000018206CED0
	public ConfigWwiseString bodyTypeSwitchKey { /* [XID] */ /* 0x00000001896F5C80-0x00000001896F5CA0 */ get => default; /* [XID] */ /* 0x00000001896FD490-0x00000001896FD4B0 */ private set {} } // 0x000000018206C2F0-0x000000018206C390 0x000000018206CED0-0x000000018206CF80
	public string[] weaponPutAwayAnimStateWhitelist { /* [XID] */ /* 0x00000001897048D0-0x00000001897048F0 */ get => default; /* [XID] */ /* 0x000000018970C0F0-0x000000018970C110 */ private set {} } // 0x000000018206DBF0-0x000000018206DC90 0x000000018206DEC0-0x000000018206DF70
	public ConfigWwiseString energyRatioRtpc { /* [XID] */ /* 0x0000000189713A40-0x0000000189713A60 */ get => default; /* [XID] */ /* 0x000000018971B360-0x000000018971B380 */ private set {} } // 0x000000018206DF70-0x000000018206E010 0x000000018206B120-0x000000018206B1D0
	public ConfigWwiseString teamHpRTPC { /* [XID] */ /* 0x0000000189722600-0x0000000189722620 */ get => default; /* [XID] */ /* 0x0000000189729CE0-0x0000000189729D00 */ private set {} } // 0x000000018206EB90-0x000000018206EC30 0x000000018206DE10-0x000000018206DEC0
	public float teamHpAliveRatio { /* [XID] */ /* 0x00000001897313A0-0x00000001897313C0 */ get => default; /* [XID] */ /* 0x0000000189738BB0-0x0000000189738BD0 */ private set {} } // 0x000000018206E720-0x000000018206E800 0x000000018206DD30-0x000000018206DE10
	public ConfigWwiseString avatarAccessTypeSwitchGroup { /* [XID] */ /* 0x00000001897409E0-0x0000000189740A00 */ get => default; /* [XID] */ /* 0x0000000189747E00-0x0000000189747E20 */ private set {} } // 0x000000018206C4E0-0x000000018206C580 0x000000018206D050-0x000000018206D100
	public ConfigWwiseString localAvatarSwitchValue { /* [XID] */ /* 0x00000001897721B0-0x00000001897721D0 */ get => default; /* [XID] */ /* 0x0000000189756B60-0x0000000189756B80 */ private set {} } // 0x000000018206DC90-0x000000018206DD30 0x000000018206D480-0x000000018206D530
	public ConfigWwiseString remoteAvatarSwitchValue { /* [XID] */ /* 0x000000018975DFF0-0x000000018975E010 */ get => default; /* [XID] */ /* 0x0000000189765790-0x00000001897657B0 */ private set {} } // 0x000000018206C390-0x000000018206C430 0x000000018206C430-0x000000018206C4E0

	// Constructors
	public ConfigAudioAvatar() {} // 0x000000018206ECD0-0x000000018206ED30

	// Methods
	// [XID] // 0x000000018976D020-0x000000018976D040
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018206E800-0x000000018206EA50
	// [XID] // 0x00000001897744F0-0x0000000189774510
	public void InitEmpty() {} // 0x000000018206D530-0x000000018206D6B0
	[BlackList] // 0x000000018977BEC0-0x000000018977BF00
	// [XID] // 0x000000018977BEC0-0x000000018977BF00
	public bool FromJson(JSONNode node) => default; // 0x000000018206D100-0x000000018206D480
	// [XID] // 0x0000000189786760-0x0000000189786780
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018206B1D0-0x000000018206BB80
	// [XID] // 0x000000018978DD70-0x000000018978DD90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72BB */, bool useObjectPool = false /* Metadata: 0x00AF72BF */) => default; // 0x000000018206D750-0x000000018206DA50
	// [XID] // 0x00000001897953E0-0x0000000189795400
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72C0 */, bool useObjectPool = false /* Metadata: 0x00AF72C4 */) => default; // 0x000000018206C580-0x000000018206CE20
	[BlackList] // 0x000000018979D790-0x000000018979D7D0
	// [XID] // 0x000000018979D790-0x000000018979D7D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018206BB80-0x000000018206BE50
	// [XID] // 0x00000001897A7900-0x00000001897A7920
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018206E010-0x000000018206E720
	// [XID] // 0x00000001897AF370-0x00000001897AF390
	public void BuildWeaponPutAwayAnimStateLookupSet() {} // 0x000000018206DA50-0x000000018206DBF0
	// [XID] // 0x00000001899D80B0-0x00000001899D80D0
	public bool CheckStateIsInPutAwayWhitelist(int shortHash) => default; // 0x000000018206CF80-0x000000018206D050
	[BlackList] // 0x00000001897BF070-0x00000001897BF0B0
	// [XID] // 0x00000001897BF070-0x00000001897BF0B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018206BE50-0x000000018206BEF0
	[BlackList] // 0x00000001897C9640-0x00000001897C9680
	// [XID] // 0x00000001897C9640-0x00000001897C9680
	public virtual void AutoRecycleTypeFields() {} // 0x000000018206BEF0-0x000000018206C2F0
	[BlackList] // 0x00000001897D3C40-0x00000001897D3C80
	// [XID] // 0x00000001897D3C40-0x00000001897D3C80
	public virtual void ReturnToObjectPool() {} // 0x000000018206EC30-0x000000018206ECD0
	[BlackList] // 0x00000001897DE330-0x00000001897DE370
	// [XID] // 0x00000001897DE330-0x00000001897DE370
	public virtual void OnPoolAllocated() {} // 0x000000018206EAF0-0x000000018206EB90
	[BlackList] // 0x00000001897E8CF0-0x00000001897E8D30
	// [XID] // 0x00000001897E8CF0-0x00000001897E8D30
	public virtual void OnBeforePoolRecycled() {} // 0x000000018206EA50-0x000000018206EAF0
}

