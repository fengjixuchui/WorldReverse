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
	public class MonoExplorePage : MonoUIProxy // TypeDefIndex: 30468
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public MonoElementSwitch monoSwitch; // 0x40
		public MonoUIContainer returnButton; // 0x48
		public GameObject grpExploreArea; // 0x50
		public MonoGridScroller exploreAreaScroller; // 0x58
		public GameObject grpExploreMap; // 0x60
		public GameObject grpExploreList; // 0x68
		public GameObject exploreAvatarIconPrefab; // 0x70
		public UnityEngine.UI.Text textQuantity; // 0x78
		public MonoExplorationDetail detailPage; // 0x80
		public GameObject grpNoExploringTip; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cityBgImage; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cityWaterMark; // 0x98
		// [Header] // 0x00000001897D8100-0x00000001897D8160
		[SerializeField] // 0x00000001897D8100-0x00000001897D8160
		[Space] // 0x00000001897D8100-0x00000001897D8160
		private GameObject _topTab; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monoTopTabList; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _challengeGo; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _challengeBtn; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNextChallengeTime; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoExpeditionActivitySelectAvatarPanel _monoActivityCharPanel; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTopTabTips; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unExploreKey; // 0xD8
		public GameObject activityMarkerPrefab; // 0xE0
	
		// Properties
		public UnityEngine.UI.Text noExplorintTipText { /* [XID] */ /* 0x000000018981B490-0x000000018981B4B0 */ get => default; } // 0x000000018562EE00-0x000000018562EEF0 
		public Image cityBgImage { /* [XID] */ /* 0x0000000189822B00-0x0000000189822B20 */ get => default; } // 0x000000018562EB40-0x000000018562EBF0 
		public Image cityWaterMarkImage { /* [XID] */ /* 0x000000018982A430-0x000000018982A450 */ get => default; } // 0x000000018562EBF0-0x000000018562ECA0 
		public GameObject topTab { /* [XID] */ /* 0x0000000189840460-0x0000000189840480 */ get => default; } // 0x000000018562EEF0-0x000000018562EFA0 
		public GameObject challengeGo { /* [XID] */ /* 0x0000000189847A50-0x0000000189847A70 */ get => default; } // 0x000000018562E9E0-0x000000018562EA90 
		public Button chanllengeBtn { /* [XID] */ /* 0x000000018984F1C0-0x000000018984F1E0 */ get => default; } // 0x000000018562EA90-0x000000018562EB40 
		public UnityEngine.UI.Text txtNextChallengeTime { /* [XID] */ /* 0x0000000189856320-0x0000000189856340 */ get => default; } // 0x000000018562EFA0-0x000000018562F050 
		public MonoExpeditionActivitySelectAvatarPanel monoCharPanel { /* [XID] */ /* 0x000000018985D6B0-0x000000018985D6D0 */ get => default; } // 0x000000018562ECA0-0x000000018562ED50 
		public MonoSimpleReusableList monoTopTabList { /* [XID] */ /* 0x0000000189865050-0x0000000189865070 */ get => default; } // 0x000000018562ED50-0x000000018562EE00 
		public UnityEngine.UI.Text txtTopTabTips { /* [XID] */ /* 0x000000018986C5D0-0x000000018986C5F0 */ get => default; } // 0x000000018562F050-0x000000018562F100 
		public GameObject unExploreKey { /* [XID] */ /* 0x0000000189873A20-0x0000000189873A40 */ get => default; } // 0x000000018562F100-0x000000018562F1B0 
	
		// Constructors
		public MonoExplorePage() {} // 0x000000018562E900-0x000000018562E9E0
	
		// Methods
		// [XID] // 0x0000000189831740-0x0000000189831760
		public void SetMapBg(string mapPath) {} // 0x000000018562E740-0x000000018562E830
		// [XID] // 0x0000000189838E40-0x0000000189838E60
		public void SetMapWaterMark(Sprite waterMarkSprite) {} // 0x000000018562E830-0x000000018562E900
	}
}
