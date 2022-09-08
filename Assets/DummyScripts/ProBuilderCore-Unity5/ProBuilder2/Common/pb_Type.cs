/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_Type : ISerializationCallbackReceiver // TypeDefIndex: 3453
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string assemblyQualifiedName; // 0x10
		public System.Type type; // 0x18
	
		// Constructors
		public pb_Type() {} // Dummy constructor
		public pb_Type(System.Type t) {} // 0x00000001894CF1C0-0x00000001894CF230
	
		// Methods
		public void OnBeforeSerialize() {} // 0x00000001894CF140-0x00000001894CF1C0
		public void OnAfterDeserialize() {} // 0x00000001894CF080-0x00000001894CF140
		public static implicit operator System.Type(pb_Type t) => default; // 0x00000001894CF230-0x00000001894CF2A0
		public static implicit operator pb_Type(System.Type t) => default; // 0x00000001894CF2A0-0x00000001894CF360
	}
}
