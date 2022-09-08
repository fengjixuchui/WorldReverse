/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMPTeamBtn : MonoSpriteProxy // TypeDefIndex: 31084
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _markIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _firstAvatarIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _secondAvatarGrp; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _secondAvatarIcon; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private SmoothMask _hpBar; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpColor; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoColorExchange _hpBgColor; // 0x60
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _energySkillGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _energySkillEffectPlugin; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _energySkillFill; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _energySkillHalo; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _energySkillHaloBlur; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _prefabPlugin; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _rtt; // 0x98
		[NonSerialized]
		public uint uid; // 0xA0
		[NonSerialized]
		public ulong firstAvatarGuid; // 0xA8
		[NonSerialized]
		public ulong secondAvatarGuid; // 0xB0
		public MonoInLevelBuffInfo buffInfo; // 0xB8
		private Transform _stateBonus; // 0xC0
		private bool _HideEnergySkill; // 0xC8
		private AvatarEntity _entity; // 0xD0
		private Animation _restoreHP; // 0xD8
		private MonoUIEffect _restoreHPEffect; // 0xE0
		private MonoMPGalleryInfo _galleryInfo; // 0xE8
		private Transform _hideAndSeekInfo; // 0xF0
	
		// Properties
		public bool showStateBonus { /* [XID] */ /* 0x0000000189A0C770-0x0000000189A0C790 */ set {} } // 0x0000000182F0F880-0x0000000182F0FA10
		public Sprite markIcon { /* [XID] */ /* 0x0000000189A22C70-0x0000000189A22C90 */ set {} } // 0x0000000182F0F2A0-0x0000000182F0F360
		public string playerName { /* [XID] */ /* 0x0000000189A29F00-0x0000000189A29F20 */ set {} } // 0x0000000182F0F360-0x0000000182F0F430
		public Sprite firstAvatarIcon { /* [XID] */ /* 0x0000000189A31440-0x0000000189A31460 */ set {} } // 0x0000000182F0F090-0x0000000182F0F150
		public UnityEngine.Material firstAvatarIconMaterial { /* [XID] */ /* 0x0000000189A38F10-0x0000000189A38F30 */ set {} } // 0x0000000182F0EFC0-0x0000000182F0F090
		public bool showSecondAvatarGrp { /* [XID] */ /* 0x0000000189A40670-0x0000000189A40690 */ set {} } // 0x0000000182F0F7A0-0x0000000182F0F880
		public Sprite secondAvatarIcon { /* [XID] */ /* 0x0000000189A47D70-0x0000000189A47D90 */ set {} } // 0x0000000182F0F500-0x0000000182F0F5C0
		public UnityEngine.Material secondAvatarIconMaterial { /* [XID] */ /* 0x0000000189A4F4D0-0x0000000189A4F4F0 */ set {} } // 0x0000000182F0F430-0x0000000182F0F500
		public bool showEnergySkillGrp { /* [XID] */ /* 0x0000000189A56C30-0x0000000189A56C50 */ set {} } // 0x0000000182F0F5C0-0x0000000182F0F6C0
		public Color energySkillColor { /* [XID] */ /* 0x0000000189A5E740-0x0000000189A5E760 */ set {} } // 0x0000000182F0EE80-0x0000000182F0EFC0
		public ElementType elementType { /* [XID] */ /* 0x0000000189A65F00-0x0000000189A65F20 */ set {} } // 0x0000000182F0ECA0-0x0000000182F0EE80
		public float hpRatio { /* [XID] */ /* 0x0000000189A6D550-0x0000000189A6D570 */ set {} } // 0x0000000182F0F150-0x0000000182F0F2A0
		public Image rttIcon { /* [XID] */ /* 0x0000000189A74CD0-0x0000000189A74CF0 */ get => default; } // 0x0000000182F0EBF0-0x0000000182F0ECA0 
		public bool showRestoreHPGrp { /* [XID] */ /* 0x0000000189A960D0-0x0000000189A960F0 */ set {} } // 0x0000000182F0F6C0-0x0000000182F0F7A0
		public MonoMPGalleryInfo galleryInfo { /* [XID] */ /* 0x0000000189AA4E60-0x0000000189AA4E80 */ get => default; } // 0x0000000182F0EA90-0x0000000182F0EB40 
		public Transform hideAndSeekInfo { /* [XID] */ /* 0x0000000189ABBC50-0x0000000189ABBC70 */ get => default; } // 0x0000000182F0EB40-0x0000000182F0EBF0 
	
		// Constructors
		public MonoMPTeamBtn() {} // 0x0000000182F0E9A0-0x0000000182F0EA90
	
		// Methods
		// [XID] // 0x0000000189A14140-0x0000000189A14160
		public void SkipFadeIn() {} // 0x0000000182F0E000-0x0000000182F0E0E0
		// [XID] // 0x0000000189A1B370-0x0000000189A1B390
		public void Reset() {} // 0x0000000182F0DF60-0x0000000182F0E000
		// [XID] // 0x0000000189A7C900-0x0000000189A7C920
		public void InitEnergyColor() {} // 0x0000000182F0DC10-0x0000000182F0DE50
		[DebuggerHidden] // 0x0000000189A84190-0x0000000189A841D0
		// [XID] // 0x0000000189A84190-0x0000000189A841D0
		private IEnumerator EnergySkillCheck() => default; // 0x0000000182F0DE50-0x0000000182F0DF60
		// [XID] // 0x0000000189A8EAA0-0x0000000189A8EAC0
		public void TryCreateRestoreHP() {} // 0x0000000182F0E3A0-0x0000000182F0E4F0
		// [XID] // 0x0000000189A9D620-0x0000000189A9D640
		public void TriggerRestoreHPEffect() {} // 0x0000000182F0E0E0-0x0000000182F0E220
		// [XID] // 0x0000000189AAC6F0-0x0000000189AAC710
		public void TryCreateGalleryInfo() {} // 0x0000000182F0E220-0x0000000182F0E3A0
		// [XID] // 0x0000000189AB3EF0-0x0000000189AB3F10
		public void TryHideGalleryInfo() {} // 0x0000000182F0E4F0-0x0000000182F0E610
		// [XID] // 0x0000000189AC33C0-0x0000000189AC33E0
		public void TryShowHideAndSeekInfo(bool isHunter, bool isCatch) {} // 0x0000000182F0E730-0x0000000182F0E9A0
		// [XID] // 0x0000000189ACAAE0-0x0000000189ACAB00
		public void TryRemoveHideAndSeekInfo() {} // 0x0000000182F0E610-0x0000000182F0E730
	}
}
