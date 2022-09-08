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
	// [AddComponentMenu] // 0x00000001897B64C0-0x00000001897B6530
	[ExecuteInEditMode] // 0x00000001897B64C0-0x00000001897B6530
	// [HelpURL] // 0x00000001897B64C0-0x00000001897B6530
	public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 9406
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_OverrideArea; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_Area; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_IgnoreFromBuild; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<int> m_AffectedAgents; // 0x28
		private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x00
	
		// Properties
		public bool overrideArea { /* [XID] */ /* 0x00000001897E37B0-0x00000001897E37D0 */ get => default; /* [XID] */ /* 0x00000001897EAFF0-0x00000001897EB010 */ set {} } // 0x000000018606C850-0x000000018606C8F0 0x000000018606CA50-0x000000018606CB00
		public int area { /* [XID] */ /* 0x000000018996A110-0x000000018996A130 */ get => default; /* [XID] */ /* 0x00000001896B6C40-0x00000001896B6C60 */ set {} } // 0x000000018606C710-0x000000018606C7B0 0x000000018606C8F0-0x000000018606C9A0
		public bool ignoreFromBuild { /* [XID] */ /* 0x0000000189801B30-0x0000000189801B50 */ get => default; /* [XID] */ /* 0x0000000189808FB0-0x0000000189808FD0 */ set {} } // 0x000000018606C7B0-0x000000018606C850 0x000000018606C9A0-0x000000018606CA50
		public static List<NavMeshModifier> activeModifiers { /* [XID] */ /* 0x0000000189810830-0x0000000189810850 */ get => default; } // 0x000000018606C640-0x000000018606C710 
	
		// Constructors
		public NavMeshModifier() {} // 0x000000018606C550-0x000000018606C640
		static NavMeshModifier() {} // 0x000000018606C4C0-0x000000018606C550
	
		// Methods
		// [XID] // 0x000000018970F040-0x000000018970F060
		private void OnEnable() {} // 0x000000018606C380-0x000000018606C4C0
		// [XID] // 0x000000018981F850-0x000000018981F870
		private void OnDisable() {} // 0x000000018606C290-0x000000018606C380
		// [XID] // 0x00000001896FD090-0x00000001896FD0B0
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018606C170-0x000000018606C290
	}
}
