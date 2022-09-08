/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Attributes
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189BBA630-0x0000000189BBA6B0
	[CustomClassObfuscation] // 0x0000000189BBA630-0x0000000189BBA6B0
	[CustomObfuscation] // 0x0000000189BBA630-0x0000000189BBA6B0
	public class SerializationTypeAttribute : Attribute // TypeDefIndex: 3472
	{
		// Fields
		private SerializationType _serializationType; // 0x10
	
		// Properties
		public SerializationType serializationType { get => default; } // 0x0000000185566F90-0x0000000185566FF0 
	
		// Nested types
		public enum SerializationType // TypeDefIndex: 3473
		{
			Default = 0,
			Object = 1
		}
	
		// Constructors
		public SerializationTypeAttribute() {} // Dummy constructor
		public SerializationTypeAttribute(SerializationType serializationType) {} // 0x0000000185566EF0-0x0000000185566F90
	}
}
