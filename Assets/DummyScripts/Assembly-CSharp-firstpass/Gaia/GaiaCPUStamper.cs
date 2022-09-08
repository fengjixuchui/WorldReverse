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

namespace Gaia
{
	public class GaiaCPUStamper // TypeDefIndex: 9154
	{
		// Fields
		public int _StampOperation; // 0x10
		public int _StampDimensions; // 0x14
		public float _StampSharpen; // 0x18
		public Vector4 _StampPosition; // 0x1C
		public Vector4 _StampScaleAndRotation; // 0x2C
		public float _StampNormalConversion; // 0x3C
		public float[] _Stamp; // 0x40
		public Vector4 _HeightmapPosition; // 0x48
		public Vector4 _HeightmapDimensions; // 0x58
		public float _HeightmapNormalConversion; // 0x68
		public float[] _Heightmap; // 0x70
		public int _DistanceMaskSize; // 0x78
		public float[] _DistanceMask; // 0x80
	
		// Constructors
		public GaiaCPUStamper() {} // 0x0000000186588400-0x00000001865885A0
	
		// Methods
		// [XID] // 0x0000000189B06D50-0x0000000189B06D70
		private Vector2 RotatePointAroundPivot(Vector2 point, Vector2 pivot, float angleDegrees) => default; // 0x0000000186587FB0-0x0000000186588130
		// [XID] // 0x0000000189B0E5D0-0x0000000189B0E5F0
		private Vector2 Translate1DTo2D(long address1D, long dimensions) => default; // 0x0000000186588130-0x0000000186588240
		// [XID] // 0x0000000189B156F0-0x0000000189B15710
		private long Translate2DTo1DActual(Vector2 address2D, long dimensions) => default; // 0x0000000186588240-0x0000000186588320
		// [XID] // 0x0000000189B1D1A0-0x0000000189B1D1C0
		private long Translate2DTo1D(long x, long y, long dimensions) => default; // 0x0000000186588320-0x0000000186588400
		// [XID] // 0x0000000189B24790-0x0000000189B247B0
		private float GetInterpolatedStampHeight(Vector2 address2DNrm) => default; // 0x0000000186587BB0-0x0000000186587EC0
		// [XID] // 0x0000000189B2BBE0-0x0000000189B2BC00
		private float CosineInterpolate(float v1, float v2, float lerp) => default; // 0x00000001865877D0-0x0000000186587910
		// [XID] // 0x0000000189B330D0-0x0000000189B330F0
		private float LinearInterpolate(float v1, float v2, float lerp) => default; // 0x0000000186587EC0-0x0000000186587FB0
		// [XID] // 0x0000000189B3AC70-0x0000000189B3AC90
		private float GetDistanceMask(float distancePct) => default; // 0x0000000186587910-0x0000000186587A80
		// [XID] // 0x00000001896C57B0-0x00000001896C57D0
		private float GetDistance(Vector2 point1, Vector2 point2) => default; // 0x0000000186587A80-0x0000000186587BB0
		// [XID] // 0x0000000189B49E60-0x0000000189B49E80
		private Vector3 ComputeStampNormals(Vector2 address2DNrm) => default; // 0x0000000186587560-0x00000001865877D0
		// [XID] // 0x0000000189B51680-0x0000000189B516A0
		public void ApplyStamp() {} // 0x0000000186587140-0x0000000186587560
	}
}
