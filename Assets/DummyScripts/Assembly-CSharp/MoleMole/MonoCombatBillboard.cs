/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCombatBillboard : MonoBehaviour // TypeDefIndex: 31191
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _titleGrp; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _onlineID; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _backgroundImage; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _combatBars; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _hpBackground; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _eliteHpBackground; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _eliteIcon; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoPrefabPlugin _prefabPlugin; // 0x58
		public MonoAsyncPrefabPlugin _asyncPrefabPlugin; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTransitionalReduceBar _hpBar; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTransitionalReduceBar _elementShieldBar; // 0x70
		private bool _bShowName; // 0x78
		private bool _bShowLevel; // 0x79
		private string _currlevel; // 0x80
		private string _currName; // 0x88
		private Color _levelColor; // 0x90
		private string _currFulltext; // 0xA0
		private MonoAffixList _affixList; // 0xA8
	
		// Properties
		public bool showTitleGrp { /* [XID] */ /* 0x0000000189BC66D0-0x0000000189BC66F0 */ set {} } // 0x0000000184BB0D60-0x0000000184BB0E40
		public bool showLevel { /* [XID] */ /* 0x0000000189BA8BF0-0x0000000189BA8C10 */ set {} } // 0x0000000184BB0B00-0x0000000184BB0BC0
		public bool showName { /* [XID] */ /* 0x0000000189BB0320-0x0000000189BB0340 */ set {} } // 0x0000000184BB0BC0-0x0000000184BB0C80
		public bool showOnlineID { /* [XID] */ /* 0x0000000189BB7760-0x0000000189BB7780 */ set {} } // 0x0000000184BB0C80-0x0000000184BB0D60
		public string titleLevel { /* [XID] */ /* 0x00000001899E72B0-0x00000001899E72D0 */ set {} } // 0x0000000184BB0E40-0x0000000184BB0F00
		public Color levelColor { /* [XID] */ /* 0x0000000189BD5A40-0x0000000189BD5A60 */ set {} } // 0x0000000184BB04A0-0x0000000184BB0570
		public string titleName { /* [XID] */ /* 0x00000001895EA250-0x00000001895EA270 */ set {} } // 0x0000000184BB0F00-0x0000000184BB0FC0
		public string onlineID { /* [XID] */ /* 0x00000001895F16D0-0x00000001895F16F0 */ set {} } // 0x0000000184BB0570-0x0000000184BB0680
		public bool showCombatBars { /* [XID] */ /* 0x00000001895F9130-0x00000001895F9150 */ set {} } // 0x0000000184BB0860-0x0000000184BB0940
		public bool showHpGrp { /* [XID] */ /* 0x0000000189600740-0x0000000189600760 */ set {} } // 0x0000000184BB0A20-0x0000000184BB0B00
		public bool isElite { /* [XID] */ /* 0x0000000189608080-0x00000001896080A0 */ set {} } // 0x0000000184BB0390-0x0000000184BB04A0
		public Sprite eliteIcon { /* [XID] */ /* 0x000000018960FA00-0x000000018960FA20 */ set {} } // 0x0000000184BB0290-0x0000000184BB0390
		public bool showElementShieldGrp { /* [XID] */ /* 0x0000000189616C50-0x0000000189616C70 */ set {} } // 0x0000000184BB0940-0x0000000184BB0A20
		public Color elementShieldColor { /* [XID] */ /* 0x000000018961E800-0x000000018961E820 */ set {} } // 0x0000000184BB01B0-0x0000000184BB0290
		public Color transitionFillColor { /* [XID] */ /* 0x0000000189625BE0-0x0000000189625C00 */ set {} } // 0x0000000184BB0FC0-0x0000000184BB10A0
		public MonoTransitionalReduceBar hpBar { /* [XID] */ /* 0x000000018962D500-0x000000018962D520 */ get => default; } // 0x0000000184BB0110-0x0000000184BB01B0 
		public MonoTransitionalReduceBar elementShieldBar { /* [XID] */ /* 0x00000001896350C0-0x00000001896350E0 */ get => default; } // 0x0000000184BB0070-0x0000000184BB0110 
		public MonoAffixList affixList { /* [XID] */ /* 0x0000000189643E30-0x0000000189643E50 */ get => default; } // 0x0000000184BAFFC0-0x0000000184BB0070 
		public bool showAffixList { /* [XID] */ /* 0x0000000189B4B1A0-0x0000000189B4B1C0 */ set {} } // 0x0000000184BB0680-0x0000000184BB0760
		public bool showArrowBoard { /* [XID] */ /* 0x0000000189669670-0x0000000189669690 */ set {} } // 0x0000000184BB0760-0x0000000184BB0860
	
		// Constructors
		public MonoCombatBillboard() {} // 0x0000000184BAFF00-0x0000000184BAFFC0
	
		// Methods
		// [XID] // 0x0000000189BC6AB0-0x0000000189BC6AD0
		public void SetScale(float scale) {} // 0x0000000184BAFD20-0x0000000184BAFE30
		// [XID] // 0x0000000189BCE7C0-0x0000000189BCE7E0
		public void SetLevelDisplay(float alpha) {} // 0x0000000184BAFB90-0x0000000184BAFD20
		// [XID] // 0x0000000189BDD680-0x0000000189BDD6A0
		public void RefreshNameTxt() {} // 0x0000000184BAF930-0x0000000184BAFB90
		// [XID] // 0x000000018963C6E0-0x000000018963C700
		public void UpdateView() {} // 0x0000000184BAFE30-0x0000000184BAFF00
		// [XID] // 0x000000018964B570-0x000000018964B590
		public void CreateAffixList() {} // 0x0000000184BAF580-0x0000000184BAF6A0
		// [XID] // 0x000000018965A480-0x000000018965A4A0
		public void DestroyAffixList() {} // 0x0000000184BAF820-0x0000000184BAF930
		// [XID] // 0x0000000189661AD0-0x0000000189661AF0
		public void CreateArrowBoard(UnityAction action) {} // 0x0000000184BAF6A0-0x0000000184BAF820
	}
}
