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

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class ElementViewRenderer : PostProcessEffectRenderer<ElementView> // TypeDefIndex: 9483
	{
		// Fields
		private static readonly string ElementViewOnKeyword; // 0x00
		private readonly Vector4[] _colors; // 0x20
		private bool _isEffectOnLastFrame; // 0x28
		private float _waveBandStartTime; // 0x2C
		private bool _isInBlastWaveBand; // 0x30
		private float _blastWaveBandTimer; // 0x34
	
		// Constructors
		public ElementViewRenderer() {} // 0x000000018605B8C0-0x000000018605B9A0
		static ElementViewRenderer() {} // 0x000000018605B850-0x000000018605B8C0
	
		// Methods
		// [XID] // 0x000000018981E870-0x000000018981E890
		private void CopySettingColorsToVector4s() {} // 0x000000018605A340-0x000000018605A4D0
		// [XID] // 0x0000000189AC3AE0-0x0000000189AC3B00
		public override void Init() {} // 0x000000018605A4D0-0x000000018605A580
		// [XID] // 0x000000018983D220-0x000000018983D240
		public override void OnEnable(PostProcessRenderContext context) {} // 0x000000018605A580-0x000000018605A650
		// [XID] // 0x0000000189AD2AA0-0x0000000189AD2AC0
		private bool Validate() => default; // 0x000000018605B680-0x000000018605B850
		// [XID] // 0x0000000189BCF8D0-0x0000000189BCF8F0
		public override void Render(PostProcessRenderContext context) {} // 0x000000018605A8E0-0x000000018605B520
		// [XID] // 0x0000000189852C90-0x0000000189852CB0
		public override void Release(PostProcessRenderContext context) {} // 0x000000018605A650-0x000000018605A8E0
	}
}
