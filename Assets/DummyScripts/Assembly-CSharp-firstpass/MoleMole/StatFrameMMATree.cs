/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class StatFrameMMATree : IReusable // TypeDefIndex: 10100
	{
		// Fields
		private List<StatFrameMMATree> _nodes; // 0x10
		private Dictionary<string, StatFrameMMATree> _statIDToNodeMap; // 0x18
		private Queue<long> _history; // 0x20
		private HashSet<StatFrameMMATree> _thisFrameMissingCollectedNodes; // 0x28
		private int recordFrameCount; // 0x30
		private long lastTotal; // 0x48
		private const int precision = 100000; // Metadata: 0x00AE6F57
	
		// Properties
		public float min { /* [XID] */ /* 0x00000001898CDD30-0x00000001898CDD70 */ get; /* [XID] */ /* 0x00000001898D86A0-0x00000001898D86E0 */ private set; } // 0x00000001868AC6D0-0x00000001868AC740 0x00000001868AC820-0x00000001868AC890
		public float max { /* [XID] */ /* 0x00000001898E32C0-0x00000001898E3300 */ get; /* [XID] */ /* 0x00000001898EDE50-0x00000001898EDE90 */ private set; } // 0x00000001868AC660-0x00000001868AC6D0 0x00000001868AC7B0-0x00000001868AC820
		public double average { get; /* [XID] */ /* 0x0000000189900130-0x0000000189900170 */ private set; } // 0x00000001868AC5F0-0x00000001868AC660 0x00000001868AC740-0x00000001868AC7B0
	
		// Nested types
		public class Spawner : ISpawner<StatFrameMMATree, int> // TypeDefIndex: 10101
		{
			// Constructors
			public Spawner() {} // 0x00000001868A9A10-0x00000001868A9A70
	
			// Methods
			// [XID] // 0x0000000189BAF480-0x0000000189BAF4A0
			public StatFrameMMATree Spawn(int inTargetFrameCount) => default; // 0x00000001868A9940-0x00000001868A9A10
		}
	
		public class Polisher : IPolisher<StatFrameMMATree, int> // TypeDefIndex: 10102
		{
			// Constructors
			public Polisher() {} // 0x000000018689ED00-0x000000018689ED60
	
			// Methods
			// [XID] // 0x00000001899F4A60-0x00000001899F4A80
			public void Polish(StatFrameMMATree reused, int param1) {} // 0x000000018689EBC0-0x000000018689ECA0
		}
	
		// Constructors
		public StatFrameMMATree() {} // Dummy constructor
		public StatFrameMMATree(int inTargetFrameCount = 300 /* Metadata: 0x00AE6F4F */) {} // 0x00000001868AC4E0-0x00000001868AC5F0
	
		// Methods
		// [XID] // 0x000000018990A650-0x000000018990A670
		public void Init(int inTargetFrameCount = 300 /* Metadata: 0x00AE6F53 */) {} // 0x00000001868ABE50-0x00000001868ABFC0
		// [XID] // 0x00000001899CF350-0x00000001899CF370
		private void InternalMergeWithNode(IStatNode inNode) {} // 0x00000001868ABFC0-0x00000001868AC220
		// [XID] // 0x0000000189A9E730-0x0000000189A9E750
		public void Clear() {} // 0x00000001868ABDB0-0x00000001868ABE50
		// [XID] // 0x0000000189921010-0x0000000189921030
		public void MergeWith(IStatNode inNode) {} // 0x00000001868AC220-0x00000001868AC430
		// [XID] // 0x0000000189928A10-0x0000000189928A30
		public void BeforeRecycle() {} // 0x00000001868ABBB0-0x00000001868ABDB0
		// [XID] // 0x00000001899ECD00-0x00000001899ECD20
		public void OnRecycle() {} // 0x00000001868AC430-0x00000001868AC4E0
	}
}
