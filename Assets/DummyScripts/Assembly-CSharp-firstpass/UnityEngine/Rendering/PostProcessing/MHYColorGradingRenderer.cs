/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class MHYColorGradingRenderer : PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.MHYColorGrading> // TypeDefIndex: 9499
	{
		// Fields
		internal static readonly int srcForegroundLUTex; // 0x00
		internal static readonly int srcForegroundDistance; // 0x04
		internal static readonly int srcBackgroundLUTex; // 0x08
		internal static readonly int srcBackgroundDistance; // 0x0C
		internal static readonly int srcCharactorLUTex; // 0x10
		internal static readonly int dstForegroundLUTex; // 0x14
		internal static readonly int dstForegroundDistance; // 0x18
		internal static readonly int dstBackgroundLUTex; // 0x1C
		internal static readonly int dstBackgroundDistance; // 0x20
		internal static readonly int dstCharactorLUTex; // 0x24
		internal static readonly int parameter0; // 0x28
		internal static readonly int parameter1; // 0x2C
	
		// Constructors
		public MHYColorGradingRenderer() {} // 0x0000000186067FA0-0x0000000186068010
		static MHYColorGradingRenderer() {} // 0x0000000186067DB0-0x0000000186067FA0
	
		// Methods
		// [XID] // 0x0000000189A65C00-0x0000000189A65C20
		public override void Init() {} // 0x0000000186066790-0x0000000186066830
		// [XID] // 0x0000000189A6D1F0-0x0000000189A6D210
		private bool IsSourceAvailable() => default; // 0x0000000186066A60-0x0000000186066C90
		// [XID] // 0x0000000189A74A20-0x0000000189A74A40
		private bool IsDestinationAvailable() => default; // 0x0000000186066830-0x0000000186066A60
		// [XID] // 0x0000000189A7C4D0-0x0000000189A7C4F0
		public override void Render(PostProcessRenderContext context) {} // 0x0000000186066D90-0x0000000186067CD0
		// [XID] // 0x0000000189B2B530-0x0000000189B2B550
		public override void Release(PostProcessRenderContext context) {} // 0x0000000186066C90-0x0000000186066D90
	}
}
