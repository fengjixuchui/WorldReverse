/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace XInputDotNetPure
{
	public struct GamePadState // TypeDefIndex: 8018
	{
		// Fields
		private bool isConnected; // 0x00
		private uint packetNumber; // 0x04
		private GamePadButtons buttons; // 0x08
		private GamePadDPad dPad; // 0x30
		private GamePadThumbSticks thumbSticks; // 0x40
		private GamePadTriggers triggers; // 0x50
	
		// Properties
		public uint PacketNumber { /* [XID] */ /* 0x00000001898AFCD0-0x00000001898AFCF0 */ get => default; } // 0x000000018948C630-0x000000018948C710 
		public bool IsConnected { /* [XID] */ /* 0x0000000189956A60-0x0000000189956A80 */ get => default; } // 0x000000018948C580-0x000000018948C630 
		public GamePadButtons Buttons { /* [XID] */ /* 0x0000000189B155D0-0x0000000189B155F0 */ get => default; } // 0x000000018948C3A0-0x000000018948C4B0 
		public GamePadDPad DPad { /* [XID] */ /* 0x0000000189A18DD0-0x0000000189A18DF0 */ get => default; } // 0x000000018948C4B0-0x000000018948C580 
		public GamePadTriggers Triggers { /* [XID] */ /* 0x0000000189BCF230-0x0000000189BCF250 */ get => default; } // 0x000000018948C7F0-0x000000018948C890 
		public GamePadThumbSticks ThumbSticks { /* [XID] */ /* 0x0000000189974C70-0x0000000189974C90 */ get => default; } // 0x000000018948C710-0x000000018948C7F0 
	
		// Nested types
		internal struct RawState // TypeDefIndex: 8019
		{
			// Fields
			public uint dwPacketNumber; // 0x00
			public GamePad Gamepad; // 0x04
	
			// Nested types
			public struct GamePad // TypeDefIndex: 8020
			{
				// Fields
				public ushort dwButtons; // 0x00
				public byte bLeftTrigger; // 0x02
				public byte bRightTrigger; // 0x03
				public short sThumbLX; // 0x04
				public short sThumbLY; // 0x06
				public short sThumbRX; // 0x08
				public short sThumbRY; // 0x0A
			}
		}
	
		private enum ButtonsConstants // TypeDefIndex: 8021
		{
			DPadUp = 1,
			DPadDown = 2,
			DPadLeft = 4,
			DPadRight = 8,
			Start = 16,
			Back = 32,
			LeftThumb = 64,
			RightThumb = 128,
			LeftShoulder = 256,
			RightShoulder = 512,
			A = 4096,
			B = 8192,
			X = 16384,
			Y = 32768
		}
	
		// Constructors
		internal GamePadState(bool isConnected, RawState rawState) : this() {
			this.isConnected = default;
			packetNumber = default;
			buttons = default;
			dPad = default;
			thumbSticks = default;
			triggers = default;
		} // 0x000000018948C250-0x000000018948C3A0
	}
}
