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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningSplineScript : LightningBoltPathScriptBase // TypeDefIndex: 9682
	{
		// Fields
		public const int MaxSplineGenerations = 5; // Metadata: 0x00AE5CF0
		// [Header] // 0x00000001898619F0-0x0000000189861A50
		// [Tooltip] // 0x00000001898619F0-0x0000000189861A50
		public float DistancePerSegmentHint; // 0x200
		private readonly List<Vector3> prevSourcePoints; // 0x208
		private readonly List<Vector3> sourcePoints; // 0x210
		private List<Vector3> savedSplinePoints; // 0x218
		private int previousGenerations; // 0x220
		private float previousDistancePerSegment; // 0x224
	
		// Constructors
		public LightningSplineScript() {} // 0x0000000186048DC0-0x0000000186048F30
	
		// Methods
		// [XID] // 0x000000018982D5E0-0x000000018982D600
		private bool SourceChanged() => default; // 0x00000001860485F0-0x0000000186048820
		// [XID] // 0x000000018991F590-0x000000018991F5B0
		protected override void Start() {} // 0x0000000186048820-0x00000001860488C0
		// [XID] // 0x000000018987E330-0x000000018987E350
		protected override void Update() {} // 0x0000000186048D20-0x0000000186048DC0
		// [XID] // 0x00000001898853D0-0x00000001898853F0
		public override void CreateLightningBolt(LightningBoltParameters parameters) {} // 0x0000000186047D80-0x00000001860482F0
		// [XID] // 0x0000000189910390-0x00000001899103B0
		protected override LightningBoltParameters OnCreateParameters() => default; // 0x00000001860482F0-0x0000000186048400
		// [XID] // 0x00000001898E7F60-0x00000001898E7F80
		public void Trigger(List<Vector3> points, bool spline) {} // 0x00000001860488C0-0x0000000186048B70
		// [XID] // 0x00000001898795C0-0x00000001898795E0
		public static void PopulateSpline(List<Vector3> splinePoints, List<Vector3> sourcePoints, int generations, float distancePerSegmentHit, Camera camera) {} // 0x0000000186048400-0x00000001860485F0
	}
}
