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

namespace RuntimeInspectorNamespace
{
	[Serializable]
	public class VariableSet // TypeDefIndex: 10034
	{
		// Fields
		private const string INCLUDE_ALL_VARIABLES = "*"; // Metadata: 0x00AE6E2D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string m_type; // 0x10
		public System.Type type; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string[] m_variables; // 0x20
		public HashSet<string> variables; // 0x28
	
		// Constructors
		public VariableSet() {} // 0x0000000186756120-0x0000000186756190
	
		// Methods
		// [XID] // 0x00000001896C2700-0x00000001896C2720
		public bool Init() => default; // 0x0000000186755F20-0x0000000186756120
		// [XID] // 0x00000001896C9CB0-0x00000001896C9CD0
		private void AddAllVariablesToSet() {} // 0x0000000186755DC0-0x0000000186755F20
	}
}
