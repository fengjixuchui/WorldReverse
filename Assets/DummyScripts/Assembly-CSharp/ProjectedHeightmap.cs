/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ProjectedHeightmap // TypeDefIndex: 14716
{
	// Fields
	private static readonly HashSet<Quant> _quantSet; // 0x00
	private readonly int _x; // 0x10
	private readonly int _y; // 0x14
	private readonly int _xBoundLow; // 0x18
	private readonly int _xBoundHigh; // 0x1C
	private readonly int _yBoundLow; // 0x20
	private readonly int _yBoundHigh; // 0x24
	private readonly float _xInterval; // 0x28
	private readonly float _yInterval; // 0x2C
	private readonly float _xStep; // 0x30
	private readonly float _yStep; // 0x34
	private readonly float[,] _heightmap; // 0x38
	private readonly Vector3[,] _normals; // 0x40
	private Matrix4x4 _mToWorld; // 0x48
	private Matrix4x4 _mToLocal; // 0x88
	public Matrix4x4 boxToUnifiedBox; // 0xC8
	public Matrix4x4 unifiedBoxToBox; // 0x108
	public Matrix4x4 boxToWorld; // 0x148
	public float depth; // 0x188
	private const float MIN_FILTER_DEPTH = 0.2f; // Metadata: 0x00AEBE5E

	// Properties
	public Matrix4x4 transformMatrixToWorld { /* [XID] */ /* 0x0000000189B7AA90-0x0000000189B7AAB0 */ get => default; /* [XID] */ /* 0x00000001897B6530-0x00000001897B6550 */ set {} } // 0x0000000183946A30-0x0000000183946B80 0x00000001839476B0-0x00000001839477E0
	public Matrix4x4 transformMatrixToLocal { /* [XID] */ /* 0x0000000189B89B50-0x0000000189B89B70 */ get => default; } // 0x000000018394B620-0x000000018394B780 
	public int X { /* [XID] */ /* 0x0000000189B910E0-0x0000000189B91100 */ get => default; } // 0x000000018394A270-0x000000018394A310 
	public int Y { /* [XID] */ /* 0x000000018981E050-0x000000018981E070 */ get => default; } // 0x0000000183948B40-0x0000000183948BE0 
	public int XMin { /* [XID] */ /* 0x0000000189867A50-0x0000000189867A70 */ get => default; } // 0x000000018394A680-0x000000018394A720 
	public int XMax { /* [XID] */ /* 0x00000001898A2A40-0x00000001898A2A60 */ get => default; } // 0x000000018394C400-0x000000018394C4A0 
	public int YMin { /* [XID] */ /* 0x0000000189BAE240-0x0000000189BAE260 */ get => default; } // 0x0000000183947610-0x00000001839476B0 
	public int YMax { /* [XID] */ /* 0x000000018988C920-0x000000018988C940 */ get => default; } // 0x000000018394B3D0-0x000000018394B470 
	public Vector3 this[int m, int n] { /* [XID] */ /* 0x0000000189BBD190-0x0000000189BBD1B0 */ get => default; /* [XID] */ /* 0x0000000189BC4D80-0x0000000189BC4DA0 */ set {} } // 0x000000018394AAB0-0x000000018394ACB0 0x000000018394A100-0x000000018394A270

	// Nested types
	public interface ILocalCriteria // TypeDefIndex: 14717
	{
		// Methods
		bool Pass(Quant quant, float localHeight);
	}

	public interface IWorldCriteria // TypeDefIndex: 14718
	{
		// Methods
		bool Pass(Vector3 worldPosition);
	}

	public struct Quant // TypeDefIndex: 14719
	{
		// Properties
		public int m { /* [XID] */ /* 0x00000001896EBC90-0x00000001896EBCD0 */ get; /* [XID] */ /* 0x00000001896F6460-0x00000001896F64A0 */ set; } // 0x0000000183940730-0x0000000183940790 0x0000000183940670-0x00000001839406D0
		public int n { /* [XID] */ /* 0x00000001897008D0-0x0000000189700910 */ get; /* [XID] */ /* 0x000000018970B050-0x000000018970B090 */ set; } // 0x0000000183940610-0x0000000183940670 0x00000001839406D0-0x0000000183940730
	}

	public class QuantEqualityComparer : IEqualityComparer<Quant> // TypeDefIndex: 14720
	{
		// Constructors
		public QuantEqualityComparer() {} // 0x000000018393F420-0x000000018393F480

		// Methods
		// [XID] // 0x0000000189715470-0x0000000189715490
		public bool Equals(Quant x, Quant y) => default; // 0x000000018393F170-0x000000018393F330
		// [XID] // 0x000000018971D010-0x000000018971D030
		public int GetHashCode(Quant obj) => default; // 0x000000018393F330-0x000000018393F420
	}

	// Constructors
	public ProjectedHeightmap() {} // Dummy constructor
	static ProjectedHeightmap() {} // 0x000000018394C6C0-0x000000018394C760
	public ProjectedHeightmap(int sizeX, int sizeY) {} // 0x000000018394C760-0x000000018394C8E0

	// Methods
	// [XID] // 0x0000000189BCC8E0-0x0000000189BCC900
	public Vector3 GetNormal(int m, int n) => default; // 0x0000000183948BE0-0x0000000183948D90
	// [XID] // 0x0000000189BD3F30-0x0000000189BD3F50
	public void SetNormal(int m, int n, Vector3 value) {} // 0x000000018394A970-0x000000018394AAB0
	// [XID] // 0x0000000189BDB890-0x0000000189BDB8B0
	public float GetLocalHeight(int m, int n) => default; // 0x0000000183949DD0-0x0000000183949EE0
	// [XID] // 0x00000001897C5980-0x00000001897C59A0
	public void Clear() {} // 0x0000000183948790-0x0000000183948910
	// [XID] // 0x00000001895EFA20-0x00000001895EFA40
	public void ProjectTriangle(Vector3 v1, Vector3 v2, Vector3 v3) {} // 0x00000001839481F0-0x0000000183948790
	// [XID] // 0x00000001895F7450-0x00000001895F7470
	private void ScanTriangle(Vector3 vs, Vector3 vl, Vector3 vr, bool topDown, Vector3 normal) {} // 0x0000000183946EE0-0x0000000183947430
	// [XID] // 0x0000000189876610-0x0000000189876630
	public Vector3 WithHeight(int m, int n, float height) => default; // 0x0000000183949510-0x0000000183949710
	// [XID] // 0x0000000189606190-0x00000001896061B0
	public void FindOverlappingSampleRegionNonExtending(float xMin, float xMax, float yMin, float yMax, out int mMin, out int mMax, out int nMin, out int nMax) {
		mMin = default;
		mMax = default;
		nMin = default;
		nMax = default;
	} // 0x000000018394ACB0-0x000000018394AEB0
	// [XID] // 0x000000018960D9F0-0x000000018960DA10
	public void FindOverlappingSampleRegion(float xMin, float xMax, float yMin, float yMax, out int mMin, out int mMax, out int nMin, out int nMax) {
		mMin = default;
		mMax = default;
		nMin = default;
		nMax = default;
	} // 0x000000018394A720-0x000000018394A970
	// [XID] // 0x00000001896151F0-0x0000000189615210
	public float BilinearInterpolatedHeight(float x, float z) => default; // 0x0000000183946B80-0x0000000183946EE0
	// [XID] // 0x00000001898B93D0-0x00000001898B93F0
	public float CurrentHeight() => default; // 0x000000018394C290-0x000000018394C400
	// [XID] // 0x0000000189623E40-0x0000000189623E60
	public float GetMaxOverlapHeight(IHeightProvider incomeHeight) => default; // 0x000000018394B1A0-0x000000018394B3D0
	// [XID] // 0x000000018962B5B0-0x000000018962B5D0
	public float CalcVarianceAgainst(float[,] smoothed) => default; // 0x0000000183947430-0x0000000183947610
	// [IDTag] // 0x0000000189632D50-0x0000000189632D90
	// [XID] // 0x0000000189632D50-0x0000000189632D90
	public float CalculateCorrelationCoefficient() => default; // 0x0000000183949710-0x00000001839497E0
	// [IDTag] // 0x000000018963D930-0x000000018963D970
	// [XID] // 0x000000018963D930-0x000000018963D970
	public float CalculateCorrelationCoefficient(int m1, int m2, int n1, int n2) => default; // 0x00000001839497E0-0x0000000183949DD0
	// [IDTag] // 0x0000000189647E60-0x0000000189647EA0
	// [XID] // 0x0000000189647E60-0x0000000189647EA0
	public void LinearRegression(out Plane plane, bool filter = true /* Metadata: 0x00AEBE5C */) {
		plane = default;
	} // 0x000000018394B780-0x000000018394B870
	// [IDTag] // 0x00000001896525C0-0x0000000189652600
	// [XID] // 0x00000001896525C0-0x0000000189652600
	public void LinearRegression(int m1, int m2, int n1, int n2, out Plane plane, bool filter = true /* Metadata: 0x00AEBE5D */) {
		plane = default;
	} // 0x000000018394B870-0x000000018394C290
	// [XID] // 0x000000018965CF00-0x000000018965CF20
	public void SobelPolar(int m, int n, out float sqrG, out float theta) {
		sqrG = default;
		theta = default;
	} // 0x0000000183948910-0x0000000183948B40
	// [XID] // 0x00000001896644F0-0x0000000189664510
	public void SobelVector(int m, int n, out float gx, out float gy) {
		gx = default;
		gy = default;
	} // 0x000000018394AEB0-0x000000018394B1A0
	// [XID] // 0x000000018966BAB0-0x000000018966BAD0
	public void FindMaximaAndMinima(out float max, out float min) {
		max = default;
		min = default;
	} // 0x00000001839480B0-0x00000001839481F0
	// [XID] // 0x0000000189673900-0x0000000189673920
	public bool Every(int m1, int m2, int n1, int n2, ILocalCriteria criteria) => default; // 0x000000018394C4A0-0x000000018394C6C0
	// [XID] // 0x000000018967B060-0x000000018967B080
	public int Count(int m1, int m2, int n1, int n2, ILocalCriteria criteria) => default; // 0x0000000183949EE0-0x000000018394A100
	// [IDTag] // 0x00000001896828E0-0x0000000189682920
	// [XID] // 0x00000001896828E0-0x0000000189682920
	public void PickQuant(IList<Quant> collection, ILocalCriteria criteria) {} // 0x0000000183949020-0x0000000183949220
	// [IDTag] // 0x000000018968D230-0x000000018968D270
	// [XID] // 0x000000018968D230-0x000000018968D270
	public void PickQuant(IList<Quant> collection, IWorldCriteria criteria) {} // 0x0000000183948D90-0x0000000183949020
	// [IDTag] // 0x0000000189698160-0x00000001896981A0
	// [XID] // 0x0000000189698160-0x00000001896981A0
	public void PickLocalHeight(IList<float> collection, ILocalCriteria criteria) {} // 0x00000001839477E0-0x00000001839479E0
	// [IDTag] // 0x00000001896A2740-0x00000001896A2780
	// [XID] // 0x00000001896A2740-0x00000001896A2780
	public void PickLocalHeight(IList<float> collection, IWorldCriteria criteria) {} // 0x00000001839479E0-0x0000000183947BE0
	// [IDTag] // 0x00000001896AC900-0x00000001896AC940
	// [XID] // 0x00000001896AC900-0x00000001896AC940
	public void PickWorldPoint(IList<Vector3> collection, ILocalCriteria criteria) {} // 0x0000000183947BE0-0x0000000183947E90
	// [IDTag] // 0x00000001896B6AA0-0x00000001896B6AE0
	// [XID] // 0x00000001896B6AA0-0x00000001896B6AE0
	public void PickWorldPoint(IList<Vector3> collection, IWorldCriteria criteria) {} // 0x0000000183947E90-0x00000001839480B0
	// [XID] // 0x00000001896C0E40-0x00000001896C0E60
	public void Compensate(IList<Quant> collection, IList<Quant> compensation) {} // 0x0000000183949220-0x0000000183949510
	// [XID] // 0x00000001896C83E0-0x00000001896C8400
	private bool VerifyRange(ref int m1, ref int m2, ref int n1, ref int n2) => default; // 0x000000018394B470-0x000000018394B620
	// [XID] // 0x00000001896CFD90-0x00000001896CFDB0
	private Matrix4x4 ManualInverse3x3(Matrix4x4 m) => default; // 0x000000018394A310-0x000000018394A680
}

