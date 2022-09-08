/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FftSharp;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace Watermark
{
	public static class BlindWatermark // TypeDefIndex: 32202
	{
		// Nested types
		public struct TiledImageWatermarkExtractInfo // TypeDefIndex: 32203
		{
			// Fields
			public double[,] unreducedResult; // 0x00
			public double[,] reducedResult; // 0x08
			public int windowHeight; // 0x10
			public int windowWidth; // 0x14
			public int tileVert; // 0x18
			public int tileHorz; // 0x1C
			public int offsetVertMax; // 0x20
			public int offsetHorzMax; // 0x24
			public int offsetVert; // 0x28
			public int offsetHorz; // 0x2C
		}
	
		private struct TiledImageWatermarkExtractRecord // TypeDefIndex: 32204
		{
			// Fields
			public int tileVert; // 0x00
			public int tileHorz; // 0x04
			public int offsetVert; // 0x08
			public int offsetHorz; // 0x0C
	
			// Methods
			public override bool Equals(object obj) => default; // 0x00000001864A2CB0-0x00000001864A2D70
			public override int GetHashCode() => default; // 0x00000001864A2D70-0x00000001864A2D80
		}
	
		private class RandomUnitGenerator // TypeDefIndex: 32205
		{
			// Fields
			private System.Random _random; // 0x10
	
			// Constructors
			public RandomUnitGenerator() {} // Dummy constructor
			public RandomUnitGenerator(int randomSeed) {} // 0x000000018649F9F0-0x00000001864A26C0
	
			// Methods
			public Complex Next() => default; // 0x000000018649F900-0x000000018649F9F0
		}
	
		// Methods
		public static double[,] PreprocessImageWatermark(double[,] watermark, int randomSeed) => default; // 0x0000000186487C40-0x0000000186487CE0
		public static void CurveGain(double[,] values, double gainFactor) {} // 0x0000000186486BB0-0x0000000186486DA0
		public static void SwapQuadrant<T>(T[,] image) {}
		public static double GetWeightByMaxColorDelta(double[,] preprocessedWatermark, int maxColorDelta) => default; // 0x00000001864878F0-0x00000001864879D0
		public static Texture2D EncodeTexture(out double valueMin, out double valueMax, double[,] preprocessedWatermark) {
			valueMin = default;
			valueMax = default;
			return default;
		} // 0x0000000186487020-0x0000000186487260
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public static IEnumerable<TiledImageWatermarkExtractInfo> ExtractTiledImageWatermark(double[,] imageBrightness, int watermarkWidth, int watermarkHeight, int randomSeed, int maxFailedAttempts, int maxLevels, bool useReduced) => default; // 0x0000000186487260-0x0000000186487380
		public static Complex[,] FFT_2D(double[,] input) => default; // 0x0000000186487380-0x00000001864874C0
		public static Complex[,] IFFT_2D(Complex[,] input) => default; // 0x00000001864879D0-0x0000000186487B10
		public static void GetValueRange(out double valueMin, out double valueMax, double[,] values) {
			valueMin = default;
			valueMax = default;
		} // 0x0000000186487790-0x00000001864878F0
		public static double[,] Resize(double[,] src, int dstWidth, int dstHeight) => default; // 0x0000000186487D60-0x0000000186488180
		public static int NextPowerOfTwo(int value) => default; // 0x0000000186487BB0-0x0000000186487C40
		public static int PrevPowerOfTwo(int value) => default; // 0x0000000186487CE0-0x0000000186487D60
		public static int IntLog2(uint value) => default; // 0x0000000186487B10-0x0000000186487BB0
		private static Complex[,] FFT_2D_Imp<T>(T[,] input, Func<T, Complex> Convert, Action<Complex[]> Transform) => default;
		private static void FillConjugateSymmetricBottomHalf(Complex[,] datas) {} // 0x00000001864874C0-0x00000001864876A0
		private static Complex[,] WatermarkToComplex(double[,] watermark, int randomSeed) => default; // 0x0000000186488520-0x00000001864886F0
		private static double CurveEaseMono(double a, double x) => default; // 0x0000000186486B00-0x0000000186486BB0
		private static void Swap<T>(ref T left, ref T right) {}
		private static void SwapRect<T>(T[,] values, int rowIndex0, int colIndex0, int rowIndex1, int colIndex1, int rectHeight, int rectWidth) {}
		private static void CopyRect<T>(T[,] dstValues, int dstRowIndexBegin, int dstColIndexBegin, T[,] srcValues, int srcRowIndexBegin, int srcColIndexBegin, int rectHeight, int rectWidth) {}
		private static T[,] New2DArray<T>(int height, int width, T defaultValue) => default;
		private static void TiledImageWatermarkExtractMergeResult(double currentValue, int currentRowIndex, int currentColIndex, int currentTileVert, int currentTileHorz, double[,] targetValues, int targetTileVert, int targetTileHorz) {} // 0x0000000186488180-0x00000001864882F0
		private static double Frac(double v) => default; // 0x00000001864876A0-0x0000000186487710
		private static Color EncodeFloatRGBA(double v) => default; // 0x0000000186486DA0-0x0000000186487020
	
		// Extension methods
		public static double GetPhaseNormalized(this Complex complex) => default; // 0x0000000186487710-0x0000000186487790
		public static double[,] ToReal(this Complex[,] valuesIn) => default; // 0x00000001864882F0-0x0000000186488420
	}
}
