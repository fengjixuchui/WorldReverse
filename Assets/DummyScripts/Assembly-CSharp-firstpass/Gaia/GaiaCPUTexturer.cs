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
	public class GaiaCPUTexturer // TypeDefIndex: 9155
	{
		// Fields
		public Vector4 _Position; // 0x10
		public float _SeaLevel; // 0x20
		public int _TextureDimensions; // 0x24
		public float _TextureNormalConversion; // 0x28
		public int _TextureCount; // 0x2C
		public float[,,] _TerrainTextures; // 0x30
		public int _TextureCurveLength; // 0x38
		public bool[] _TextureCheckHeights; // 0x40
		public Vector2[] _TextureHeightRanges; // 0x48
		public float[,] _TextureHeightCurves; // 0x50
		public bool[] _TextureCheckSlopes; // 0x58
		public Vector2[] _TextureSlopeRanges; // 0x60
		public float[,] _TextureSlopeCurves; // 0x68
		public bool[] _TextureIgnoreMasks; // 0x70
		public Texture2D _TextureMask; // 0x78
		public int _TextureMaskDimensions; // 0x80
		public Vector4 _HeightmapPosition; // 0x84
		public Vector4 _HeightmapDimensions; // 0x94
		public float _HeightmapNormalConversion; // 0xA4
		public float[] _Heightmap; // 0xA8
	
		// Constructors
		public GaiaCPUTexturer() {} // 0x000000018658A2B0-0x000000018658A510
	
		// Methods
		// [XID] // 0x000000018980EE60-0x000000018980EE80
		private Vector2 Translate1DTo2D(long address1D, long dimensions) => default; // 0x0000000186589E00-0x0000000186589F10
		// [XID] // 0x00000001896D3FE0-0x00000001896D4000
		private long Translate2DTo1DActual(Vector2 address2D, long dimensions) => default; // 0x0000000186589F10-0x0000000186589FF0
		// [XID] // 0x00000001898164D0-0x00000001898164F0
		private long Translate2DTo1D(long x, long y, long dimensions) => default; // 0x0000000186589FF0-0x000000018658A0D0
		// [XID] // 0x0000000189B6F0A0-0x0000000189B6F0C0
		private float GetInterpolatedTerrainHeight(Vector2 address2DNrm) => default; // 0x0000000186589620-0x0000000186589950
		// [XID] // 0x0000000189B76740-0x0000000189B76760
		private float GetInterpolatedTexureMask(Vector2 address2DNrm) => default; // 0x0000000186589950-0x0000000186589A10
		// [XID] // 0x0000000189B7DD00-0x0000000189B7DD20
		private Vector2 ComputeTerrainHeightAndSlope(Vector2 address2DNrm) => default; // 0x0000000186588D70-0x0000000186589020
		// [XID] // 0x0000000189B85A20-0x0000000189B85A40
		private Vector2 ComputeTerrainHeightAndSlopeFaster(Vector2 address2DNrm) => default; // 0x0000000186588B40-0x0000000186588D70
		// [XID] // 0x00000001896EA6E0-0x00000001896EA700
		private Vector3 ComputeTerrainNormal(Vector2 address2DNrm) => default; // 0x0000000186589020-0x0000000186589320
		// [XID] // 0x000000018982CC10-0x000000018982CC30
		private float LinearInterpolate(float v1, float v2, float lerp) => default; // 0x0000000186589D10-0x0000000186589E00
		// [XID] // 0x0000000189B9B860-0x0000000189B9B880
		private float GetHeightMask(int curveIdx, float distancePct) => default; // 0x0000000186589460-0x0000000186589620
		// [XID] // 0x0000000189BA3080-0x0000000189BA30A0
		private float GetSlopeMask(int curveIdx, float distancePct) => default; // 0x0000000186589B50-0x0000000186589D10
		// [XID] // 0x0000000189BAA320-0x0000000189BAA340
		public void Apply() {} // 0x00000001865885A0-0x0000000186588B40
		// [XID] // 0x000000018998CC20-0x000000018998CC40
		private float GetSlopeFitness(int texture, float slope, float minSlope, float maxSlope) => default; // 0x0000000186589A10-0x0000000186589B50
		// [XID] // 0x0000000189924410-0x0000000189924430
		private float GetHeightFitness(int texture, float height, float seaLevel, float minHeight, float maxHeight) => default; // 0x0000000186589320-0x0000000186589460
		// [XID] // 0x0000000189BC0580-0x0000000189BC05A0
		private void UpdateTextures(int x, int y, int targetTexture, float value) {} // 0x000000018658A0D0-0x000000018658A2B0
	}
}
