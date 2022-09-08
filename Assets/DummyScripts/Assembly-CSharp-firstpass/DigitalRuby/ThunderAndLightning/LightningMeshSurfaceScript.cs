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
	public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase // TypeDefIndex: 9681
	{
		// Fields
		// [Header] // 0x00000001897DED20-0x00000001897DED80
		// [Tooltip] // 0x00000001897DED20-0x00000001897DED80
		public MeshFilter MeshFilter; // 0x1F0
		// [Tooltip] // 0x00000001897ECB20-0x00000001897ECB50
		public Collider MeshCollider; // 0x1F8
		// [SingleLine] // 0x00000001897F5950-0x00000001897F5980
		public RangeOfFloats MeshOffsetRange; // 0x200
		// [Header] // 0x00000001897FE750-0x00000001897FE7B0
		// [SingleLine] // 0x00000001897FE750-0x00000001897FE7B0
		public RangeOfIntegers PathLengthCount; // 0x208
		// [SingleLine] // 0x000000018980A7F0-0x000000018980A820
		public RangeOfFloats MinimumPathDistanceRange; // 0x210
		// [Tooltip] // 0x0000000189813520-0x0000000189813550
		public float MaximumPathDistance; // 0x218
		private float maximumPathDistanceSquared; // 0x21C
		// [Tooltip] // 0x000000018981C7A0-0x000000018981C7D0
		public bool Spline; // 0x220
		// [Tooltip] // 0x0000000189825510-0x0000000189825540
		public float DistancePerSegmentHint; // 0x224
		private readonly List<Vector3> sourcePoints; // 0x228
		private Mesh previousMesh; // 0x230
		private MeshHelper meshHelper; // 0x238
	
		// Constructors
		public LightningMeshSurfaceScript() {} // 0x00000001860479A0-0x0000000186047AA0
	
		// Methods
		// [XID] // 0x0000000189749400-0x0000000189749420
		private void CheckMesh() {} // 0x00000001860468C0-0x0000000186046B10
		// [XID] // 0x0000000189835BD0-0x0000000189835BF0
		protected override LightningBoltParameters OnCreateParameters() => default; // 0x00000001860474E0-0x00000001860475D0
		// [XID] // 0x0000000189A73BF0-0x0000000189A73C10
		protected virtual void PopulateSourcePoints(List<Vector3> points) {} // 0x00000001860475D0-0x00000001860476A0
		// [XID] // 0x0000000189AE15B0-0x0000000189AE15D0
		public void CreateRandomLightningPath(List<Vector3> points) {} // 0x0000000186046E30-0x00000001860474E0
		// [XID] // 0x000000018984BE50-0x000000018984BE70
		protected override void Start() {} // 0x00000001860476A0-0x0000000186047740
		// [XID] // 0x0000000189852C70-0x0000000189852C90
		protected override void Update() {} // 0x00000001860478F0-0x00000001860479A0
		// [XID] // 0x000000018985A940-0x000000018985A960
		public override void CreateLightningBolt(LightningBoltParameters parameters) {} // 0x0000000186046B10-0x0000000186046E30
	}
}
