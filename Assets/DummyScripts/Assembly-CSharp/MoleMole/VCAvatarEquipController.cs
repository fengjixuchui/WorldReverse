/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class VCAvatarEquipController : VCBaseEquipController // TypeDefIndex: 11793
	{
		// Fields
		protected LCAvatarEquipController _lcEquipController; // 0x198
		protected float _autoWeaponHideTime; // 0x1A0
		protected float _autoHideTime; // 0x1A4
		protected bool _enableAutoHideEquip; // 0x1A8
		protected Animator _animator; // 0x1B0
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public ConfigEquipReattach[] equipReattach; // 0x1B8
		protected float _currChangeToNormalStyleTime; // 0x1C0
		protected float CHANGE_TO_NORMAL_STYLE_TIME; // 0x1C4
		private bool _changeOutWithTakingWeaponOnHand; // 0x1C8
		public static bool autoPutawayWeaponSwitch; // 0x00
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		private VCEquipModel[] _vcEquipModelsBuff; // 0x1D0
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x0000000189A37280-0x0000000189A372A0 */ get => default; } // 0x0000000183BE28A0-0x0000000183BE2940 
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool isTakingWeaponOnHand { /* [XID] */ /* 0x0000000189A89D20-0x0000000189A89D60 */ get; /* [XID] */ /* 0x0000000189A94130-0x0000000189A94170 */ private set; } // 0x0000000183BE2840-0x0000000183BE28A0 0x0000000183BE29B0-0x0000000183BE2A20
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool isBindingCutscene { /* [XID] */ /* 0x0000000189A9E7D0-0x0000000189A9E810 */ get; /* [XID] */ /* 0x0000000189AA8DF0-0x0000000189AA8E30 */ private set; } // 0x0000000183BE27E0-0x0000000183BE2840 0x0000000183BE2940-0x0000000183BE29B0
	
		// Constructors
		public VCAvatarEquipController() {} // 0x0000000183BE2700-0x0000000183BE27E0
		static VCAvatarEquipController() {} // 0x0000000183BE26A0-0x0000000183BE2700
	
		// Methods
		// [XID] // 0x0000000189A3E970-0x0000000189A3E990
		public override void Init() {} // 0x0000000183BE0E40-0x0000000183BE1260
		// [XID] // 0x0000000189A46060-0x0000000189A46080
		public override void Destroy() {} // 0x0000000183BE02D0-0x0000000183BE0450
		// [XID] // 0x0000000189A4D7B0-0x0000000189A4D7D0
		public override void InitScale() {} // 0x0000000183BE2470-0x0000000183BE25D0
		// [XID] // 0x0000000189A54FF0-0x0000000189A55010
		protected override void Tick(float inDeltaTime) {} // 0x0000000183BE25D0-0x0000000183BE26A0
		// [XID] // 0x0000000189A5C920-0x0000000189A5C940
		private void UpdateAutoHideEquip(float deltaTime) {} // 0x0000000183BE0760-0x0000000183BE0950
		// [XID] // 0x0000000189A641F0-0x0000000189A64210
		public override void OnEnable() {} // 0x0000000183BE1FF0-0x0000000183BE20A0
		// [XID] // 0x0000000189A6BBA0-0x0000000189A6BBC0
		public void CheckAutoHideEquip() {} // 0x0000000183BE0680-0x0000000183BE0760
		// [XID] // 0x0000000189A180B0-0x0000000189A180D0
		public override void OnDisable() {} // 0x0000000183BE1E60-0x0000000183BE1FF0
		// [XID] // 0x0000000189A7AE50-0x0000000189A7AE70
		protected override string GetAttachPointRealName(string partName) => default; // 0x0000000183BE1C30-0x0000000183BE1E60
		// [XID] // 0x0000000189A823E0-0x0000000189A82400
		protected override bool FollowRotationClosely() => default; // 0x0000000183BE12E0-0x0000000183BE13B0
		// [XID] // 0x0000000189AB39F0-0x0000000189AB3A10
		private void UpdateEquips(float deltaTime) {} // 0x0000000183BE1670-0x0000000183BE1810
		// [XID] // 0x0000000189ABB710-0x0000000189ABB730
		private bool IsInRunWalkIdleMoveTag() => default; // 0x0000000183BE0450-0x0000000183BE0620
		// [XID] // 0x0000000189AC2DD0-0x0000000189AC2DF0
		private void SetPutawayTrigger() {} // 0x0000000183BDFEC0-0x0000000183BE0050
		// [XID] // 0x0000000189ACA440-0x0000000189ACA460
		public void ShowTakingWeaponAndPutOnBack(float? dissolveDelay = default, float? dissolveSpeed = default) {} // 0x0000000183BE20A0-0x0000000183BE2470
		// [XID] // 0x0000000189AD1EC0-0x0000000189AD1EE0
		public void PutOnHandAndShowTakingWeapon(bool showImmediately = true /* Metadata: 0x00AEAB8D */, float? dissolveDelay = default, float? dissolveSpeed = default) {} // 0x0000000183BDFCC0-0x0000000183BDFE60
		// [XID] // 0x0000000189AD9990-0x0000000189AD99B0
		public void HideWeapon(float dissolveDelay, float dissolveSpeed, bool hidePutWeapon) {} // 0x0000000183BE1530-0x0000000183BE1670
		// [XID] // 0x0000000189AA0210-0x0000000189AA0230
		public void BindCutscene() {} // 0x0000000183BE1AD0-0x0000000183BE1C30
		// [XID] // 0x0000000189AAF2F0-0x0000000189AAF310
		public void FreeCutscene() {} // 0x0000000183BE19F0-0x0000000183BE1AD0
		// [XID] // 0x0000000189AF0880-0x0000000189AF08A0
		private void DoShowEquip(ulong guid, bool showImmediately, float? dissolveDelay = default, float? dissolveSpeed = default) {} // 0x0000000183BE09D0-0x0000000183BE0B30
		// [XID] // 0x0000000189613B00-0x0000000189613B20
		protected override void UpdateEquipPartToAttachPoint(float deltaTime, EquipContent equipContent, bool with) {} // 0x0000000183BE00C0-0x0000000183BE01D0
		// [XID] // 0x0000000189AFF430-0x0000000189AFF450
		private void DoHideEquip(ulong guid, float dissolveDelay, float dissolveSpeed) {} // 0x0000000183BE1810-0x0000000183BE1980
		// [XID] // 0x0000000189B06BF0-0x0000000189B06C10
		private void DoHideEquipImmediately(ulong guid, bool showEffect = false /* Metadata: 0x00AEAB8E */) {} // 0x0000000183BE1410-0x0000000183BE1530
		// [XID] // 0x0000000189B0E3F0-0x0000000189B0E410
		private VCEquipModel[] GetEquipModels(ulong guid) => default; // 0x0000000183BE0B30-0x0000000183BE0E40
	}
}
