/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class P3D_Brush // TypeDefIndex: 9416
{
	// Fields
	public static Action<Texture2D, P3D_Rect> OnPrePaint; // 0x00
	public static Action<Texture2D, P3D_Rect> OnPostPaint; // 0x08
	// [Tooltip] // 0x000000018972A6B0-0x000000018972A6E0
	public string Name; // 0x10
	// [Range] // 0x0000000189733500-0x0000000189733560
	// [Tooltip] // 0x0000000189733500-0x0000000189733560
	public float Opacity; // 0x18
	// [Range] // 0x000000018973FC50-0x000000018973FCA0
	// [Tooltip] // 0x000000018973FC50-0x000000018973FCA0
	public float Angle; // 0x1C
	// [Tooltip] // 0x000000018974BAE0-0x000000018974BB10
	public Vector2 Offset; // 0x20
	// [Tooltip] // 0x00000001897548A0-0x00000001897548D0
	public Vector2 Size; // 0x28
	// [Tooltip] // 0x000000018975D310-0x000000018975D340
	public P3D_BlendMode Blend; // 0x30
	// [Tooltip] // 0x0000000189766280-0x00000001897662B0
	public Texture2D Shape; // 0x38
	// [Tooltip] // 0x000000018976EFF0-0x000000018976F020
	public Color Color; // 0x40
	// [Tooltip] // 0x0000000189778210-0x0000000189778240
	public Vector2 Direction; // 0x50
	// [Tooltip] // 0x0000000189781390-0x00000001897813C0
	public Texture2D Detail; // 0x58
	// [Tooltip] // 0x0000000189789F70-0x0000000189789FA0
	public Vector2 DetailScale; // 0x60
	private static Texture2D canvas; // 0x10
	private static Texture2D canvasCopy; // 0x18
	private static int canvasW; // 0x20
	private static int canvasH; // 0x24
	private static P3D_Rect rect; // 0x28
	private static P3D_Matrix matrix; // 0x38
	private static P3D_Matrix inverse; // 0x5C
	private static float opacity; // 0x80
	private static Color color; // 0x84
	private static Vector2 direction; // 0x94
	private static Texture2D shape; // 0xA0
	private static Texture2D detail; // 0xA8
	private static Vector2 detailScale; // 0xB0
	private static float OPACITY_SCALE; // 0xB8
	private static P3D_Brush tempInstance; // 0xC0

	// Properties
	public static P3D_Brush TempInstance { get => default; } // 0x0000000187231360-0x0000000187231470 

	// Nested types
	private static class AdditiveBlend // TypeDefIndex: 9417
	{
		// Methods
		public static void Paint() {} // 0x0000000187226F40-0x0000000187227610
		private static Color Blend(Color old, Color add) => default; // 0x0000000187226E90-0x0000000187226F40
	}

	private static class AlphaBlend // TypeDefIndex: 9418
	{
		// Methods
		public static void Paint() {} // 0x0000000187227E80-0x00000001872284D0
		private static Color Blend(Color old, Color add) => default; // 0x0000000187227D70-0x0000000187227E80
	}

	private static class CustomBlend // TypeDefIndex: 9419
	{
		// Methods
		public static void Paint() {} // 0x0000000187228B80-0x0000000187229210
	}

	private static class AlphaBlendRGB // TypeDefIndex: 9420
	{
		// Methods
		public static void Paint() {} // 0x0000000187227720-0x0000000187227D70
		private static Color Blend(Color old, Color add) => default; // 0x0000000187227610-0x0000000187227720
	}

	private static class AlphaErase // TypeDefIndex: 9421
	{
		// Methods
		public static void Paint() {} // 0x0000000187228550-0x0000000187228B80
		private static Color Blend(Color old, float sub) => default; // 0x00000001872284D0-0x0000000187228550
	}

	private static class NormalBlend // TypeDefIndex: 9422
	{
		// Methods
		public static void Paint() {} // 0x000000018722E630-0x000000018722F690
		private static Vector3 ColorToNormalXY(Color c) => default; // 0x000000018722E210-0x000000018722E2C0
		private static Color NormalToColor(Vector3 n) => default; // 0x000000018722E580-0x000000018722E630
		private static Vector3 ComputeZ(Vector3 a) => default; // 0x000000018722E4B0-0x000000018722E580
		private static Vector3 CombineNormalsXY(Vector3 a, Vector3 b) => default; // 0x000000018722E410-0x000000018722E4B0
		private static Vector3 CombineNormalsXY(Vector3 a, Vector3 b, float c) => default; // 0x000000018722E360-0x000000018722E410
		private static Vector3 CombineNormalsXY(Vector3 a, Vector2 b, float c) => default; // 0x000000018722E2C0-0x000000018722E360
	}

	private static class Replace // TypeDefIndex: 9423
	{
		// Methods
		public static void Paint() {} // 0x0000000187242A20-0x0000000187243060
		private static Color Blend(Color old, Color add) => default; // 0x0000000187242910-0x0000000187242A20
	}

	private static class SubtractiveBlend // TypeDefIndex: 9424
	{
		// Methods
		public static void Paint() {} // 0x0000000187243110-0x00000001872437E0
		private static Color Blend(Color old, Color sub) => default; // 0x0000000187243060-0x0000000187243110
	}

	// Constructors
	public P3D_Brush() {} // 0x0000000187231270-0x0000000187231360
	static P3D_Brush() {} // 0x0000000187231200-0x0000000187231270

	// Methods
	public P3D_Brush GetTempClone() => default; // 0x0000000187230B20-0x0000000187230BD0
	public void CopyTo(P3D_Brush other) {} // 0x0000000187230A50-0x0000000187230B20
	public void Paint(Texture2D newCanvas, P3D_Matrix newMatrix, Texture2D newCanvasCopy) {} // 0x0000000187230CA0-0x0000000187231110
	private bool CalculateRect(ref P3D_Rect rect) => default; // 0x0000000187230690-0x0000000187230A50
	private static bool IsInsideShape(P3D_Matrix inverseMatrix, int x, int y, ref Vector2 shapeCoord) => default; // 0x0000000187230BD0-0x0000000187230CA0
	private static Color SampleRepeat(Texture2D texture, float u, float v) => default; // 0x0000000187231110-0x0000000187231200
}

