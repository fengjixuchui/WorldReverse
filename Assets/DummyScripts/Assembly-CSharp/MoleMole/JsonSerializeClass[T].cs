/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class JsonSerializeClass<T> : JsonSerializeClassBase // TypeDefIndex: 27861
		where T : class
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected List<T> _data;
	
		// Properties
		public List<T> data { get => default; }
	
		// Constructors
		public JsonSerializeClass() {} // Dummy constructor
		public JsonSerializeClass(List<T> inData) {}
		public JsonSerializeClass(List<object> inData) {}
	
		// Methods
		public override void FillDataList(List<object> inData) {}
		public override void PostLoad() {}
	}
}
