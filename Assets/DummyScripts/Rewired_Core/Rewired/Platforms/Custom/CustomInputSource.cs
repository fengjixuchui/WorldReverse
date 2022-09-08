/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable // TypeDefIndex: 3739
	{
		// Fields
		private readonly InputSource FXkavZACisNCWLIPykvLbGBTlyBs; // 0x10
		private readonly List<Joystick> INKeeLdtIZyPgwCXkbuBLQHVLuw; // 0x18
		private readonly ReadOnlyCollection<Joystick> lKvoWJPksBkfaRJJBWkMLqzYwJT; // 0x20
		private bool pTGniWBxToLpUuqOInIctlSthaB; // 0x28
		private Action QEcMzQDATbeyElEnDAJZizfvvJP; // 0x30
		private Action vclxbmAbBeTwcgbeMcUXaZQkDLri; // 0x38
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x40
	
		// Properties
		public bool useApproximateMatching { get; protected set; } // 0x00000001852F3420-0x00000001852F3480 0x00000001852F3720-0x00000001852F3780
		internal InputSource inputSource { get; } // 0x00000001852F33C0-0x00000001852F3420 
		public abstract bool isReady { get; }
	
		// Events
		private event Action _JoystickConnectedEvent;
		private event Action _JoystickDisconnectedEvent;
		internal event Action JoystickConnectedEvent;
		internal event Action JoystickDisconnectedEvent;
	
		// Nested types
		public abstract class Controller // TypeDefIndex: 3740
		{
			// Fields
			protected bool _isConnected; // 0x10
			protected string _deviceName; // 0x18
			protected string _customName; // 0x20
	
			// Properties
			public string customName { get; } // 0x00000001852F2800-0x00000001852F2860 
			public bool isConnected { get; } // 0x00000001852F28C0-0x00000001852F2920 
			public string deviceName { get; } // 0x00000001852F2860-0x00000001852F28C0 
	
			// Constructors
			protected Controller() {} // Dummy constructor
			protected Controller(string deviceName) {} // 0x00000001852F2790-0x00000001852F2800
	
			// Methods
			public void Disconnect() {} // 0x00000001852F2710-0x00000001852F2790
			public void Connect() {} // 0x00000001852F26B0-0x00000001852F2710
			public abstract void Update();
		}
	
		public abstract class Joystick : Controller // TypeDefIndex: 3741
		{
			// Fields
			private long? JJkBjQCiHgwWIGHDBEAYPgCRjNJZ; // 0x28
			private int YAsnSUHUHZSXPqVPdYXTHFQokii; // 0x38
			private readonly Axis[] PbFORHCAibynPVwQMVeRWSjVVbJ; // 0x40
			private readonly Button[] lgAkyeKCNYSjxkICDjzKgIcrtWEL; // 0x48
			private readonly ReadOnlyCollection<Axis> XPokcnKJNNUAUtIRBGdBJVNIoHAw; // 0x50
			private readonly ReadOnlyCollection<Button> YUEEutEHRiXnwNizOlBTOCVAsZw; // 0x58
			private bool fAXOjZJLQkAzMaiFlKooHbCzXfGr; // 0x60
			private Controller.Extension RlhCPmWdFbcKPPhKmYBnLApskyE; // 0x68
	
			// Properties
			public long? systemId { get; protected set; } // 0x00000001852F93F0-0x00000001852F9460 0x00000001852F97B0-0x00000001852F9820
			public int unityId { get; } // 0x00000001852F9460-0x00000001852F94C0 
			public IList<Axis> Axes { get; } // 0x00000001852F8B60-0x00000001852F8BC0 
			public IList<Button> Buttons { get; } // 0x00000001852F8BC0-0x00000001852F8C20 
			public bool supportsVibration { get; set; } // 0x00000001852F9120-0x00000001852F9180 0x00000001852F9750-0x00000001852F97B0
			public Controller.Extension extension { get; set; } // 0x00000001852F8EB0-0x00000001852F8F10 0x00000001852F96F0-0x00000001852F9750
			public int buttonCount { get; } // 0x00000001852F8C90-0x00000001852F8D00 
			public int axisCount { get; } // 0x00000001852F8C20-0x00000001852F8C90 
	
			// Constructors
			protected Joystick() {} // Dummy constructor
			public Joystick(string deviceName, long? systemId, int unityId, int axisCount, int buttonCount) {} // 0x00000001852F7E40-0x00000001852F82C0
	
			// Methods
			public virtual float GetAxisValue(int index) => default; // 0x00000001852F63E0-0x00000001852F64B0
			public virtual bool GetButtonValue(int index) => default; // 0x00000001852F64B0-0x00000001852F6570
		}
	
		public abstract class Element // TypeDefIndex: 3742
		{
			// Constructors
			protected Element() {} // 0x00000001852F39C0-0x00000001852F3A20
		}
	
		public sealed class Axis : Element // TypeDefIndex: 3743
		{
			// Fields
			public float value; // 0x10
	
			// Constructors
			public Axis() {} // 0x00000001852F12D0-0x00000001852F1370
		}
	
		public sealed class Button : Element // TypeDefIndex: 3744
		{
			// Fields
			public bool value; // 0x10
	
			// Constructors
			public Button() {} // 0x00000001852F1C50-0x00000001852F1CF0
		}
	
		// Constructors
		protected CustomInputSource() {} // Dummy constructor
		public CustomInputSource(int inputSource) {} // 0x00000001852F2E80-0x00000001852F30D0
	
		// Methods
		public void AddJoystick(Joystick joystick) {} // 0x00000001852F2920-0x00000001852F2A20
		public void RemoveJoystick(Joystick joystick) {} // 0x00000001852F2D20-0x00000001852F2E80
		public IList<Joystick> GetJoysticks() => default; // 0x00000001852F2BE0-0x00000001852F2C40
		protected virtual void OnJoystickConnected() {} // 0x00000001852F2C40-0x00000001852F2CB0
		protected virtual void OnJoystickDisconnected() {} // 0x00000001852F2CB0-0x00000001852F2D20
		internal Joystick[] wcCVtOLMXtslsqKKaATjxgsaWWV() => default; // 0x00000001852F3780-0x00000001852F39C0
		public virtual void Dispose() {} // 0x00000001852F2A20-0x00000001852F2AA0
		~CustomInputSource() {} // 0x00000001852F2B30-0x00000001852F2BE0
		protected virtual void Dispose(bool disposing) {} // 0x00000001852F2AA0-0x00000001852F2B30
		public abstract void Update();
	}
}
