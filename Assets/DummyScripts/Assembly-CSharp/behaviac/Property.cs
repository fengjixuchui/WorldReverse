/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class Property // TypeDefIndex: 27413
	{
		// Fields
		private IProperty m_bindingProperty; // 0x10
		private bool m_bIsStatic; // 0x18
		private bool m_bIsLocal; // 0x19
		private string m_strNativeTypeName; // 0x20
		protected string m_variableName; // 0x28
		protected string m_instanceName; // 0x30
		protected uint m_variableId; // 0x38
		protected Property m_parent; // 0x40
		protected Property m_index; // 0x48
		protected readonly CMemberBase m_memberBase; // 0x50
		protected object m_defaultValue; // 0x58
		private bool m_bValidDefaultValue; // 0x60
		protected readonly bool m_bIsConst; // 0x61
	
		// Properties
		public IProperty BindingProperty { get => default; set {} } // 0x0000000186DF06B0-0x0000000186DF0710 0x0000000186DF0A40-0x0000000186DF0AA0
		public string Name { get => default; set {} } // 0x0000000186DF0890-0x0000000186DF08F0 0x0000000186DF0BC0-0x0000000186DF0C60
		public string InstanceName { get => default; set {} } // 0x0000000186DF0710-0x0000000186DF07D0 0x0000000186DF0AA0-0x0000000186DF0B00
		public uint VariableId { get => default; } // 0x0000000186DF09E0-0x0000000186DF0A40 
		public bool IsStatic { get => default; set {} } // 0x0000000186DF0830-0x0000000186DF0890 0x0000000186DF0B60-0x0000000186DF0BC0
		public bool IsLocal { get => default; set {} } // 0x0000000186DF07D0-0x0000000186DF0830 0x0000000186DF0B00-0x0000000186DF0B60
		public System.Type PropertyType { get => default; } // 0x0000000186DF0950-0x0000000186DF09E0 
		public string NativeTypeName { get => default; set {} } // 0x0000000186DF08F0-0x0000000186DF0950 0x0000000186DF0C60-0x0000000186DF0D20
	
		// Constructors
		public Property() {} // Dummy constructor
		public Property(CMemberBase pMemberBase, bool bIsConst) {} // 0x0000000186DF05A0-0x0000000186DF0630
		protected Property(Property copy) {} // 0x0000000186DF04C0-0x0000000186DF05A0
	
		// Methods
		public float GetRange() => default; // 0x0000000186DF0440-0x0000000186DF04C0
		public virtual Property clone() => default; // 0x0000000186DF0630-0x0000000186DF06B0
		public static void Cleanup() {} // 0x0000000186DF03F0-0x0000000186DF0440
	}
}
