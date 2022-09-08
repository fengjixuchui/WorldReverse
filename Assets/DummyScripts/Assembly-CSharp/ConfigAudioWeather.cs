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
public class ConfigAudioWeather : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17637
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _transitionRtpcKey; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dominantStateName; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dominantSwitchName; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dominantRtpcKey; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dominantStateNameWithoutDelay; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dominantRtpcKeyWithoutDelay; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _timeOfDayRtpcKey; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _avatarSpeechEvent; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, AudioWeatherProperties> _weatherStateMap; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioWeatherWorkSet _workset1; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioWeatherWorkSet _workset2; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _nearThunderStart; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _nearThunderEnd; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _distantThunderStart; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _distantThunderEnd; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _worksetSwitchKey; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _windSpeedRtpcKey; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _climateRtpcKey; // 0x98
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioWeatherVoTrigger[] _weatherVoiceTriggers; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private VoiceTriggerIdentity _thunderVoiceTrigger; // 0xA8

	// Properties
	public ConfigWwiseString transitionRtpcKey { /* [XID] */ /* 0x0000000189A02B70-0x0000000189A02B90 */ get => default; /* [XID] */ /* 0x0000000189A0A2A0-0x0000000189A0A2C0 */ private set {} } // 0x0000000185697DD0-0x0000000185697E70 0x0000000185695DA0-0x0000000185695E50
	public ConfigWwiseString dominantStateName { /* [XID] */ /* 0x0000000189A11B80-0x0000000189A11BA0 */ get => default; /* [XID] */ /* 0x0000000189A18DB0-0x0000000189A18DD0 */ private set {} } // 0x0000000185698BC0-0x0000000185698C60 0x0000000185697BC0-0x0000000185697C70
	public ConfigWwiseString dominantSwitchName { /* [XID] */ /* 0x0000000189A204D0-0x0000000189A204F0 */ get => default; /* [XID] */ /* 0x0000000189A27900-0x0000000189A27920 */ private set {} } // 0x0000000185693820-0x00000001856938C0 0x0000000185698200-0x00000001856982B0
	public ConfigWwiseString dominantRtpcKey { /* [XID] */ /* 0x0000000189A2F090-0x0000000189A2F0B0 */ get => default; /* [XID] */ /* 0x0000000189A36A50-0x0000000189A36A70 */ private set {} } // 0x0000000185697300-0x00000001856973A0 0x00000001856959A0-0x0000000185695A50
	public ConfigWwiseString dominantStateNameWithoutDelay { /* [XID] */ /* 0x0000000189A3E0D0-0x0000000189A3E0F0 */ get => default; /* [XID] */ /* 0x0000000189A45820-0x0000000189A45840 */ private set {} } // 0x0000000185695E50-0x0000000185695EF0 0x000000018569A060-0x000000018569A110
	public ConfigWwiseString dominantRtpcKeyWithoutDelay { /* [XID] */ /* 0x0000000189A4CE20-0x0000000189A4CE40 */ get => default; /* [XID] */ /* 0x0000000189A54570-0x0000000189A54590 */ private set {} } // 0x0000000185697B20-0x0000000185697BC0 0x0000000185697D20-0x0000000185697DD0
	public ConfigWwiseString timeOfDayRtpcKey { /* [XID] */ /* 0x0000000189A5C0A0-0x0000000189A5C0C0 */ get => default; /* [XID] */ /* 0x0000000189A63930-0x0000000189A63950 */ private set {} } // 0x0000000185695D00-0x0000000185695DA0 0x0000000185695C50-0x0000000185695D00
	public ConfigWwiseString avatarSpeechEvent { /* [XID] */ /* 0x0000000189A6B1B0-0x0000000189A6B1D0 */ get => default; /* [XID] */ /* 0x0000000189A72A60-0x0000000189A72A80 */ private set {} } // 0x0000000185698910-0x00000001856989B0 0x0000000185698A60-0x0000000185698B10
	public Dictionary<string, AudioWeatherProperties> weatherStateMap { /* [XID] */ /* 0x0000000189A7A530-0x0000000189A7A550 */ get => default; /* [XID] */ /* 0x0000000189A81A10-0x0000000189A81A30 */ private set {} } // 0x0000000185695B00-0x0000000185695BA0 0x00000001856974F0-0x00000001856975A0
	public AudioWeatherWorkSet workset1 { /* [XID] */ /* 0x0000000189A89570-0x0000000189A89590 */ get => default; /* [XID] */ /* 0x0000000189A90D70-0x0000000189A90D90 */ private set {} } // 0x00000001856987C0-0x0000000185698860 0x0000000185698860-0x0000000185698910
	public AudioWeatherWorkSet workset2 { /* [XID] */ /* 0x0000000189A98540-0x0000000189A98560 */ get => default; /* [XID] */ /* 0x0000000189A9F930-0x0000000189A9F950 */ private set {} } // 0x0000000185697260-0x0000000185697300 0x0000000185695EF0-0x0000000185695FA0
	public AudioOneTimeEvent nearThunderStart { /* [XID] */ /* 0x0000000189AA7160-0x0000000189AA7180 */ get => default; /* [XID] */ /* 0x0000000189AAE7E0-0x0000000189AAE800 */ private set {} } // 0x0000000185697A80-0x0000000185697B20 0x0000000185695FA0-0x0000000185696050
	public AudioOneTimeEvent nearThunderEnd { /* [XID] */ /* 0x0000000189AB6080-0x0000000189AB60A0 */ get => default; /* [XID] */ /* 0x0000000189ABDAB0-0x0000000189ABDAD0 */ private set {} } // 0x0000000185698160-0x0000000185698200 0x000000018569A110-0x000000018569A1C0
	public AudioOneTimeEvent distantThunderStart { /* [XID] */ /* 0x0000000189AC5670-0x0000000189AC5690 */ get => default; /* [XID] */ /* 0x0000000189ACCAE0-0x0000000189ACCB00 */ private set {} } // 0x00000001856973A0-0x0000000185697440 0x00000001856975A0-0x0000000185697650
	public AudioOneTimeEvent distantThunderEnd { /* [XID] */ /* 0x0000000189AD48E0-0x0000000189AD4900 */ get => default; /* [XID] */ /* 0x0000000189ADC1E0-0x0000000189ADC200 */ private set {} } // 0x0000000185698B10-0x0000000185698BC0 0x0000000185697E70-0x0000000185697F20
	public ConfigWwiseString worksetSwitchKey { /* [XID] */ /* 0x0000000189AE3BB0-0x0000000189AE3BD0 */ get => default; /* [XID] */ /* 0x0000000189AEB450-0x0000000189AEB470 */ private set {} } // 0x00000001856982B0-0x0000000185698360 0x0000000185697440-0x00000001856974F0
	public ConfigWwiseString windSpeedRtpcKey { /* [XID] */ /* 0x0000000189AF2E10-0x0000000189AF2E30 */ get => default; /* [XID] */ /* 0x0000000189AFA680-0x0000000189AFA6A0 */ private set {} } // 0x0000000185695BA0-0x0000000185695C50 0x0000000185698710-0x00000001856987C0
	public ConfigWwiseString climateRtpcKey { /* [XID] */ /* 0x0000000189B01BD0-0x0000000189B01BF0 */ get => default; /* [XID] */ /* 0x0000000189B091F0-0x0000000189B09210 */ private set {} } // 0x00000001856938C0-0x0000000185693970 0x0000000185695A50-0x0000000185695B00
	public AudioWeatherVoTrigger[] weatherVoiceTriggers { /* [XID] */ /* 0x0000000189B10C10-0x0000000189B10C30 */ get => default; /* [XID] */ /* 0x0000000189B17DE0-0x0000000189B17E00 */ private set {} } // 0x0000000185697650-0x0000000185697700 0x00000001856989B0-0x0000000185698A60
	public VoiceTriggerIdentity thunderVoiceTrigger { /* [XID] */ /* 0x0000000189B1F640-0x0000000189B1F660 */ get => default; /* [XID] */ /* 0x0000000189B26EE0-0x0000000189B26F00 */ private set {} } // 0x0000000185698660-0x0000000185698710 0x0000000185697C70-0x0000000185697D20

	// Constructors
	public ConfigAudioWeather() {} // 0x000000018569A260-0x000000018569A2C0

	// Methods
	// [XID] // 0x0000000189B2E0B0-0x0000000189B2E0D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185699AB0-0x0000000185699F20
	// [XID] // 0x0000000189B35420-0x0000000189B35440
	public void InitEmpty() {} // 0x0000000185697F20-0x0000000185698160
	[BlackList] // 0x0000000189B3CCE0-0x0000000189B3CD20
	// [XID] // 0x0000000189B3CCE0-0x0000000189B3CD20
	public bool FromJson(JSONNode node) => default; // 0x0000000185697700-0x0000000185697A80
	// [XID] // 0x0000000189B479E0-0x0000000189B47A00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185693970-0x0000000185694D40
	// [XID] // 0x0000000189B4F130-0x0000000189B4F150
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75A9 */, bool useObjectPool = false /* Metadata: 0x00AF75AD */) => default; // 0x0000000185698360-0x0000000185698660
	// [XID] // 0x0000000189B56B30-0x0000000189B56B50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75AE */, bool useObjectPool = false /* Metadata: 0x00AF75B2 */) => default; // 0x0000000185696050-0x0000000185697260
	[BlackList] // 0x0000000189B5E360-0x0000000189B5E3A0
	// [XID] // 0x0000000189B5E360-0x0000000189B5E3A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185694D40-0x0000000185695010
	// [XID] // 0x0000000189B689A0-0x0000000189B689C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185698C60-0x0000000185699AB0
	[BlackList] // 0x0000000189B6FEA0-0x0000000189B6FEE0
	// [XID] // 0x0000000189B6FEA0-0x0000000189B6FEE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185695010-0x00000001856950B0
	[BlackList] // 0x0000000189B7A410-0x0000000189B7A450
	// [XID] // 0x0000000189B7A410-0x0000000189B7A450
	public virtual void AutoRecycleTypeFields() {} // 0x00000001856950B0-0x00000001856959A0
	[BlackList] // 0x0000000189B85010-0x0000000189B85050
	// [XID] // 0x0000000189B85010-0x0000000189B85050
	public virtual void ReturnToObjectPool() {} // 0x000000018569A1C0-0x000000018569A260
	[BlackList] // 0x0000000189B8EE70-0x0000000189B8EEB0
	// [XID] // 0x0000000189B8EE70-0x0000000189B8EEB0
	public virtual void OnPoolAllocated() {} // 0x0000000185699FC0-0x000000018569A060
	[BlackList] // 0x0000000189B993A0-0x0000000189B993E0
	// [XID] // 0x0000000189B993A0-0x0000000189B993E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185699F20-0x0000000185699FC0
}

