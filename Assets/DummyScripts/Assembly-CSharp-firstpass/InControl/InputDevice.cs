/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class InputDevice // TypeDefIndex: 7634
	{
		// Fields
		public static readonly InputDevice Null; // 0x00
		private readonly List<InputControl> controls; // 0x50
		public bool Passive; // 0x80
		private InputControl cachedLeftStickUp; // 0x90
		private InputControl cachedLeftStickDown; // 0x98
		private InputControl cachedLeftStickLeft; // 0xA0
		private InputControl cachedLeftStickRight; // 0xA8
		private InputControl cachedRightStickUp; // 0xB0
		private InputControl cachedRightStickDown; // 0xB8
		private InputControl cachedRightStickLeft; // 0xC0
		private InputControl cachedRightStickRight; // 0xC8
		private InputControl cachedDPadUp; // 0xD0
		private InputControl cachedDPadDown; // 0xD8
		private InputControl cachedDPadLeft; // 0xE0
		private InputControl cachedDPadRight; // 0xE8
		private InputControl cachedAction1; // 0xF0
		private InputControl cachedAction2; // 0xF8
		private InputControl cachedAction3; // 0x100
		private InputControl cachedAction4; // 0x108
		private InputControl cachedLeftTrigger; // 0x110
		private InputControl cachedRightTrigger; // 0x118
		private InputControl cachedLeftBumper; // 0x120
		private InputControl cachedRightBumper; // 0x128
		private InputControl cachedLeftStickButton; // 0x130
		private InputControl cachedRightStickButton; // 0x138
		private InputControl cachedLeftStickX; // 0x140
		private InputControl cachedLeftStickY; // 0x148
		private InputControl cachedRightStickX; // 0x150
		private InputControl cachedRightStickY; // 0x158
		private InputControl cachedDPadX; // 0x160
		private InputControl cachedDPadY; // 0x168
		private InputControl cachedCommand; // 0x170
	
		// Properties
		public string Name { /* [XID] */ /* 0x000000018972BFD0-0x000000018972C010 */ get; /* [XID] */ /* 0x0000000189736770-0x00000001897367B0 */ protected set; } // 0x00000001870D4B50-0x00000001870D4BB0 0x00000001870D5A00-0x00000001870D5A60
		public string Meta { /* [XID] */ /* 0x0000000189741200-0x0000000189741240 */ get; /* [XID] */ /* 0x000000018974BBD0-0x000000018974BC10 */ protected set; } // 0x00000001870D4AF0-0x00000001870D4B50 0x00000001870D59A0-0x00000001870D5A00
		public int SortOrder { /* [XID] */ /* 0x0000000189756070-0x00000001897560B0 */ get; /* [XID] */ /* 0x0000000189612F20-0x0000000189612F60 */ protected set; } // 0x00000001870D5500-0x00000001870D5560 0x00000001870D5B20-0x00000001870D5B80
		public InputDeviceClass DeviceClass { /* [XID] */ /* 0x000000018976ADD0-0x000000018976AE10 */ get; /* [XID] */ /* 0x00000001897750D0-0x0000000189775110 */ protected set; } // 0x00000001870D39B0-0x00000001870D3A10 0x00000001870D56F0-0x00000001870D5750
		public InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x000000018977F800-0x000000018977F840 */ get; /* [XID] */ /* 0x000000018978A040-0x000000018978A080 */ protected set; } // 0x00000001870D3A10-0x00000001870D3A70 0x00000001870D5750-0x00000001870D57B0
		public Guid GUID { /* [XID] */ /* 0x00000001897943F0-0x0000000189794430 */ get; private set; } // 0x00000001870D3C50-0x00000001870D3CC0 0x00000001870D57B0-0x00000001870D5820
		public ulong LastInputTick { /* [XID] */ /* 0x00000001897A6D00-0x00000001897A6D40 */ get; /* [XID] */ /* 0x00000001897B13B0-0x00000001897B13F0 */ private set; } // 0x00000001870D4040-0x00000001870D40A0 0x00000001870D58E0-0x00000001870D5940
		public bool IsActive { /* [XID] */ /* 0x00000001897BCA00-0x00000001897BCA40 */ get; /* [XID] */ /* 0x00000001897C72B0-0x00000001897C72F0 */ private set; } // 0x00000001870D3CC0-0x00000001870D3D20 0x00000001870D5820-0x00000001870D5880
		public bool IsAttached { /* [XID] */ /* 0x00000001897D1580-0x00000001897D15C0 */ get; /* [XID] */ /* 0x00000001897DBE80-0x00000001897DBEC0 */ private set; } // 0x00000001870D3D20-0x00000001870D3D80 0x00000001870D5880-0x00000001870D58E0
		protected bool RawSticks { /* [XID] */ /* 0x00000001897E6980-0x00000001897E69C0 */ get; private set; } // 0x00000001870D4CF0-0x00000001870D4D50 0x00000001870D5A60-0x00000001870D5AC0
		public ReadOnlyCollection<InputControl> Controls { /* [XID] */ /* 0x00000001897F8C30-0x00000001897F8C70 */ get; protected set; } // 0x00000001870D3410-0x00000001870D3470 0x00000001870D5630-0x00000001870D5690
		protected InputControl[] ControlsByTarget { /* [XID] */ /* 0x000000018980A930-0x000000018980A970 */ get; private set; } // 0x00000001870D33B0-0x00000001870D3410 0x00000001870D55D0-0x00000001870D5630
		public TwoAxisInputControl LeftStick { /* [XID] */ /* 0x000000018981C920-0x000000018981C960 */ get; /* [XID] */ /* 0x0000000189827060-0x00000001898270A0 */ private set; } // 0x00000001870D4720-0x00000001870D4780 0x00000001870D5940-0x00000001870D59A0
		public TwoAxisInputControl RightStick { /* [XID] */ /* 0x00000001898313D0-0x0000000189831410 */ get; /* [XID] */ /* 0x000000018983B930-0x000000018983B970 */ private set; } // 0x00000001870D53D0-0x00000001870D5430 0x00000001870D5AC0-0x00000001870D5B20
		public TwoAxisInputControl DPad { /* [XID] */ /* 0x00000001898460E0-0x0000000189846120 */ get; /* [XID] */ /* 0x0000000189850500-0x0000000189850540 */ private set; } // 0x00000001870D3950-0x00000001870D39B0 0x00000001870D5690-0x00000001870D56F0
		protected AnalogSnapshotEntry[] AnalogSnapshot { /* [XID] */ /* 0x000000018985AAB0-0x000000018985AAF0 */ get; /* [XID] */ /* 0x000000018981AF50-0x000000018981AF90 */ set; } // 0x00000001870D2930-0x00000001870D2990 0x00000001870D5560-0x00000001870D55D0
		public InputControl this[InputControlType controlType] { /* [XID] */ /* 0x00000001898A2B00-0x00000001898A2B20 */ get => default; } // 0x00000001870D3F80-0x00000001870D4040 
		public virtual bool IsSupportedOnThisPlatform { /* [XID] */ /* 0x00000001898A4D20-0x00000001898A4D40 */ get => default; } // 0x00000001870D3E20-0x00000001870D3EC0 
		public virtual bool IsKnown { /* [XID] */ /* 0x0000000189996240-0x0000000189996260 */ get => default; } // 0x00000001870D3D80-0x00000001870D3E20 
		public bool IsUnknown { /* [XID] */ /* 0x000000018999DC80-0x000000018999DCA0 */ get => default; } // 0x00000001870D3EC0-0x00000001870D3F80 
		[Obsolete] // 0x0000000189B0CCA0-0x0000000189B0CCD0
		public bool MenuIsPressed { /* [XID] */ /* 0x0000000189819A10-0x0000000189819A30 */ get => default; } // 0x00000001870D4850-0x00000001870D4930 
		[Obsolete] // 0x0000000189B15830-0x0000000189B15860
		public bool MenuWasPressed { /* [XID] */ /* 0x00000001898211E0-0x0000000189821200 */ get => default; } // 0x00000001870D4930-0x00000001870D4A10 
		[Obsolete] // 0x0000000189B1E780-0x0000000189B1E7B0
		public bool MenuWasReleased { /* [XID] */ /* 0x00000001899B4740-0x00000001899B4760 */ get => default; } // 0x00000001870D4A10-0x00000001870D4AF0 
		public bool CommandIsPressed { /* [XID] */ /* 0x0000000189ACB280-0x0000000189ACB2A0 */ get => default; } // 0x00000001870D3040-0x00000001870D3120 
		public bool CommandWasPressed { /* [XID] */ /* 0x00000001899C38C0-0x00000001899C38E0 */ get => default; } // 0x00000001870D3120-0x00000001870D3200 
		public bool CommandWasReleased { /* [XID] */ /* 0x00000001899CADB0-0x00000001899CADD0 */ get => default; } // 0x00000001870D3200-0x00000001870D32E0 
		public InputControl AnyButton { /* [XID] */ /* 0x00000001897A5450-0x00000001897A5470 */ get => default; } // 0x00000001870D2E70-0x00000001870D3040 
		public bool AnyButtonIsPressed { /* [XID] */ /* 0x00000001897B48E0-0x00000001897B4900 */ get => default; } // 0x00000001870D2990-0x00000001870D2B30 
		public bool AnyButtonWasPressed { /* [XID] */ /* 0x00000001897C3C90-0x00000001897C3CB0 */ get => default; } // 0x00000001870D2B30-0x00000001870D2CD0 
		public bool AnyButtonWasReleased { /* [XID] */ /* 0x00000001899E8BF0-0x00000001899E8C10 */ get => default; } // 0x00000001870D2CD0-0x00000001870D2E70 
		public TwoAxisInputControl Direction { /* [XID] */ /* 0x0000000189630150-0x0000000189630170 */ get => default; } // 0x00000001870D3A70-0x00000001870D3C50 
		public InputControl LeftStickUp { /* [XID] */ /* 0x00000001899F79B0-0x00000001899F79D0 */ get => default; } // 0x00000001870D44B0-0x00000001870D4580 
		public InputControl LeftStickDown { /* [XID] */ /* 0x00000001899FF050-0x00000001899FF070 */ get => default; } // 0x00000001870D4240-0x00000001870D4310 
		public InputControl LeftStickLeft { /* [XID] */ /* 0x0000000189B1FEF0-0x0000000189B1FF10 */ get => default; } // 0x00000001870D4310-0x00000001870D43E0 
		public InputControl LeftStickRight { /* [XID] */ /* 0x0000000189A6A4C0-0x0000000189A6A4E0 */ get => default; } // 0x00000001870D43E0-0x00000001870D44B0 
		public InputControl RightStickUp { /* [XID] */ /* 0x0000000189A154F0-0x0000000189A15510 */ get => default; } // 0x00000001870D5160-0x00000001870D5230 
		public InputControl RightStickDown { /* [XID] */ /* 0x0000000189A80A80-0x0000000189A80AA0 */ get => default; } // 0x00000001870D4EF0-0x00000001870D4FC0 
		public InputControl RightStickLeft { /* [XID] */ /* 0x0000000189A24010-0x0000000189A24030 */ get => default; } // 0x00000001870D4FC0-0x00000001870D5090 
		public InputControl RightStickRight { /* [XID] */ /* 0x0000000189A2B350-0x0000000189A2B370 */ get => default; } // 0x00000001870D5090-0x00000001870D5160 
		public InputControl DPadUp { /* [XID] */ /* 0x0000000189BD10B0-0x0000000189BD10D0 */ get => default; } // 0x00000001870D36E0-0x00000001870D37B0 
		public InputControl DPadDown { /* [XID] */ /* 0x0000000189BD8730-0x0000000189BD8750 */ get => default; } // 0x00000001870D3470-0x00000001870D3540 
		public InputControl DPadLeft { /* [XID] */ /* 0x0000000189B082D0-0x0000000189B082F0 */ get => default; } // 0x00000001870D3540-0x00000001870D3610 
		public InputControl DPadRight { /* [XID] */ /* 0x0000000189A491D0-0x0000000189A491F0 */ get => default; } // 0x00000001870D3610-0x00000001870D36E0 
		public InputControl Action1 { /* [XID] */ /* 0x0000000189A50B20-0x0000000189A50B40 */ get => default; } // 0x00000001870D25F0-0x00000001870D26C0 
		public InputControl Action2 { /* [XID] */ /* 0x00000001897BF0B0-0x00000001897BF0D0 */ get => default; } // 0x00000001870D26C0-0x00000001870D2790 
		public InputControl Action3 { /* [XID] */ /* 0x0000000189A5FC80-0x0000000189A5FCA0 */ get => default; } // 0x00000001870D2790-0x00000001870D2860 
		public InputControl Action4 { /* [XID] */ /* 0x0000000189A676C0-0x0000000189A676E0 */ get => default; } // 0x00000001870D2860-0x00000001870D2930 
		public InputControl LeftTrigger { /* [XID] */ /* 0x00000001897099E0-0x0000000189709A00 */ get => default; } // 0x00000001870D4780-0x00000001870D4850 
		public InputControl RightTrigger { /* [XID] */ /* 0x0000000189A76460-0x0000000189A76480 */ get => default; } // 0x00000001870D5430-0x00000001870D5500 
		public InputControl LeftBumper { /* [XID] */ /* 0x0000000189A7DD20-0x0000000189A7DD40 */ get => default; } // 0x00000001870D40A0-0x00000001870D4170 
		public InputControl RightBumper { /* [XID] */ /* 0x0000000189A85700-0x0000000189A85720 */ get => default; } // 0x00000001870D4D50-0x00000001870D4E20 
		public InputControl LeftStickButton { /* [XID] */ /* 0x00000001896B0210-0x00000001896B0230 */ get => default; } // 0x00000001870D4170-0x00000001870D4240 
		public InputControl RightStickButton { /* [XID] */ /* 0x0000000189A943D0-0x0000000189A943F0 */ get => default; } // 0x00000001870D4E20-0x00000001870D4EF0 
		public InputControl LeftStickX { /* [XID] */ /* 0x0000000189A9BE30-0x0000000189A9BE50 */ get => default; } // 0x00000001870D4580-0x00000001870D4650 
		public InputControl LeftStickY { /* [XID] */ /* 0x0000000189AA33E0-0x0000000189AA3400 */ get => default; } // 0x00000001870D4650-0x00000001870D4720 
		public InputControl RightStickX { /* [XID] */ /* 0x0000000189AAA860-0x0000000189AAA880 */ get => default; } // 0x00000001870D5230-0x00000001870D5300 
		public InputControl RightStickY { /* [XID] */ /* 0x00000001899C1CE0-0x00000001899C1D00 */ get => default; } // 0x00000001870D5300-0x00000001870D53D0 
		public InputControl DPadX { /* [XID] */ /* 0x0000000189AB9B20-0x0000000189AB9B40 */ get => default; } // 0x00000001870D37B0-0x00000001870D3880 
		public InputControl DPadY { /* [XID] */ /* 0x0000000189AC1700-0x0000000189AC1720 */ get => default; } // 0x00000001870D3880-0x00000001870D3950 
		public InputControl Command { /* [XID] */ /* 0x0000000189AC8E60-0x0000000189AC8E80 */ get => default; } // 0x00000001870D32E0-0x00000001870D33B0 
		internal virtual int NumUnknownAnalogs { /* [XID] */ /* 0x0000000189693A90-0x0000000189693AB0 */ get => default; } // 0x00000001870D4BB0-0x00000001870D4C50 
		internal virtual int NumUnknownButtons { /* [XID] */ /* 0x00000001896FA230-0x00000001896FA250 */ get => default; } // 0x00000001870D4C50-0x00000001870D4CF0 
	
		// Nested types
		protected struct AnalogSnapshotEntry // TypeDefIndex: 7635
		{
			// Fields
			public float value; // 0x00
			public float maxValue; // 0x04
			public float minValue; // 0x08
	
			// Methods
			// [XID] // 0x00000001896755F0-0x0000000189675610
			public void TrackMinMaxValue(float currentValue) {} // 0x00000001870BD5D0-0x00000001870BD5E0
		}
	
		// Constructors
		public InputDevice() {} // 0x00000001870D2530-0x00000001870D25F0
		public InputDevice(string name) {} // 0x00000001870D2140-0x00000001870D21C0
		public InputDevice(string name, bool rawSticks) {} // 0x00000001870D21C0-0x00000001870D2530
		static InputDevice() {} // 0x00000001870D2060-0x00000001870D2140
	
		// Methods
		// [XID] // 0x0000000189915BA0-0x0000000189915BC0
		internal void OnAttached() {} // 0x00000001870CE760-0x00000001870CE840
		// [XID] // 0x0000000189876710-0x0000000189876730
		internal void OnDetached() {} // 0x00000001870CE840-0x00000001870CE930
		// [XID] // 0x0000000189895D40-0x0000000189895D60
		private void AddAliasControls() {} // 0x00000001870CC970-0x00000001870CCC70
		// [XID] // 0x00000001898854D0-0x00000001898854F0
		private void RemoveAliasControls() {} // 0x00000001870D0480-0x00000001870D06B0
		// [XID] // 0x0000000189A94210-0x0000000189A94230
		protected void ClearControls() {} // 0x00000001870CCFC0-0x00000001870CD130
		// [XID] // 0x00000001897D7690-0x00000001897D76B0
		public bool HasControl(InputControlType controlType) => default; // 0x00000001870CE510-0x00000001870CE620
		// [XID] // 0x000000018989B5F0-0x000000018989B610
		public InputControl GetControl(InputControlType controlType) => default; // 0x00000001870CDC50-0x00000001870CDDA0
		// [XID] // 0x00000001898AA000-0x00000001898AA020
		public static InputControlType GetInputControlTypeByName(string inputControlName) => default; // 0x00000001870CE3D0-0x00000001870CE510
		// [XID] // 0x0000000189BC3BD0-0x0000000189BC3BF0
		public InputControl GetControlByName(string controlName) => default; // 0x00000001870CDB60-0x00000001870CDC50
		// [IDTag] // 0x00000001898B94C0-0x00000001898B9500
		// [XID] // 0x00000001898B94C0-0x00000001898B9500
		public InputControl AddControl(InputControlType controlType, string handle) => default; // 0x00000001870CCC70-0x00000001870CCE90
		// [IDTag] // 0x00000001898C37D0-0x00000001898C3810
		// [XID] // 0x00000001898C37D0-0x00000001898C3810
		public InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone) => default; // 0x00000001870CCE90-0x00000001870CCFC0
		// [XID] // 0x0000000189BC8F80-0x0000000189BC8FA0
		private void RemoveControl(InputControlType controlType) {} // 0x00000001870D06B0-0x00000001870D0870
		// [XID] // 0x00000001898D5830-0x00000001898D5850
		public void ClearInputState() {} // 0x00000001870CD130-0x00000001870CD3B0
		// [XID] // 0x0000000189A88520-0x0000000189A88540
		protected void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime) {} // 0x00000001870D1BF0-0x00000001870D1D10
		// [XID] // 0x00000001898E4CF0-0x00000001898E4D10
		protected void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime) {} // 0x00000001870D1D10-0x00000001870D1E20
		// [XID] // 0x00000001898EC720-0x00000001898EC740
		internal void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime) {} // 0x00000001870D12C0-0x00000001870D15D0
		// [XID] // 0x00000001898F4030-0x00000001898F4050
		internal void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime) {} // 0x00000001870D0FB0-0x00000001870D12C0
		// [XID] // 0x0000000189769130-0x0000000189769150
		internal void CommitLeftStick() {} // 0x00000001870CD3B0-0x00000001870CD4D0
		// [XID] // 0x0000000189903150-0x0000000189903170
		internal void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime) {} // 0x00000001870D18E0-0x00000001870D1BF0
		// [XID] // 0x000000018990A7E0-0x000000018990A800
		internal void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime) {} // 0x00000001870D15D0-0x00000001870D18E0
		// [XID] // 0x0000000189795D40-0x0000000189795D60
		internal void CommitRightStick() {} // 0x00000001870CD4D0-0x00000001870CD5F0
		// [XID] // 0x0000000189919CF0-0x0000000189919D10
		public virtual void Update(ulong updateTick, float deltaTime) {} // 0x00000001870D1E20-0x00000001870D1EE0
		// [XID] // 0x0000000189BB2E30-0x0000000189BB2E50
		private void ProcessLeftStick(ulong updateTick, float deltaTime) {} // 0x00000001870CF1D0-0x00000001870CFA70
		// [XID] // 0x0000000189928B90-0x0000000189928BB0
		private void ProcessRightStick(ulong updateTick, float deltaTime) {} // 0x00000001870CFA70-0x00000001870D0310
		// [XID] // 0x00000001899300B0-0x00000001899300D0
		private void ProcessDPad(ulong updateTick, float deltaTime) {} // 0x00000001870CE930-0x00000001870CF1D0
		// [XID] // 0x0000000189AF1ED0-0x0000000189AF1EF0
		public void Commit(ulong updateTick, float deltaTime) {} // 0x00000001870CD5F0-0x00000001870CD9F0
		// [XID] // 0x0000000189B4CB10-0x0000000189B4CB30
		public bool LastInputAfter(InputDevice device) => default; // 0x00000001870CE620-0x00000001870CE760
		// [XID] // 0x00000001899466E0-0x0000000189946700
		internal void RequestActivation() {} // 0x00000001870D0870-0x00000001870D09C0
		// [IDTag] // 0x000000018994DD80-0x000000018994DDC0
		// [XID] // 0x000000018994DD80-0x000000018994DDC0
		public virtual void Vibrate(float leftMotor, float rightMotor) {} // 0x00000001870D1EE0-0x00000001870D1FA0
		// [IDTag] // 0x0000000189958700-0x0000000189958740
		// [XID] // 0x0000000189958700-0x0000000189958740
		public void Vibrate(float intensity) {} // 0x00000001870D1FA0-0x00000001870D2060
		// [XID] // 0x0000000189963020-0x0000000189963040
		public void StopVibration() {} // 0x00000001870D0D00-0x00000001870D0DA0
		// [IDTag] // 0x000000018996A2D0-0x000000018996A310
		// [XID] // 0x000000018996A2D0-0x000000018996A310
		public virtual void SetLightColor(float red, float green, float blue) {} // 0x00000001870D0AA0-0x00000001870D0B80
		// [IDTag] // 0x0000000189974C90-0x0000000189974CD0
		// [XID] // 0x0000000189974C90-0x0000000189974CD0
		public void SetLightColor(Color color) {} // 0x00000001870D09C0-0x00000001870D0AA0
		// [XID] // 0x000000018997F240-0x000000018997F260
		public virtual void SetLightFlash(float flashOnDuration, float flashOffDuration) {} // 0x00000001870D0B80-0x00000001870D0C40
		// [XID] // 0x0000000189811D80-0x0000000189811DA0
		public void StopLightFlash() {} // 0x00000001870D0C40-0x00000001870D0D00
		// [XID] // 0x0000000189AD0600-0x0000000189AD0620
		private void ExpireControlCache() {} // 0x00000001870CD9F0-0x00000001870CDB60
		// [XID] // 0x000000018974B200-0x000000018974B220
		internal virtual bool ReadRawButtonState(int index) => default; // 0x00000001870D03D0-0x00000001870D0480
		// [XID] // 0x000000018969AEB0-0x000000018969AED0
		internal virtual float ReadRawAnalogValue(int index) => default; // 0x00000001870D0310-0x00000001870D03D0
		// [XID] // 0x00000001896D80D0-0x00000001896D80F0
		internal void TakeSnapshot() {} // 0x00000001870D0DA0-0x00000001870D0FB0
		// [XID] // 0x0000000189AFDDD0-0x0000000189AFDDF0
		internal UnknownDeviceControl GetFirstPressedAnalog() => default; // 0x00000001870CDDA0-0x00000001870CE230
		// [XID] // 0x0000000189B055F0-0x0000000189B05610
		internal UnknownDeviceControl GetFirstPressedButton() => default; // 0x00000001870CE230-0x00000001870CE3D0
	}
}
