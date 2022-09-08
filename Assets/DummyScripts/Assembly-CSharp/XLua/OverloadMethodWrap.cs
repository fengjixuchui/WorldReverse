/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class OverloadMethodWrap // TypeDefIndex: 32402
	{
		// Fields
		private ObjectTranslator translator; // 0x10
		private System.Type targetType; // 0x18
		private MethodBase method; // 0x20
		private ObjectCheck[] checkArray; // 0x28
		private ObjectCast[] castArray; // 0x30
		private int[] inPosArray; // 0x38
		private int[] outPosArray; // 0x40
		private bool[] isOptionalArray; // 0x48
		private object[] defaultValueArray; // 0x50
		private bool isVoid; // 0x58
		private int luaStackPosStart; // 0x5C
		private bool targetNeeded; // 0x60
		private object[] args; // 0x68
		private int[] refPos; // 0x70
		private System.Type paramsType; // 0x78
	
		// Properties
		public bool HasDefalutValue { get; private set; } // 0x00000001866B2C50-0x00000001866B2CB0 0x00000001866B2CB0-0x00000001866B2D20
	
		// Constructors
		public OverloadMethodWrap() {} // Dummy constructor
		public OverloadMethodWrap(ObjectTranslator translator, System.Type targetType, MethodBase method) {} // 0x00000001866B2B70-0x00000001866B2C50
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x00000001866B1D50-0x00000001866B2B70
		public bool Check(IntPtr L) => default; // 0x00000001866B1B50-0x00000001866B1D50
		public int Call(IntPtr L) => default; // 0x00000001866B12F0-0x00000001866B1B50
	}
}
