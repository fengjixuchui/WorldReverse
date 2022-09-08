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
	public class MonoExpeditionActivitySelectAvatarPanel : MonoSpriteProxy // TypeDefIndex: 30459
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDest; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _requiredAvatarNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtBonusProbability; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCharTime; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _elementIconList; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _avatarSelectedList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gridScrollerReward; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gridScrollerAvatar; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _sTag; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _aTag; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bTag; // 0x80
		private List<ElementType> _elemList; // 0x88
	
		// Properties
		public UnityEngine.UI.Text txtDest { /* [XID] */ /* 0x0000000189B44110-0x0000000189B44130 */ get => default; } // 0x000000018562A140-0x000000018562A1E0 
		public UnityEngine.UI.Text txtDesc { /* [XID] */ /* 0x0000000189B4B7C0-0x0000000189B4B7E0 */ get => default; } // 0x000000018562A0A0-0x000000018562A140 
		public UnityEngine.UI.Text requiredAvatarAmount { /* [XID] */ /* 0x0000000189B52E70-0x0000000189B52E90 */ get => default; } // 0x0000000185629E20-0x0000000185629EC0 
		public UnityEngine.UI.Text txtBonusProbability { /* [XID] */ /* 0x0000000189B5A840-0x0000000189B5A860 */ get => default; } // 0x0000000185629F60-0x000000018562A000 
		public MonoGridScroller gridScrollerReward { /* [XID] */ /* 0x0000000189B61CF0-0x0000000189B61D10 */ get => default; } // 0x0000000185629D80-0x0000000185629E20 
		public MonoSimpleReusableList avatarSelectedList { /* [XID] */ /* 0x0000000189B69900-0x0000000189B69920 */ get => default; } // 0x0000000185629BA0-0x0000000185629C40 
		public MonoSimpleReusableList elementList { /* [XID] */ /* 0x0000000189B70F00-0x0000000189B70F20 */ get => default; } // 0x0000000185629C40-0x0000000185629CE0 
		public MonoGridScroller gridScrollerAvatar { /* [XID] */ /* 0x0000000189B784D0-0x0000000189B784F0 */ get => default; } // 0x0000000185629CE0-0x0000000185629D80 
		public GameObject STag { /* [XID] */ /* 0x0000000189B7F9F0-0x0000000189B7FA10 */ get => default; } // 0x0000000185629B00-0x0000000185629BA0 
		public GameObject ATag { /* [XID] */ /* 0x0000000189B874A0-0x0000000189B874C0 */ get => default; } // 0x00000001856299B0-0x0000000185629A50 
		public GameObject BTag { /* [XID] */ /* 0x0000000189B8E5D0-0x0000000189B8E5F0 */ get => default; } // 0x0000000185629A50-0x0000000185629B00 
		public ScrollRect scrollRect { /* [XID] */ /* 0x0000000189B95AB0-0x0000000189B95AD0 */ get => default; } // 0x0000000185629EC0-0x0000000185629F60 
		public UnityEngine.UI.Text txtCharTime { /* [XID] */ /* 0x0000000189B9D050-0x0000000189B9D070 */ get => default; } // 0x000000018562A000-0x000000018562A0A0 
	
		// Constructors
		public MonoExpeditionActivitySelectAvatarPanel() {} // 0x0000000185629910-0x00000001856299B0
	
		// Methods
		// [XID] // 0x0000000189BA4990-0x0000000189BA49B0
		public void RefreshTitleAndDesc(MonoExplorationMark monoMark) {} // 0x0000000185629650-0x00000001856297C0
		// [XID] // 0x0000000189BABCB0-0x0000000189BABCD0
		public void RefreshElementIcon(MonoExplorationMark monoMark) {} // 0x0000000185629500-0x0000000185629650
		// [XID] // 0x0000000189BB3360-0x0000000189BB3380
		private void InitElementIconItem(Transform trans, int index) {} // 0x0000000185629350-0x0000000185629500
		// [XID] // 0x0000000189BBA920-0x0000000189BBA940
		public void SetDiffTag(uint diffId) {} // 0x00000001856297C0-0x0000000185629910
	}
}
