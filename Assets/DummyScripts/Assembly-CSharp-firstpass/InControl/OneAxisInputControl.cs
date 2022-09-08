/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class OneAxisInputControl : IInputControl // TypeDefIndex: 7628
	{
		// Fields
		private float sensitivity; // 0x18
		private float lowerDeadZone; // 0x1C
		private float upperDeadZone; // 0x20
		private float stateThreshold; // 0x24
		protected bool isNullControl; // 0x28
		public float FirstRepeatDelay; // 0x2C
		public float RepeatDelay; // 0x30
		public bool Raw; // 0x34
		internal bool Enabled; // 0x35
		private ulong pendingTick; // 0x38
		private bool pendingCommit; // 0x40
		private float nextRepeatTime; // 0x44
		private float lastPressedTime; // 0x48
		private bool wasRepeated; // 0x4C
		private bool clearInputState; // 0x4D
		private InputControlState lastState; // 0x50
		private InputControlState nextState; // 0x5C
		private InputControlState thisState; // 0x68
	
		// Properties
		public ulong UpdateTick { /* [XID] */ /* 0x0000000189986C20-0x0000000189986C60 */ get; /* [XID] */ /* 0x0000000189991A50-0x0000000189991A90 */ protected set; } // 0x0000000187EF6D60-0x0000000187EF6DC0 0x0000000187EF75E0-0x0000000187EF7640
		public bool State { /* [XID] */ /* 0x000000018974B910-0x000000018974B930 */ get => default; } // 0x0000000187EF6CB0-0x0000000187EF6D60 
		public bool LastState { /* [XID] */ /* 0x00000001899EE960-0x00000001899EE980 */ get => default; } // 0x0000000187EF67B0-0x0000000187EF6860 
		public float Value { /* [XID] */ /* 0x00000001897FB370-0x00000001897FB390 */ get => default; } // 0x0000000187EF6E70-0x0000000187EF6F30 
		public float LastValue { /* [XID] */ /* 0x00000001899FD890-0x00000001899FD8B0 */ get => default; } // 0x0000000187EF6860-0x0000000187EF6920 
		public float RawValue { /* [XID] */ /* 0x00000001899C3710-0x00000001899C3730 */ get => default; } // 0x0000000187EF6A90-0x0000000187EF6B50 
		internal float NextRawValue { /* [XID] */ /* 0x0000000189A0C5B0-0x0000000189A0C5D0 */ get => default; } // 0x0000000187EF69D0-0x0000000187EF6A90 
		internal bool HasInput { /* [XID] */ /* 0x0000000189B16D40-0x0000000189B16D60 */ get => default; } // 0x0000000187EF6570-0x0000000187EF6660 
		public bool HasChanged { /* [XID] */ /* 0x00000001899D21D0-0x00000001899D21F0 */ get => default; } // 0x0000000187EF6480-0x0000000187EF6570 
		public bool IsPressed { /* [XID] */ /* 0x0000000189A22AC0-0x0000000189A22AE0 */ get => default; } // 0x0000000187EF6700-0x0000000187EF67B0 
		public bool WasPressed { /* [XID] */ /* 0x00000001897CFE50-0x00000001897CFE70 */ get => default; } // 0x0000000187EF6F30-0x0000000187EF7020 
		public bool WasReleased { /* [XID] */ /* 0x0000000189A31160-0x0000000189A31180 */ get => default; } // 0x0000000187EF7020-0x0000000187EF7120 
		public bool WasRepeated { /* [XID] */ /* 0x0000000189769150-0x0000000189769170 */ get => default; } // 0x0000000187EF7120-0x0000000187EF71D0 
		public float Sensitivity { /* [XID] */ /* 0x0000000189A40420-0x0000000189A40440 */ get => default; /* [XID] */ /* 0x0000000189A47AB0-0x0000000189A47AD0 */ set {} } // 0x0000000187EF6B50-0x0000000187EF6C00 0x0000000187EF7420-0x0000000187EF7500
		public float LowerDeadZone { /* [XID] */ /* 0x0000000189B43B30-0x0000000189B43B50 */ get => default; /* [XID] */ /* 0x0000000189A56920-0x0000000189A56940 */ set {} } // 0x0000000187EF6920-0x0000000187EF69D0 0x0000000187EF7340-0x0000000187EF7420
		public float UpperDeadZone { /* [XID] */ /* 0x0000000189A5E4C0-0x0000000189A5E4E0 */ get => default; /* [XID] */ /* 0x0000000189A65D00-0x0000000189A65D20 */ set {} } // 0x0000000187EF6DC0-0x0000000187EF6E70 0x0000000187EF7640-0x0000000187EF7720
		public float StateThreshold { /* [XID] */ /* 0x0000000189B693F0-0x0000000189B69410 */ get => default; /* [XID] */ /* 0x0000000189A74B60-0x0000000189A74B80 */ set {} } // 0x0000000187EF6C00-0x0000000187EF6CB0 0x0000000187EF7500-0x0000000187EF75E0
		public bool IsNullControl { /* [XID] */ /* 0x00000001899D9920-0x00000001899D9940 */ get => default; } // 0x0000000187EF6660-0x0000000187EF6700 
	
		// Constructors
		public OneAxisInputControl() {} // 0x0000000187EF63F0-0x0000000187EF6480
	
		// Methods
		// [XID] // 0x000000018999C440-0x000000018999C460
		private void PrepareForUpdate(ulong updateTick) {} // 0x0000000187EF5D70-0x0000000187EF5ED0
		// [XID] // 0x00000001899A3D60-0x00000001899A3D80
		public bool UpdateWithState(bool state, ulong updateTick, float deltaTime) => default; // 0x0000000187EF6130-0x0000000187EF6240
		// [XID] // 0x00000001899AB970-0x00000001899AB990
		public bool UpdateWithValue(float value, ulong updateTick, float deltaTime) => default; // 0x0000000187EF6240-0x0000000187EF63F0
		// [XID] // 0x00000001899B3250-0x00000001899B3270
		internal bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime) => default; // 0x0000000187EF5FE0-0x0000000187EF6130
		// [XID] // 0x00000001899BA560-0x00000001899BA580
		internal void SetValue(float value, ulong updateTick) {} // 0x0000000187EF5ED0-0x0000000187EF5FE0
		// [XID] // 0x0000000189ADCDF0-0x0000000189ADCE10
		public void ClearInputState() {} // 0x0000000187EF56E0-0x0000000187EF57A0
		// [XID] // 0x00000001895E69D0-0x00000001895E69F0
		public void Commit() {} // 0x0000000187EF5BD0-0x0000000187EF5D70
		// [XID] // 0x0000000189A9E8F0-0x0000000189A9E910
		public void CommitWithState(bool state, ulong updateTick, float deltaTime) {} // 0x0000000187EF59D0-0x0000000187EF5AD0
		// [XID] // 0x00000001899D8370-0x00000001899D8390
		public void CommitWithValue(float value, ulong updateTick, float deltaTime) {} // 0x0000000187EF5AD0-0x0000000187EF5BD0
		// [XID] // 0x0000000189731360-0x0000000189731380
		internal void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime) {} // 0x0000000187EF57A0-0x0000000187EF59D0
		// [IDTag] // 0x0000000189A83FB0-0x0000000189A83FF0
		// [XID] // 0x0000000189A83FB0-0x0000000189A83FF0
		public static implicit operator bool(OneAxisInputControl instance) => default; // 0x0000000187EF71D0-0x0000000187EF7280
		// [IDTag] // 0x0000000189A8E8D0-0x0000000189A8E910
		// [XID] // 0x0000000189A8E8D0-0x0000000189A8E910
		public static implicit operator float(OneAxisInputControl instance) => default; // 0x0000000187EF7280-0x0000000187EF7340
	}
}
