/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMapSwitchListRow : MonoSpriteProxy // TypeDefIndex: 31137
	{
		// Fields
		public Button switchButton; // 0x20
		public Image icon; // 0x28
		public UnityEngine.UI.Text nameText; // 0x30
		public UnityEngine.UI.Text currentSelectedText; // 0x38
		public GameObject iconLock; // 0x40
		public GameObject iconMarkPoint; // 0x48
		public GameObject iconReward; // 0x50
		public Image imageReward; // 0x58
		public uint tagID; // 0x60
		private bool _isUnlocked; // 0x64
	
		// Constructors
		public MonoMapSwitchListRow() {} // 0x0000000184934F70-0x0000000184934FE0
	
		// Methods
		// [XID] // 0x00000001896CD380-0x00000001896CD3A0
		public void init(MapTagDataConfig config, bool isCurrShown, bool isCurrSelected, bool isUnlocked) {} // 0x0000000184934FE0-0x0000000184935250
		// [XID] // 0x00000001896D47B0-0x00000001896D47D0
		public void RefreshQuest(GeneralMarkData mark) {} // 0x00000001849349A0-0x0000000184934D30
		// [XID] // 0x00000001896DBE50-0x00000001896DBE70
		public void RefreshRewardIcon(MarkIconType icon) {} // 0x0000000184934D30-0x0000000184934F70
	}
}
