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
	public class MonoBattleBtn : MonoBaseSkillBtn // TypeDefIndex: 31103
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _arrow; // 0x148
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _touchPlus; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _touchSmall; // 0x158
		private LCAvatarCombat.SkillInfo _skillInfo; // 0x160
		private float _horizontalDragRatio; // 0x168
		private float _verticalDragRatio; // 0x16C
		private LCAvatarCombat avatarCombat; // 0x170
		private LCAbility teamAbility; // 0x178
		private bool _enableDrag; // 0x180
		private bool _showIconArrow; // 0x181
		private bool _focusAttackMode; // 0x182
		private static bool _isSkipFirstDrag; // 0x00
		private bool _skipFirstDrag; // 0x183
		private int _skillIndex; // 0x184
		private bool _canUseByMove; // 0x188
		private string[] cdText; // 0x190
		private Transform _chargeEffect; // 0x198
	
		// Properties
		public bool focusAttackMode { /* [XID] */ /* 0x00000001897846B0-0x00000001897846D0 */ set {} } // 0x00000001848FE980-0x00000001848FEA30
		public static bool isSkipFirstDrag { /* [XID] */ /* 0x000000018978BCE0-0x000000018978BD00 */ get => default; /* [XID] */ /* 0x0000000189793190-0x00000001897931B0 */ set {} } // 0x00000001848FE8B0-0x00000001848FE980 0x00000001848FEA30-0x00000001848FEB00
		private Transform chargeEffect { /* [XID] */ /* 0x0000000189864F50-0x0000000189864F70 */ get => default; } // 0x00000001848FC110-0x00000001848FC220 
	
		// Constructors
		public MonoBattleBtn() {} // 0x00000001848FE7C0-0x00000001848FE8B0
		static MonoBattleBtn() {} // 0x00000001848FE760-0x00000001848FE7C0
	
		// Methods
		// [XID] // 0x000000018979B460-0x000000018979B480
		private void OnEnable() {} // 0x00000001848FD530-0x00000001848FD5E0
		// [XID] // 0x00000001897A2900-0x00000001897A2920
		protected override void OnDestroy() {} // 0x00000001848FD480-0x00000001848FD530
		// [XID] // 0x00000001897A9DE0-0x00000001897A9E00
		public void SetupSkillView(AvatarEntity avatar, int index) {} // 0x00000001848FDF30-0x00000001848FE500
		// [XID] // 0x00000001897B17B0-0x00000001897B17D0
		public bool SetActive(bool active, ActionPanelState state) => default; // 0x00000001848FDD80-0x00000001848FDF30
		// [XID] // 0x00000001897B91E0-0x00000001897B9200
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x00000001848FD730-0x00000001848FD970
		// [XID] // 0x00000001897C1300-0x00000001897C1320
		public bool CanUseSkillByGlobalValue() => default; // 0x00000001848FAB20-0x00000001848FAC10
		// [XID] // 0x00000001897C8D80-0x00000001897C8DA0
		public bool CanUseSkillByMove() => default; // 0x00000001848FAC10-0x00000001848FACC0
		// [XID] // 0x00000001897D03C0-0x00000001897D03E0
		public void RefreshMoveEnable() {} // 0x00000001848FDB40-0x00000001848FDC70
		// [XID] // 0x00000001897D80A0-0x00000001897D80C0
		protected override bool IsGlobalValueEnergyFull(float value) => default; // 0x00000001848FC2E0-0x00000001848FC3C0
		// [XID] // 0x00000001897DF1E0-0x00000001897DF200
		public override void OnPointerUp(PointerEventData eventData) {} // 0x00000001848FD5E0-0x00000001848FD730
		// [XID] // 0x00000001897E6A80-0x00000001897E6AA0
		public override void ResetButton() {} // 0x00000001848FDC70-0x00000001848FDD80
		// [XID] // 0x00000001897EE5B0-0x00000001897EE5D0
		protected override void HandlePointDown() {} // 0x00000001848FD380-0x00000001848FD480
		// [XID] // 0x00000001897F5E40-0x00000001897F5E60
		protected override void HandlePointUp() {} // 0x00000001848FB450-0x00000001848FB510
		// [XID] // 0x00000001897FD5A0-0x00000001897FD5C0
		protected override void HandleDrag(Vector2 delta) {} // 0x00000001848FCC90-0x00000001848FCF80
		// [XID] // 0x0000000189804B20-0x0000000189804B40
		private bool checkIfDuringChangeAvatar() => default; // 0x00000001848FCF80-0x00000001848FD080
		// [XID] // 0x000000018980C130-0x000000018980C150
		private void recordOnSkillTime(uint skillID) {} // 0x00000001848FA8F0-0x00000001848FA9F0
		// [XID] // 0x0000000189813820-0x0000000189813840
		private void OnSkill(uint skillID) {} // 0x00000001848FD970-0x00000001848FDAE0
		// [XID] // 0x000000018981B3D0-0x000000018981B3F0
		private void TryCancelSkill() {} // 0x00000001848FB090-0x00000001848FB150
		// [XID] // 0x00000001898229C0-0x00000001898229E0
		private void OnSkillCancel(uint skillID) {} // 0x00000001848FCB50-0x00000001848FCC90
		// [XID] // 0x000000018982A370-0x000000018982A390
		private void OnDragRotateCharacter(Vector2 delta) {} // 0x00000001848FB1D0-0x00000001848FB450
		// [XID] // 0x0000000189831630-0x0000000189831650
		private void OnDragRotateCamera(Vector2 delta) {} // 0x00000001848FD080-0x00000001848FD290
		// [XID] // 0x0000000189838CE0-0x0000000189838D00
		protected override void Update() {} // 0x00000001848FE610-0x00000001848FE760
		// [XID] // 0x00000001898403C0-0x00000001898403E0
		private void InitCD() {} // 0x00000001848FC3C0-0x00000001848FCAF0
		// [XID] // 0x0000000189847990-0x00000001898479B0
		public string ChangeString(int t, float cd) => default; // 0x00000001848FACC0-0x00000001848FB090
		// [XID] // 0x000000018984F100-0x000000018984F120
		private void UpdateForCD() {} // 0x00000001848FB810-0x00000001848FBFE0
		// [XID] // 0x0000000189856200-0x0000000189856220
		private void UpdateIconArrow() {} // 0x00000001848FB570-0x00000001848FB6E0
		// [XID] // 0x000000018985D5B0-0x000000018985D5D0
		public bool CanUseInAir() => default; // 0x00000001848FAA70-0x00000001848FAB20
		// [XID] // 0x000000018986C550-0x000000018986C570
		public void EnableChargeMaxEffect(bool enable) {} // 0x00000001848FB6E0-0x00000001848FB810
		// [XID] // 0x0000000189873980-0x00000001898739A0
		public float GetGlobalValueEnergy() => default; // 0x00000001848FBFE0-0x00000001848FC110
		// [XID] // 0x000000018987B3D0-0x000000018987B3F0
		public void SwitchTouchGrp(bool bSmall) {} // 0x00000001848FE500-0x00000001848FE610
	}
}
