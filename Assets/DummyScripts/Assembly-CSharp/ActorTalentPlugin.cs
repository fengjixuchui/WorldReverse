/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActorTalentPlugin : BaseComponentPlugin // TypeDefIndex: 11989
{
	// Fields
	private LCTalent _owner; // 0x58
	[InspectorCollapsedFoldout] // 0x0000000189879680-0x00000001898796B0
	[ShowInInspector] // 0x0000000189879680-0x00000001898796B0
	private List<ActorTalent> _talents; // 0x60
	private List<BaseTalentConfig> _reloadedTalents; // 0x68
	private static List<BaseTalentConfig> _talentsToBeAdded; // 0x00
	private static List<BaseTalentConfig> _talentsToBeRemoved; // 0x08
	private static List<string> _abilitiesTemp; // 0x10

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189669130-0x0000000189669150 */ get => default; } // 0x00000001820D2360-0x00000001820D2400 
	public List<BaseTalentConfig> ReloadedTalents { /* [XID] */ /* 0x0000000189670AE0-0x0000000189670B00 */ get => default; } // 0x00000001820CEFA0-0x00000001820CF040 

	// Constructors
	public ActorTalentPlugin() {} // Dummy constructor
	public ActorTalentPlugin(LCTalent lcTalent) {} // 0x00000001820D22C0-0x00000001820D2360
	static ActorTalentPlugin() {} // 0x00000001820D21D0-0x00000001820D22C0

	// Methods
	// [XID] // 0x00000001896783B0-0x00000001896783D0
	public override void Init() {} // 0x00000001820D04E0-0x00000001820D0690
	// [XID] // 0x000000018967FC50-0x000000018967FC70
	public override void Destroy() {} // 0x00000001820CF0A0-0x00000001820CF330
	// [XID] // 0x00000001896872C0-0x00000001896872E0
	public override void OnEnable() {} // 0x00000001820D1CB0-0x00000001820D1F20
	// [XID] // 0x000000018968F070-0x000000018968F090
	public override void OnDisable() {} // 0x00000001820D1A40-0x00000001820D1CB0
	// [XID] // 0x0000000189696B30-0x0000000189696B50
	public bool ReloadTalents(AvatarDataItem avatarData) => default; // 0x00000001820D0CF0-0x00000001820D0EC0
	// [XID] // 0x000000018969E0C0-0x000000018969E0E0
	private bool CheckTalentsChanged(AvatarDataItem avatarData) => default; // 0x00000001820D00A0-0x00000001820D01B0
	// [XID] // 0x00000001896A5130-0x00000001896A5150
	public bool ReloadNecessaryTalents(AvatarDataItem avatarData) => default; // 0x00000001820CEA00-0x00000001820CEC50
	// [XID] // 0x00000001896ACA60-0x00000001896ACA80
	private bool CheckTalentsDifference(AvatarDataItem avatarData, List<BaseTalentConfig> talentsToBeAdded, List<BaseTalentConfig> talentsToBeRemoved) => default; // 0x00000001820CF330-0x00000001820CF4D0
	// [XID] // 0x00000001896B3D30-0x00000001896B3D50
	public OverrideMap CalculateOverrideMap(string abilityName) => default; // 0x00000001820CF4D0-0x00000001820CF9B0
	// [XID] // 0x00000001897C26A0-0x00000001897C26C0
	public bool HasUnlockedTalentParam(string abilityName, string paramName) => default; // 0x00000001820CEC50-0x00000001820CEE40
	// [XID] // 0x00000001898CDE00-0x00000001898CDE20
	private int GetTalentIndex(uint talentSkillID, string talentName) => default; // 0x00000001820CEE40-0x00000001820CEFA0
	// [XID] // 0x00000001896C9B50-0x00000001896C9B70
	private void AddTalents(List<BaseTalentConfig> talents) {} // 0x00000001820D0F30-0x00000001820D12F0
	// [XID] // 0x00000001897157B0-0x00000001897157D0
	private void RemoveAllTalents() {} // 0x00000001820D1F20-0x00000001820D21D0
	// [XID] // 0x000000018987F5D0-0x000000018987F5F0
	private void RemoveTalents(List<BaseTalentConfig> talents) {} // 0x00000001820CF9B0-0x00000001820CFD30
	// [XID] // 0x00000001896E0290-0x00000001896E02B0
	private void MergeAbilitiesOverrideMap(List<BaseTalentConfig> talents) {} // 0x00000001820D12F0-0x00000001820D1A40
	// [XID] // 0x00000001898B0210-0x00000001898B0230
	public void DoAbilitiesOnAdd() {} // 0x00000001820CE440-0x00000001820CE9A0
	// [XID] // 0x00000001898D5770-0x00000001898D5790
	private void CollectAddAbilityTalents(string talentName, List<string> addAbilitiesTemp) {} // 0x00000001820CFD90-0x00000001820D00A0
	// [XID] // 0x00000001896F65A0-0x00000001896F65C0
	private bool CheckAndDoOnAddActions(ActorAbility ability) => default; // 0x00000001820D0690-0x00000001820D0C90
	// [XID] // 0x00000001896FDCD0-0x00000001896FDCF0
	private bool CheckTalentHasUnlockParam(string abilityName, string talentParam, List<BaseTalentConfig> talentsToBeHandled) => default; // 0x00000001820D01B0-0x00000001820D04E0
}

