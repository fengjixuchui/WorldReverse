/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
	// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
	public sealed class Player_Editor // TypeDefIndex: 3949
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _name; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string _descriptiveName; // 0x20
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private bool _startPlaying; // 0x28
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<Mapping> _defaultJoystickMaps; // 0x30
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Mapping> _defaultMouseMaps; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Mapping> _defaultKeyboardMaps; // 0x40
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Mapping> _defaultCustomControllerMaps; // 0x48
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<CreateControllerInfo> _startingCustomControllers; // 0x50
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _assignMouseOnStart; // 0x58
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private bool _assignKeyboardOnStart; // 0x59
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _excludeFromControllerAutoAssignment; // 0x5A
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; // 0x60
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ControllerMapEnablerSettings _controllerMapEnablerSettings; // 0x68
	
		// Properties
		internal int id { set {} } // 0x0000000185104F10-0x0000000185104F70
		public string name { get => default; internal set {} } // 0x0000000185104BB0-0x0000000185104C10 0x0000000185104F70-0x0000000185104FD0
		public string descriptiveName { get => default; internal set {} } // 0x0000000185104AF0-0x0000000185104B50 0x0000000185104E50-0x0000000185104EB0
		public bool startPlaying { get => default; internal set {} } // 0x0000000185104C10-0x0000000185104C70 0x0000000185104FD0-0x0000000185105030
		public List<CreateControllerInfo> startingCustomControllers { get => default; } // 0x0000000185104C70-0x0000000185104CD0 
		public bool assignMouseOnStart { get => default; internal set {} } // 0x00000001851049D0-0x0000000185104A30 0x0000000185104D30-0x0000000185104D90
		public bool assignKeyboardOnStart { get => default; internal set {} } // 0x0000000185104970-0x00000001851049D0 0x0000000185104CD0-0x0000000185104D30
		public bool excludeFromControllerAutoAssignment { get => default; internal set {} } // 0x0000000185104B50-0x0000000185104BB0 0x0000000185104EB0-0x0000000185104F10
		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings { get => default; set {} } // 0x0000000185104A90-0x0000000185104AF0 0x0000000185104DF0-0x0000000185104E50
		public ControllerMapEnablerSettings controllerMapEnablerSettings { get => default; set {} } // 0x0000000185104A30-0x0000000185104A90 0x0000000185104D90-0x0000000185104DF0
	
		// Nested types
		[Serializable]
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class Mapping // TypeDefIndex: 3950
		{
			// Fields
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private int _categoryId; // 0x14
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private int _layoutId; // 0x18
	
			// Constructors
			public Mapping() {} // 0x00000001850FD000-0x00000001850FD070
	
			// Methods
			public void Clear() {} // 0x00000001850FCEE0-0x00000001850FCF60
			internal LbyXjOIzPbSKtwNeSiJafzWOdxVB CviVPMMcUnBBALxnriLTePqaZlAh() => default; // 0x00000001850FCF60-0x00000001850FD000
		}
	
		[Serializable]
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable // TypeDefIndex: 3951
		{
			// Fields
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private bool _loadFromUserDataStore; // 0x11
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Constructors
			public ControllerMapLayoutManagerSettings() {} // 0x00000001850E2480-0x00000001850E2520
			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings source) {} // 0x00000001850E2360-0x00000001850E2480
	
			// Methods
			internal ControllerMapLayoutManager.StartingSettings RDaWziREIKhWZlbRtZbglsspeWG() => default; // 0x00000001850E2230-0x00000001850E22E0
			private IBXCWQaiuXApgrsayPNtUSrFqVH[] IsnxUxNdJfqpaVAralabxmofesy() => default; // 0x00000001850E2090-0x00000001850E2230
			object IDeepCloneable.DeepClone() => default; // 0x00000001850E22E0-0x00000001850E2360
		}
	
		[Serializable]
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class ControllerMapEnablerSettings : IDeepCloneable // TypeDefIndex: 3952
		{
			// Fields
			[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
			[SerializeField] // 0x00000001898227C0-0x0000000189822800
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private List<RuleSetMapping> _ruleSets; // 0x18
	
			// Constructors
			public ControllerMapEnablerSettings() {} // 0x00000001850E1FD0-0x00000001850E2090
			public ControllerMapEnablerSettings(ControllerMapEnablerSettings source) {} // 0x00000001850E1EC0-0x00000001850E1FD0
	
			// Methods
			internal ControllerMapEnabler.JUZYTaWfnqZOjNkWvtfvZbKqPkC RDaWziREIKhWZlbRtZbglsspeWG() => default; // 0x00000001850E1DA0-0x00000001850E1E40
			private IBXCWQaiuXApgrsayPNtUSrFqVH[] IsnxUxNdJfqpaVAralabxmofesy() => default; // 0x00000001850E1C10-0x00000001850E1DA0
			object IDeepCloneable.DeepClone() => default; // 0x00000001850E1E40-0x00000001850E1EC0
		}
	
		[Serializable]
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class RuleSetMapping : IDeepCloneable // TypeDefIndex: 3953
		{
			// Fields
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private bool _enabled; // 0x10
			[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
			[SerializeField] // 0x00000001898227C0-0x0000000189822800
			private int _id; // 0x14
	
			// Constructors
			public RuleSetMapping() {} // 0x00000001851062E0-0x0000000185106390
			public RuleSetMapping(RuleSetMapping source) {} // 0x0000000185106220-0x00000001851062E0
	
			// Methods
			public void Clear() {} // 0x0000000185106140-0x00000001851061A0
			internal IBXCWQaiuXApgrsayPNtUSrFqVH hiiFXAapUtNxBcWpELWWwSzbaAf() => default; // 0x0000000185106390-0x0000000185106430
			object IDeepCloneable.DeepClone() => default; // 0x00000001851061A0-0x0000000185106220
		}
	
		[Serializable]
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class CreateControllerInfo // TypeDefIndex: 3954
		{
			// Fields
			[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
			[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
			private int _sourceId; // 0x10
			[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
			[SerializeField] // 0x00000001898227C0-0x0000000189822800
			private string _tag; // 0x18
	
			// Properties
			public int sourceId { get => default; } // 0x00000001850E2580-0x00000001850E25E0 
			public string tag { get => default; } // 0x00000001850E25E0-0x00000001850E2640 
	
			// Constructors
			public CreateControllerInfo() {} // 0x00000001850E2520-0x00000001850E2580
		}
	
		// Constructors
		public Player_Editor() {} // 0x0000000185104760-0x0000000185104970
	
		// Methods
		internal LDQPFPXQyLIyqtAUvmVCEbFpcBq SycpkkLkUewaZPGUqaerYpMkdXJB() => default; // 0x0000000185103ED0-0x0000000185104760
	}
}
