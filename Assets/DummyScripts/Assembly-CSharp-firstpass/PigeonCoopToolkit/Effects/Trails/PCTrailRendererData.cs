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

namespace PigeonCoopToolkit.Effects.Trails
{
	[Serializable]
	public class PCTrailRendererData // TypeDefIndex: 9458
	{
		// Fields
		public UnityEngine.Material[] TrailMaterials; // 0x10
		public float Lifetime; // 0x18
		public bool UsingSimpleSize; // 0x1C
		public float SimpleSizeOverLifeStart; // 0x20
		public float SimpleSizeOverLifeEnd; // 0x24
		public AnimationCurve SizeOverLife; // 0x28
		public bool UsingSimpleColor; // 0x30
		public Color SimpleColorOverLifeStart; // 0x34
		public Color SimpleColorOverLifeEnd; // 0x44
		public Gradient ColorOverLife; // 0x58
		public bool StretchSizeToFit; // 0x60
		public bool StretchColorToFit; // 0x61
		public float MaterialTileLength; // 0x64
		public bool UseForwardOverride; // 0x68
		public Vector3 ForwardOverride; // 0x6C
		public bool ForwardOverrideRelative; // 0x78
		public bool UseUpOverride; // 0x79
		public Vector3 UpOverride; // 0x7C
		public int ExpandDirSmoothIteration; // 0x88
		public bool UseDistortion; // 0x8C
		public DistortionPlaneType DistortionPlane; // 0x90
		public float Frequency; // 0x94
		public float Amplitude; // 0x98
		public float WalkAuto; // 0x9C
		public float WarpRandom; // 0xA0
		[NonSerialized]
		private TrailRenderer_Base.MaterialsContainer _materialsContainer; // 0xA8
	
		// Nested types
		public enum DistortionPlaneType // TypeDefIndex: 9459
		{
			X = 0,
			Y = 1,
			Z = 2,
			XY = 3,
			XZ = 4,
			YZ = 5
		}
	
		// Constructors
		public PCTrailRendererData() {} // 0x0000000186016010-0x0000000186016130
	
		// Methods
		// [XID] // 0x0000000189AE6060-0x0000000189AE6080
		public TrailRenderer_Base.MaterialsContainer GetMaterialsContainer() => default; // 0x0000000186015F20-0x0000000186016010
	}
}
