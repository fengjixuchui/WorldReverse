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
	public class MonoQuestRewardDialog : MonoUIProxy // TypeDefIndex: 30570
	{
		// Fields
		private const string QUEST_REWARD_ITEM_PATH = "ART/UI/Menus/Widget/InLevel/QuestReward_Item"; // Metadata: 0x00B111A8
		private const string QUEST_REWARD_ITEM_PURPLE_PATH = "ART/UI/Menus/Widget/InLevel/QuestReward_Item_Purple"; // Metadata: 0x00B111D8
		private const string QUEST_REWARD_ITEM_ORANGE_PATH = "ART/UI/Menus/Widget/InLevel/QuestReward_Item_Orange"; // Metadata: 0x00B1120F
		private const string TEXTMAPID_ITEM_GET_GENERAL = "UI_ITEM_GET_DIALOG_TITLE"; // Metadata: 0x00B11246
		private const string TEXTMAPID_ITEM_GET_QUEST = "UI_ITEM_GET_DIALOG_TITLE_BY_QUEST"; // Metadata: 0x00B11262
		private const string TEXTMAPID_ITEM_GET_DAILYTASK = "UI_ITEM_GET_DIALOG_TITLE_BY_DAILYTASK"; // Metadata: 0x00B11287
		private const string TEXTMAPID_ITEM_GET_RANDTASK = "UI_ITEM_GET_DIALOG_TITLE_BY_RANDTASK"; // Metadata: 0x00B112B0
		private const string TEXTMAPID_ITEM_GET_GATHER = "UI_ITEM_GET_DIALOG_TITLE"; // Metadata: 0x00B112D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemRoot; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemHQRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _itemFadeTime; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _endProtectTime; // 0x54
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x58
		public int maxShowCount; // 0x60
		private GameObject _itemPrefabDefault; // 0x68
		private GameObject _itemPrefabPurple; // 0x70
		private GameObject _itemPrefabOrange; // 0x78
		private Dictionary<RewardItemQuality, Queue<MonoSimpleItem>> _itemCacheDict; // 0x80
		private AsyncJob loadJob1; // 0x88
		private AsyncJob loadJob2; // 0x98
		private AsyncJob loadJob3; // 0xA8
	
		// Properties
		public Transform itemRoot { /* [XID] */ /* 0x00000001896848E0-0x0000000189684900 */ get => default; } // 0x0000000184424720-0x00000001844247C0 
		public Transform itemHQRoot { /* [XID] */ /* 0x000000018968C4D0-0x000000018968C4F0 */ get => default; } // 0x0000000184424680-0x0000000184424720 
		public float itemFadeTime { /* [XID] */ /* 0x0000000189693F20-0x0000000189693F40 */ get => default; } // 0x00000001844245D0-0x0000000184424680 
		public float endProtectTime { /* [XID] */ /* 0x000000018969B4D0-0x000000018969B4F0 */ get => default; } // 0x0000000184424520-0x00000001844245D0 
	
		// Nested types
		public class RewardItemQualityComparer : IEqualityComparer<RewardItemQuality> // TypeDefIndex: 30571
		{
			// Constructors
			public RewardItemQualityComparer() {} // 0x0000000184422180-0x00000001844221E0
	
			// Methods
			// [XID] // 0x00000001896E4DE0-0x00000001896E4E00
			public bool Equals(RewardItemQuality x, RewardItemQuality y) => default; // 0x0000000184422000-0x00000001844220D0
			// [XID] // 0x00000001896EC2E0-0x00000001896EC300
			public int GetHashCode(RewardItemQuality obj) => default; // 0x00000001844220D0-0x0000000184422180
		}
	
		// Constructors
		public MonoQuestRewardDialog() {} // 0x0000000184424350-0x0000000184424520
	
		// Methods
		// [XID] // 0x00000001896A2BF0-0x00000001896A2C10
		public void ResetItems() {} // 0x0000000184423F60-0x00000001844241C0
		// [XID] // 0x00000001896AA0E0-0x00000001896AA100
		public void SetupTitle(ItemGetReason itemGetReason) {} // 0x00000001844241C0-0x0000000184424350
		// [XID] // 0x00000001896B0E50-0x00000001896B0E70
		public MonoSimpleItem GetUnuseItemMono(uint itemID) => default; // 0x0000000184423150-0x0000000184423670
		// [XID] // 0x00000001896B8A70-0x00000001896B8A90
		public void EnqueueUnuseItemMono(MonoSimpleItem item) {} // 0x0000000184422CA0-0x0000000184422E80
		// [XID] // 0x00000001896BFCF0-0x00000001896BFD10
		protected override void OnDestroy() {} // 0x0000000184423EA0-0x0000000184423F60
		// [XID] // 0x00000001896C75D0-0x00000001896C75F0
		public void LoadItemPrefabAsync(Action callback) {} // 0x0000000184423AE0-0x0000000184423EA0
		// [XID] // 0x00000001896CED30-0x00000001896CED50
		private bool CheckAllPrefabLoaded() => default; // 0x0000000184423980-0x0000000184423AE0
		// [XID] // 0x00000001896D6150-0x00000001896D6170
		private void StopAllAsyncLoadJob() {} // 0x0000000184422E80-0x0000000184423150
		// [XID] // 0x00000001896DD770-0x00000001896DD790
		private void DissmissAllPrefab() {} // 0x0000000184423670-0x0000000184423980
	}
}
