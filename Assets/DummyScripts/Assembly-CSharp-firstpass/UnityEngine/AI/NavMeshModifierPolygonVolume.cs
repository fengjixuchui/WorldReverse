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
	// [AddComponentMenu] // 0x000000018982E460-0x000000018982E4B0
	[ExecuteInEditMode] // 0x000000018982E460-0x000000018982E4B0
	public class NavMeshModifierPolygonVolume : MonoBehaviour // TypeDefIndex: 9407
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Shape _shape; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Vector3> _points; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _bottom; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _top; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _area; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<int> m_AffectedAgents; // 0x38
		private static readonly List<NavMeshModifierPolygonVolume> s_NavMeshModifiers; // 0x00
	
		// Properties
		public Shape shape { /* [XID] */ /* 0x0000000189866070-0x0000000189866090 */ get => default; /* [XID] */ /* 0x000000018986D800-0x000000018986D820 */ set {} } // 0x000000018606B1E0-0x000000018606B280 0x000000018606B540-0x000000018606B5F0
		public List<Vector3> points { /* [XID] */ /* 0x0000000189874C70-0x0000000189874C90 */ get => default; /* [XID] */ /* 0x000000018990D740-0x000000018990D760 */ set {} } // 0x000000018606B140-0x000000018606B1E0 0x000000018606B490-0x000000018606B540
		public float bottom { /* [XID] */ /* 0x0000000189883830-0x0000000189883850 */ get => default; /* [XID] */ /* 0x000000018988B070-0x000000018988B090 */ set {} } // 0x000000018606B090-0x000000018606B140 0x000000018606B3E0-0x000000018606B490
		public float top { /* [XID] */ /* 0x000000018962E660-0x000000018962E680 */ get => default; /* [XID] */ /* 0x00000001896D1750-0x00000001896D1770 */ set {} } // 0x000000018606B280-0x000000018606B330 0x000000018606B5F0-0x000000018606B6A0
		public int area { /* [XID] */ /* 0x00000001898A10C0-0x00000001898A10E0 */ get => default; /* [XID] */ /* 0x0000000189610A40-0x0000000189610A60 */ set {} } // 0x000000018606AFF0-0x000000018606B090 0x000000018606B330-0x000000018606B3E0
		public static List<NavMeshModifierPolygonVolume> activeModifiers { /* [XID] */ /* 0x0000000189672390-0x00000001896723B0 */ get => default; } // 0x000000018606AF20-0x000000018606AFF0 
	
		// Nested types
		public enum Shape // TypeDefIndex: 9408
		{
			KeepInArea = 0,
			KeepOutArea = 1
		}
	
		// Constructors
		public NavMeshModifierPolygonVolume() {} // 0x000000018606AE70-0x000000018606AF20
		static NavMeshModifierPolygonVolume() {} // 0x000000018606ADE0-0x000000018606AE70
	
		// Methods
		// [XID] // 0x00000001896DB940-0x00000001896DB960
		private void OnEnable() {} // 0x000000018606ACA0-0x000000018606ADE0
		// [XID] // 0x00000001898BEE20-0x00000001898BEE40
		private void OnDisable() {} // 0x000000018606ABB0-0x000000018606ACA0
		// [XID] // 0x0000000189769F50-0x0000000189769F70
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018606AA90-0x000000018606ABB0
	}
}
