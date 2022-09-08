/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class SimpleFixedBitStack : IDisposable // TypeDefIndex: 31406
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _value; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _stack; // 0x14
	
		// Properties
		public bool value { /* [XID] */ /* 0x000000018978D180-0x000000018978D1A0 */ get => default; } // 0x0000000184EF9240-0x0000000184EF92E0 
		public uint stack { /* [XID] */ /* 0x0000000189794530-0x0000000189794550 */ get => default; } // 0x0000000184EF9140-0x0000000184EF91E0 
		public StackMethod updateType { /* [XID] */ /* 0x000000018979C9C0-0x000000018979CA00 */ get; /* [XID] */ /* 0x00000001897A6E30-0x00000001897A6E70 */ private set; } // 0x0000000184EF91E0-0x0000000184EF9240 0x0000000184EF92E0-0x0000000184EF9340
	
		// Nested types
		public enum StackMethod // TypeDefIndex: 31407
		{
			OnceTrue = 0,
			OnceFalse = 1
		}
	
		// Constructors
		public SimpleFixedBitStack() {} // 0x0000000184EF9060-0x0000000184EF90C0
		public SimpleFixedBitStack(StackMethod valueType) {} // 0x0000000184EF90C0-0x0000000184EF9140
	
		// Methods
		// [XID] // 0x00000001897B1750-0x00000001897B1770
		public void Init(StackMethod valueType) {} // 0x0000000184EF8C20-0x0000000184EF8D10
		// [XID] // 0x00000001897B9180-0x00000001897B91A0
		public void Reinit() {} // 0x0000000184EF88B0-0x0000000184EF89B0
		// [XID] // 0x00000001897C12A0-0x00000001897C12C0
		public void Push(int ix, bool value) {} // 0x0000000184EF89B0-0x0000000184EF8AC0
		// [XID] // 0x00000001897C8D00-0x00000001897C8D20
		public void Pop(int ix) {} // 0x0000000184EF8E10-0x0000000184EF8F60
		// [XID] // 0x00000001897D0320-0x00000001897D0340
		public bool Get(int ix) => default; // 0x0000000184EF8D10-0x0000000184EF8E10
		// [XID] // 0x00000001897D7FC0-0x00000001897D7FE0
		private void UpdateValue() {} // 0x0000000184EF8F60-0x0000000184EF9060
		// [XID] // 0x00000001896C7190-0x00000001896C71B0
		public void SyncStack(uint newStack) {} // 0x0000000184EF8AC0-0x0000000184EF8B80
		// [XID] // 0x00000001897E6A00-0x00000001897E6A20
		public void Dispose() {} // 0x0000000184EF8B80-0x0000000184EF8C20
	}
}
