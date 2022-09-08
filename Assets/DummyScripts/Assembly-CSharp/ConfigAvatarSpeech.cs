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
public class ConfigAvatarSpeech : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17644
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AvatarSpeechEquipObtain[] _suitableEquipObtain; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AvatarSpeechEquipObtain[] _unsuitableEquipObtain; // 0x18
	private string _eventCommonPrefix; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _externalVoiceEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _personSwitchKey; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _positioningSwitchKey; // 0x38
	private Dictionary<string, string> _personSwitchValueMap; // 0x40
	private Dictionary<string, string> _positioningSwitchValueMap; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private VoiceSound[] _externalSoundNames; // 0x50
	private SimpleSafeFloat defaultNarrationIntervalRawNum; // 0x58
	private SimpleSafeFloat defaultNarrationDurationRawNum; // 0x5C
	private SimpleSafeUInt32 gachaVoiceTriggerParamRawNum; // 0x60
	private SimpleSafeUInt32 joinTeamVoiceTriggerParamRawNum; // 0x64
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeUInt32, VoiceTriggerIdentity> _fetterVoiceTriggerMap; // 0x68
	private SimpleSafeFloat teammateLowHPVo_hpRatioRawNum; // 0x70
	private SimpleSafeUInt32 teammateLowHPVo_cooldownRawNum; // 0x74
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private VoiceTriggerIdentity _teammateLowHPVo_voTrigger; // 0x78
	private EnumToHash _personalitySwitch; // 0x80
	private EnumToHash _positioningSwitch; // 0x88
	private Dictionary<VoiceOutputMethod, ConfigWwiseString> _externalSounds; // 0x90

	// Properties
	public AvatarSpeechEquipObtain[] suitableEquipObtain { /* [XID] */ /* 0x000000018975DFB0-0x000000018975DFD0 */ get => default; /* [XID] */ /* 0x0000000189765730-0x0000000189765750 */ private set {} } // 0x000000018593FB30-0x000000018593FBD0 0x00000001859415E0-0x0000000185941690
	public AvatarSpeechEquipObtain[] unsuitableEquipObtain { /* [XID] */ /* 0x000000018976CFC0-0x000000018976CFE0 */ get => default; /* [XID] */ /* 0x0000000189774490-0x00000001897744B0 */ private set {} } // 0x000000018593DF00-0x000000018593DFA0 0x0000000185941810-0x00000001859418C0
	public string eventCommonPrefix { /* [XID] */ /* 0x000000018977BDE0-0x000000018977BE00 */ get => default; /* [XID] */ /* 0x0000000189783730-0x0000000189783750 */ private set {} } // 0x0000000185942340-0x00000001859423E0 0x00000001859421C0-0x0000000185942270
	public ConfigWwiseString externalVoiceEvent { /* [XID] */ /* 0x000000018978AE40-0x000000018978AE60 */ get => default; /* [XID] */ /* 0x0000000189792400-0x0000000189792420 */ private set {} } // 0x0000000185941AE0-0x0000000185941B80 0x0000000185943330-0x00000001859433E0
	public ConfigWwiseString personSwitchKey { /* [XID] */ /* 0x00000001897999D0-0x00000001897999F0 */ get => default; /* [XID] */ /* 0x00000001897A18C0-0x00000001897A18E0 */ private set {} } // 0x0000000185943960-0x0000000185943A00 0x00000001859433E0-0x0000000185943490
	public ConfigWwiseString positioningSwitchKey { /* [XID] */ /* 0x00000001897A90E0-0x00000001897A9100 */ get => default; /* [XID] */ /* 0x00000001897B0940-0x00000001897B0960 */ private set {} } // 0x000000018593DD90-0x000000018593DE30 0x0000000185941CD0-0x0000000185941D80
	public Dictionary<string, string> personSwitchValueMap { /* [XID] */ /* 0x00000001897B86E0-0x00000001897B8700 */ get => default; /* [XID] */ /* 0x00000001897C0720-0x00000001897C0740 */ private set {} } // 0x0000000185943AA0-0x0000000185943B40 0x000000018593FCB0-0x000000018593FD60
	public Dictionary<string, string> positioningSwitchValueMap { /* [XID] */ /* 0x00000001897C7FB0-0x00000001897C7FD0 */ get => default; /* [XID] */ /* 0x00000001897CF310-0x00000001897CF330 */ private set {} } // 0x00000001859413B0-0x0000000185941450 0x000000018593F9A0-0x000000018593FA50
	public VoiceSound[] externalSoundNames { /* [XID] */ /* 0x00000001897D6BC0-0x00000001897D6BE0 */ get => default; /* [XID] */ /* 0x00000001897DE2D0-0x00000001897DE2F0 */ private set {} } // 0x0000000185943A00-0x0000000185943AA0 0x0000000185941690-0x0000000185941740
	public float defaultNarrationInterval { /* [XID] */ /* 0x00000001897E5D90-0x00000001897E5DB0 */ get => default; /* [XID] */ /* 0x00000001897ED790-0x00000001897ED7B0 */ private set {} } // 0x0000000185940BB0-0x0000000185940C90 0x000000018593FBD0-0x000000018593FCB0
	public float defaultNarrationDuration { /* [XID] */ /* 0x00000001897F5030-0x00000001897F5050 */ get => default; /* [XID] */ /* 0x00000001897FCAC0-0x00000001897FCAE0 */ private set {} } // 0x00000001859412D0-0x00000001859413B0 0x0000000185941500-0x00000001859415E0
	public uint gachaVoiceTriggerParam { /* [XID] */ /* 0x0000000189803FD0-0x0000000189803FF0 */ get => default; /* [XID] */ /* 0x000000018980B380-0x000000018980B3A0 */ private set {} } // 0x000000018593DE30-0x000000018593DF00 0x0000000185940AD0-0x0000000185940BB0
	public uint joinTeamVoiceTriggerParam { /* [XID] */ /* 0x0000000189812AA0-0x0000000189812AC0 */ get => default; /* [XID] */ /* 0x000000018981A640-0x000000018981A660 */ private set {} } // 0x0000000185942270-0x0000000185942340 0x000000018593FA50-0x000000018593FB30
	public Dictionary<SimpleSafeUInt32, VoiceTriggerIdentity> fetterVoiceTriggerMap { /* [XID] */ /* 0x0000000189821E10-0x0000000189821E30 */ get => default; /* [XID] */ /* 0x0000000189829250-0x0000000189829270 */ private set {} } // 0x0000000185943BE0-0x0000000185943C80 0x0000000185941450-0x0000000185941500
	public float teammateLowHPVo_hpRatio { /* [XID] */ /* 0x0000000189830960-0x0000000189830980 */ get => default; /* [XID] */ /* 0x0000000189837FA0-0x0000000189837FC0 */ private set {} } // 0x000000018593F8C0-0x000000018593F9A0 0x00000001859423E0-0x00000001859424C0
	public uint teammateLowHPVo_cooldown { /* [XID] */ /* 0x000000018983F710-0x000000018983F730 */ get => default; /* [XID] */ /* 0x0000000189846D70-0x0000000189846D90 */ private set {} } // 0x0000000185940C90-0x0000000185940D60 0x000000018593F7E0-0x000000018593F8C0
	public VoiceTriggerIdentity teammateLowHPVo_voTrigger { /* [XID] */ /* 0x000000018984E320-0x000000018984E340 */ get => default; /* [XID] */ /* 0x00000001898554F0-0x0000000189855510 */ private set {} } // 0x0000000185943B40-0x0000000185943BE0 0x00000001859438B0-0x0000000185943960

	// Constructors
	public ConfigAvatarSpeech() {} // 0x0000000185943D20-0x0000000185943D80

	// Methods
	// [XID] // 0x000000018985CAB0-0x000000018985CAD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185943490-0x0000000185943770
	// [XID] // 0x00000001898643D0-0x00000001898643F0
	public void InitEmpty() {} // 0x00000001859418C0-0x0000000185941AE0
	[BlackList] // 0x000000018986B880-0x000000018986B8C0
	// [XID] // 0x000000018986B880-0x000000018986B8C0
	public bool FromJson(JSONNode node) => default; // 0x0000000185940F50-0x00000001859412D0
	// [XID] // 0x0000000189875CE0-0x0000000189875D00
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018593DFA0-0x000000018593F0F0
	// [XID] // 0x000000018987D8A0-0x000000018987D8C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75E7 */, bool useObjectPool = false /* Metadata: 0x00AF75EB */) => default; // 0x0000000185941D80-0x0000000185942080
	// [XID] // 0x0000000189884790-0x00000001898847B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75EC */, bool useObjectPool = false /* Metadata: 0x00AF75F0 */) => default; // 0x000000018593FD60-0x0000000185940AD0
	[BlackList] // 0x000000018988BDE0-0x000000018988BE20
	// [XID] // 0x000000018988BDE0-0x000000018988BE20
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018593F0F0-0x000000018593F3C0
	// [XID] // 0x00000001898960C0-0x00000001898960E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001859426E0-0x0000000185943330
	// [XID] // 0x000000018989D6C0-0x000000018989D6E0
	public void SetupPersonSwitch() {} // 0x00000001859424C0-0x0000000185942610
	// [XID] // 0x00000001898A50C0-0x00000001898A50E0
	public void SetupPositioningSwitch() {} // 0x0000000185941B80-0x0000000185941CD0
	// [XID] // 0x00000001898AC520-0x00000001898AC540
	public void BuildExternalSoundLookupTable() {} // 0x0000000185940D60-0x0000000185940F50
	// [XID] // 0x00000001898B3AE0-0x00000001898B3B00
	public uint GetPersonSwitchValue(VoicePersonality personality) => default; // 0x0000000185942610-0x00000001859426E0
	// [XID] // 0x00000001898BB890-0x00000001898BB8B0
	public uint GetPositioningSwitchValue(VoicePositioning positioning) => default; // 0x0000000185941740-0x0000000185941810
	// [XID] // 0x0000000189A4AA90-0x0000000189A4AAB0
	public uint GetExternalSoundCookie(VoicePersonality personality, VoicePositioning positioning) => default; // 0x0000000185942080-0x00000001859421C0
	[BlackList] // 0x00000001898CA4C0-0x00000001898CA500
	// [XID] // 0x00000001898CA4C0-0x00000001898CA500
	public virtual void AutoAllocTypeFields() {} // 0x000000018593F3C0-0x000000018593F460
	[BlackList] // 0x00000001898D4CD0-0x00000001898D4D10
	// [XID] // 0x00000001898D4CD0-0x00000001898D4D10
	public virtual void AutoRecycleTypeFields() {} // 0x000000018593F460-0x000000018593F7E0
	[BlackList] // 0x00000001898DFA60-0x00000001898DFAA0
	// [XID] // 0x00000001898DFA60-0x00000001898DFAA0
	public virtual void ReturnToObjectPool() {} // 0x0000000185943C80-0x0000000185943D20
	[BlackList] // 0x00000001898EA670-0x00000001898EA6B0
	// [XID] // 0x00000001898EA670-0x00000001898EA6B0
	public virtual void OnPoolAllocated() {} // 0x0000000185943810-0x00000001859438B0
	[BlackList] // 0x00000001898F4CE0-0x00000001898F4D20
	// [XID] // 0x00000001898F4CE0-0x00000001898F4D20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185943770-0x0000000185943810
}

