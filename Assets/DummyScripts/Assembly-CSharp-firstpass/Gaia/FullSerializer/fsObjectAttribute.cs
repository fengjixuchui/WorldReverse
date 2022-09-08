/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	[AttributeUsage(AttributeTargets.All)] // 0x000000018991E380-0x000000018991E3A0
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 9257
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute() {} // 0x0000000186B57BA0-0x0000000186B57C10
		public fsObjectAttribute(string versionString, params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] previousModels) {} // 0x0000000186B57B10-0x0000000186B57BA0
	}
}
