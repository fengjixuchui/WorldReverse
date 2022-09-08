/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	[AttributeUsage(AttributeTargets.All)] // 0x000000018991E380-0x000000018991E3A0
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 4728
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute() {} // 0x0000000188DD7150-0x0000000188DD71C0
		public fsObjectAttribute(string versionString, params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] previousModels) {} // 0x0000000188DD70C0-0x0000000188DD7150
	}
}
