/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls;
using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent] // 0x0000000189A95E40-0x0000000189A95EE0
	[ExecuteInEditMode] // 0x0000000189A95E40-0x0000000189A95EE0
	// [RequireComponent] // 0x0000000189A95E40-0x0000000189A95EE0
	// [RequireComponent] // 0x0000000189A95E40-0x0000000189A95EE0
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler // TypeDefIndex: 3573
	{
		// Fields
		[CustomObfuscation] // 0x0000000189AAAA50-0x0000000189AAAAB0
		[SerializeField] // 0x0000000189AAAA50-0x0000000189AAAAB0
		// [Tooltip] // 0x0000000189AAAA50-0x0000000189AAAAB0
		private bool _visible; // 0x18
		[CustomObfuscation] // 0x0000000189AB9BA0-0x0000000189AB9C00
		[SerializeField] // 0x0000000189AB9BA0-0x0000000189AB9C00
		// [Tooltip] // 0x0000000189AB9BA0-0x0000000189AB9C00
		private bool _targetAngleFromRotation; // 0x19
		[CustomObfuscation] // 0x0000000189AC8F30-0x0000000189AC8FB0
		// [Range] // 0x0000000189AC8F30-0x0000000189AC8FB0
		[SerializeField] // 0x0000000189AC8F30-0x0000000189AC8FB0
		// [Tooltip] // 0x0000000189AC8F30-0x0000000189AC8FB0
		private float _targetAngle; // 0x1C
		[CustomObfuscation] // 0x0000000189ADB550-0x0000000189ADB5B0
		[SerializeField] // 0x0000000189ADB550-0x0000000189ADB5B0
		// [Tooltip] // 0x0000000189ADB550-0x0000000189ADB5B0
		private bool _fadeWithValue; // 0x20
		[CustomObfuscation] // 0x0000000189AEA830-0x0000000189AEA890
		[SerializeField] // 0x0000000189AEA830-0x0000000189AEA890
		// [Tooltip] // 0x0000000189AEA830-0x0000000189AEA890
		private bool _fadeWithAngle; // 0x21
		[CustomObfuscation] // 0x0000000189AF9AC0-0x0000000189AF9B40
		// [Range] // 0x0000000189AF9AC0-0x0000000189AF9B40
		[SerializeField] // 0x0000000189AF9AC0-0x0000000189AF9B40
		// [Tooltip] // 0x0000000189AF9AC0-0x0000000189AF9B40
		private float _fadeRange; // 0x24
		[CustomObfuscation] // 0x0000000189B0B630-0x0000000189B0B690
		[SerializeField] // 0x0000000189B0B630-0x0000000189B0B690
		// [Tooltip] // 0x0000000189B0B630-0x0000000189B0B690
		private Color _activeColor; // 0x28
		[CustomObfuscation] // 0x0000000189B1A230-0x0000000189B1A290
		[SerializeField] // 0x0000000189B1A230-0x0000000189B1A290
		// [Tooltip] // 0x0000000189B1A230-0x0000000189B1A290
		private Color _normalColor; // 0x38
		private Image UkytztfegFjxRAnWtoiQGueBHbBq; // 0x48
		private RectTransform jWsAaYZljMxgOQUIkeMAAFRfBYz; // 0x50
		private Vector2 XySdAOKjAJnwmJRnyfScrRwkPM; // 0x58
		private bool btfgbdYZiylScewFWjvlbyDWYmd; // 0x60
		private IRegistrar<TouchJoystickAngleIndicator> AbOcnoXWPhAHWAUcZjcsWpKNXSTc; // 0x68
	
		// Properties
		public bool visible { get => default; set {} } // 0x0000000185AAD1A0-0x0000000185AAD200 0x0000000185AAD920-0x0000000185AADA20
		public bool targetAngleFromRotation { get => default; set {} } // 0x0000000185AAD090-0x0000000185AAD0F0 0x0000000185AAD7C0-0x0000000185AAD870
		public float targetAngle { get => default; set {} } // 0x0000000185AAD0F0-0x0000000185AAD1A0 0x0000000185AAD870-0x0000000185AAD920
		public bool fadeWithValue { get => default; set {} } // 0x0000000185AACEA0-0x0000000185AACF00 0x0000000185AAD660-0x0000000185AAD710
		public bool fadeWithAngle { get => default; set {} } // 0x0000000185AACE40-0x0000000185AACEA0 0x0000000185AAD590-0x0000000185AAD660
		public float fadeRange { get => default; set {} } // 0x0000000185AACDD0-0x0000000185AACE40 0x0000000185AAD4C0-0x0000000185AAD590
		public Color activeColor { get => default; set {} } // 0x0000000185AACC40-0x0000000185AACCB0 0x0000000185AAD410-0x0000000185AAD4C0
		public Color normalColor { get => default; set {} } // 0x0000000185AACF90-0x0000000185AAD000 0x0000000185AAD710-0x0000000185AAD7C0
		internal Image image { get => default; } // 0x0000000185AACF00-0x0000000185AACF90 
		internal Sprite currentSprite { get => default; } // 0x0000000185AACCB0-0x0000000185AACDD0 
		internal RectTransform rectTransform { get => default; } // 0x0000000185AAD000-0x0000000185AAD090 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchJoystickAngleIndicator() {} // 0x0000000185AACB40-0x0000000185AACC40
	
		// Methods
		internal bool FYqANZihtIgQbnChZTLtBHGRmzL(out Vector2 param_00007e87) {
			param_00007e87 = default;
			return default;
		} // 0x0000000185AABD90-0x0000000185AABFD0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Awake() {} // 0x0000000185AABB80-0x0000000185AABC50
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnEnable() {} // 0x0000000185AAC5E0-0x0000000185AAC6C0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDisable() {} // 0x0000000185AAC580-0x0000000185AAC5E0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnValidate() {} // 0x0000000185AAC870-0x0000000185AAC8E0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnTransformParentChanged() {} // 0x0000000185AAC810-0x0000000185AAC870
		private void SWnzUAEKhgDxxwxmMhpFBvKnnQNm(bool param_00007e88, bool param_00007e89) {} // 0x0000000185AAC9D0-0x0000000185AACB40
		private void KRVFzSAGLbzTcEyxGHvVNUMJQtBd(Vector2 param_00007e8a) {} // 0x0000000185AABFD0-0x0000000185AAC580
		private void uYzFvpGmRyWWGtLVturUCJxekis() {} // 0x0000000185AADA20-0x0000000185AADA80
		private void qVsMyoYBvETfokpXbIGIpiZNXPA() {} // 0x0000000185AAD370-0x0000000185AAD410
		private void wQiEPKGVkSYAiCZoyTUamohUIKKd() {} // 0x0000000185AADA80-0x0000000185AADAD0
		private void mwAJbHrkLrwyZOsaQsXhEmbTPQk() {} // 0x0000000185AAD200-0x0000000185AAD370
		private void DQHwWBHiVzxXqYGEuuinzLqJNOq() {} // 0x0000000185AABC50-0x0000000185AABD90
		public void OnVisibilityChanged(bool state) {} // 0x0000000185AAC8E0-0x0000000185AAC960
		public void OnTouchJoystickStickPositionChanged(Vector2 value) {} // 0x0000000185AAC6C0-0x0000000185AAC810
		void Rewired.ComponentControls.TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 param_00007e8d) {} // 0x0000000185AAC960-0x0000000185AAC9D0
	}
}
