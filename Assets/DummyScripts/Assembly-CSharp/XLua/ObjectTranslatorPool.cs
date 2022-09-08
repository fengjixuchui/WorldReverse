/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class ObjectTranslatorPool // TypeDefIndex: 32427
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators; // 0x10
		private IntPtr lastPtr; // 0x18
		private ObjectTranslator lastTranslator; // 0x20
	
		// Properties
		public static ObjectTranslatorPool Instance { get => default; } // 0x00000001866B1260-0x00000001866B12F0 
	
		// Constructors
		public ObjectTranslatorPool() {} // 0x00000001866B11C0-0x00000001866B1260
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator) {} // 0x00000001866B0D70-0x00000001866B0EA0
		public ObjectTranslator Find(IntPtr L) => default; // 0x00000001866B0EA0-0x00000001866B1090
		public void Remove(IntPtr L) {} // 0x00000001866B1090-0x00000001866B11C0
	}
}
