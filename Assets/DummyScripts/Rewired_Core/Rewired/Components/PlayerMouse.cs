/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Components
{
	[Serializable]
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 3613
	{
		// Fields
		[CustomObfuscation] // 0x0000000189AA90B0-0x0000000189AA9110
		[SerializeField] // 0x0000000189AA90B0-0x0000000189AA9110
		// [Tooltip] // 0x0000000189AA90B0-0x0000000189AA9110
		private bool _defaultToCenter; // 0x58
		[CustomObfuscation] // 0x0000000189AB8360-0x0000000189AB83C0
		[SerializeField] // 0x0000000189AB8360-0x0000000189AB83C0
		// [Tooltip] // 0x0000000189AB8360-0x0000000189AB83C0
		private float _pointerSpeed; // 0x5C
		[CustomObfuscation] // 0x0000000189AC7A70-0x0000000189AC7AD0
		[SerializeField] // 0x0000000189AC7A70-0x0000000189AC7AD0
		// [Tooltip] // 0x0000000189AC7A70-0x0000000189AC7AD0
		private bool _useHardwarePointerPosition; // 0x60
		[CustomObfuscation] // 0x0000000189AD6E40-0x0000000189AD6EA0
		[SerializeField] // 0x0000000189AD6E40-0x0000000189AD6EA0
		// [Tooltip] // 0x0000000189AD6E40-0x0000000189AD6EA0
		private Rect _movementArea; // 0x64
		[CustomObfuscation] // 0x0000000189AE6130-0x0000000189AE6190
		[SerializeField] // 0x0000000189AE6130-0x0000000189AE6190
		// [Tooltip] // 0x0000000189AE6130-0x0000000189AE6190
		private PlayerMouse.MovementAreaUnit _movementAreaUnit; // 0x74
		[CustomObfuscation] // 0x0000000189AF50A0-0x0000000189AF5100
		[SerializeField] // 0x0000000189AF50A0-0x0000000189AF5100
		// [Tooltip] // 0x0000000189AF50A0-0x0000000189AF5100
		private ScreenPositionChangedHandler _onScreenPositionChanged; // 0x78
	
		// Properties
		private new Rewired.PlayerMouse source { get => default; } // 0x0000000185E911C0-0x0000000185E91240 
		public bool defaultToCenter { get => default; set {} } // 0x0000000185E90A60-0x0000000185E90B00 0x0000000185E915F0-0x0000000185E91690
		public ScreenRect movementArea { get => default; set {} } // 0x0000000185E90CD0-0x0000000185E90E10 0x0000000185E91730-0x0000000185E917D0
		public PlayerMouse.MovementAreaUnit movementAreaUnit { get => default; set {} } // 0x0000000185E90C40-0x0000000185E90CD0 0x0000000185E91690-0x0000000185E91730
		public Vector2 screenPosition { get => default; set {} } // 0x0000000185E910F0-0x0000000185E911C0 0x0000000185E91910-0x0000000185E919A0
		public Vector2 screenPositionPrev { get => default; } // 0x0000000185E91020-0x0000000185E910F0 
		public Vector2 screenPositionDelta { get => default; } // 0x0000000185E90F50-0x0000000185E91020 
		public PlayerController.MouseAxis xAxis { get => default; } // 0x0000000185E91380-0x0000000185E91420 
		public PlayerController.MouseAxis yAxis { get => default; } // 0x0000000185E91420-0x0000000185E914C0 
		public PlayerController.MouseWheel wheel { get => default; } // 0x0000000185E912E0-0x0000000185E91380 
		public PlayerController.Button leftButton { get => default; } // 0x0000000185E90B00-0x0000000185E90BA0 
		public PlayerController.Button rightButton { get => default; } // 0x0000000185E90EB0-0x0000000185E90F50 
		public PlayerController.Button middleButton { get => default; } // 0x0000000185E90BA0-0x0000000185E90C40 
		public float pointerSpeed { get => default; set {} } // 0x0000000185E90E10-0x0000000185E90EB0 0x0000000185E917D0-0x0000000185E91910
		public bool useHardwarePointerPosition { get => default; set {} } // 0x0000000185E91240-0x0000000185E912E0 0x0000000185E919A0-0x0000000185E91A40
		bool IMouseInputSource.enabled { get => default; } // 0x0000000185E90140-0x0000000185E901E0 
		Vector2 IMouseInputSource.screenPosition { get => default; } // 0x0000000185E90350-0x0000000185E90420 
		Vector2 IMouseInputSource.screenPositionDelta { get => default; } // 0x0000000185E90280-0x0000000185E90350 
		Vector2 IMouseInputSource.wheelDelta { get => default; } // 0x0000000185E90420-0x0000000185E904F0 
		bool IMouseInputSource.locked { get => default; } // 0x0000000185E901E0-0x0000000185E90280 
		new bool IPlayerController.enabled { get => default; } // 0x0000000185E8FE40-0x0000000185E8FEB0 
		new bool IPlayerController.enabled { set {} } // 0x0000000185E8FEB0-0x0000000185E8FF30
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent;
	
		// Nested types
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2> // TypeDefIndex: 3614
		{
			// Constructors
			public ScreenPositionChangedHandler() {} // 0x0000000185E94330-0x0000000185E943A0
		}
	
		// Constructors
		public PlayerMouse() {} // 0x0000000185E90720-0x0000000185E90840
	
		// Methods
		protected override void OnValidated() {} // 0x0000000185E8F830-0x0000000185E8FE40
		protected override void OnReset() {} // 0x0000000185E8F710-0x0000000185E8F830
		protected override PlayerController CreateSource(object args) => default; // 0x0000000185E8F090-0x0000000185E8F6A0
		protected override void Deinitialize() {} // 0x0000000185E8F6A0-0x0000000185E8F710
		protected override void Subscribe() {} // 0x0000000185E904F0-0x0000000185E905C0
		protected override void Unsubscribe() {} // 0x0000000185E905C0-0x0000000185E90720
		internal override List<ElementInfo> CreateDefaultElementInfos() => default; // 0x0000000185E8E440-0x0000000185E8F090
		private void dcMYGxUbuujICKGUcqavgluIZPY(Vector2 param_00007f62) {} // 0x0000000185E90970-0x0000000185E90A60
		bool IMouseInputSource.GetButtonDown(int param_00007f63) => default; // 0x0000000185E8FF30-0x0000000185E8FFE0
		bool IMouseInputSource.GetButtonUp(int param_00007f64) => default; // 0x0000000185E8FFE0-0x0000000185E90090
		bool IMouseInputSource.GetButton(int param_00007f65) => default; // 0x0000000185E90090-0x0000000185E90140
	}
}
