/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	[CreateAssetMenu] // 0x0000000189B9FC20-0x0000000189B9FC80
	public class RuntimeInspectorSettings : ScriptableObject // TypeDefIndex: 10032
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InspectorField[] m_standardDrawers; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InspectorField[] m_referenceDrawers; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private VariableSet[] m_hiddenVariables; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private VariableSet[] m_exposedVariables; // 0x30
	
		// Properties
		public InspectorField[] StandardDrawers { /* [XID] */ /* 0x0000000189BD5570-0x0000000189BD5590 */ get => default; } // 0x0000000186748170-0x0000000186748210 
		public InspectorField[] ReferenceDrawers { /* [XID] */ /* 0x0000000189BCFAB0-0x0000000189BCFAD0 */ get => default; } // 0x00000001867480D0-0x0000000186748170 
		public VariableSet[] HiddenVariables { /* [XID] */ /* 0x0000000189BD6EB0-0x0000000189BD6ED0 */ get => default; } // 0x0000000186748030-0x00000001867480D0 
		public VariableSet[] ExposedVariables { /* [XID] */ /* 0x000000018964F730-0x000000018964F750 */ get => default; } // 0x0000000186747F90-0x0000000186748030 
	
		// Constructors
		public RuntimeInspectorSettings() {} // 0x0000000186747F30-0x0000000186747F90
	}
}
