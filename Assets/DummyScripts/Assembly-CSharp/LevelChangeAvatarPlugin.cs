/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelChangeAvatarPlugin : BaseComponentPlugin // TypeDefIndex: 12061
{
	// Fields
	public static int MAX_SUPPORT_NUM; // 0x00
	public Vector3 lastValidAvatarPos; // 0x58

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896B20D0-0x00000001896B20F0 */ get => default; } // 0x00000001811EE470-0x00000001811EE510 

	// Constructors
	public LevelChangeAvatarPlugin() {} // 0x00000001811EE3D0-0x00000001811EE470
	static LevelChangeAvatarPlugin() {} // 0x00000001811EE370-0x00000001811EE3D0

	// Methods
	// [XID] // 0x00000001896B9B20-0x00000001896B9B40
	public override void Init() {} // 0x00000001811ECC50-0x00000001811ECCF0
	// [XID] // 0x00000001896C0F00-0x00000001896C0F20
	public override void Destroy() {} // 0x00000001811EC410-0x00000001811EC4B0
	// [XID] // 0x00000001896C84A0-0x00000001896C84C0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001811EC5A0-0x00000001811EC680
	// [XID] // 0x00000001896CFE50-0x00000001896CFE70
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001811EE230-0x00000001811EE370
	// [XID] // 0x00000001896D71E0-0x00000001896D7200
	public void ChangeAuthorityAvatar(uint selectEntityId, uint chargeSkillID, VisionType type) {} // 0x00000001811ECD50-0x00000001811ECF10
	// [XID] // 0x00000001896DEAD0-0x00000001896DEAF0
	private void AvatarAuthorityChangeInLevel(AvatarEntity changeEntity, uint chargeSkillID, VisionType type) {} // 0x00000001811ED000-0x00000001811EDF80
	// [XID] // 0x00000001896E5D80-0x00000001896E5DA0
	private void ShowAvatarEffect(AvatarEntity avatarEntity, LCAvatarCombat lcAvatarCombat) {} // 0x00000001811EDF80-0x00000001811EE230
	// [XID] // 0x00000001896ED350-0x00000001896ED370
	public void ChangeRemoteAvatar(uint selectEntityId, uint userId, uint chargeSkillID, VisionType type) {} // 0x00000001811EC220-0x00000001811EC410
	// [XID] // 0x00000001896F4C80-0x00000001896F4CA0
	private void AvatarRemoteChangeInLevel(AvatarEntity changeEntity, uint uid, uint chargeSkillID, VisionType type) {} // 0x00000001811EC680-0x00000001811ECC50
	// [XID] // 0x00000001896FC3D0-0x00000001896FC3F0
	private void EntityDisappearEntityReadyPost(EvtEntityReadyPost evt) {} // 0x00000001811EC4B0-0x00000001811EC5A0
}

