/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace XInputDotNetPure
{
	public struct GamePadThumbSticks // TypeDefIndex: 8015
	{
		// Fields
		private StickValue left; // 0x00
		private StickValue right; // 0x08
	
		// Properties
		public StickValue Left { /* [XID] */ /* 0x000000018991B530-0x000000018991B550 */ get => default; } // 0x000000018948C9B0-0x000000018948CA70 
		public StickValue Right { /* [XID] */ /* 0x00000001895F2110-0x00000001895F2130 */ get => default; } // 0x000000018948CA70-0x000000018948CA80 
	
		// Nested types
		public struct StickValue // TypeDefIndex: 8016
		{
			// Fields
			private Vector2 vector; // 0x00
	
			// Properties
			public float X { /* [XID] */ /* 0x000000018992A260-0x000000018992A280 */ get => default; } // 0x000000018948E3B0-0x000000018948E470 
			public float Y { /* [XID] */ /* 0x0000000189931870-0x0000000189931890 */ get => default; } // 0x000000018948E470-0x000000018948E480 
			public Vector2 Vector { /* [XID] */ /* 0x0000000189686A70-0x0000000189686A90 */ get => default; } // 0x000000018948E2F0-0x000000018948E3B0 
	
			// Constructors
			internal StickValue(float x, float y) : this() {
				vector = default;
			} // 0x000000018948E230-0x000000018948E2F0
		}
	
		// Constructors
		internal GamePadThumbSticks(StickValue left, StickValue right) : this() {
			this.left = default;
			this.right = default;
		} // 0x000000018948C890-0x000000018948C9B0
	}
}
