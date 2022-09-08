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

namespace UnityEngine.AI
{
	// [AddComponentMenu] // 0x0000000189696CF0-0x0000000189696D80
	// [DefaultExecutionOrder] // 0x0000000189696CF0-0x0000000189696D80
	[ExecuteInEditMode] // 0x0000000189696CF0-0x0000000189696D80
	// [HelpURL] // 0x0000000189696CF0-0x0000000189696D80
	public class NavMeshLink : MonoBehaviour // TypeDefIndex: 9405
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_AgentTypeID; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_StartPoint; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_EndPoint; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_Width; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_CostModifier; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_Bidirectional; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_AutoUpdatePosition; // 0x3D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_Area; // 0x40
		private NavMeshLinkInstance m_LinkInstance; // 0x44
		private Vector3 m_LastPosition; // 0x48
		private Quaternion m_LastRotation; // 0x54
		private static readonly List<NavMeshLink> s_Tracked; // 0x00
	
		// Properties
		public int agentTypeID { /* [XID] */ /* 0x0000000189A16780-0x0000000189A167A0 */ get => default; /* [XID] */ /* 0x0000000189695060-0x0000000189695080 */ set {} } // 0x0000000186069EC0-0x0000000186069F60 0x000000018606A450-0x000000018606A510
		public Vector3 startPoint { /* [XID] */ /* 0x0000000189702430-0x0000000189702450 */ get => default; /* [XID] */ /* 0x0000000189709C40-0x0000000189709C60 */ set {} } // 0x000000018606A2C0-0x000000018606A3A0 0x000000018606A8F0-0x000000018606A9D0
		public Vector3 endPoint { /* [XID] */ /* 0x0000000189A7F060-0x0000000189A7F080 */ get => default; /* [XID] */ /* 0x0000000189718B00-0x0000000189718B20 */ set {} } // 0x000000018606A1E0-0x000000018606A2C0 0x000000018606A810-0x000000018606A8F0
		public float width { /* [XID] */ /* 0x0000000189720200-0x0000000189720220 */ get => default; /* [XID] */ /* 0x00000001897279A0-0x00000001897279C0 */ set {} } // 0x000000018606A3A0-0x000000018606A450 0x000000018606A9D0-0x000000018606AA90
		public int costModifier { /* [XID] */ /* 0x000000018972EE90-0x000000018972EEB0 */ get => default; /* [XID] */ /* 0x00000001897366D0-0x00000001897366F0 */ set {} } // 0x000000018606A140-0x000000018606A1E0 0x000000018606A750-0x000000018606A810
		public bool bidirectional { /* [XID] */ /* 0x0000000189BD52F0-0x0000000189BD5310 */ get => default; /* [XID] */ /* 0x00000001897457D0-0x00000001897457F0 */ set {} } // 0x000000018606A0A0-0x000000018606A140 0x000000018606A690-0x000000018606A750
		public bool autoUpdate { /* [XID] */ /* 0x0000000189623FE0-0x0000000189624000 */ get => default; /* [XID] */ /* 0x000000018968BED0-0x000000018968BEF0 */ set {} } // 0x000000018606A000-0x000000018606A0A0 0x000000018606A5D0-0x000000018606A690
		public int area { /* [XID] */ /* 0x000000018975BB50-0x000000018975BB70 */ get => default; /* [XID] */ /* 0x0000000189763530-0x0000000189763550 */ set {} } // 0x0000000186069F60-0x000000018606A000 0x000000018606A510-0x000000018606A5D0
	
		// Constructors
		public NavMeshLink() {} // 0x0000000186069D60-0x0000000186069EC0
		static NavMeshLink() {} // 0x0000000186069CD0-0x0000000186069D60
	
		// Methods
		// [XID] // 0x0000000189988210-0x0000000189988230
		private void OnEnable() {} // 0x0000000186069620-0x0000000186069700
		// [XID] // 0x0000000189772270-0x0000000189772290
		private void OnDisable() {} // 0x0000000186069550-0x0000000186069620
		// [XID] // 0x00000001897799A0-0x00000001897799C0
		public void UpdateLink() {} // 0x0000000186069A60-0x0000000186069B10
		// [XID] // 0x00000001897813C0-0x00000001897813E0
		private static void AddTracking(NavMeshLink link) {} // 0x0000000186069070-0x00000001860692E0
		// [XID] // 0x00000001898ED8A0-0x00000001898ED8C0
		private static void RemoveTracking(NavMeshLink link) {} // 0x0000000186069700-0x0000000186069950
		// [XID] // 0x0000000189790030-0x0000000189790050
		private void SetAutoUpdate(bool value) {} // 0x0000000186069950-0x0000000186069A60
		// [XID] // 0x0000000189797820-0x0000000189797840
		private void AddLink() {} // 0x0000000186068DA0-0x0000000186069070
		// [XID] // 0x000000018979F730-0x000000018979F750
		private bool HasTransformChanged() => default; // 0x00000001860692E0-0x00000001860694B0
		// [XID] // 0x000000018969DD90-0x000000018969DDB0
		private void OnDidApplyAnimationProperties() {} // 0x00000001860694B0-0x0000000186069550
		// [XID] // 0x00000001897AE450-0x00000001897AE470
		private static void UpdateTrackedInstances() {} // 0x0000000186069B10-0x0000000186069CD0
	}
}
