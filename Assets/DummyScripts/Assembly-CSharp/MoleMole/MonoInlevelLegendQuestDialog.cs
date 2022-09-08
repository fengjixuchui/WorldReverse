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
	public class MonoInlevelLegendQuestDialog : MonoBehaviour // TypeDefIndex: 29745
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDailyQuest; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDailyNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtKeyNum; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNoQuest; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _scroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _progressScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x58
		// [Header] // 0x0000000189B2D6F0-0x0000000189B2D740
		[SerializeField] // 0x0000000189B2D6F0-0x0000000189B2D740
		private GameObject _personalPanel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _coopPanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _coopScroller; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _coopScrollerHandler; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _coopScrollRect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _coopPrevIcon; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _coopNextIcon; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _coopAvatarFadeTime; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _coopRecoverElasticTime; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnSwitchSelectStatus; // 0xA0
	
		// Properties
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001897E25C0-0x00000001897E25E0 */ get => default; } // 0x0000000183D77890-0x0000000183D77930 
		public UnityEngine.UI.Text txtDailyQuest { /* [XID] */ /* 0x00000001897E9D70-0x00000001897E9D90 */ get => default; } // 0x0000000183D776B0-0x0000000183D77750 
		public UnityEngine.UI.Text txtDailyNum { /* [XID] */ /* 0x00000001897F19D0-0x00000001897F19F0 */ get => default; } // 0x0000000183D77610-0x0000000183D776B0 
		public UnityEngine.UI.Text txtKeyNum { /* [XID] */ /* 0x00000001897F9140-0x00000001897F9160 */ get => default; } // 0x0000000183D77750-0x0000000183D777F0 
		public UnityEngine.UI.Text txtNoQuest { /* [XID] */ /* 0x0000000189800750-0x0000000189800770 */ get => default; } // 0x0000000183D777F0-0x0000000183D77890 
		public MonoGridScroller scroller { /* [XID] */ /* 0x0000000189807DF0-0x0000000189807E10 */ get => default; } // 0x0000000183D77390-0x0000000183D77430 
		public MonoSimpleReusableList progressScroller { /* [XID] */ /* 0x000000018980F6D0-0x000000018980F6F0 */ get => default; } // 0x0000000183D772F0-0x0000000183D77390 
		public GameObject personalPanel { /* [XID] */ /* 0x0000000189816D80-0x0000000189816DA0 */ get => default; } // 0x0000000183D77250-0x0000000183D772F0 
		public GameObject coopPanel { /* [XID] */ /* 0x000000018981E5F0-0x000000018981E610 */ get => default; } // 0x0000000183D76E60-0x0000000183D76F00 
		public MonoSimpleReusableList coopScroller { /* [XID] */ /* 0x0000000189825A50-0x0000000189825A70 */ get => default; } // 0x0000000183D771B0-0x0000000183D77250 
		public MonoJoypadSimpleResuableListHandler coopScrollerHandler { /* [XID] */ /* 0x000000018982D200-0x000000018982D220 */ get => default; } // 0x0000000183D77110-0x0000000183D771B0 
		public MonoScrollRectExtention coopScrollRect { /* [XID] */ /* 0x0000000189834960-0x0000000189834980 */ get => default; } // 0x0000000183D77060-0x0000000183D77110 
		public GameObject coopPrevIcon { /* [XID] */ /* 0x000000018983BFF0-0x000000018983C010 */ get => default; } // 0x0000000183D76F00-0x0000000183D76FB0 
		public GameObject coopNextIcon { /* [XID] */ /* 0x0000000189843620-0x0000000189843640 */ get => default; } // 0x0000000183D76DB0-0x0000000183D76E60 
		public float coopAvatarFadeTime { /* [XID] */ /* 0x000000018984AB20-0x000000018984AB40 */ get => default; } // 0x0000000183D76D00-0x0000000183D76DB0 
		public float coopRecoverElasticTime { /* [XID] */ /* 0x0000000189851EC0-0x0000000189851EE0 */ get => default; } // 0x0000000183D76FB0-0x0000000183D77060 
		public Button btnSwitchSelectStatus { /* [XID] */ /* 0x0000000189859780-0x00000001898597A0 */ get => default; } // 0x0000000183D76C50-0x0000000183D76D00 
		public Button btnLock { /* [XID] */ /* 0x0000000189860900-0x0000000189860920 */ get => default; } // 0x0000000183D76A30-0x0000000183D76C50 
		public Button btnClose { /* [XID] */ /* 0x0000000189868030-0x0000000189868050 */ get => default; } // 0x0000000183D76130-0x0000000183D76350 
		public Button btnFetch { /* [XID] */ /* 0x000000018986F5D0-0x000000018986F5F0 */ get => default; } // 0x0000000183D765F0-0x0000000183D76810 
		public Button btnInfo { /* [XID] */ /* 0x0000000189876BA0-0x0000000189876BC0 */ get => default; } // 0x0000000183D76810-0x0000000183D76A30 
		public Button btnCheck { /* [XID] */ /* 0x000000018987E6A0-0x000000018987E6C0 */ get => default; } // 0x0000000183D75F10-0x0000000183D76130 
		public bool showNoQuestPage { /* [XID] */ /* 0x000000018988CD80-0x000000018988CDA0 */ set {} } // 0x0000000183D77930-0x0000000183D77A40
		public MonoReusableList tabList { /* [XID] */ /* 0x0000000189894470-0x0000000189894490 */ get => default; } // 0x0000000183D77430-0x0000000183D77610 
		public MonoUIContainer btnCoopReward { /* [XID] */ /* 0x000000018989BA20-0x000000018989BA40 */ get => default; } // 0x0000000183D764A0-0x0000000183D765F0 
		public MonoUIContainer btnCoopGoto { /* [XID] */ /* 0x00000001898A2EB0-0x00000001898A2ED0 */ get => default; } // 0x0000000183D76350-0x0000000183D764A0 
	
		// Constructors
		public MonoInlevelLegendQuestDialog() {} // 0x0000000183D75E40-0x0000000183D75F10
	
		// Methods
		// [XID] // 0x0000000189885A90-0x0000000189885AB0
		public void PlayGetKeyAnimation() {} // 0x0000000183D75D40-0x0000000183D75E40
	}
}
