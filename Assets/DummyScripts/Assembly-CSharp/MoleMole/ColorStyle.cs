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
	[CreateAssetMenu] // 0x00000001897F05E0-0x00000001897F0620
	public class ColorStyle : ScriptableObject // TypeDefIndex: 19619
	{
		// Fields
		public Color normal; // 0x18
		public Color insufficient; // 0x28
		// [Header] // 0x00000001897F96D0-0x00000001897F9700
		public Color starActivated; // 0x38
		public Color starInactivated; // 0x48
		// [Header] // 0x00000001898024B0-0x00000001898024E0
		public Color levelSufficient; // 0x58
		public Color levelInsufficient; // 0x68
		public Color levelSeriouslyInsufficient; // 0x78
		// [Header] // 0x000000018980B1D0-0x000000018980B200
		public Color propUpColor; // 0x88
		public Color propDownColor; // 0x98
		// [Header] // 0x0000000189813F80-0x0000000189813FB0
		public Color talentLockColor; // 0xA8
		public Color talentUnlockColor; // 0xB8
		// [Header] // 0x000000018981D3A0-0x000000018981D3D0
		public Color setAddColor; // 0xC8
		public Color setDeleteColor; // 0xD8
		// [Header] // 0x0000000189825F60-0x0000000189825F90
		public MainQuestColor normalQuest; // 0xE8
		public MainQuestColor dangerousQuest; // 0x108
		public MainQuestColor finishedQuest; // 0x128
		// [Header] // 0x000000018982ED70-0x000000018982EDA0
		public Color easyMonster; // 0x148
		public Color normalMonster; // 0x158
		public Color difficultMonster; // 0x168
		public Color hardMonster; // 0x178
		// [Header] // 0x0000000189837C30-0x0000000189837C60
		public Color areaInfoNormal; // 0x188
		public Color areaInfoHighlevel; // 0x198
		// [Header] // 0x0000000189840A50-0x0000000189840A80
		public Color darkColor; // 0x1A8
		public Color questionColor; // 0x1B8
		// [Header] // 0x0000000189849780-0x00000001898497B0
		public Color awakenUnmaxBgColor; // 0x1C8
		public Color awakenMaxBgColor; // 0x1D8
		public Color awakenUnmaxTextColor; // 0x1E8
		public Color awakenMaxTextColor; // 0x1F8
		// [Header] // 0x0000000189852230-0x0000000189852260
		public Color radarHintAreaColor; // 0x208
		public Color radarHintAreaRingColor; // 0x218
		// [Header] // 0x000000018985B390-0x000000018985B3F0
		// [Tooltip] // 0x000000018985B390-0x000000018985B3F0
		public MarkPointAreaColor markPointAreaColorYellow; // 0x228
		// [Tooltip] // 0x0000000189868520-0x0000000189868550
		public MarkPointAreaColor markPointAreaColorBlue; // 0x248
		// [Tooltip] // 0x0000000189871040-0x0000000189871070
		public MarkPointAreaColor markPointAreaColorRed; // 0x268
		// [Header] // 0x000000018987A5A0-0x000000018987A5D0
		public Color weeklyBossResinNormalColor; // 0x288
		public Color weeklyBossResinDiscountColor; // 0x298
		public Color weeklyBossResinDiscountNumEnoughColor; // 0x2A8
		public Color weeklyBossResinDiscountNumInsufficientColor; // 0x2B8
	
		// Nested types
		[Serializable]
		public struct MainQuestColor // TypeDefIndex: 19620
		{
			// Fields
			public Color recommendLevel; // 0x00
			public Color effect; // 0x10
		}
	
		[Serializable]
		public struct MarkPointAreaColor // TypeDefIndex: 19621
		{
			// Fields
			public Color mainColor; // 0x00
			public Color edgeColor; // 0x10
		}
	
		// Constructors
		public ColorStyle() {} // 0x0000000181ADD5F0-0x0000000181ADD6F0
	}
}
