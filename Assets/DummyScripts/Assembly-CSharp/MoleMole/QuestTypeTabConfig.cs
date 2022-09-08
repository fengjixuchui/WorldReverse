/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189B6FB40-0x0000000189B6FB80
	public class QuestTypeTabConfig : ScriptableObject // TypeDefIndex: 19657
	{
		// Fields
		public QuestTypeConfig[] questTypeConfig; // 0x18
		public QuestTypeTextConfig[] questTypeTextConfig; // 0x20
	
		// Nested types
		[Serializable]
		public struct QuestTypeConfig // TypeDefIndex: 19658
		{
			// Fields
			public bool AQ; // 0x00
			public bool FQ; // 0x01
			public bool LQ; // 0x02
			public bool EQ; // 0x03
			public bool DQ; // 0x04
			public bool IQ; // 0x05
			public bool WQ; // 0x06
			public bool TASK; // 0x07
			public string nameTextID; // 0x08
			public string iconName; // 0x10
		}
	
		[Serializable]
		public struct QuestTypeTextConfig // TypeDefIndex: 19659
		{
			// Fields
			public QuestType questType; // 0x00
			public string textMapID; // 0x08
			public string iconName; // 0x10
		}
	
		// Constructors
		public QuestTypeTabConfig() {} // 0x0000000183BBCFD0-0x0000000183BBD030
	
		// Methods
		// [XID] // 0x0000000189B78AA0-0x0000000189B78AC0
		public bool IsShowTask(int index) => default; // 0x0000000183BBCAF0-0x0000000183BBCBD0
		// [XID] // 0x0000000189B7FF70-0x0000000189B7FF90
		public bool IsQuestType(int index, QuestType type) => default; // 0x0000000183BBCD10-0x0000000183BBCE90
		// [XID] // 0x0000000189B87A20-0x0000000189B87A40
		public string GetTextMapId(QuestType type) => default; // 0x0000000183BBCE90-0x0000000183BBCFD0
		// [XID] // 0x0000000189B8EBB0-0x0000000189B8EBD0
		public string GetIconName(QuestType type) => default; // 0x0000000183BBCBD0-0x0000000183BBCD10
	}
}
