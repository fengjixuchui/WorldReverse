/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public static class InspectedMemberFilters // TypeDefIndex: 4823
	{
		// Fields
		public static IInspectedMemberFilter All; // 0x00
		public static IInspectedMemberFilter FullInspectorSerializedProperties; // 0x08
		public static IInspectedMemberFilter InspectableMembers; // 0x10
		public static IInspectedMemberFilter StaticInspectableMembers; // 0x18
		public static IInspectedMemberFilter ButtonMembers; // 0x20
	
		// Nested types
		private class AllFilter : IInspectedMemberFilter // TypeDefIndex: 4824
		{
			// Constructors
			public AllFilter() {} // 0x0000000185CE8230-0x0000000185CE82B0
	
			// Methods
			public bool IsInterested(InspectedProperty property) => default; // 0x0000000185CE8190-0x0000000185CE81E0
			public bool IsInterested(InspectedMethod method) => default; // 0x0000000185CE81E0-0x0000000185CE8230
		}
	
		private class FullInspectorSerializedPropertiesFilter : IInspectedMemberFilter // TypeDefIndex: 4825
		{
			// Constructors
			public FullInspectorSerializedPropertiesFilter() {} // 0x0000000185CEB570-0x0000000185CEB5D0
	
			// Methods
			public bool IsInterested(InspectedProperty property) => default; // 0x0000000185CEB450-0x0000000185CEB570
			public bool IsInterested(InspectedMethod method) => default; // 0x0000000185CEB400-0x0000000185CEB450
		}
	
		private class InspectableMembersFilter : IInspectedMemberFilter // TypeDefIndex: 4826
		{
			// Constructors
			public InspectableMembersFilter() {} // 0x0000000185CEC6F0-0x0000000185CEC750
	
			// Methods
			public bool IsInterested(InspectedProperty property) => default; // 0x0000000185CEC630-0x0000000185CEC6F0
			public bool IsInterested(InspectedMethod method) => default; // 0x0000000185CEC520-0x0000000185CEC630
		}
	
		private class StaticInspectableMembersFilter : IInspectedMemberFilter // TypeDefIndex: 4827
		{
			// Constructors
			public StaticInspectableMembersFilter() {} // 0x0000000185CF6250-0x0000000185CF62B0
	
			// Methods
			public bool IsInterested(InspectedProperty property) => default; // 0x0000000185CF6170-0x0000000185CF6250
			public bool IsInterested(InspectedMethod method) => default; // 0x0000000185CF6060-0x0000000185CF6170
		}
	
		private class ButtonMembersFilter : IInspectedMemberFilter // TypeDefIndex: 4828
		{
			// Constructors
			public ButtonMembersFilter() {} // 0x0000000185CE9CE0-0x0000000185CE9D40
	
			// Methods
			public bool IsInterested(InspectedProperty property) => default; // 0x0000000185CE9C90-0x0000000185CE9CE0
			public bool IsInterested(InspectedMethod method) => default; // 0x0000000185CE9B80-0x0000000185CE9C90
		}
	
		// Constructors
		static InspectedMemberFilters() {} // 0x0000000185CECFB0-0x0000000185CED210
	
		// Methods
		private static bool ShouldDisplayProperty(InspectedProperty property) => default; // 0x0000000185CECB10-0x0000000185CECFB0
		private static bool IsPropertyTypeInspectable(InspectedProperty property) => default; // 0x0000000185CEC750-0x0000000185CECB10
	}
}
