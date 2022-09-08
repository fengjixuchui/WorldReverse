/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIModelAster : MonoUIManekinCtrl // TypeDefIndex: 31318
	{
		// Fields
		private MonoAsterScene _setupGo; // 0x58
		public Action EndCallBack; // 0x60
		public Action StartCallBack; // 0x68
		private bool _isEnd; // 0x70
		private bool _hasGetlastTouchPos; // 0x71
		private float _lastTouchAngle; // 0x74
		private bool _rotated; // 0x78
	
		// Properties
		public MonoAsterScene setupGo { /* [XID] */ /* 0x0000000189674100-0x0000000189674120 */ get => default; } // 0x0000000184898510-0x00000001848985B0 
	
		// Constructors
		public MonoUIModelAster() {} // 0x0000000184898490-0x0000000184898510
	
		// Methods
		// [XID] // 0x000000018967B940-0x000000018967B960
		protected override void HandleMovePostionUpdateEvent(Notify ntf) {} // 0x0000000184897AF0-0x0000000184897C40
		// [XID] // 0x0000000189683050-0x0000000189683070
		protected override void HandleMoveEvent(Notify ntf) {} // 0x0000000184897D60-0x0000000184897EE0
		// [XID] // 0x000000018968AAA0-0x000000018968AAC0
		protected override void HandleTouchStartEvent(Notify ntf) {} // 0x00000001848977E0-0x0000000184897940
		// [XID] // 0x0000000189692800-0x0000000189692820
		protected override void HandleTouchUpEvent(Notify ntf) {} // 0x0000000184897EE0-0x0000000184897FF0
		// [XID] // 0x0000000189699B30-0x0000000189699B50
		public void RotateByJoypad(float x, float y) {} // 0x0000000184898080-0x0000000184898160
		// [XID] // 0x00000001896A12A0-0x00000001896A12C0
		private void SetRotationAngle(float angle) {} // 0x0000000184897690-0x0000000184897750
		// [XID] // 0x00000001896A8710-0x00000001896A8730
		public void SetTargetRotation(Vector2 targetDir) {} // 0x0000000184898160-0x0000000184898390
		// [XID] // 0x00000001896AF8C0-0x00000001896AF8E0
		public void SetupMonoAsterScene(MonoAsterScene asterScene) {} // 0x0000000184898390-0x0000000184898490
		// [XID] // 0x00000001896B71D0-0x00000001896B71F0
		private bool CheckSuccess() => default; // 0x0000000184897940-0x00000001848979F0
		// [XID] // 0x00000001896BE360-0x00000001896BE380
		private void CheckRotationAuto() {} // 0x00000001848979F0-0x0000000184897AF0
	}
}
