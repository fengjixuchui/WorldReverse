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
	public class MonoSprintButton : MonoActionBtn // TypeDefIndex: 31113
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _image; // 0x58
		private VCHumanoidMove _move; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _sprintIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite _swimIcon; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGrp; // 0x80
		private bool _isSprinting; // 0x88
		public bool enableDrag; // 0x89
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _horizontalDragRatio; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _verticalDragRatio; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _effect; // 0x98
		private float _clickTime; // 0xA0
		private bool _pressCached; // 0xA4
		private PointerEventData _fakePointerEvent; // 0xA8
	
		// Properties
		public bool sprintSet { /* [XID] */ /* 0x0000000189739960-0x0000000189739980 */ get => default; } // 0x0000000184FFDA10-0x0000000184FFDAC0 
		public bool pressCached { /* [XID] */ /* 0x00000001897414D0-0x00000001897414F0 */ get => default; } // 0x0000000184FFD940-0x0000000184FFDA10 
	
		// Constructors
		public MonoSprintButton() {} // 0x0000000184FFD890-0x0000000184FFD940
	
		// Methods
		// [XID] // 0x0000000189748E00-0x0000000189748E20
		protected override void OnDestroy() {} // 0x0000000184FFCB70-0x0000000184FFCC20
		// [XID] // 0x0000000189750290-0x00000001897502B0
		private new void OnDisable() {} // 0x0000000184FFCC20-0x0000000184FFCCC0
		// [XID] // 0x0000000189757870-0x0000000189757890
		private void OnEnable() {} // 0x0000000184FFCCC0-0x0000000184FFCD60
		// [XID] // 0x000000018975F250-0x000000018975F270
		public void Setup(AvatarEntity avatar) {} // 0x0000000184FFD3C0-0x0000000184FFD520
		// [XID] // 0x0000000189766670-0x0000000189766690
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x0000000184FFCE70-0x0000000184FFCFB0
		// [XID] // 0x000000018976DD10-0x000000018976DD30
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000184FFCD60-0x0000000184FFCE70
		// [XID] // 0x0000000189775420-0x0000000189775440
		public void ManualInterrupt() {} // 0x0000000184FFC780-0x0000000184FFC8A0
		// [XID] // 0x000000018977CC90-0x000000018977CCB0
		public void PlayEffect() {} // 0x0000000184FFCFB0-0x0000000184FFD0A0
		// [XID] // 0x0000000189784690-0x00000001897846B0
		public void RefreshEnable() {} // 0x0000000184FFD0A0-0x0000000184FFD2A0
		// [XID] // 0x000000018978BCC0-0x000000018978BCE0
		private void ToggleSprint() {} // 0x0000000184FFC4E0-0x0000000184FFC580
		// [XID] // 0x0000000189793170-0x0000000189793190
		private void TrySprint() {} // 0x0000000184FFC360-0x0000000184FFC480
		// [XID] // 0x000000018979B440-0x000000018979B460
		public void ConsumeCachedPress() {} // 0x0000000184FFC1D0-0x0000000184FFC280
		// [XID] // 0x00000001897A28E0-0x00000001897A2900
		private void TryStopSprint(bool forceStop) {} // 0x0000000184FFC8A0-0x0000000184FFC9E0
		// [XID] // 0x00000001897A9DC0-0x00000001897A9DE0
		private void GetVCHumanoidMove() {} // 0x0000000184FFC9E0-0x0000000184FFCB00
		// [XID] // 0x00000001897B1790-0x00000001897B17B0
		protected override void Update() {} // 0x0000000184FFD680-0x0000000184FFD890
		// [XID] // 0x00000001897B91C0-0x00000001897B91E0
		protected override void HandleDrag(Vector2 delta) {} // 0x0000000184FFC580-0x0000000184FFC780
		// [XID] // 0x00000001897C12E0-0x00000001897C1300
		public void SetActive(bool active, ActionPanelState state) {} // 0x0000000184FFD2A0-0x0000000184FFD3C0
		// [XID] // 0x00000001897C8D60-0x00000001897C8D80
		private void SetBtnStyle(ActionPanelState state) {} // 0x0000000184FFC110-0x0000000184FFC1D0
		// [XID] // 0x00000001897D03A0-0x00000001897D03C0
		public void ToSprintIcon() {} // 0x0000000184FFD520-0x0000000184FFD5D0
		// [XID] // 0x00000001897D8080-0x00000001897D80A0
		public void ToSwimIcon() {} // 0x0000000184FFD5D0-0x0000000184FFD680
	}
}
