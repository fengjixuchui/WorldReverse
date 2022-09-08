/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HeightmapPlugin : BaseComponentPlugin // TypeDefIndex: 12047
{
	// Fields
	public static bool bUseMultiThread; // 0x00
	private const int SAMPLE_RATE = 4; // Metadata: 0x00AEB39A
	private const float SCAN_BOX_RADIUS_SCALE = 1f; // Metadata: 0x00AEB39E
	private const float SCAN_BOX_HEIGHT_SCALE = 0.5f; // Metadata: 0x00AEB3A2
	private const float SCAN_BOX_WIDTH_RATIO = 2f; // Metadata: 0x00AEB3A6
	private const float SCAN_BOX_LENGTH_RATIO = 2f; // Metadata: 0x00AEB3AA
	private const float SCAN_BOX_DEPTH_RATIO = 2f; // Metadata: 0x00AEB3AE
	private ProjectedHeightmap _heightmap; // 0x58
	private ProjectedHeightmapProcessChain _heightmapProcessChain; // 0x60
	private int _lastScannedHeightsBeneathAtFrame; // 0x68
	private Vector3 _lastScanPosition; // 0x6C
	private float _radius; // 0x78
	private float _height; // 0x7C
	private Transform _transform; // 0x80
	public OncePerFrameMultivariateCorrelationCoefficient mcc; // 0x88
	private Plane _lastLinearRegressionPlane; // 0x90

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896E5DA0-0x00000001896E5DC0 */ get => default; } // 0x000000018554E7A0-0x000000018554E840 

	// Nested types
	public class OncePerFrameMultivariateCorrelationCoefficient : OnceAtMostPerFrame<float> // TypeDefIndex: 12048
	{
		// Fields
		private int _m1; // 0x18
		private int _m2; // 0x1C
		private int _n1; // 0x20
		private int _n2; // 0x24
		private ProjectedHeightmap _heightmap; // 0x28

		// Constructors
		public OncePerFrameMultivariateCorrelationCoefficient() {} // Dummy constructor
		public OncePerFrameMultivariateCorrelationCoefficient(ProjectedHeightmap heightmap, int m1, int m2, int n1, int n2) {} // 0x0000000185896040-0x00000001858960E0
		public OncePerFrameMultivariateCorrelationCoefficient(ProjectedHeightmap heightmap) {} // 0x00000001858960E0-0x00000001858961C0
		public OncePerFrameMultivariateCorrelationCoefficient(ProjectedHeightmap heightmap, float x1, float x2, float y1, float y2) {} // 0x0000000185895EF0-0x0000000185896040

		// Methods
		// [XID] // 0x0000000189736430-0x0000000189736450
		public override float Update(float previousValue) => default; // 0x0000000185895D80-0x0000000185895EF0
	}

	// Constructors
	public HeightmapPlugin() {} // 0x000000018554E740-0x000000018554E7A0
	static HeightmapPlugin() {} // 0x000000018554E6E0-0x000000018554E740

	// Methods
	// [XID] // 0x00000001896ED370-0x00000001896ED390
	public override void Init() {} // 0x000000018554DA10-0x000000018554DC30
	// [XID] // 0x00000001896F4CA0-0x00000001896F4CC0
	public override void Destroy() {} // 0x000000018554D700-0x000000018554D7B0
	// [XID] // 0x00000001898B18B0-0x00000001898B18D0
	public void LinearRegression(out Plane plane, bool filter = true /* Metadata: 0x00AEB396 */) {
		plane = default;
	} // 0x000000018554E530-0x000000018554E620
	// [XID] // 0x0000000189703980-0x00000001897039A0
	public void LinearRegressionForceCalc(out Plane plane, bool filter = true /* Metadata: 0x00AEB397 */) {
		plane = default;
	} // 0x000000018554D7B0-0x000000018554D890
	// [XID] // 0x00000001899642F0-0x0000000189964310
	public float BilinearInterpolatedHeight(float x, float z) => default; // 0x000000018554D5D0-0x000000018554D700
	// [XID] // 0x00000001898A9F60-0x00000001898A9F80
	public float CurrentHeight() => default; // 0x000000018554E620-0x000000018554E6E0
	// [IDTag] // 0x000000018971A270-0x000000018971A2B0
	// [XID] // 0x000000018971A270-0x000000018971A2B0
	public void ScanHeightsBeneath(bool forceScan = false /* Metadata: 0x00AEB398 */) {} // 0x000000018554DC90-0x000000018554E120
	// [IDTag] // 0x0000000189724550-0x0000000189724590
	// [XID] // 0x0000000189724550-0x0000000189724590
	public void ScanHeightsBeneath(Vector3 position, bool forceScan = false /* Metadata: 0x00AEB399 */) {} // 0x000000018554E120-0x000000018554E4C0
	// [XID] // 0x000000018972ECB0-0x000000018972ECD0
	private static Bounds GetEnclosingCube(Vector3 position, float extent) => default; // 0x000000018554D890-0x000000018554DA10
}

