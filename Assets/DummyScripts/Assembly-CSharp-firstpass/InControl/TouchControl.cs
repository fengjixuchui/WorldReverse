/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public abstract class TouchControl : MonoBehaviour // TypeDefIndex: 7830
	{
		// Nested types
		public enum ButtonTarget // TypeDefIndex: 7831
		{
			None = 0,
			DPadUp = 11,
			DPadDown = 12,
			DPadLeft = 13,
			DPadRight = 14,
			LeftTrigger = 15,
			RightTrigger = 16,
			LeftBumper = 17,
			RightBumper = 18,
			Action1 = 19,
			Action2 = 20,
			Action3 = 21,
			Action4 = 22,
			Action5 = 23,
			Action6 = 24,
			Action7 = 25,
			Action8 = 26,
			Action9 = 27,
			Action10 = 28,
			Action11 = 29,
			Action12 = 30,
			Menu = 106,
			Button0 = 500,
			Button1 = 501,
			Button2 = 502,
			Button3 = 503,
			Button4 = 504,
			Button5 = 505,
			Button6 = 506,
			Button7 = 507,
			Button8 = 508,
			Button9 = 509,
			Button10 = 510,
			Button11 = 511,
			Button12 = 512,
			Button13 = 513,
			Button14 = 514,
			Button15 = 515,
			Button16 = 516,
			Button17 = 517,
			Button18 = 518,
			Button19 = 519
		}
	
		public enum AnalogTarget // TypeDefIndex: 7832
		{
			None = 0,
			LeftStick = 1,
			RightStick = 2,
			Both = 3
		}
	
		public enum SnapAngles // TypeDefIndex: 7833
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 16
		}
	
		// Constructors
		protected TouchControl() {} // 0x00000001877DC580-0x00000001877DC5E0
	
		// Methods
		public abstract void CreateControl();
		public abstract void DestroyControl();
		public abstract void ConfigureControl();
		public abstract void SubmitControlState(ulong updateTick, float deltaTime);
		public abstract void CommitControlState(ulong updateTick, float deltaTime);
		public abstract void TouchBegan(Touch touch);
		public abstract void TouchMoved(Touch touch);
		public abstract void TouchEnded(Touch touch);
		public abstract void DrawGizmos();
		// [XID] // 0x00000001899DF660-0x00000001899DF680
		private void OnEnable() {} // 0x00000001877DB8C0-0x00000001877DB9A0
		// [XID] // 0x00000001899419D0-0x00000001899419F0
		private void OnDisable() {} // 0x00000001877DB560-0x00000001877DB620
		// [XID] // 0x000000018964E3E0-0x000000018964E400
		private void Setup() {} // 0x00000001877DB9A0-0x00000001877DBA70
		// [XID] // 0x0000000189655C80-0x0000000189655CA0
		protected Vector3 OffsetToWorldPosition(TouchControlAnchor anchor, Vector2 offset, TouchUnitType offsetUnitType, bool lockAspectRatio) => default; // 0x00000001877DB240-0x00000001877DB560
		// [XID] // 0x000000018965D3E0-0x000000018965D400
		protected void SubmitButtonState(ButtonTarget target, bool state, ulong updateTick, float deltaTime) {} // 0x00000001877DC100-0x00000001877DC280
		// [XID] // 0x0000000189664A70-0x0000000189664A90
		protected void SubmitButtonValue(ButtonTarget target, float value, ulong updateTick, float deltaTime) {} // 0x00000001877DC280-0x00000001877DC400
		// [XID] // 0x000000018966C020-0x000000018966C040
		protected void CommitButton(ButtonTarget target) {} // 0x00000001877DB110-0x00000001877DB240
		// [XID] // 0x0000000189673E80-0x0000000189673EA0
		protected void SubmitAnalogValue(AnalogTarget target, Vector2 value, float lowerDeadZone, float upperDeadZone, ulong updateTick, float deltaTime) {} // 0x00000001877DBF20-0x00000001877DC100
		// [XID] // 0x00000001896D3340-0x00000001896D3360
		protected void CommitAnalog(AnalogTarget target) {} // 0x00000001877DB000-0x00000001877DB110
		// [XID] // 0x0000000189682DD0-0x0000000189682DF0
		protected void SubmitRawAnalogValue(AnalogTarget target, Vector2 rawValue, ulong updateTick, float deltaTime) {} // 0x00000001877DC400-0x00000001877DC580
		// [IDTag] // 0x000000018968A980-0x000000018968A9C0
		// [XID] // 0x000000018968A980-0x000000018968A9C0
		protected static Vector3 SnapTo(Vector2 vector, SnapAngles snapAngles) => default; // 0x00000001877DBDD0-0x00000001877DBF20
		// [IDTag] // 0x0000000189695350-0x0000000189695390
		// [XID] // 0x0000000189695350-0x0000000189695390
		protected static Vector3 SnapTo(Vector2 vector, float snapAngle) => default; // 0x00000001877DBA70-0x00000001877DBDD0
		// [XID] // 0x00000001899674F0-0x0000000189967510
		private void OnDrawGizmosSelected() {} // 0x00000001877DB620-0x00000001877DB760
		// [XID] // 0x00000001896A6C10-0x00000001896A6C30
		private void OnDrawGizmos() {} // 0x00000001877DB760-0x00000001877DB8C0
	}
}
