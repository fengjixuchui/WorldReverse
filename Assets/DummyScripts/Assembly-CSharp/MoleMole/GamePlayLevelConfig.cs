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
	[CreateAssetMenu] // 0x000000018961D630-0x000000018961D670
	public class GamePlayLevelConfig : ScriptableObject // TypeDefIndex: 19590
	{
		// Fields
		public string[] gmCommands; // 0x18
		public GamePlayTmpSectorLoad[] sectors; // 0x20
	
		// Nested types
		public enum WhiteboxType // TypeDefIndex: 19591
		{
			LDWhiteBox = 0,
			LABigWorldSector = 1,
			LAWhiteBox = 2
		}
	
		[Serializable]
		public class GamePlayTmpSectorLoad // TypeDefIndex: 19592
		{
			// Fields
			public int widthIndex; // 0x10
			public int heightIndex; // 0x14
			public WhiteboxType whiteboxType; // 0x18
			public bool addtoSector; // 0x1C
	
			// Constructors
			public GamePlayTmpSectorLoad() {} // 0x0000000181F86F50-0x0000000181F86FC0
		}
	
		// Constructors
		public GamePlayLevelConfig() {} // 0x0000000181F86E30-0x0000000181F86E90
	}
}
