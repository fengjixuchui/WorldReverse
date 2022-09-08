/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	[Serializable]
	public class AnimationPhase : AnimationPhaseRunTime // TypeDefIndex: 9353
	{
		// Fields
		public int _customData; // 0x20
		public Vector3 _offPos; // 0x24
		public Vector3 _motionPos; // 0x30
		public List<string> _extraTrajName; // 0x40
		public List<Vector3> _extraTrajPos; // 0x48
	
		// Constructors
		public AnimationPhase() {} // 0x000000018607BE20-0x000000018607BE80
	
		// Methods
		// [XID] // 0x000000018985A860-0x000000018985A880
		public Vector3 GetExtraTrajPos(string key) => default; // 0x000000018607BBC0-0x000000018607BE20
	}
}
