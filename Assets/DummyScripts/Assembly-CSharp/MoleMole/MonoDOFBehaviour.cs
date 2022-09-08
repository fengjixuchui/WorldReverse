/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoDOFBehaviour : MonoBehaviour // TypeDefIndex: 26225
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enabled; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _focusDistance; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _focusRange; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _nearFocalDistance; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _nearFocalTransDistance; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _dofBlurAmount; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MotionBlur.DofQuality _quality; // 0x30
		private MotionBlur _motionBlur; // 0x38
		private MHYDepthOfField _mhyDepthOfField; // 0x40
		private bool _rEnabled; // 0x48
		private float _rFocusDistance; // 0x4C
		private float _rFocusRange; // 0x50
		private float _rNearFocalDistance; // 0x54
		private float _rNearFocalTransDistance; // 0x58
		private float _rDofBlurAmount; // 0x5C
		private MotionBlur.DofQuality _rQuality; // 0x60
	
		// Constructors
		public MonoDOFBehaviour() {} // 0x0000000183F3C560-0x0000000183F3C5E0
	
		// Methods
		// [XID] // 0x00000001897EE990-0x00000001897EE9B0
		private void Update() {} // 0x0000000183F3C430-0x0000000183F3C560
		// [XID] // 0x00000001897F6140-0x00000001897F6160
		private void OnDestroy() {} // 0x0000000183F3C340-0x0000000183F3C430
		// [XID] // 0x00000001897FD780-0x00000001897FD7A0
		private void InitMotionBlurResetParam() {} // 0x0000000183F3B8F0-0x0000000183F3BAF0
		// [XID] // 0x0000000189804F90-0x0000000189804FB0
		private void InitMHYDepthOfFieldResetParam() {} // 0x0000000183F3C160-0x0000000183F3C340
		// [XID] // 0x000000018980C470-0x000000018980C490
		public MotionBlur GetMotionBlur() => default; // 0x0000000183F3BC10-0x0000000183F3BD30
		// [XID] // 0x0000000189813C70-0x0000000189813C90
		public MHYDepthOfField GetMHYDepthOfField() => default; // 0x0000000183F3BAF0-0x0000000183F3BC10
		// [XID] // 0x000000018981B7A0-0x000000018981B7C0
		private void PerformDofParam(bool enabled, float focusDistance, float focusRange, float nearFocalDistance, float nearFocalTransDistance, float dofBlurAmount, MotionBlur.DofQuality quality) {} // 0x0000000183F3BD30-0x0000000183F3C160
	}
}
