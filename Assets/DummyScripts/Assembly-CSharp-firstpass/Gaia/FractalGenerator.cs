/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class FractalGenerator // TypeDefIndex: 9328
	{
		// Fields
		private float m_seed; // 0x10
		private int m_octaves; // 0x14
		private float m_persistence; // 0x18
		private float m_frequency; // 0x1C
		private float m_lacunarity; // 0x20
		private float m_XOffset; // 0x24
		private float m_ZOffset; // 0x28
		private float m_YOffset; // 0x2C
		private Fractals m_fractalType; // 0x30
		private float[] m_spectralWeights; // 0x38
		private GetCalcValue m_noiseCalculator; // 0x40
	
		// Properties
		public float Seed { /* [XID] */ /* 0x0000000189B7ADA0-0x0000000189B7ADC0 */ get => default; /* [XID] */ /* 0x0000000189B827A0-0x0000000189B827C0 */ set {} } // 0x0000000186B3D7D0-0x0000000186B3D880 0x0000000186B3DE70-0x0000000186B3DF20
		public int Octaves { /* [XID] */ /* 0x0000000189B0D6B0-0x0000000189B0D6D0 */ get => default; /* [XID] */ /* 0x0000000189B91530-0x0000000189B91550 */ set {} } // 0x0000000186B3D680-0x0000000186B3D720 0x0000000186B3DD10-0x0000000186B3DDC0
		public float Persistence { /* [XID] */ /* 0x0000000189671900-0x0000000189671920 */ get => default; /* [XID] */ /* 0x0000000189889080-0x00000001898890A0 */ set {} } // 0x0000000186B3D720-0x0000000186B3D7D0 0x0000000186B3DDC0-0x0000000186B3DE70
		public float Frequency { /* [XID] */ /* 0x0000000189B14BD0-0x0000000189B14BF0 */ get => default; /* [XID] */ /* 0x0000000189925040-0x0000000189925060 */ set {} } // 0x0000000186B3D520-0x0000000186B3D5D0 0x0000000186B3DBB0-0x0000000186B3DC60
		public float Lacunarity { /* [XID] */ /* 0x0000000189BB5E70-0x0000000189BB5E90 */ get => default; /* [XID] */ /* 0x0000000189915DC0-0x0000000189915DE0 */ set {} } // 0x0000000186B3D5D0-0x0000000186B3D680 0x0000000186B3DC60-0x0000000186B3DD10
		public float XOffset { /* [XID] */ /* 0x0000000189BC70F0-0x0000000189BC7110 */ get => default; /* [XID] */ /* 0x0000000189BCCC20-0x0000000189BCCC40 */ set {} } // 0x0000000186B3D880-0x0000000186B3D930 0x0000000186B3DF20-0x0000000186B3DFD0
		public float ZOffset { /* [XID] */ /* 0x00000001895F1E10-0x00000001895F1E30 */ get => default; /* [XID] */ /* 0x0000000189BDBC00-0x0000000189BDBC20 */ set {} } // 0x0000000186B3D9E0-0x0000000186B3DA90 0x0000000186B3E080-0x0000000186B3E130
		public float YOffset { /* [XID] */ /* 0x0000000189BDDD00-0x0000000189BDDD20 */ get => default; /* [XID] */ /* 0x00000001895EFD60-0x00000001895EFD80 */ set {} } // 0x0000000186B3D930-0x0000000186B3D9E0 0x0000000186B3DFD0-0x0000000186B3E080
		public Fractals FractalType { /* [XID] */ /* 0x0000000189B39C50-0x0000000189B39C70 */ get => default; /* [XID] */ /* 0x00000001895FEA70-0x00000001895FEA90 */ set {} } // 0x0000000186B3D480-0x0000000186B3D520 0x0000000186B3DA90-0x0000000186B3DBB0
	
		// Nested types
		public enum Fractals // TypeDefIndex: 9329
		{
			Perlin = 0,
			Billow = 1,
			RidgeMulti = 2,
			fBM = 3
		}
	
		private delegate float GetCalcValue(float x, float z); // TypeDefIndex: 9330; 0x0000000186B403E0-0x0000000186B405A0
	
		// Constructors
		public FractalGenerator() {} // 0x0000000186B3D190-0x0000000186B3D2F0
		public FractalGenerator(float frequency, float lacunarity, int octaves, float persistance, float seed, Fractals type) {} // 0x0000000186B3D2F0-0x0000000186B3D480
	
		// Methods
		// [XID] // 0x0000000189B41510-0x0000000189B41530
		public void SetDefaults() {} // 0x0000000186B3CFE0-0x0000000186B3D190
		// [IDTag] // 0x000000018960DDC0-0x000000018960DE00
		// [XID] // 0x000000018960DDC0-0x000000018960DE00
		public float GetValue(float x, float z) => default; // 0x0000000186B3CF00-0x0000000186B3CFE0
		// [IDTag] // 0x00000001896181F0-0x0000000189618230
		// [XID] // 0x00000001896181F0-0x0000000189618230
		public double GetValue(double x, double z) => default; // 0x0000000186B3CE20-0x0000000186B3CF00
		// [IDTag] // 0x00000001896229D0-0x0000000189622A10
		// [XID] // 0x00000001896229D0-0x0000000189622A10
		public float GetNormalisedValue(float x, float z) => default; // 0x0000000186B3C450-0x0000000186B3C560
		// [IDTag] // 0x000000018962D1C0-0x000000018962D200
		// [XID] // 0x000000018962D1C0-0x000000018962D200
		public double GetNormalisedValue(double x, double z) => default; // 0x0000000186B3C560-0x0000000186B3C640
		// [XID] // 0x0000000189A938D0-0x0000000189A938F0
		public float GetValue_Perlin(float x, float z) => default; // 0x0000000186B3C840-0x0000000186B3C9F0
		// [XID] // 0x000000018963F130-0x000000018963F150
		public float GetValue_Billow(float x, float z) => default; // 0x0000000186B3C640-0x0000000186B3C840
		// [XID] // 0x00000001895FB230-0x00000001895FB250
		public float GetValue_RidgedMulti(float x, float z) => default; // 0x0000000186B3C9F0-0x0000000186B3CC70
		// [XID] // 0x000000018964E260-0x000000018964E280
		public float GetValue_fBM(float x, float z) => default; // 0x0000000186B3CC70-0x0000000186B3CE20
		// [XID] // 0x00000001897343D0-0x00000001897343F0
		private void CalcSpectralWeights() {} // 0x0000000186B3C2E0-0x0000000186B3C450
	}
}
