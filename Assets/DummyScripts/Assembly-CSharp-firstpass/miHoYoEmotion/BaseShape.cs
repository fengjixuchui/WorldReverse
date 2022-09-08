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

namespace miHoYoEmotion
{
	[Serializable]
	public class BaseShape : ISerializationCallbackReceiver // TypeDefIndex: 8532
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string name; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<string> elements; // 0x18
	
		// Constructors
		public BaseShape() {} // 0x0000000187318A00-0x0000000187318A90
	
		// Methods
		// [XID] // 0x0000000189848BA0-0x0000000189848BC0
		public virtual string GetElementName() => default; // 0x00000001873187A0-0x0000000187318880
		// [XID] // 0x00000001898504A0-0x00000001898504C0
		public void OnBeforeSerialize() {} // 0x0000000187318960-0x0000000187318A00
		// [XID] // 0x00000001898576F0-0x0000000189857710
		public void OnAfterDeserialize() {} // 0x0000000187318880-0x0000000187318960
	}
}
