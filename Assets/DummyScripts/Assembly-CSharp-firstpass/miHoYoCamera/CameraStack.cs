/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public class CameraStack // TypeDefIndex: 8939
	{
		// Fields
		private CommonPriorityStack _stack; // 0x10
	
		// Properties
		public int Count { /* [XID] */ /* 0x0000000189667AF0-0x0000000189667B10 */ get => default; } // 0x0000000185A725A0-0x0000000185A72650 
		public ICameraState this[int index] { /* [XID] */ /* 0x0000000189A2FCF0-0x0000000189A2FD10 */ get => default; } // 0x0000000185A72650-0x0000000185A72730 
	
		// Constructors
		public CameraStack() {} // 0x0000000185A72510-0x0000000185A725A0
	
		// Methods
		// [XID] // 0x0000000189676DB0-0x0000000189676DD0
		public void Push(ICameraState state) {} // 0x0000000185A723A0-0x0000000185A72460
		// [XID] // 0x000000018967E420-0x000000018967E440
		public ICameraState Pop(int index = 0 /* Metadata: 0x00AE4ED5 */) => default; // 0x0000000185A722C0-0x0000000185A723A0
		// [XID] // 0x0000000189AA4A60-0x0000000189AA4A80
		public ICameraState Top() => default; // 0x0000000185A72460-0x0000000185A72510
		// [XID] // 0x00000001899A6FF0-0x00000001899A7010
		public ICameraState Next() => default; // 0x0000000185A72130-0x0000000185A721E0
		// [XID] // 0x0000000189695250-0x0000000189695270
		private ICameraState Peek(int index) => default; // 0x0000000185A721E0-0x0000000185A722C0
	}
}
