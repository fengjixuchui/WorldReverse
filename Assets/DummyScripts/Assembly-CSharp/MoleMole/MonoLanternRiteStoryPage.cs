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
	public class MonoLanternRiteStoryPage : MonoUIProxy // TypeDefIndex: 31007
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		public StoryInfo xiaoStory; // 0x48
		public StoryInfo activityStory; // 0x50
	
		// Properties
		public MonoUIContainer returnButton { /* [XID] */ /* 0x0000000189A12960-0x0000000189A12980 */ get => default; } // 0x0000000183F96450-0x0000000183F96560 
		public MonoUIContainer gotoButton { /* [XID] */ /* 0x0000000189A19B90-0x0000000189A19BB0 */ get => default; } // 0x0000000183F96340-0x0000000183F96450 
	
		// Nested types
		[Serializable]
		public class StoryInfo // TypeDefIndex: 31008
		{
			// Fields
			public RectTransform root; // 0x10
			public UnityEngine.UI.Text titleText; // 0x18
			public RectTransform grpTips; // 0x20
			public UnityEngine.UI.Text tipsText; // 0x28
			public UnityEngine.UI.Text descText; // 0x30
			public RectTransform grpReward; // 0x38
			public MonoGridScroller rewardScroller; // 0x40
			public RectTransform grpRestriction; // 0x48
			public UnityEngine.UI.Text restricText; // 0x50
			public RectTransform grpFinished; // 0x58
	
			// Constructors
			public StoryInfo() {} // 0x0000000183FA0680-0x0000000183FA06E0
		}
	
		// Constructors
		public MonoLanternRiteStoryPage() {} // 0x0000000183F962D0-0x0000000183F96340
	}
}
