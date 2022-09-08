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
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class WaterRipplesRenderer : PostProcessEffectRenderer<WaterRipple> // TypeDefIndex: 9544
	{
		// Fields
		private static readonly float EPS; // 0x00
		private static readonly int RIPPLE_TEXTURE_SIZE; // 0x04
		public static readonly string WATER_RIPPLE_ON_KEYWORD; // 0x08
		public static readonly string WATER_RIPPLE_INIT_KEYWORD; // 0x10
		private Vector2 _lastSnapPos; // 0x20
		private bool _isInitSim; // 0x28
		private float _lastUpdateTime; // 0x2C
		private bool _isSnapToCenter; // 0x30
		private List<Vector2> _hitPoints; // 0x38
		private HashSet<Vector2> _preHitPointHashSet; // 0x40
		private Camera _curCam; // 0x48
		private Vector3 _curCamPos; // 0x50
		private CommandBuffer _curCommandBuffer; // 0x60
		private PropertySheet _curSheet; // 0x68
		private Vector4 _waterRippleParam; // 0x70
		private RenderTexture _waterRipples; // 0x80
		private RenderTexture _waterRipplesTemp; // 0x88
		private bool _haveAddHitPointAction; // 0x90
	
		// Nested types
		private enum Pass // TypeDefIndex: 9545
		{
			RippleHit = 0,
			RippleGen = 1
		}
	
		public static class Uniforms // TypeDefIndex: 9546
		{
			// Fields
			internal static readonly int WATERRIPPLES; // 0x00
			internal static readonly int WATERRIPPLEPARAMS; // 0x04
			internal static readonly int RIPPLEPARAM; // 0x08
			internal static readonly int RIPPLEQUAD; // 0x0C
			internal static readonly int RIPPLETEX; // 0x10
			internal static readonly int RIPPLESPREADSPEED; // 0x14
	
			// Constructors
			static Uniforms() {} // 0x00000001862B40C0-0x00000001862B41E0
		}
	
		// Constructors
		public WaterRipplesRenderer() {} // 0x00000001862BDCD0-0x00000001862BDE60
		static WaterRipplesRenderer() {} // 0x00000001862BDC30-0x00000001862BDCD0
	
		// Methods
		// [XID] // 0x0000000189B5D4A0-0x0000000189B5D4C0
		public override void Init() {} // 0x00000001862BC440-0x00000001862BC4E0
		// [XID] // 0x0000000189B64C30-0x0000000189B64C50
		internal void InitParams() {} // 0x00000001862BC2C0-0x00000001862BC440
		// [XID] // 0x0000000189B6C010-0x0000000189B6C030
		internal void CreateTextures() {} // 0x00000001862BBE50-0x00000001862BC1C0
		// [XID] // 0x0000000189B73870-0x0000000189B73890
		public override void Release(PostProcessRenderContext context) {} // 0x00000001862BC4E0-0x00000001862BC710
		// [XID] // 0x0000000189B7AD80-0x0000000189B7ADA0
		internal void GetHitPoints(Vector3 pos) {} // 0x00000001862BC1C0-0x00000001862BC2C0
		// [XID] // 0x0000000189B82730-0x0000000189B82750
		internal void RenderRipples() {} // 0x00000001862BCC60-0x00000001862BD520
		// [XID] // 0x000000018970A7E0-0x000000018970A800
		internal void RenderHitPoints() {} // 0x00000001862BC710-0x00000001862BCC60
		// [XID] // 0x000000018986F800-0x000000018986F820
		internal void SetWaterMaterial() {} // 0x00000001862BD850-0x00000001862BDB50
		// [XID] // 0x00000001897603D0-0x00000001897603F0
		internal void ClearHitPoint(bool clearHashSet) {} // 0x00000001862BBCE0-0x00000001862BBE50
		// [XID] // 0x000000018987E8C0-0x000000018987E8E0
		public override void Render(PostProcessRenderContext context) {} // 0x00000001862BD520-0x00000001862BD850
	}
}
