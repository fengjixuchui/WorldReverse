/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIManekinCtrl : MonoBehaviour // TypeDefIndex: 30966
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _easyTouchUICompatibily; // 0x18
		private FingerUtil _fingerUtil; // 0x20
		private RectTransform _rectTrans; // 0x28
		private bool _isCtrl; // 0x30
		private Notify _ctrlNotify; // 0x38
		private bool _isCloudGame; // 0x50
	
		// Constructors
		public MonoUIManekinCtrl() {} // 0x00000001848975A0-0x0000000184897690
	
		// Methods
		// [XID] // 0x000000018998D350-0x000000018998D370
		private void Awake() {} // 0x0000000184895F10-0x0000000184896000
		// [XID] // 0x0000000189994DF0-0x0000000189994E10
		public virtual void OnEnable() {} // 0x00000001848970A0-0x0000000184897170
		// [XID] // 0x000000018999C690-0x000000018999C6B0
		public virtual void OnDisable() {} // 0x0000000184897000-0x00000001848970A0
		// [XID] // 0x00000001899A4100-0x00000001899A4120
		public virtual void OnDestroy() {} // 0x0000000184896F60-0x0000000184897000
		// [XID] // 0x00000001899ABAD0-0x00000001899ABAF0
		public void SubscribeEvent() {} // 0x0000000184897170-0x0000000184897390
		// [XID] // 0x00000001899B34B0-0x00000001899B34D0
		public void UnsubscribeEvent() {} // 0x0000000184897390-0x00000001848975A0
		// [XID] // 0x00000001899BA830-0x00000001899BA850
		private void On_TouchStart(Gesture gesture) {} // 0x0000000184896560-0x0000000184896750
		// [XID] // 0x00000001899C2170-0x00000001899C2190
		private void On_TouchUp(Gesture gesture) {} // 0x0000000184896750-0x0000000184896A60
		// [XID] // 0x00000001899C9830-0x00000001899C9850
		private void On_Swipe(Gesture gesture) {} // 0x0000000184896000-0x0000000184896290
		// [XID] // 0x00000001899D10B0-0x00000001899D10D0
		protected virtual void HandleMovePostionUpdateEvent(Notify ctrlNotify) {} // 0x00000001848964A0-0x0000000184896560
		// [XID] // 0x00000001899D85A0-0x00000001899D85C0
		protected virtual void HandleTouchStartEvent(Notify ctrlNotify) {} // 0x0000000184896290-0x0000000184896350
		// [XID] // 0x00000001899DFC30-0x00000001899DFC50
		protected virtual void HandleTouchUpEvent(Notify ctrlNotify) {} // 0x0000000184896BD0-0x0000000184896C90
		// [XID] // 0x00000001899E7680-0x00000001899E76A0
		protected virtual void HandleMoveEvent(Notify ctrlNotify) {} // 0x0000000184896A60-0x0000000184896B20
		// [XID] // 0x00000001899EEC50-0x00000001899EEC70
		protected virtual void HandlePitchEvent(Notify ctrlNotify) {} // 0x0000000184896D50-0x0000000184896E10
		// [XID] // 0x00000001899F6510-0x00000001899F6530
		protected virtual void HandleSwipeEndEvent(Notify ctrlNotify) {} // 0x0000000184896C90-0x0000000184896D50
		// [XID] // 0x00000001899FDA10-0x00000001899FDA30
		private void On_SwipeEnd(Gesture gesture) {} // 0x0000000184896B20-0x0000000184896BD0
		// [XID] // 0x0000000189A05450-0x0000000189A05470
		private void On_PinchIn(Gesture gesture) {} // 0x0000000184896E10-0x0000000184896F60
		// [XID] // 0x0000000189A0C790-0x0000000189A0C7B0
		private void On_PinchOut(Gesture gesture) {} // 0x0000000184896350-0x00000001848964A0
	}
}
