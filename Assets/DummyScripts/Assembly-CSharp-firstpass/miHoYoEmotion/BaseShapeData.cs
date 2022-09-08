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
	public abstract class BaseShapeData : ScriptableObject // TypeDefIndex: 8497
	{
		// Fields
		protected Dictionary<string, ShapeElement> _elementDic; // 0x18
	
		// Constructors
		protected BaseShapeData() {} // 0x0000000187318560-0x00000001873185D0
	
		// Methods
		// [XID] // 0x00000001897E58C0-0x00000001897E58E0
		protected void InitElementDic() {} // 0x00000001873183D0-0x00000001873184A0
		public T GetShapeElement<T>(string name)
			where T : ShapeElement, new() => default;
		// [XID] // 0x0000000189AF0A90-0x0000000189AF0AB0
		protected void AddShapeElement(ShapeElement shapeElement) {} // 0x00000001873182B0-0x00000001873183D0
		// [XID] // 0x0000000189B10000-0x0000000189B10020
		public virtual void UpdateElements() {} // 0x00000001873184A0-0x0000000187318560
	}
}
