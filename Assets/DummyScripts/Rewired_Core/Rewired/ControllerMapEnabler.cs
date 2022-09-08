/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class ControllerMapEnabler // TypeDefIndex: 4114
	{
		// Fields
		private bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x10
		private Player wVmxupsXoTmxeBeKFxYheQCHgkk; // 0x18
		private JUZYTaWfnqZOjNkWvtfvZbKqPkC gsnFfbHUowjcMozBbVutOVOnzWrp; // 0x20
		private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x28
		private List<RuleSet> fmkyPPQwfusueTmcunGmhZCqgqU; // 0x30
	
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000185E79AD0-0x0000000185E79B30 0x0000000185E79B90-0x0000000185E79C10
		public List<RuleSet> ruleSets { get => default; } // 0x0000000185E79B30-0x0000000185E79B90 
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x00000001898461E0-0x0000000189846220
		[Preserve] // 0x00000001898461E0-0x0000000189846220
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 4115
		{
			// Fields
			[Serialize] // 0x0000000189909080-0x00000001899090C0
			[SerializeField] // 0x0000000189909080-0x00000001899090C0
			private string _tag; // 0x10
			[Serialize] // 0x00000001897E5050-0x00000001897E50A0
			[SerializeField] // 0x00000001897E5050-0x00000001897E50A0
			private bool _enable; // 0x18
			[Serialize] // 0x00000001897F16B0-0x00000001897F16F0
			[SerializeField] // 0x00000001897F16B0-0x00000001897F16F0
			private int[] _categoryIds; // 0x20
			[Serialize] // 0x00000001897FD330-0x00000001897FD370
			[SerializeField] // 0x00000001897FD330-0x00000001897FD370
			private int[] _layoutIds; // 0x28
			[Serialize] // 0x00000001898E33E0-0x00000001898E3420
			[SerializeField] // 0x00000001898E33E0-0x00000001898E3420
			private ControllerSetSelector _controllerSetSelector; // 0x30
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x38
			[NonSerialized]
			private string[] _preInitLayoutNames; // 0x40
	
			// Properties
			public string tag { get => default; } // 0x0000000185E94270-0x0000000185E942D0 
			public bool enable { get => default; set {} } // 0x0000000185E93E60-0x0000000185E93EC0 0x0000000185E942D0-0x0000000185E94330
			public ControllerSetSelector controllerSetSelector { get => default; } // 0x0000000185E93DD0-0x0000000185E93E60 
			public int[] categoryIds { get => default; } // 0x0000000185E93D40-0x0000000185E93DD0 
			public int[] layoutIds { get => default; } // 0x0000000185E941C0-0x0000000185E94270 
			internal bool isValid { get => default; } // 0x0000000185E93EC0-0x0000000185E941C0 
	
			// Constructors
			public Rule() {} // 0x0000000185E93C80-0x0000000185E93D40
			public Rule(Rule source) {} // 0x0000000185E93A90-0x0000000185E93BE0
			internal Rule(string tag, bool enabled, int[] categoryIds, int[] layoutIds, ControllerSetSelector controllerSetSelector) {} // 0x0000000185E93BE0-0x0000000185E93C80
	
			// Methods
			internal bool Matches(ControllerMap map) => default; // 0x0000000185E938C0-0x0000000185E93A10
			private void Initialize() {} // 0x0000000185E931E0-0x0000000185E938C0
			private void CheckNoControllerTypeError() {} // 0x0000000185E92E90-0x0000000185E931E0
			object IDeepCloneable.DeepClone() => default; // 0x0000000185E93A10-0x0000000185E93A90
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189814E90-0x0000000189814F10
		[Preserve] // 0x0000000189814E90-0x0000000189814F10
		// [SerializationType] // 0x0000000189814E90-0x0000000189814F10
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 4116
		{
			// Fields
			private const string className = "ControllerMapEnabler.RuleSet"; // Metadata: 0x00AC4903
			[Serialize] // 0x0000000189825650-0x00000001898256A0
			[SerializeField] // 0x0000000189825650-0x00000001898256A0
			private bool _enabled; // 0x10
			[Serialize] // 0x0000000189909080-0x00000001899090C0
			[SerializeField] // 0x0000000189909080-0x00000001899090C0
			private string _tag; // 0x18
			[Serialize] // 0x000000018983A260-0x000000018983A2B0
			[SerializeField] // 0x000000018983A260-0x000000018983A2B0
			private List<Rule> _rules; // 0x20
	
			// Properties
			public bool enabled { get => default; set {} } // 0x0000000185E92CB0-0x0000000185E92D10 0x0000000185E92E30-0x0000000185E92E90
			public string tag { get => default; } // 0x0000000185E92D10-0x0000000185E92D70 
			public Rule this[int index] { get => default; set {} } // 0x0000000185E92C20-0x0000000185E92CB0 0x0000000185E92D70-0x0000000185E92E30
			public int Count { get => default; } // 0x0000000185E92BA0-0x0000000185E92C20 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.IsReadOnly { get => default; } // 0x0000000185E927A0-0x0000000185E92830 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules) {} // 0x0000000185E92A80-0x0000000185E92B10
			public RuleSet() {} // 0x0000000185E92B10-0x0000000185E92BA0
			public RuleSet(RuleSet source) {} // 0x0000000185E928E0-0x0000000185E92A80
	
			// Methods
			public int IndexOf(Rule item) => default; // 0x0000000185E924D0-0x0000000185E92550
			public void Insert(int index, Rule item) {} // 0x0000000185E92550-0x0000000185E925F0
			public void RemoveAt(int index) {} // 0x0000000185E925F0-0x0000000185E92680
			public void Add(Rule item) {} // 0x0000000185E92140-0x0000000185E921D0
			public void Clear() {} // 0x0000000185E92260-0x0000000185E922E0
			public bool Contains(Rule item) => default; // 0x0000000185E922E0-0x0000000185E92380
			public void CopyTo(Rule[] array, int arrayIndex) {} // 0x0000000185E92380-0x0000000185E92420
			public bool Remove(Rule item) => default; // 0x0000000185E92680-0x0000000185E92720
			public IEnumerator<Rule> GetEnumerator() => default; // 0x0000000185E92420-0x0000000185E924D0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185E92830-0x0000000185E928E0
			object IDeepCloneable.DeepClone() => default; // 0x0000000185E92720-0x0000000185E927A0
			private void CheckList() {} // 0x0000000185E921D0-0x0000000185E92260
		}
	
		internal class JUZYTaWfnqZOjNkWvtfvZbKqPkC // TypeDefIndex: 4117
		{
			// Fields
			public bool HrjcqFAgRRaZLGApNJxkDOsvjGCj; // 0x10
			public IBXCWQaiuXApgrsayPNtUSrFqVH[] RtJELTFcmewuelgbgQphxlidefQ; // 0x18
	
			// Constructors
			public JUZYTaWfnqZOjNkWvtfvZbKqPkC() {} // Dummy constructor
			public JUZYTaWfnqZOjNkWvtfvZbKqPkC(bool enabled, IBXCWQaiuXApgrsayPNtUSrFqVH[] startingRuleSets) {} // 0x0000000185E8B390-0x0000000185E8B420
		}
	
		// Constructors
		public ControllerMapEnabler() {} // Dummy constructor
		internal ControllerMapEnabler(Player player, JUZYTaWfnqZOjNkWvtfvZbKqPkC startingSettings) {} // 0x0000000185E799B0-0x0000000185E79AD0
	
		// Methods
		public void Apply() {} // 0x0000000185E791A0-0x0000000185E79630
		public void LoadDefaults() {} // 0x0000000185E79630-0x0000000185E799B0
	}
}
