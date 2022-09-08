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

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001897AB0C0-0x00000001897AB140
	// [DocumentationSorting] // 0x00000001897AB0C0-0x00000001897AB140
	[ExecuteInEditMode] // 0x00000001897AB0C0-0x00000001897AB140
	[SaveDuringPlay] // 0x00000001897AB0C0-0x00000001897AB140
	public class CinemachineTargetGroup : MonoBehaviour // TypeDefIndex: 6786
	{
		// Fields
		// [Tooltip] // 0x00000001897BE380-0x00000001897BE3B0
		public PositionMode m_PositionMode; // 0x18
		// [Tooltip] // 0x00000001897C73A0-0x00000001897C73D0
		public RotationMode m_RotationMode; // 0x1C
		// [Tooltip] // 0x00000001897D0150-0x00000001897D0180
		public UpdateMethod m_UpdateMethod; // 0x20
		[NoSaveDuringPlay] // 0x00000001897D9460-0x00000001897D94A0
		// [Tooltip] // 0x00000001897D9460-0x00000001897D94A0
		public Target[] m_Targets; // 0x28
		private List<Target> _targetsList; // 0x30
		private bool _targetsDirty; // 0x38
		private float m_lastRadius; // 0x3C
	
		// Properties
		public Bounds BoundingBox { /* [XID] */ /* 0x00000001896F4DC0-0x00000001896F4DE0 */ get => default; } // 0x0000000186CCEC80-0x0000000186CCF160 
		public bool IsEmpty { /* [XID] */ /* 0x0000000189821460-0x0000000189821480 */ get => default; } // 0x0000000186CCF160-0x0000000186CCF300 
	
		// Nested types
		[Serializable]
		// [DocumentationSorting] // 0x000000018986ACE0-0x000000018986AD00
		public struct Target // TypeDefIndex: 6787
		{
			// Fields
			// [Tooltip] // 0x0000000189872120-0x0000000189872150
			public Transform target; // 0x00
			// [Tooltip] // 0x000000018987B290-0x000000018987B2C0
			public float weight; // 0x08
			// [Tooltip] // 0x00000001898839D0-0x0000000189883A00
			public float radius; // 0x0C
			private Vector3 _targetPosition; // 0x10
			private bool _modifyPos; // 0x1C
	
			// Properties
			public Vector3 targetPos { /* [XID] */ /* 0x00000001899C4D10-0x00000001899C4D30 */ get => default; } // 0x0000000186CD7B20-0x0000000186CD7B70 
	
			// Methods
			// [XID] // 0x00000001897216A0-0x00000001897216C0
			public void SetTargetPosition(Vector3 pos) {} // 0x0000000186CD79F0-0x0000000186CD7B20
		}
	
		// [DocumentationSorting] // 0x000000018989B650-0x000000018989B670
		public enum PositionMode // TypeDefIndex: 6788
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		// [DocumentationSorting] // 0x00000001898A2B40-0x00000001898A2B60
		public enum RotationMode // TypeDefIndex: 6789
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 6790
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup() {} // 0x0000000186CCEBB0-0x0000000186CCEC80
	
		// Methods
		// [XID] // 0x00000001897E4FF0-0x00000001897E5010
		public int GetTargetIndex(Transform target) => default; // 0x0000000186CCD980-0x0000000186CCDB50
		// [XID] // 0x0000000189A626C0-0x0000000189A626E0
		public void AddTargetOverride(Transform target, float weight, float radius) {} // 0x0000000186CCCC90-0x0000000186CCCE80
		// [XID] // 0x0000000189703B00-0x0000000189703B20
		public void AddTarget(Transform target, float weight, float radius) {} // 0x0000000186CCCE80-0x0000000186CCD020
		// [XID] // 0x00000001897FBFE0-0x00000001897FC000
		public void RemoveTarget(Transform target) {} // 0x0000000186CCE4D0-0x0000000186CCE6E0
		// [XID] // 0x0000000189803310-0x0000000189803330
		public void RefreshTargets() {} // 0x0000000186CCE400-0x0000000186CCE4D0
		// [XID] // 0x0000000189712AF0-0x0000000189712B10
		public void ClearTargets() {} // 0x0000000186CCD820-0x0000000186CCD8D0
		// [XID] // 0x000000018971A390-0x000000018971A3B0
		public void SetTargetPosition(Transform targetTrans, Vector3 pos) {} // 0x0000000186CCE6E0-0x0000000186CCE920
		// [XID] // 0x0000000189828990-0x00000001898289B0
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 mView) => default; // 0x0000000186CCDB50-0x0000000186CCE1B0
		// [XID] // 0x00000001896FC510-0x00000001896FC530
		private Vector3 CalculateAveragePosition(out float averageWeight) {
			averageWeight = default;
			return default;
		} // 0x0000000186CCD3E0-0x0000000186CCD820
		// [XID] // 0x00000001898374F0-0x0000000189837510
		private Quaternion CalculateAverageOrientation() => default; // 0x0000000186CCD100-0x0000000186CCD3E0
		// [XID] // 0x000000018983EAF0-0x000000018983EB10
		private void OnValidate() {} // 0x0000000186CCE260-0x0000000186CCE400
		// [XID] // 0x00000001898461C0-0x00000001898461E0
		private void Awake() {} // 0x0000000186CCD020-0x0000000186CCD100
		// [XID] // 0x00000001897306F0-0x0000000189730710
		private void FixedUpdate() {} // 0x0000000186CCD8D0-0x0000000186CCD980
		// [XID] // 0x0000000189854750-0x0000000189854770
		private void Update() {} // 0x0000000186CCEB00-0x0000000186CCEBB0
		// [XID] // 0x000000018973FAE0-0x000000018973FB00
		private void LateUpdate() {} // 0x0000000186CCE1B0-0x0000000186CCE260
		// [XID] // 0x00000001896E5E00-0x00000001896E5E20
		private void UpdateTransform() {} // 0x0000000186CCE920-0x0000000186CCEB00
	}
}
