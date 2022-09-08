/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001896144E0-0x0000000189614520
	public class GamePlayIndexConfig : ScriptableObject // TypeDefIndex: 19587
	{
		// Fields
		public GamePlayOneClassConfig[] allGamePlayClasses; // 0x18
	
		// Nested types
		[Serializable]
		public class GamePlayOneClassConfig // TypeDefIndex: 19588
		{
			// Fields
			public string name; // 0x10
			public GamePlayOneLevelConfig[] levels; // 0x18
	
			// Constructors
			public GamePlayOneClassConfig() {} // 0x0000000181F86E90-0x0000000181F86EF0
		}
	
		[Serializable]
		public class GamePlayOneLevelConfig // TypeDefIndex: 19589
		{
			// Fields
			public string name; // 0x10
			public GamePlayLevelConfig config; // 0x18
			public DateTime date; // 0x20
			public bool isUp; // 0x30
			public string introduction; // 0x38
	
			// Constructors
			public GamePlayOneLevelConfig() {} // 0x0000000181F86EF0-0x0000000181F86F50
		}
	
		// Constructors
		public GamePlayIndexConfig() {} // 0x0000000181F86DD0-0x0000000181F86E30
	}
}
