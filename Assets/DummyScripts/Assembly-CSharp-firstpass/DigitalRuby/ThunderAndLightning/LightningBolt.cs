/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBolt // TypeDefIndex: 9636
	{
		// Fields
		public static int MaximumLightCount; // 0x00
		public static int MaximumLightsPerBatch; // 0x04
		private DateTime startTimeOffset; // 0x20
		private LightningBoltDependencies dependencies; // 0x30
		private float elapsedTime; // 0x38
		private float lifeTime; // 0x3C
		private float maxLifeTime; // 0x40
		private float timeSinceLevelLoad; // 0x44
		private readonly List<LightningBoltSegmentGroup> segmentGroups; // 0x48
		private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight; // 0x50
		private readonly List<LineRendererMesh> activeLineRenderers; // 0x58
		private static int lightCount; // 0x08
		private static readonly List<LineRendererMesh> lineRendererCache; // 0x10
		private static readonly List<LightningBoltSegmentGroup> groupCache; // 0x18
		private static readonly List<Light> lightCache; // 0x20
	
		// Properties
		public float MinimumDelay { /* [XID] */ /* 0x0000000189965CD0-0x0000000189965D10 */ get; /* [XID] */ /* 0x00000001899701A0-0x00000001899701E0 */ private set; } // 0x00000001874A39D0-0x00000001874A3A40 0x00000001874A3B00-0x00000001874A3B70
		public bool HasGlow { /* [XID] */ /* 0x000000018997AD40-0x000000018997AD80 */ get; /* [XID] */ /* 0x0000000189985290-0x00000001899852D0 */ private set; } // 0x00000001874A38C0-0x00000001874A3920 0x00000001874A3AA0-0x00000001874A3B00
		public bool IsActive { /* [XID] */ /* 0x00000001898069D0-0x00000001898069F0 */ get => default; } // 0x00000001874A3920-0x00000001874A39D0 
		public CameraMode CameraMode { /* [XID] */ /* 0x0000000189997760-0x00000001899977A0 */ get; /* [XID] */ /* 0x00000001899A24B0-0x00000001899A24F0 */ private set; } // 0x00000001874A3860-0x00000001874A38C0 0x00000001874A3A40-0x00000001874A3AA0
	
		// Nested types
		public class LineRendererMesh // TypeDefIndex: 9637
		{
			// Fields
			private static readonly Vector2 uv1; // 0x00
			private static readonly Vector2 uv2; // 0x08
			private static readonly Vector2 uv3; // 0x10
			private static readonly Vector2 uv4; // 0x18
			private readonly List<int> indices; // 0x30
			private readonly List<Vector3> vertices; // 0x38
			private readonly List<Vector4> lineDirs; // 0x40
			private readonly List<Color32> colors; // 0x48
			private readonly List<Vector3> ends; // 0x50
			private readonly List<Vector4> texCoordsAndGlowModifiers; // 0x58
			private readonly List<Vector4> fadeLifetimes; // 0x60
			private const int boundsPadder = 1000000000; // Metadata: 0x00AE5CEB
			private int currentBoundsMinX; // 0x68
			private int currentBoundsMinY; // 0x6C
			private int currentBoundsMinZ; // 0x70
			private int currentBoundsMaxX; // 0x74
			private int currentBoundsMaxY; // 0x78
			private int currentBoundsMaxZ; // 0x7C
			private Mesh mesh; // 0x80
			private MeshFilter meshFilter; // 0x88
			private MeshRenderer meshRenderer; // 0x90
	
			// Properties
			public GameObject GameObject { /* [XID] */ /* 0x0000000189A86BA0-0x0000000189A86BE0 */ get; private set; } // 0x000000018604C1E0-0x000000018604C240 0x000000018604C4D0-0x000000018604C530
			public UnityEngine.Material Material { /* [XID] */ /* 0x0000000189AACF40-0x0000000189AACF60 */ get => default; /* [XID] */ /* 0x00000001899AE9C0-0x00000001899AE9E0 */ set {} } // 0x000000018604C240-0x000000018604C300 0x000000018604C530-0x000000018604C600
			public MeshRenderer MeshRenderer { /* [XID] */ /* 0x00000001899F94E0-0x00000001899F9500 */ get => default; } // 0x000000018604C300-0x000000018604C3B0 
			public int Tag { /* [XID] */ /* 0x0000000189AAF400-0x0000000189AAF440 */ get; /* [XID] */ /* 0x0000000189AB99E0-0x0000000189AB9A20 */ set; } // 0x000000018604C3B0-0x000000018604C410 0x000000018604C600-0x000000018604C660
			public Action<LightningCustomTransformStateInfo> CustomTransform { /* [XID] */ /* 0x0000000189AC4790-0x0000000189AC47D0 */ get; /* [XID] */ /* 0x0000000189ACEE30-0x0000000189ACEE70 */ set; } // 0x000000018604C0C0-0x000000018604C120 0x000000018604C470-0x000000018604C4D0
			public Transform Transform { /* [XID] */ /* 0x0000000189AD9AB0-0x0000000189AD9AF0 */ get; private set; } // 0x000000018604C410-0x000000018604C470 0x000000018604C660-0x000000018604C6C0
			public bool Empty { /* [XID] */ /* 0x0000000189AEBE50-0x0000000189AEBE70 */ get => default; } // 0x000000018604C120-0x000000018604C1E0 
	
			// Constructors
			public LineRendererMesh() {} // 0x000000018604BC40-0x000000018604C0C0
			static LineRendererMesh() {} // 0x000000018604BB00-0x000000018604BC40
	
			// Methods
			// [XID] // 0x00000001899C9C40-0x00000001899C9C60
			public void PopulateMesh() {} // 0x000000018604B4D0-0x000000018604B5B0
			// [XID] // 0x0000000189AFB120-0x0000000189AFB140
			public bool PrepareForLines(int lineCount) => default; // 0x000000018604B5B0-0x000000018604B690
			// [XID] // 0x0000000189B02740-0x0000000189B02760
			public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity) {} // 0x000000018604AE40-0x000000018604B0C0
			// [XID] // 0x0000000189AAD7E0-0x0000000189AAD800
			public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity) {} // 0x000000018604AB00-0x000000018604AE40
			// [XID] // 0x00000001899FE650-0x00000001899FE670
			public void Reset() {} // 0x000000018604B690-0x000000018604B960
			// [XID] // 0x0000000189B189A0-0x0000000189B189C0
			private void PopulateMeshInternal() {} // 0x000000018604B0C0-0x000000018604B4D0
			// [XID] // 0x0000000189AA61C0-0x0000000189AA61E0
			private void UpdateBounds(ref Vector3 point1, ref Vector3 point2) {} // 0x000000018604B960-0x000000018604BB00
			// [XID] // 0x00000001898691D0-0x00000001898691F0
			private void AddIndices() {} // 0x000000018604A1B0-0x000000018604A330
			// [XID] // 0x0000000189A8CE60-0x0000000189A8CE80
			private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity) {} // 0x000000018604A330-0x000000018604AB00
		}
	
		// Constructors
		public LightningBolt() {} // 0x00000001874A3790-0x00000001874A3860
		static LightningBolt() {} // 0x00000001874A3680-0x00000001874A3790
	
		// Methods
		// [XID] // 0x00000001899ACF10-0x00000001899ACF30
		public void SetupLightningBolt(LightningBoltDependencies dependencies) {} // 0x00000001874A30D0-0x00000001874A33C0
		// [XID] // 0x00000001899771A0-0x00000001899771C0
		public bool Update() => default; // 0x00000001874A35C0-0x00000001874A3680
		// [XID] // 0x0000000189A5D880-0x0000000189A5D8A0
		public void Cleanup() {} // 0x000000018749FD40-0x00000001874A01A0
		// [XID] // 0x00000001899C37E0-0x00000001899C3800
		public LightningBoltSegmentGroup AddGroup() => default; // 0x000000018749F690-0x000000018749F950
		// [XID] // 0x00000001899E0480-0x00000001899E04A0
		public static void ClearCache() {} // 0x00000001874A01A0-0x00000001874A0630
		// [XID] // 0x00000001899D1940-0x00000001899D1960
		private void CleanupLight(Light l) {} // 0x000000018749FB90-0x000000018749FD40
		// [XID] // 0x000000018985DED0-0x000000018985DEF0
		private void EnableLineRenderer(LineRendererMesh lineRenderer, int tag) {} // 0x00000001874A0AD0-0x00000001874A0C10
		[DebuggerHidden] // 0x00000001899E1060-0x00000001899E10A0
		// [XID] // 0x00000001899E1060-0x00000001899E10A0
		private IEnumerator EnableLastRendererCoRoutine() => default; // 0x00000001874A0A00-0x00000001874A0AD0
		// [XID] // 0x0000000189AEB0F0-0x0000000189AEB110
		private LineRendererMesh GetOrCreateLineRenderer() => default; // 0x00000001874A0D40-0x00000001874A1310
		// [XID] // 0x00000001899268A0-0x00000001899268C0
		private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p) {} // 0x00000001874A2010-0x00000001874A2700
		[DebuggerHidden] // 0x00000001899FA9A0-0x00000001899FA9E0
		// [XID] // 0x00000001899FA9A0-0x00000001899FA9E0
		private static IEnumerator NotifyBolt(LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end) => default; // 0x00000001874A1310-0x00000001874A1490
		// [XID] // 0x000000018971DCE0-0x000000018971DD00
		private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay) {} // 0x00000001874A1D30-0x00000001874A2010
		// [XID] // 0x0000000189A0C390-0x0000000189A0C3B0
		private void ProcessAllLightningParameters() {} // 0x00000001874A1560-0x00000001874A1D30
		// [XID] // 0x0000000189A13D70-0x0000000189A13D90
		public void StartNotifyBlot(LightningBoltDependencies dependenciesRef, LightningBoltParameters parameters, Transform transform, Vector3 start, Vector3 end) {} // 0x00000001874A33C0-0x00000001874A35C0
		[DebuggerHidden] // 0x0000000189A1AFB0-0x0000000189A1AFF0
		// [XID] // 0x0000000189A1AFB0-0x0000000189A1AFF0
		public IEnumerator ProcessAllLightningParametersForJobSystem() => default; // 0x00000001874A1490-0x00000001874A1560
		// [XID] // 0x0000000189A25490-0x0000000189A254B0
		public void EnableCurrentLineRendererFromThread() {} // 0x00000001874A06E0-0x00000001874A0830
		// [XID] // 0x0000000189A2CA00-0x0000000189A2CA20
		private void EnableCurrentLineRenderer() {} // 0x00000001874A0830-0x00000001874A0A00
		// [XID] // 0x0000000189A34180-0x0000000189A341A0
		public void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds) {} // 0x00000001874A2E20-0x00000001874A30D0
		// [XID] // 0x0000000189A3B890-0x0000000189A3B8B0
		public LineRendererMesh EnableAndGetOrCreateLineRenderer() => default; // 0x00000001874A0630-0x00000001874A06E0
		// [XID] // 0x0000000189A816F0-0x0000000189A81710
		private Transform RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters) => default; // 0x00000001874A2700-0x00000001874A2E20
		[DebuggerHidden] // 0x0000000189A4A880-0x0000000189A4A8C0
		// [XID] // 0x0000000189A4A880-0x0000000189A4A8C0
		private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay) => default; // 0x00000001874A0C10-0x00000001874A0D40
		// [XID] // 0x00000001897E10C0-0x00000001897E10E0
		private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters) {} // 0x000000018749F950-0x000000018749FB90
	}
}
