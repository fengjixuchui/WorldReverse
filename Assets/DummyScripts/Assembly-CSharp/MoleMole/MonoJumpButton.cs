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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJumpButton : MonoActionBtn // TypeDefIndex: 31104
	{
		// Fields
		public Image image; // 0x58
		private VCHumanoidMove _move; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _jumpIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _downIcon; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _swimIcon; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _uiEffect; // 0x88
	
		// Constructors
		public MonoJumpButton() {} // 0x0000000183F91D70-0x0000000183F91E00
	
		// Methods
		// [XID] // 0x00000001898A7440-0x00000001898A7460
		protected override void OnDestroy() {} // 0x0000000183F914A0-0x0000000183F91550
		// [XID] // 0x00000001898AEE00-0x00000001898AEE20
		public void Setup(AvatarEntity avatar) {} // 0x0000000183F91860-0x0000000183F91950
		// [XID] // 0x00000001898B6210-0x00000001898B6230
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x0000000183F91550-0x0000000183F91610
		// [XID] // 0x00000001898BDAA0-0x00000001898BDAC0
		private bool OnJumpButtonDown() => default; // 0x0000000183F91280-0x0000000183F91380
		// [XID] // 0x00000001898C5380-0x00000001898C53A0
		private void GetVCHumanoidMove() {} // 0x0000000183F91380-0x0000000183F914A0
		// [XID] // 0x00000001898CC850-0x00000001898CC870
		protected override void Update() {} // 0x0000000183F91B70-0x0000000183F91D70
		// [XID] // 0x00000001898D4320-0x00000001898D4340
		public void ToJumpIcon() {} // 0x0000000183F91A00-0x0000000183F91AB0
		// [XID] // 0x00000001898DBAB0-0x00000001898DBAD0
		public void ToDownIcon() {} // 0x0000000183F91950-0x0000000183F91A00
		// [XID] // 0x00000001898E36E0-0x00000001898E3700
		public void ToSwimIcon() {} // 0x0000000183F91AB0-0x0000000183F91B70
		// [XID] // 0x00000001898EB380-0x00000001898EB3A0
		public void PlayEffect(bool enable) {} // 0x0000000183F91610-0x0000000183F91740
		// [XID] // 0x00000001898F2A80-0x00000001898F2AA0
		public void CreateJumpEffect() {} // 0x0000000183F910C0-0x0000000183F911C0
		// [XID] // 0x00000001898FA210-0x00000001898FA230
		public void SetActive(bool active, ActionPanelState state) {} // 0x0000000183F91740-0x0000000183F91860
		// [XID] // 0x0000000189901BE0-0x0000000189901C00
		private void SetBtnStyle(ActionPanelState state) {} // 0x0000000183F91000-0x0000000183F910C0
	}
}
