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
	public sealed class ControllerMapLayoutManager // TypeDefIndex: 4120
	{
		// Fields
		private bool _enabled; // 0x10
		private bool _loadFromUserDataStore; // 0x11
		private Player _player; // 0x18
		private StartingSettings _startingSettings; // 0x20
		private readonly int _reInputId; // 0x28
		private List<RuleSet> _ruleSets; // 0x30
		private Action _ApplyCalledEvent; // 0x38
	
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000185E7B080-0x0000000185E7B0E0 0x0000000185E7B240-0x0000000185E7B2C0
		public bool loadFromUserDataStore { get => default; set {} } // 0x0000000185E7B0E0-0x0000000185E7B140 0x0000000185E7B2C0-0x0000000185E7B320
		public List<RuleSet> ruleSets { get => default; } // 0x0000000185E7B140-0x0000000185E7B1A0 
	
		// Events
		internal event Action ApplyCalledEvent;
	
		// Nested types
		internal class StartingSettings // TypeDefIndex: 4121
		{
			// Fields
			public bool enabled; // 0x10
			public bool loadFromUserDataStore; // 0x11
			public IBXCWQaiuXApgrsayPNtUSrFqVH[] startingRuleSets; // 0x18
	
			// Constructors
			public StartingSettings() {} // Dummy constructor
			public StartingSettings(bool enabled, bool loadFromUserDataStore, IBXCWQaiuXApgrsayPNtUSrFqVH[] startingRuleSets) {} // 0x0000000185D6E140-0x0000000185D6E1D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001898B7860-0x00000001898B78A0
		[Preserve] // 0x00000001898B7860-0x00000001898B78A0
		public sealed class Rule : IDeepCloneable // TypeDefIndex: 4122
		{
			// Fields
			[Serialize] // 0x0000000189909080-0x00000001899090C0
			[SerializeField] // 0x0000000189909080-0x00000001899090C0
			private string _tag; // 0x10
			[Serialize] // 0x00000001898CC5D0-0x00000001898CC620
			[SerializeField] // 0x00000001898CC5D0-0x00000001898CC620
			private int[] _categoryIds; // 0x18
			[Serialize] // 0x00000001898D72D0-0x00000001898D7320
			[SerializeField] // 0x00000001898D72D0-0x00000001898D7320
			private int _layoutId; // 0x20
			[Serialize] // 0x00000001898E33E0-0x00000001898E3420
			[SerializeField] // 0x00000001898E33E0-0x00000001898E3420
			private ControllerSetSelector _controllerSetSelector; // 0x28
			[NonSerialized]
			private string[] _preInitCategoryNames; // 0x30
			[NonSerialized]
			private string _preInitLayoutName; // 0x38
	
			// Properties
			public string tag { get => default; } // 0x0000000185D6DB30-0x0000000185D6DB90 
			public ControllerSetSelector controllerSetSelector { get => default; } // 0x0000000185D6D770-0x0000000185D6D800 
			public int[] categoryIds { get => default; } // 0x0000000185D6D6E0-0x0000000185D6D770 
			public int layoutId { get => default; set {} } // 0x0000000185D6DAC0-0x0000000185D6DB30 0x0000000185D6DB90-0x0000000185D6DC00
			public string layoutName { set {} } // 0x0000000185D6DC00-0x0000000185D6E140
			internal bool isValid { get => default; } // 0x0000000185D6D800-0x0000000185D6DAC0 
	
			// Constructors
			public Rule() {} // 0x0000000185D6D450-0x0000000185D6D500
			public Rule(Rule source) {} // 0x0000000185D6D500-0x0000000185D6D6E0
			internal Rule(string tag, int[] categoryIds, int layoutId, ControllerSetSelector controllerSetSelector) {} // 0x0000000185D6D3C0-0x0000000185D6D450
	
			// Methods
			private void Initialize() {} // 0x0000000185D6CF00-0x0000000185D6D340
			object IDeepCloneable.DeepClone() => default; // 0x0000000185D6D340-0x0000000185D6D3C0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001898EE080-0x00000001898EE100
		[Preserve] // 0x00000001898EE080-0x00000001898EE100
		// [SerializationType] // 0x00000001898EE080-0x00000001898EE100
		public sealed class RuleSet : IDeepCloneable, IList<Rule> // TypeDefIndex: 4123
		{
			// Fields
			private const string className = "ControllerMapLayoutManager.RuleSet"; // Metadata: 0x00AC4923
			[Serialize] // 0x0000000189825650-0x00000001898256A0
			[SerializeField] // 0x0000000189825650-0x00000001898256A0
			private bool _enabled; // 0x10
			[Serialize] // 0x0000000189909080-0x00000001899090C0
			[SerializeField] // 0x0000000189909080-0x00000001899090C0
			private string _tag; // 0x18
			[Serialize] // 0x00000001899139F0-0x0000000189913A30
			[SerializeField] // 0x00000001899139F0-0x0000000189913A30
			private List<Rule> _rules; // 0x20
	
			// Properties
			public bool enabled { get => default; set {} } // 0x0000000185D6CD40-0x0000000185D6CDA0 0x0000000185D6CEA0-0x0000000185D6CF00
			public string tag { get => default; } // 0x0000000185D6CDA0-0x0000000185D6CE00 
			public Rule this[int index] { get => default; set {} } // 0x0000000185D6CCB0-0x0000000185D6CD40 0x0000000185D6CE00-0x0000000185D6CEA0
			public int Count { get => default; } // 0x0000000185D6CC30-0x0000000185D6CCB0 
			bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly { get => default; } // 0x0000000185D6C830-0x0000000185D6C8C0 
	
			// Constructors
			internal RuleSet(bool enabled, string tag, List<Rule> rules) {} // 0x0000000185D6CA00-0x0000000185D6CB30
			public RuleSet() {} // 0x0000000185D6C970-0x0000000185D6CA00
			public RuleSet(RuleSet source) {} // 0x0000000185D6CB30-0x0000000185D6CC30
	
			// Methods
			public int IndexOf(Rule item) => default; // 0x0000000185D6C560-0x0000000185D6C5E0
			public void Insert(int index, Rule item) {} // 0x0000000185D6C5E0-0x0000000185D6C680
			public void RemoveAt(int index) {} // 0x0000000185D6C680-0x0000000185D6C710
			public void Add(Rule item) {} // 0x0000000185D6C1D0-0x0000000185D6C260
			public void Clear() {} // 0x0000000185D6C2F0-0x0000000185D6C370
			public bool Contains(Rule item) => default; // 0x0000000185D6C370-0x0000000185D6C410
			public void CopyTo(Rule[] array, int arrayIndex) {} // 0x0000000185D6C410-0x0000000185D6C4B0
			public bool Remove(Rule item) => default; // 0x0000000185D6C710-0x0000000185D6C7B0
			public IEnumerator<Rule> GetEnumerator() => default; // 0x0000000185D6C4B0-0x0000000185D6C560
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185D6C8C0-0x0000000185D6C970
			object IDeepCloneable.DeepClone() => default; // 0x0000000185D6C7B0-0x0000000185D6C830
			private void CheckList() {} // 0x0000000185D6C260-0x0000000185D6C2F0
		}
	
		// Constructors
		public ControllerMapLayoutManager() {} // Dummy constructor
		internal ControllerMapLayoutManager(Player player, StartingSettings startingSettings) {} // 0x0000000185E7AEC0-0x0000000185E7AFE0
	
		// Methods
		public void Apply() {} // 0x0000000185E79C10-0x0000000185E7AB80
		public void LoadDefaults() {} // 0x0000000185E7AB80-0x0000000185E7AEC0
	}
}
