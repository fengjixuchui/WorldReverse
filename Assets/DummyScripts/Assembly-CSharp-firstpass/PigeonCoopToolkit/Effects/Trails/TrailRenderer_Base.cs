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

namespace PigeonCoopToolkit.Effects.Trails
{
	public abstract class TrailRenderer_Base : MonoBehaviour // TypeDefIndex: 9454
	{
		// Fields
		public PCTrailRendererData TrailData; // 0x18
		public bool Emit; // 0x20
		public float StretchUpRatio; // 0x24
		public float StretchDownRatio; // 0x28
		public bool clockSize; // 0x2C
		protected bool _emit; // 0x2D
		protected bool _noDecay; // 0x2E
		protected PCTrail _activeTrail; // 0x30
		private List<PCTrail> _fadingTrails; // 0x38
		protected Transform _t; // 0x40
		protected bool _castShadow; // 0x48
		protected Color _mainTintColor; // 0x4C
		[NonSerialized]
		public float TimeScale; // 0x5C
		[NonSerialized]
		protected bool _useCrossCheck; // 0x60
		[NonSerialized]
		protected float _walkShift; // 0x64
		protected static readonly int DISTORTION_VERTEX_SMOOTH_RANGE; // 0x00
		protected static Dictionary<MaterialsContainer, List<PCTrail>> _matToTrailList; // 0x08
		protected static List<Mesh> _toClean; // 0x10
		protected static bool _hasRenderer; // 0x18
		protected static int GlobalTrailRendererCount; // 0x1C
	
		// Nested types
		public class MaterialsContainer // TypeDefIndex: 9455
		{
			// Fields
			public UnityEngine.Material[] materials; // 0x10
	
			// Constructors
			public MaterialsContainer() {} // 0x0000000186010310-0x0000000186010370
	
			// Methods
			// [XID] // 0x0000000189AA8F70-0x0000000189AA8F90
			public override bool Equals(object obj) => default; // 0x000000018600FE80-0x0000000186010080
			// [XID] // 0x0000000189AB0B80-0x0000000189AB0BA0
			public override int GetHashCode() => default; // 0x0000000186010080-0x0000000186010220
		}
	
		// Constructors
		protected TrailRenderer_Base() {} // 0x0000000186027640-0x00000001860276F0
		static TrailRenderer_Base() {} // 0x00000001860275B0-0x0000000186027640
	
		// Methods
		// [XID] // 0x0000000189B0CA00-0x0000000189B0CA20
		public void UpdateMainTintColor(ref Color color) {} // 0x0000000186026A70-0x0000000186026B20
		// [XID] // 0x00000001899B8BB0-0x00000001899B8BD0
		protected virtual void Awake() {} // 0x0000000186022B60-0x0000000186022D70
		// [XID] // 0x00000001899C0450-0x00000001899C0470
		protected virtual void Start() {} // 0x00000001860263C0-0x0000000186026470
		// [XID] // 0x0000000189B22DF0-0x0000000189B22E10
		protected virtual void LateUpdate() {} // 0x0000000186024D30-0x0000000186025290
		// [XID] // 0x00000001898C7200-0x00000001898C7220
		protected virtual void Update() {} // 0x0000000186026E10-0x00000001860275B0
		// [XID] // 0x00000001899D6A70-0x00000001899D6A90
		protected virtual void OnEnable() {} // 0x00000001860259D0-0x0000000186025A70
		// [XID] // 0x00000001899DE050-0x00000001899DE070
		protected virtual void OnDestroy() {} // 0x0000000186025570-0x00000001860259D0
		// [XID] // 0x00000001899E5E00-0x00000001899E5E20
		protected virtual void OnStopEmit() {} // 0x0000000186025B10-0x0000000186025BB0
		// [XID] // 0x00000001899ECF00-0x00000001899ECF20
		protected virtual void OnStartEmit() {} // 0x0000000186025A70-0x0000000186025B10
		// [XID] // 0x00000001899F4CE0-0x00000001899F4D00
		protected virtual void OnTranslate(Vector3 t) {} // 0x0000000186025BB0-0x0000000186025C70
		protected abstract int GetMaxNumberOfPoints();
		// [XID] // 0x00000001899FC280-0x00000001899FC2A0
		protected virtual void Reset() {} // 0x0000000186025E40-0x00000001860261D0
		// [XID] // 0x00000001895FDB60-0x00000001895FDB80
		protected virtual void InitialiseNewPoint(PCTrailPoint newPoint) {} // 0x0000000186024C80-0x0000000186024D30
		// [XID] // 0x00000001898AE570-0x00000001898AE590
		protected virtual void UpdateTrail(PCTrail trail, float deltaTime) {} // 0x0000000186026D30-0x0000000186026E10
		// [XID] // 0x0000000189A12590-0x0000000189A125B0
		protected void AddPoint(PCTrailPoint newPoint, Vector3 pos) {} // 0x0000000186022730-0x0000000186022B60
		// [XID] // 0x0000000189A19940-0x0000000189A19960
		private void GenerateMesh(PCTrail trail) {} // 0x0000000186023780-0x0000000186024C80
		// [XID] // 0x0000000189B409D0-0x0000000189B409F0
		private void DrawMesh(Mesh trailMesh, UnityEngine.Material trailMaterial) {} // 0x0000000186023540-0x0000000186023780
		// [XID] // 0x00000001899595D0-0x00000001899595F0
		protected virtual void UpdatePoints(PCTrail line, float deltaTime) {} // 0x0000000186026BE0-0x0000000186026D30
		[Obsolete] // 0x0000000189A2FB40-0x0000000189A2FB90
		// [XID] // 0x0000000189A2FB40-0x0000000189A2FB90
		protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime) {} // 0x0000000186026B20-0x0000000186026BE0
		// [XID] // 0x000000018980E190-0x000000018980E1B0
		protected void CheckEmitChange() {} // 0x0000000186022D70-0x0000000186022EE0
		// [XID] // 0x0000000189A433A0-0x0000000189A433C0
		private int NumberOfActivePoints(PCTrail line) => default; // 0x0000000186025420-0x0000000186025570
		// [ContextMenu] // 0x0000000189A4A8C0-0x0000000189A4A910
		// [XID] // 0x0000000189A4A8C0-0x0000000189A4A910
		protected void ToggleSizeInputStyle() {} // 0x0000000186026520-0x00000001860265D0
		// [ContextMenu] // 0x0000000189A566A0-0x0000000189A566F0
		// [XID] // 0x0000000189A566A0-0x0000000189A566F0
		protected void ToggleColorInputStyle() {} // 0x0000000186026470-0x0000000186026520
		// [XID] // 0x0000000189A62840-0x0000000189A62860
		public void LifeDecayEnabled(bool enabled) {} // 0x0000000186025290-0x0000000186025340
		// [XID] // 0x0000000189A6A600-0x0000000189A6A620
		public void Translate(Vector3 t) {} // 0x00000001860265D0-0x00000001860269D0
		// [XID] // 0x0000000189A719F0-0x0000000189A71A10
		public void CreateTrail(Vector3 from, Vector3 to, float distanceBetweenPoints) {} // 0x00000001860230D0-0x0000000186023540
		// [XID] // 0x0000000189A794F0-0x0000000189A79510
		public void ClearSystem(bool emitState) {} // 0x0000000186022EE0-0x00000001860230D0
		// [XID] // 0x0000000189BA1240-0x0000000189BA1260
		public int NumSegments() => default; // 0x0000000186025340-0x0000000186025420
		// [XID] // 0x0000000189A885E0-0x0000000189A88600
		protected virtual void AddDistortion(PCTrail line) {} // 0x00000001860222B0-0x0000000186022730
		// [XID] // 0x000000018999D490-0x000000018999D4B0
		protected void SetDistortionPosition(ref Vector3 newPos, ref Vector2 distortion) {} // 0x00000001860261D0-0x00000001860263C0
		// [XID] // 0x00000001899100B0-0x00000001899100D0
		protected virtual void ResetDistortion(PCTrail line) {} // 0x0000000186025C70-0x0000000186025E40
	}
}
