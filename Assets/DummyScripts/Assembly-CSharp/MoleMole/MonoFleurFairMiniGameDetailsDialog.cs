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
	public class MonoFleurFairMiniGameDetailsDialog : MonoUIProxy // TypeDefIndex: 30376
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _tabPanel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _avatarRows; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameBalloonDetail _balloonDetail; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameFallDetail _fallDetail; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameMusicDetail _musicDetail; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _rightScroll; // 0x70
	
		// Properties
		public ScrollRect rightScroll { /* [XID] */ /* 0x0000000189B874E0-0x0000000189B87500 */ get => default; } // 0x0000000185639900-0x00000001856399A0 
		public Button prevBtn { /* [XID] */ /* 0x0000000189B8E610-0x0000000189B8E630 */ get => default; } // 0x0000000185639780-0x0000000185639840 
		public Button nextBtn { /* [XID] */ /* 0x0000000189B95AF0-0x0000000189B95B10 */ get => default; } // 0x00000001856396C0-0x0000000185639780 
		public Button gotoBtn { /* [XID] */ /* 0x0000000189B9D090-0x0000000189B9D0B0 */ get => default; } // 0x0000000185639600-0x00000001856396C0 
		public Button closeBtn { /* [XID] */ /* 0x0000000189BA49D0-0x0000000189BA49F0 */ get => default; } // 0x0000000185639540-0x0000000185639600 
		public MonoUIContainer rewardBtn { /* [XID] */ /* 0x0000000189BABCF0-0x0000000189BABD10 */ get => default; } // 0x0000000185639840-0x0000000185639900 
		public MonoReusableList tabPanel { /* [XID] */ /* 0x0000000189BB33A0-0x0000000189BB33C0 */ get => default; } // 0x00000001856399A0-0x0000000185639A40 
		public MonoFleurFairMiniGameBalloonDetail BalloonDetail { /* [XID] */ /* 0x0000000189BC2980-0x0000000189BC29A0 */ get => default; } // 0x0000000185639360-0x0000000185639400 
		public MonoFleurFairMiniGameFallDetail FallDetail { /* [XID] */ /* 0x0000000189BCA120-0x0000000189BCA140 */ get => default; } // 0x0000000185639400-0x00000001856394A0 
		public MonoFleurFairMiniGameMusicDetail MusicDetail { /* [XID] */ /* 0x0000000189BD17B0-0x0000000189BD17D0 */ get => default; } // 0x00000001856394A0-0x0000000185639540 
	
		// Constructors
		public MonoFleurFairMiniGameDetailsDialog() {} // 0x00000001856392E0-0x0000000185639360
	
		// Methods
		// [XID] // 0x0000000189BBA960-0x0000000189BBA980
		public MonoFleurFairMiniGameAvatarRow GetAvatarRow(int index) => default; // 0x0000000185639000-0x00000001856390F0
		// [XID] // 0x0000000189BD8D80-0x0000000189BD8DA0
		public void ShowMiniGame(EFleurFairMiniGame gameType) {} // 0x00000001856391D0-0x00000001856392E0
		// [XID] // 0x00000001895E5960-0x00000001895E5980
		public void SetGotoText(string btnText) {} // 0x00000001856390F0-0x00000001856391D0
	}
}
