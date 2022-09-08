/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[AttributeUsage(AttributeTargets.All)] // 0x00000001896D1B50-0x00000001896D1B70
	public class ValueRangeAttribute : Attribute // TypeDefIndex: 32162
	{
		// Fields
		public float min; // 0x10
		public float max; // 0x14
		public bool rangeByValue; // 0x18
		public FieldInfo minField; // 0x20
		public FieldInfo maxField; // 0x28
		public CameraModuleType[] moduleType; // 0x30
		public typeEnum type; // 0x38
	
		// Nested types
		public enum typeEnum // TypeDefIndex: 32163
		{
			Int = 0,
			Float = 1,
			Bool = 2,
			EaseType = 3
		}
	
		// Constructors
		public ValueRangeAttribute() {} // Dummy constructor
		public ValueRangeAttribute(float min, float max, typeEnum type, params /* 0x000000018989F6F0-0x000000018989F700 */ CameraModuleType[] types) {} // 0x00000001821B5A90-0x00000001821B5B40
		public ValueRangeAttribute(typeEnum type, params /* 0x000000018989F6F0-0x000000018989F700 */ CameraModuleType[] types) {} // 0x00000001821B5A10-0x00000001821B5A90
		public ValueRangeAttribute(params /* 0x000000018989F6F0-0x000000018989F700 */ CameraModuleType[] types) {} // 0x00000001821B5B40-0x00000001821B5BC0
		public ValueRangeAttribute(System.Type codeType, string min, string max, typeEnum type, params /* 0x000000018989F6F0-0x000000018989F700 */ CameraModuleType[] moduleTypes) {} // 0x00000001821B5950-0x00000001821B5A10
	}
}
