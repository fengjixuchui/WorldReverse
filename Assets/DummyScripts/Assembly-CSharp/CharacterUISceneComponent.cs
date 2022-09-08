/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CharacterUISceneComponent : LegacyUISceneComponent // TypeDefIndex: 28540
{
	// Constructors
	public CharacterUISceneComponent() {} // 0x0000000184E5EA50-0x0000000184E5EAB0

	// Methods
	// [XID] // 0x000000018979B640-0x000000018979B660
	public void UnloadAvatar() {} // 0x0000000184E5D600-0x0000000184E5D6B0
	// [XID] // 0x00000001897A2AE0-0x00000001897A2B00
	public MonoSceneUISetup.SceneUiState GetSceneState() => default; // 0x0000000184E5D760-0x0000000184E5D810
	// [XID] // 0x00000001897AA100-0x00000001897AA120
	public MonoSceneUISetup.ShowType GetSceneUIType() => default; // 0x0000000184E5E830-0x0000000184E5E8E0
	// [XID] // 0x00000001897B1A90-0x00000001897B1AB0
	public MonoSceneUISetup.ShowSubType GetSceneUISubType() => default; // 0x0000000184E5D810-0x0000000184E5D8C0
	// [XID] // 0x00000001897B94F0-0x00000001897B9510
	public void ZoomCamera(float value) {} // 0x0000000184E5D3B0-0x0000000184E5D470
	// [XID] // 0x00000001897C1500-0x00000001897C1520
	public void RotateModelByDelta(float x, float y) {} // 0x0000000184E5E5C0-0x0000000184E5E6A0
	// [XID] // 0x00000001897C8F60-0x00000001897C8F80
	public void SelectNearestRelicSlot(bool value) {} // 0x0000000184E5E6A0-0x0000000184E5E770
	// [XID] // 0x00000001897D05C0-0x00000001897D05E0
	public bool OnRelicSelectBtnClick(bool value) => default; // 0x0000000184E5E2C0-0x0000000184E5E390
	// [XID] // 0x00000001897D8360-0x00000001897D8380
	public void SetCurrCameraByAvatarCamera() {} // 0x0000000184E5DD60-0x0000000184E5DE10
	// [XID] // 0x00000001897DF3A0-0x00000001897DF3C0
	public void FadeInOrOutTalentBg(bool value) {} // 0x0000000184E5D470-0x0000000184E5D540
	// [XID] // 0x00000001897E6C60-0x00000001897E6C80
	public void CanShowLevelText(bool value) {} // 0x0000000184E5DED0-0x0000000184E5DFA0
	// [XID] // 0x00000001897EE8F0-0x00000001897EE910
	public void PreSetupAvatar() {} // 0x0000000184E5E9A0-0x0000000184E5EA50
	// [XID] // 0x00000001897F6040-0x00000001897F6060
	public void ShowAvatarOld() {} // 0x0000000184E5DCB0-0x0000000184E5DD60
	// [XID] // 0x00000001897FD720-0x00000001897FD740
	public void ResetIdleTriggerTimerForPreview() {} // 0x0000000184E5D6B0-0x0000000184E5D760
	// [XID] // 0x0000000189804D80-0x0000000189804DA0
	public void DoShowAvatarTab(MonoSceneUISetup.ShowSubType type) {} // 0x0000000184E5E770-0x0000000184E5E830
	// [XID] // 0x000000018980C330-0x000000018980C350
	public bool IsManekinEntityReady() => default; // 0x0000000184E5E440-0x0000000184E5E4F0
	// [XID] // 0x0000000189813B20-0x0000000189813B40
	public void MoveStoryAndVoiceCam(bool value) {} // 0x0000000184E5E4F0-0x0000000184E5E5C0
	// [XID] // 0x000000018981B690-0x000000018981B6B0
	public void BackRelicDetail() {} // 0x0000000184E5D8C0-0x0000000184E5D970
	// [XID] // 0x0000000189822C80-0x0000000189822CA0
	public void TurnToRelic(EquipType type) {} // 0x0000000184E5DE10-0x0000000184E5DED0
	// [XID] // 0x000000018982A5B0-0x000000018982A5D0
	public void ChangeRelic(ReliquaryItem relicItem, EquipType equipType, bool changeSkybox = true /* Metadata: 0x00B0D8FA */) {} // 0x0000000184E5E050-0x0000000184E5E150
	// [XID] // 0x0000000189831920-0x0000000189831940
	public void RefreshRelicRotation() {} // 0x0000000184E5E390-0x0000000184E5E440
	// [XID] // 0x0000000189839020-0x0000000189839040
	public void PlaySelectRelicClickEffect() {} // 0x0000000184E5DFA0-0x0000000184E5E050
	// [XID] // 0x00000001898406A0-0x00000001898406C0
	public void SetTalentStarMaxEffect(int index, ElementType elemType) {} // 0x0000000184E5D970-0x0000000184E5DA50
	// [XID] // 0x0000000189847B90-0x0000000189847BB0
	public void SetTalentStarLinesColor(int index, bool isUnlock) {} // 0x0000000184E5DBD0-0x0000000184E5DCB0
	// [XID] // 0x000000018984F360-0x000000018984F380
	public void MoveTalentCameraToStar(int index) {} // 0x0000000184E5E8E0-0x0000000184E5E9A0
	// [XID] // 0x00000001898564E0-0x0000000189856500
	public void BackTalentCameraToDefault() {} // 0x0000000184E5E210-0x0000000184E5E2C0
	// [XID] // 0x000000018985D870-0x000000018985D890
	public void PlayTalentLevelUpEffect(int index) {} // 0x0000000184E5E150-0x0000000184E5E210
	// [XID] // 0x0000000189865230-0x0000000189865250
	public void MoveWeaponReplaceCam(bool toOrBack) {} // 0x0000000184E5DA50-0x0000000184E5DB20
	// [XID] // 0x000000018986C770-0x000000018986C790
	public void ShowSelectWeapon(WeaponItem item) {} // 0x0000000184E5D540-0x0000000184E5D600
	// [XID] // 0x0000000189873B80-0x0000000189873BA0
	public void RefreshModelWeapon() {} // 0x0000000184E5DB20-0x0000000184E5DBD0
}

