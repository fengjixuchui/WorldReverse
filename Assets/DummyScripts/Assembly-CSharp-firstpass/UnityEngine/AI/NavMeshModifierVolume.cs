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
	// [AddComponentMenu] // 0x00000001898CDD90-0x00000001898CDE00
	[ExecuteInEditMode] // 0x00000001898CDD90-0x00000001898CDE00
	// [HelpURL] // 0x00000001898CDD90-0x00000001898CDE00
	public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 9409
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_Size; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_Center; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_Area; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<int> m_AffectedAgents; // 0x38
		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x00
	
		// Properties
		public Vector3 size { /* [XID] */ /* 0x00000001898FB420-0x00000001898FB440 */ get => default; /* [XID] */ /* 0x00000001899D2FD0-0x00000001899D2FF0 */ set {} } // 0x000000018606BE40-0x000000018606BF20 0x000000018606C0A0-0x000000018606C170
		public Vector3 center { /* [XID] */ /* 0x000000018990A670-0x000000018990A690 */ get => default; /* [XID] */ /* 0x0000000189912010-0x0000000189912030 */ set {} } // 0x000000018606BD60-0x000000018606BE40 0x000000018606BFD0-0x000000018606C0A0
		public int area { /* [XID] */ /* 0x00000001899E2060-0x00000001899E2080 */ get => default; /* [XID] */ /* 0x0000000189B2A480-0x0000000189B2A4A0 */ set {} } // 0x000000018606BCC0-0x000000018606BD60 0x000000018606BF20-0x000000018606BFD0
		public static List<NavMeshModifierVolume> activeModifiers { /* [XID] */ /* 0x0000000189928AD0-0x0000000189928AF0 */ get => default; } // 0x000000018606BBF0-0x000000018606BCC0 
	
		// Constructors
		public NavMeshModifierVolume() {} // 0x000000018606BA80-0x000000018606BBF0
		static NavMeshModifierVolume() {} // 0x000000018606B9F0-0x000000018606BA80
	
		// Methods
		// [XID] // 0x000000018992FF10-0x000000018992FF30
		private void OnEnable() {} // 0x000000018606B8B0-0x000000018606B9F0
		// [XID] // 0x00000001899374B0-0x00000001899374D0
		private void OnDisable() {} // 0x000000018606B7C0-0x000000018606B8B0
		// [XID] // 0x000000018993EF30-0x000000018993EF50
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018606B6A0-0x000000018606B7C0
	}
}
