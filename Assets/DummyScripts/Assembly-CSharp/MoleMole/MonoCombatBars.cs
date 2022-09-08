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
	public class MonoCombatBars : MonoBehaviour // TypeDefIndex: 31190
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoTransitionalReduceBar _hpBar; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTransitionalReduceBar _shieldBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTransitionalReduceBar _elementShieldBar; // 0x28
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0x30
		public UnityEngine.UI.Text combatName; // 0x38
		public GameObject affixGO; // 0x40
		public Image affixImage; // 0x48
		public GameObject levelGo; // 0x50
		public UnityEngine.UI.Text levelTxt; // 0x58
		public MonoInLevelBuffInfo buffInfo; // 0x60
		// [Header] // 0x0000000189AEDB20-0x0000000189AEDB50
		public Color none; // 0x68
		public Color fire; // 0x78
		public Color water; // 0x88
		public Color grass; // 0x98
		public Color electric; // 0xA8
		public Color ice; // 0xB8
		public Color wind; // 0xC8
		public Color rock; // 0xD8
		// [Header] // 0x0000000189AF5350-0x0000000189AF5380
		public Color friendHPColor; // 0xE8
		public Color friendHPBgColor; // 0xF8
		public Color enemyHPColor; // 0x108
		public Color enemyHPBgColor; // 0x118
	
		// Properties
		public bool showHPBar { /* [XID] */ /* 0x0000000189AFC8B0-0x0000000189AFC8D0 */ set {} } // 0x0000000184BAF210-0x0000000184BAF2F0
		public bool showShieldBar { /* [XID] */ /* 0x0000000189B03FF0-0x0000000189B04010 */ set {} } // 0x0000000184BAF2F0-0x0000000184BAF3D0
		public bool showElementShieldBar { /* [XID] */ /* 0x0000000189B0B8B0-0x0000000189B0B8D0 */ set {} } // 0x0000000184BAF130-0x0000000184BAF210
		public bool showTitle { /* [XID] */ /* 0x0000000189B12DE0-0x0000000189B12E00 */ set {} } // 0x0000000184BAF3D0-0x0000000184BAF4B0
		public string title { /* [XID] */ /* 0x0000000189B1A470-0x0000000189B1A490 */ set {} } // 0x0000000184BAF4B0-0x0000000184BAF580
		public MonoTransitionalReduceBar hpBar { /* [XID] */ /* 0x0000000189B21990-0x0000000189B219B0 */ get => default; } // 0x0000000184BAEE20-0x0000000184BAEEC0 
		public MonoTransitionalReduceBar shieldBar { /* [XID] */ /* 0x0000000189B290C0-0x0000000189B290E0 */ get => default; } // 0x0000000184BAEEC0-0x0000000184BAEF60 
		public MonoTransitionalReduceBar elementShieldBar { /* [XID] */ /* 0x0000000189B304F0-0x0000000189B30510 */ get => default; } // 0x0000000184BAED80-0x0000000184BAEE20 
		public ElementType elementShieldElementType { /* [XID] */ /* 0x0000000189B37E10-0x0000000189B37E30 */ set {} } // 0x0000000184BAEF60-0x0000000184BAF130
	
		// Constructors
		public MonoCombatBars() {} // 0x0000000184BAEBD0-0x0000000184BAED80
	
		// Methods
		// [XID] // 0x0000000189B3F740-0x0000000189B3F760
		public void UpdateView() {} // 0x0000000184BAEAF0-0x0000000184BAEBD0
	}
}
