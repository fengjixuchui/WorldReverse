/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	[Serializable]
	// [AddComponentMenu] // 0x00000001897BAAF0-0x00000001897BAB20
	public class EasyTouchTrigger : MonoBehaviour // TypeDefIndex: 7249
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<EasyTouchReceiver> receivers; // 0x18
	
		// Nested types
		public enum ETTParameter // TypeDefIndex: 7250
		{
			None = 0,
			Gesture = 1,
			Finger_Id = 2,
			Touch_Count = 3,
			Start_Position = 4,
			Position = 5,
			Delta_Position = 6,
			Swipe_Type = 7,
			Swipe_Length = 8,
			Swipe_Vector = 9,
			Delta_Pinch = 10,
			Twist_Anlge = 11,
			ActionTime = 12,
			DeltaTime = 13,
			PickedObject = 14,
			PickedUIElement = 15
		}
	
		public enum ETTType // TypeDefIndex: 7251
		{
			Object3D = 0,
			UI = 1
		}
	
		[Serializable]
		public class EasyTouchReceiver // TypeDefIndex: 7252
		{
			// Fields
			public bool enable; // 0x10
			public ETTType triggerType; // 0x14
			public string name; // 0x18
			public bool restricted; // 0x20
			public GameObject gameObject; // 0x28
			public bool otherReceiver; // 0x30
			public GameObject gameObjectReceiver; // 0x38
			public EasyTouch.EvtType eventName; // 0x40
			public string methodName; // 0x48
			public ETTParameter parameter; // 0x50
	
			// Constructors
			public EasyTouchReceiver() {} // 0x0000000180B2F050-0x0000000180B2F0B0
		}
	
		// Constructors
		public EasyTouchTrigger() {} // 0x0000000180B33550-0x0000000180B335E0
	
		// Methods
		// [XID] // 0x00000001897CB6C0-0x00000001897CB6E0
		private void Start() {} // 0x0000000180B31480-0x0000000180B31540
		// [XID] // 0x00000001897D2F60-0x00000001897D2F80
		private void OnEnable() {} // 0x0000000180B2F740-0x0000000180B2F7E0
		// [XID] // 0x00000001897DABD0-0x00000001897DABF0
		private void OnDisable() {} // 0x0000000180B2F6A0-0x0000000180B2F740
		// [XID] // 0x0000000189BA73B0-0x0000000189BA73D0
		private void OnDestroy() {} // 0x0000000180B2F600-0x0000000180B2F6A0
		// [XID] // 0x00000001897E9920-0x00000001897E9940
		private void SubscribeEasyTouchEvent() {} // 0x0000000180B31540-0x0000000180B32490
		// [XID] // 0x0000000189AA8E90-0x0000000189AA8EB0
		private void UnsubscribeEasyTouchEvent() {} // 0x0000000180B32D00-0x0000000180B33550
		// [XID] // 0x00000001897EE0E0-0x00000001897EE100
		private void On_TouchStart(Gesture gesture) {} // 0x0000000180B30F20-0x0000000180B30FE0
		// [XID] // 0x0000000189800320-0x0000000189800340
		private void On_TouchDown(Gesture gesture) {} // 0x0000000180B30DA0-0x0000000180B30E60
		// [XID] // 0x0000000189807A40-0x0000000189807A60
		private void On_TouchUp(Gesture gesture) {} // 0x0000000180B310A0-0x0000000180B31160
		// [XID] // 0x000000018980F0D0-0x000000018980F0F0
		private void On_SimpleTap(Gesture gesture) {} // 0x0000000180B307A0-0x0000000180B30860
		// [XID] // 0x0000000189816880-0x00000001898168A0
		private void On_DoubleTap(Gesture gesture) {} // 0x0000000180B2F960-0x0000000180B2FA20
		// [XID] // 0x000000018981E180-0x000000018981E1A0
		private void On_LongTapStart(Gesture gesture) {} // 0x0000000180B301A0-0x0000000180B30260
		// [XID] // 0x0000000189865F70-0x0000000189865F90
		private void On_LongTap(Gesture gesture) {} // 0x0000000180B30260-0x0000000180B30320
		// [XID] // 0x000000018982CDF0-0x000000018982CE10
		private void On_LongTapEnd(Gesture gesture) {} // 0x0000000180B30020-0x0000000180B300E0
		// [XID] // 0x00000001898329E0-0x0000000189832A00
		private void On_SwipeStart(Gesture gesture) {} // 0x0000000180B30B60-0x0000000180B30C20
		// [XID] // 0x000000018983B970-0x000000018983B990
		private void On_Swipe(Gesture gesture) {} // 0x0000000180B30C20-0x0000000180B30CE0
		// [XID] // 0x0000000189841520-0x0000000189841540
		private void On_SwipeEnd(Gesture gesture) {} // 0x0000000180B309E0-0x0000000180B30AA0
		// [XID] // 0x000000018984A5F0-0x000000018984A610
		private void On_DragStart(Gesture gesture) {} // 0x0000000180B2FD20-0x0000000180B2FDE0
		// [XID] // 0x0000000189851BA0-0x0000000189851BC0
		private void On_Drag(Gesture gesture) {} // 0x0000000180B2FDE0-0x0000000180B2FEA0
		// [XID] // 0x0000000189859430-0x0000000189859450
		private void On_DragEnd(Gesture gesture) {} // 0x0000000180B2FBA0-0x0000000180B2FC60
		// [XID] // 0x00000001898604F0-0x0000000189860510
		private void On_Cancel(Gesture gesture) {} // 0x0000000180B2F7E0-0x0000000180B2F8A0
		// [XID] // 0x0000000189867BF0-0x0000000189867C10
		private void On_TouchStart2Fingers(Gesture gesture) {} // 0x0000000180B30E60-0x0000000180B30F20
		// [XID] // 0x000000018986F290-0x000000018986F2B0
		private void On_TouchDown2Fingers(Gesture gesture) {} // 0x0000000180B30CE0-0x0000000180B30DA0
		// [XID] // 0x0000000189876730-0x0000000189876750
		private void On_TouchUp2Fingers(Gesture gesture) {} // 0x0000000180B30FE0-0x0000000180B310A0
		// [XID] // 0x000000018982B590-0x000000018982B5B0
		private void On_LongTapStart2Fingers(Gesture gesture) {} // 0x0000000180B300E0-0x0000000180B301A0
		// [XID] // 0x00000001898854F0-0x0000000189885510
		private void On_LongTap2Fingers(Gesture gesture) {} // 0x0000000180B2FEA0-0x0000000180B2FF60
		// [XID] // 0x000000018988CA30-0x000000018988CA50
		private void On_LongTapEnd2Fingers(Gesture gesture) {} // 0x0000000180B2FF60-0x0000000180B30020
		// [XID] // 0x0000000189893FA0-0x0000000189893FC0
		private void On_DragStart2Fingers(Gesture gesture) {} // 0x0000000180B2FC60-0x0000000180B2FD20
		// [XID] // 0x00000001899C03B0-0x00000001899C03D0
		private void On_Drag2Fingers(Gesture gesture) {} // 0x0000000180B2FA20-0x0000000180B2FAE0
		// [XID] // 0x000000018986D670-0x000000018986D690
		private void On_DragEnd2Fingers(Gesture gesture) {} // 0x0000000180B2FAE0-0x0000000180B2FBA0
		// [XID] // 0x00000001898AA020-0x00000001898AA040
		private void On_SwipeStart2Fingers(Gesture gesture) {} // 0x0000000180B30AA0-0x0000000180B30B60
		// [XID] // 0x00000001898B19B0-0x00000001898B19D0
		private void On_Swipe2Fingers(Gesture gesture) {} // 0x0000000180B30860-0x0000000180B30920
		// [XID] // 0x00000001898B9520-0x00000001898B9540
		private void On_SwipeEnd2Fingers(Gesture gesture) {} // 0x0000000180B30920-0x0000000180B309E0
		// [XID] // 0x0000000189A7C360-0x0000000189A7C380
		private void On_Twist(Gesture gesture) {} // 0x0000000180B31220-0x0000000180B312E0
		// [XID] // 0x0000000189AB80C0-0x0000000189AB80E0
		private void On_TwistEnd(Gesture gesture) {} // 0x0000000180B31160-0x0000000180B31220
		// [XID] // 0x00000001898CF950-0x00000001898CF970
		private void On_Pinch(Gesture gesture) {} // 0x0000000180B30620-0x0000000180B306E0
		// [XID] // 0x0000000189A0C310-0x0000000189A0C330
		private void On_PinchOut(Gesture gesture) {} // 0x0000000180B30560-0x0000000180B30620
		// [XID] // 0x00000001898DF030-0x00000001898DF050
		private void On_PinchIn(Gesture gesture) {} // 0x0000000180B304A0-0x0000000180B30560
		// [XID] // 0x00000001898E66A0-0x00000001898E66C0
		private void On_PinchEnd(Gesture gesture) {} // 0x0000000180B303E0-0x0000000180B304A0
		// [XID] // 0x00000001898EDFB0-0x00000001898EDFD0
		private void On_SimpleTap2Fingers(Gesture gesture) {} // 0x0000000180B306E0-0x0000000180B307A0
		// [XID] // 0x00000001898F58B0-0x00000001898F58D0
		private void On_DoubleTap2Fingers(Gesture gesture) {} // 0x0000000180B2F8A0-0x0000000180B2F960
		// [XID] // 0x00000001898FD000-0x00000001898FD020
		private void On_UIElementTouchUp(Gesture gesture) {} // 0x0000000180B312E0-0x0000000180B313A0
		// [XID] // 0x0000000189904980-0x00000001899049A0
		private void On_OverUIElement(Gesture gesture) {} // 0x0000000180B30320-0x0000000180B303E0
		// [XID] // 0x0000000189BAE500-0x0000000189BAE520
		public void AddTrigger(EasyTouch.EvtType ev) {} // 0x0000000180B2F0B0-0x0000000180B2F230
		// [XID] // 0x00000001899139D0-0x00000001899139F0
		public bool SetTriggerEnable(string triggerName, bool value) => default; // 0x0000000180B313A0-0x0000000180B31480
		// [XID] // 0x0000000189BD4210-0x0000000189BD4230
		public bool GetTriggerEnable(string triggerName) => default; // 0x0000000180B2F230-0x0000000180B2F300
		// [XID] // 0x0000000189922A70-0x0000000189922A90
		private void TriggerScheduler(EasyTouch.EvtType evnt, Gesture gesture) {} // 0x0000000180B32490-0x0000000180B32D00
		// [XID] // 0x000000018992A2C0-0x000000018992A2E0
		private bool IsRecevier4(EasyTouch.EvtType evnt) => default; // 0x0000000180B2F480-0x0000000180B2F600
		// [XID] // 0x0000000189919D90-0x0000000189919DB0
		private EasyTouchReceiver GetTrigger(string triggerName) => default; // 0x0000000180B2F300-0x0000000180B2F480
	}
}
