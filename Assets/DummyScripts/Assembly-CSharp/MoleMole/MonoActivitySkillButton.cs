/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActivitySkillButton : MonoBaseSkillBtn // TypeDefIndex: 31097
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _reduceEffect; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _fadeInEffect; // 0x150
		private ActivitySkillExcelConfig _skillInfo; // 0x158
		private EntityHandle<BaseEntity> _targetHandle; // 0x160
		private LCAbility _teamAbility; // 0x170
		private bool _fadeIn; // 0x178
		[NonSerialized]
		public bool mainButton; // 0x179
	
		// Constructors
		public MonoActivitySkillButton() {} // 0x00000001852E1300-0x00000001852E13A0
	
		// Methods
		// [XID] // 0x0000000189B15C00-0x0000000189B15C20
		private void OnEnable() {} // 0x00000001852DFF30-0x00000001852E0000
		// [XID] // 0x0000000189B1D310-0x0000000189B1D330
		protected override void OnDestroy() {} // 0x00000001852DFE80-0x00000001852DFF30
		// [XID] // 0x0000000189B24B50-0x0000000189B24B70
		private bool IsStartGuide() => default; // 0x00000001852DEFA0-0x00000001852DF090
		// [XID] // 0x0000000189B2C020-0x0000000189B2C040
		public void SetActivitySkillState(ExtraAbilityState state) {} // 0x00000001852E07B0-0x00000001852E0BF0
		// [XID] // 0x0000000189B33550-0x0000000189B33570
		public void SetupSkillView(AvatarEntity avatar) {} // 0x00000001852E0BF0-0x00000001852E11C0
		// [XID] // 0x0000000189B3AE70-0x0000000189B3AE90
		public bool SetActive(bool active, ActionPanelState state) => default; // 0x00000001852E0690-0x00000001852E07B0
		// [XID] // 0x0000000189B42630-0x0000000189B42650
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x00000001852E0000-0x00000001852E0210
		// [XID] // 0x0000000189B4A0F0-0x0000000189B4A110
		protected override void HandlePointDown() {} // 0x00000001852DFDD0-0x00000001852DFE80
		// [XID] // 0x0000000189B51990-0x0000000189B519B0
		private void OnSkill() {} // 0x00000001852E0350-0x00000001852E0510
		// [XID] // 0x0000000189B59150-0x0000000189B59170
		protected override void Update() {} // 0x00000001852E11C0-0x00000001852E1300
		// [XID] // 0x0000000189B60980-0x0000000189B609A0
		private float GetEnergy() => default; // 0x00000001852DFBE0-0x00000001852DFD30
		// [XID] // 0x0000000189B680D0-0x0000000189B680F0
		private bool IsSkillInCD() => default; // 0x00000001852DE910-0x00000001852DEA20
		// [XID] // 0x0000000189B6F470-0x0000000189B6F490
		private bool CanUseSkill() => default; // 0x00000001852E0510-0x00000001852E0630
		// [XID] // 0x0000000189B76AD0-0x0000000189B76AF0
		private float GetSkillCDRatio() => default; // 0x00000001852DF0F0-0x00000001852DF280
		// [XID] // 0x0000000189B7E080-0x0000000189B7E0A0
		private float GetEnergyRatio() => default; // 0x00000001852DF720-0x00000001852DF800
		// [XID] // 0x0000000189B85C80-0x0000000189B85CA0
		private int GetSkillMaxChargesCount() => default; // 0x00000001852DFD30-0x00000001852DFDD0
		// [XID] // 0x0000000189B8CC70-0x0000000189B8CC90
		private void InitCD() {} // 0x00000001852DF800-0x00000001852DFBE0
		// [XID] // 0x0000000189B944A0-0x0000000189B944C0
		private void UpdateForCD() {} // 0x00000001852DEBB0-0x00000001852DEFA0
		// [XID] // 0x0000000189B9BB90-0x0000000189B9BBB0
		private void UpdateButtonState(bool forceUpdate) {} // 0x00000001852DF280-0x00000001852DF720
		// [XID] // 0x0000000189BA32C0-0x0000000189BA32E0
		private void PlayReduceEffect() {} // 0x00000001852DEA20-0x00000001852DEB50
		// [XID] // 0x0000000189BAA600-0x0000000189BAA620
		private bool PlayFadeInEffect() => default; // 0x00000001852E0210-0x00000001852E0350
	}
}
