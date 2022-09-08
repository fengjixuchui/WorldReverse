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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMusicDifficlutItem : MonoBehaviour // TypeDefIndex: 30848
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _score; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lock; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _level; // 0x30
		private uint difficultLevel; // 0x38
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001896D1830-0x00000001896D1850 */ get => default; } // 0x0000000182F258E0-0x0000000182F25980 
		public bool selected { /* [XID] */ /* 0x00000001896E7B10-0x00000001896E7B30 */ set {} } // 0x0000000182F25980-0x0000000182F25A50
	
		// Constructors
		public MonoMusicDifficlutItem() {} // 0x0000000182F25860-0x0000000182F258E0
	
		// Methods
		// [XID] // 0x00000001896D9010-0x00000001896D9030
		public void SetMusicInfo(MusicInfoConfig musicInfo, int levelIndex, uint maxScore, bool locked) {} // 0x0000000182F25590-0x0000000182F25860
		// [XID] // 0x00000001896E0890-0x00000001896E08B0
		private void ShowLevel(int index) {} // 0x0000000182F25430-0x0000000182F25590
	}
}
