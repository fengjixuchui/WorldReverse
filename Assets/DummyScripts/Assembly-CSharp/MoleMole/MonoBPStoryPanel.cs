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
	public class MonoBPStoryPanel : MonoBehaviour // TypeDefIndex: 30716
	{
		// Fields
		private const string ITEMTIPS_PREFAB_PATH = "ART/UI/Menus/Widget/ItemTips"; // Metadata: 0x00B114A7
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardNameText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardDescText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _storyRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _weaponScroller; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _storyScroller; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _weaponTipsContainer; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponSelectRoot; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _weaponTipsScroller; // 0x58
		private MonoItemTip _itemTips; // 0x60
	
		// Properties
		public UnityEngine.UI.Text rewardNameText { /* [XID] */ /* 0x0000000189AF9D20-0x0000000189AF9D40 */ get => default; } // 0x00000001847FB790-0x00000001847FB830 
		public UnityEngine.UI.Text rewardDescText { /* [XID] */ /* 0x0000000189B01250-0x0000000189B01270 */ get => default; } // 0x00000001847FB6F0-0x00000001847FB790 
		public GameObject weaponRoot { /* [XID] */ /* 0x0000000189B087A0-0x0000000189B087C0 */ get => default; } // 0x00000001847FB970-0x00000001847FBA10 
		public GameObject storyRoot { /* [XID] */ /* 0x0000000189B10140-0x0000000189B10160 */ get => default; } // 0x00000001847FB830-0x00000001847FB8D0 
		public MonoGridScroller weaponScroller { /* [XID] */ /* 0x0000000189B17260-0x0000000189B17280 */ get => default; } // 0x00000001847FBA10-0x00000001847FBAB0 
		public MonoGridScroller storyScroller { /* [XID] */ /* 0x0000000189B1EC00-0x0000000189B1EC20 */ get => default; } // 0x00000001847FB8D0-0x00000001847FB970 
		public GameObject weaponSelectRoot { /* [XID] */ /* 0x0000000189B26490-0x0000000189B264B0 */ get => default; } // 0x00000001847FBAB0-0x00000001847FBB50 
		public ScrollRect weaponTipsScroller { /* [XID] */ /* 0x0000000189B2D760-0x0000000189B2D780 */ get => default; } // 0x00000001847FBB50-0x00000001847FBBF0 
		public MonoItemTip itemTips { /* [XID] */ /* 0x0000000189B34BE0-0x0000000189B34C00 */ get => default; } // 0x00000001847FB540-0x00000001847FB6F0 
	
		// Constructors
		public MonoBPStoryPanel() {} // 0x00000001847FB4B0-0x00000001847FB540
	
		// Methods
		// [XID] // 0x0000000189B3C3F0-0x0000000189B3C410
		private void OnDestroy() {} // 0x00000001847FB3A0-0x00000001847FB4B0
	}
}
