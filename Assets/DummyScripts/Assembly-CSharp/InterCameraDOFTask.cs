/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InterCameraDOFTask : BaseInterTask // TypeDefIndex: 20932
{
	// Fields
	private CameraDOFStruct _targetDof; // 0x38
	private CameraDOFStruct _currDof; // 0x54
	private MHYDepthOfField _mhyDepthOfField; // 0x70
	private MotionBlur _motionBlur; // 0x78

	// Properties
	public override InteractionType dataType { /* [XID] */ /* 0x000000018983AAA0-0x000000018983AAC0 */ get => default; } // 0x000000018366BA90-0x000000018366BB30 

	// Nested types
	public struct CameraDOFStruct // TypeDefIndex: 20933
	{
		// Fields
		public bool enabled; // 0x00
		public float focusDistance; // 0x04
		public float focusRange; // 0x08
		public float nearFocalDistance; // 0x0C
		public float nearFocalTransDistance; // 0x10
		public float dofBlurAmount; // 0x14
		public MotionBlur.DofQuality quality; // 0x18
	}

	// Constructors
	public InterCameraDOFTask() {} // 0x000000018366C940-0x000000018366C9B0

	// Methods
	// [XID] // 0x0000000189842100-0x0000000189842120
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x000000018366BB30-0x000000018366C180
	// [XID] // 0x0000000189849560-0x0000000189849580
	public override void Tick() {} // 0x000000018366B900-0x000000018366B9C0
	// [XID] // 0x0000000189850DD0-0x0000000189850DF0
	private void TickCameraDof() {} // 0x000000018366C180-0x000000018366C400
	// [XID] // 0x00000001898581A0-0x00000001898581C0
	private void UpdateCameraDof(bool enabled, float focusDistance, float focusRange, float nearFocalDistance, float nearFocalTransDistance, float dofBlurAmount, MotionBlur.DofQuality quality) {} // 0x000000018366C480-0x000000018366C940
}

