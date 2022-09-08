/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class LevelGuideScoutflyData : ScriptableObject // TypeDefIndex: 19524
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<ScoutflyNavPoint> _allScoutflyNavPoints; // 0x18
	
		// Properties
		public List<ScoutflyNavPoint> allScoutflyNavPoints { /* [XID] */ /* 0x0000000189AF7260-0x0000000189AF7280 */ get => default; /* [XID] */ /* 0x0000000189AFE8B0-0x0000000189AFE8D0 */ set {} } // 0x0000000183A34E90-0x0000000183A34F30 0x0000000183A34F30-0x0000000183A34FE0
	
		// Nested types
		[Serializable]
		public class ScoutflyNavPoint // TypeDefIndex: 19525
		{
			// Fields
			public int id; // 0x10
			public Vector3 pos; // 0x14
			public float distanceToGoal; // 0x20
			public List<int> neighbours; // 0x28
	
			// Constructors
			public ScoutflyNavPoint() {} // 0x0000000183A47010-0x0000000183A470B0
		}
	
		// Constructors
		public LevelGuideScoutflyData() {} // 0x0000000183A34E00-0x0000000183A34E90
	}
}
