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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class ExposedVariablesEnumerator : IEnumerator<MemberInfo>, IEnumerable<MemberInfo> // TypeDefIndex: 10023
	{
		// Fields
		private int index; // 0x10
		private MemberInfo[] variables; // 0x18
		private List<VariableSet> hiddenVariables; // 0x20
		private List<VariableSet> exposedVariables; // 0x28
		private bool debugMode; // 0x30
		private bool exposePrivateFields; // 0x31
		private bool exposePublicFields; // 0x32
		private bool exposePrivateProperties; // 0x33
		private bool exposePublicProperties; // 0x34
	
		// Properties
		object IEnumerator.Current { /* [XID] */ /* 0x00000001898F3F80-0x00000001898F3FA0 */ get => default; } // 0x00000001867EF220-0x00000001867EF2D0 
		public MemberInfo Current { /* [XID] */ /* 0x00000001898EC540-0x00000001898EC560 */ get => default; } // 0x00000001867EF390-0x00000001867EF460 
	
		// Constructors
		public ExposedVariablesEnumerator() {} // Dummy constructor
		public ExposedVariablesEnumerator(MemberInfo[] variables, List<VariableSet> hiddenVariables, List<VariableSet> exposedVariables, bool debugMode, bool exposePrivateFields, bool exposePublicFields, bool exposePrivateProperties, bool exposePublicProperties) {} // 0x00000001867EF2D0-0x00000001867EF390
	
		// Methods
		// [XID] // 0x00000001898FB370-0x00000001898FB390
		public void Dispose() {} // 0x00000001867EE9C0-0x00000001867EEA60
		// [XID] // 0x0000000189902FC0-0x0000000189902FE0
		public IEnumerator<MemberInfo> GetEnumerator() => default; // 0x00000001867EEA60-0x00000001867EEB00
		// [XID] // 0x00000001895EECC0-0x00000001895EECE0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001867EF180-0x00000001867EF220
		// [XID] // 0x0000000189911FD0-0x0000000189911FF0
		public bool MoveNext() => default; // 0x00000001867EEC60-0x00000001867EEF30
		// [XID] // 0x0000000189A4AF50-0x0000000189A4AF70
		public void Reset() {} // 0x00000001867EEF30-0x00000001867EEFD0
		// [XID] // 0x000000018962C010-0x000000018962C030
		private bool IsVariableInExposedVariablesList(string variableName) => default; // 0x00000001867EEB00-0x00000001867EEC60
		// [XID] // 0x0000000189928A30-0x0000000189928A50
		private bool ShouldExposeVariable(MemberInfo variable) => default; // 0x00000001867EEFD0-0x00000001867EF180
	}
}
