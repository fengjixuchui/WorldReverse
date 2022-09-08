/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnviroManager : InLevelManager, IWorldShiftAgent // TypeDefIndex: 20817
{
	// Fields
	public const string Weather_Path = "Data/Environment/Weather/"; // Metadata: 0x00AFE4E5
	public const string Skill_Path = "Data/Environment/Weather/SkillTint/"; // Metadata: 0x00AFE502
	public const string DATA_PLATFORM_CONFIG_FOLDER = "Data/Environment/MultiPlatform/"; // Metadata: 0x00AFE529
	public Dictionary<string, string> weatherDict; // 0x10
	private List<EnviroPriv> privList; // 0x18
	private Dictionary<EnviroPriv, List<string>> weatherPrivDict; // 0x20
	private uint _curAreaID; // 0x28
	private string _curWeatherName; // 0x30
	private ClimateType _curClimateType; // 0x38
	public Action postLateUpdateAction; // 0x40
	private EnviroPlatformProfile _platformProfile; // 0x48
	private string _lastEvniroPlatformProfileName; // 0x50
	private static uint _curEvniroPlatformProfileHandle; // 0x00
	private ObjectPoolWithConfigID<GameObject> _windZonePool; // 0x58
	private Dictionary<ElementReactionType, float> _elemEnergyRevivePools; // 0x60
	private Dictionary<ElementReactionType, EntityTimer> _elemEnergyRevivePoolTimers; // 0x68

	// Properties
	public EnviroPlatformProfile platformProfile { /* [XID] */ /* 0x0000000189738810-0x0000000189738830 */ get => default; } // 0x0000000182461A60-0x0000000182461B50 
	public uint curAreaID { /* [XID] */ /* 0x00000001897740C0-0x00000001897740E0 */ get => default; } // 0x0000000182463E10-0x0000000182463EB0 
	public ClimateType curClimateType { /* [XID] */ /* 0x000000018977B840-0x000000018977B860 */ get => default; } // 0x0000000182462000-0x00000001824620A0 
	public string curWeatherName { /* [XID] */ /* 0x00000001897832D0-0x00000001897832F0 */ get => default; } // 0x0000000182462670-0x0000000182462710 

	// Nested types
	public enum EnviroPriv // TypeDefIndex: 20818
	{
		Enviro = 0,
		QuestShow = 1,
		Skill = 2,
		ElementView = 3,
		Cutscene = 4
	}

	// Constructors
	public EnviroManager() {} // 0x0000000182465D00-0x0000000182465E40

	// Methods
	// [XID] // 0x0000000189740550-0x0000000189740570
	public void ResetPlatformConfig() {} // 0x00000001824619C0-0x0000000182461A60
	// [XID] // 0x0000000189747950-0x0000000189747970
	private string GetEnviroPlatformProfileName() => default; // 0x0000000182464BF0-0x0000000182464D90
	// [XID] // 0x000000018974F0F0-0x000000018974F110
	public void InitPlatformConfig() {} // 0x0000000182461910-0x00000001824619C0
	// [XID] // 0x00000001897567C0-0x00000001897567E0
	public void SetPlatformProfile(string name) {} // 0x0000000182461200-0x00000001824615D0
	// [XID] // 0x000000018975DC10-0x000000018975DC30
	public override void LateTick() {} // 0x0000000182463EB0-0x0000000182463FF0
	// [XID] // 0x0000000189765240-0x0000000189765260
	public float GetRandNum() => default; // 0x0000000182461D50-0x0000000182461E00
	// [XID] // 0x000000018976CCE0-0x000000018976CD00
	public float GetWindStrength() => default; // 0x0000000182463A70-0x0000000182463BB0
	// [XID] // 0x000000018978A8C0-0x000000018978A8E0
	public void ResetWeatherConfig() {} // 0x00000001824620A0-0x00000001824622C0
	// [XID] // 0x0000000189791F40-0x0000000189791F60
	public string GetDefaultWeatherName() => default; // 0x00000001824630B0-0x00000001824631C0
	// [XID] // 0x0000000189799630-0x0000000189799650
	public override void Init() {} // 0x0000000182463530-0x0000000182463610
	// [XID] // 0x00000001897A14A0-0x00000001897A14C0
	public override void Destroy() {} // 0x0000000182461BB0-0x0000000182461D50
	// [XID] // 0x00000001897A8C40-0x00000001897A8C60
	public override void Tick() {} // 0x0000000182465BB0-0x0000000182465D00
	// [XID] // 0x00000001897B0520-0x00000001897B0540
	public string GetWeaterByName(string name) => default; // 0x00000001824631C0-0x0000000182463290
	// [XID] // 0x00000001897B8340-0x00000001897B8360
	private string WeatherName2Path(string name) => default; // 0x0000000182463CF0-0x0000000182463E10
	// [XID] // 0x00000001897C03E0-0x00000001897C0400
	public void ResetDefaultProfile(string name) {} // 0x0000000182464D90-0x0000000182464F80
	// [IDTag] // 0x00000001897C7C30-0x00000001897C7C70
	// [XID] // 0x00000001897C7C30-0x00000001897C7C70
	public bool ChangeWeather(ClimateType type, EnviroPriv priv = EnviroPriv.Enviro /* Metadata: 0x00AFE4A2 */, float transTime = -1f /* Metadata: 0x00AFE4A6 */, string fromWeather = null, bool fromServer = false /* Metadata: 0x00AFE4AA */) => default; // 0x0000000182465810-0x00000001824659F0
	// [IDTag] // 0x00000001897D1ED0-0x00000001897D1F10
	// [XID] // 0x00000001897D1ED0-0x00000001897D1F10
	public bool ChangeWeather(string name, EnviroPriv priv = EnviroPriv.Enviro /* Metadata: 0x00AFE4AB */, float transTime = -1f /* Metadata: 0x00AFE4AF */, string fromWeather = null, bool fromServer = false /* Metadata: 0x00AFE4B3 */) => default; // 0x0000000182465460-0x0000000182465810
	// [IDTag] // 0x00000001897DC6D0-0x00000001897DC710
	// [XID] // 0x00000001897DC6D0-0x00000001897DC710
	public bool LeaveWeather(EnviroPriv priv = EnviroPriv.Enviro /* Metadata: 0x00AFE4B4 */, float transTime = -1f /* Metadata: 0x00AFE4B8 */) => default; // 0x0000000182462710-0x0000000182462890
	// [XID] // 0x00000001897E6E70-0x00000001897E6E90
	public string GetWeatherNameByPriv(EnviroPriv priv) => default; // 0x0000000182463900-0x0000000182463A70
	// [IDTag] // 0x00000001897EEB60-0x00000001897EEBA0
	// [XID] // 0x00000001897EEB60-0x00000001897EEBA0
	public bool LeaveWeather(string name, EnviroPriv priv = EnviroPriv.Enviro /* Metadata: 0x00AFE4BC */, float transTime = -1f /* Metadata: 0x00AFE4C0 */, bool fromServer = false /* Metadata: 0x00AFE4C4 */) => default; // 0x0000000182462890-0x0000000182462C70
	// [XID] // 0x00000001897F95B0-0x00000001897F95D0
	public void DelightPlayer(bool enable) {} // 0x0000000182464F80-0x0000000182465070
	// [XID] // 0x0000000189800B10-0x0000000189800B30
	public bool ChangeVolume(string name, int priority = 0 /* Metadata: 0x00AFE4C5 */, float transTime = -1f /* Metadata: 0x00AFE4C9 */, float ratio = 0f /* Metadata: 0x00AFE4CD */) => default; // 0x00000001824633E0-0x0000000182463530
	// [XID] // 0x0000000189808060-0x0000000189808080
	public void RemoveVolume(string name, int priority = 0 /* Metadata: 0x00AFE4D1 */, float transTime = -1f /* Metadata: 0x00AFE4D5 */, float ratio = 0f /* Metadata: 0x00AFE4D9 */) {} // 0x0000000182465290-0x0000000182465460
	// [XID] // 0x000000018980FA70-0x000000018980FA90
	public void UseSkillEffect(string name, float transTime) {} // 0x0000000182463BB0-0x0000000182463CF0
	// [XID] // 0x0000000189817040-0x0000000189817060
	public void PopSkillEffect(string name, float transTime) {} // 0x00000001824637C0-0x0000000182463900
	// [XID] // 0x000000018981E950-0x000000018981E970
	public void Refresh() {} // 0x00000001824610C0-0x0000000182461200
	// [XID] // 0x0000000189825DE0-0x0000000189825E00
	public void NotifyChangeWeatherByAreaId(uint areaid) {} // 0x0000000182462530-0x0000000182462610
	// [XID] // 0x000000018982D540-0x000000018982D560
	public void NotifyChangeWeather(uint areaid, ClimateType type, float duration = -1f /* Metadata: 0x00AFE4DD */) {} // 0x0000000182463FF0-0x00000001824645B0
	// [XID] // 0x0000000189834C70-0x0000000189834C90
	public ConfigWeatherType GetCurWeatherType(out float ratio, out float effectChangeRatio) {
		ratio = default;
		effectChangeRatio = default;
		return default;
	} // 0x00000001824622C0-0x0000000182462530
	// [XID] // 0x000000018983C3F0-0x000000018983C410
	public WindZone AllocateWindZone(uint runtimeID) => default; // 0x00000001824645B0-0x00000001824647F0
	// [XID] // 0x0000000189843980-0x00000001898439A0
	public void DeallocateWindZone(WindZone windObj) {} // 0x0000000182463610-0x00000001824637C0
	// [XID] // 0x000000018984AE50-0x000000018984AE70
	private void TickElementEnergyPool(float inDeltaTime) {} // 0x00000001824615D0-0x0000000182461910
	// [XID] // 0x0000000189852150-0x0000000189852170
	public float CheckElementReactionEnergy(ReactionEnergyExcelConfig config, float energy) => default; // 0x0000000182462DE0-0x00000001824630B0
	// [XID] // 0x0000000189859BB0-0x0000000189859BD0
	public void ReduceElementReactionEnergy(ReactionEnergyExcelConfig config, float energy) {} // 0x0000000182461E00-0x0000000182462000
	// [XID] // 0x0000000189860C70-0x0000000189860C90
	private void ElementEnergyClear() {} // 0x0000000182465070-0x0000000182465290
	// [XID] // 0x0000000189868420-0x0000000189868440
	public void FakeWeatherArea() {} // 0x00000001824647F0-0x0000000182464BF0
	// [XID] // 0x0000000189A55400-0x0000000189A55420
	public bool SetCurrentScreenEffect(int index, float initial_intensity = 1f /* Metadata: 0x00AFE4E1 */) => default; // 0x0000000182462C70-0x0000000182462DE0
	// [XID] // 0x0000000189876ED0-0x0000000189876EF0
	public void SetScreenEffectIntensity(float intensity) {} // 0x0000000182463290-0x00000001824633E0
	// [XID] // 0x000000018987E940-0x000000018987E960
	public bool ShiftWorld(Vector3 offset, Vector3 oldOffset) => default; // 0x00000001824659F0-0x0000000182465BB0
}

