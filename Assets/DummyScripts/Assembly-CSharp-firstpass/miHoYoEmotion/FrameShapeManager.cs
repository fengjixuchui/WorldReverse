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

namespace miHoYoEmotion
{
	public class FrameShapeManager : ElementManager // TypeDefIndex: 8490
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private FrameShapeRuntime[] _phonemeShapeRuntimes; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private FrameShapeRuntime[] _emotionShapeRuntimes; // 0x58
		protected FrameShapeData _frameShapeData; // 0x60
	
		// Nested types
		[Serializable]
		public class FrameBinding // TypeDefIndex: 8491
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public UnityEngine.Material templateMat; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public Renderer bindingRender; // 0x18
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public int propertyID; // 0x20
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public int matIndex; // 0x24
			private UnityEngine.Material _runtimeMat; // 0x28
	
			// Constructors
			public FrameBinding() {} // 0x0000000187255720-0x0000000187255980
	
			// Methods
			// [XID] // 0x0000000189A79550-0x0000000189A79570
			public void Apply(Texture2D frame, Vector2 offset, Vector2 scale) {} // 0x0000000187255060-0x00000001872552D0
		}
	
		[Serializable]
		public class FrameShapeRuntime : ElementManager.BaseShapeRuntime // TypeDefIndex: 8492
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public FrameBinding binding; // 0x18
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public Vector2 offset; // 0x20
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			public Vector2 scale; // 0x28
	
			// Constructors
			public FrameShapeRuntime() {} // 0x0000000187259C80-0x0000000187259D20
	
			// Methods
			// [XID] // 0x0000000189924E20-0x0000000189924E40
			public void Apply(Texture2D frame) {} // 0x0000000187259BB0-0x0000000187259C80
		}
	
		// Constructors
		public FrameShapeManager() {} // 0x0000000187259B40-0x0000000187259BB0
	
		// Methods
		// [XID] // 0x0000000189A2E3F0-0x0000000189A2E410
		protected override void Start() {} // 0x0000000187259540-0x0000000187259610
		// [XID] // 0x0000000189A35C60-0x0000000189A35C80
		protected override void OnEnable() {} // 0x0000000187259470-0x0000000187259540
		// [XID] // 0x0000000189A3D250-0x0000000189A3D270
		public override void InitEmoAnim() {} // 0x0000000187259380-0x0000000187259470
		// [XID] // 0x0000000189A44AE0-0x0000000189A44B00
		public void ForceUpdateShapeRuntime() {} // 0x00000001872592D0-0x0000000187259380
		// [XID] // 0x0000000189A4C200-0x0000000189A4C220
		public override void UpdateShapeData() {} // 0x00000001872597F0-0x0000000187259990
		// [XID] // 0x0000000189B7B8B0-0x0000000189B7B8D0
		protected override void UpdateShapeRuntime() {} // 0x0000000187259990-0x0000000187259B40
	}
}
