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
	public class MonoMallPage : MonoUIProxy // TypeDefIndex: 31055
	{
		// Fields
		public string[] type2PanelPath; // 0x40
		public MonoRegionJoypadController regionController; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject mallCNWarning; // 0x58
		public MonoRegionJoypadController joypadController; // 0x60
		public MonoGridScroller tabScroller; // 0x68
		public Transform panelTrans; // 0x70
		public GameObject shopMatierialItem; // 0x78
		public Transform shopMatierialContent; // 0x80
		public GameObject mallTips; // 0x88
		public GameObject mallDoubleHcoinTips; // 0x90
		public GameObject emptyTips; // 0x98
		public GameObject noPriceTips; // 0xA0
		public UnityEngine.UI.Text refreshTimeText; // 0xA8
	
		// Properties
		public MonoUIContainer closeButton { /* [XID] */ /* 0x0000000189904BC0-0x0000000189904BE0 */ get => default; } // 0x00000001842966D0-0x0000000184296790 
		public MonoUIContainer backButton { /* [XID] */ /* 0x000000018990C400-0x000000018990C420 */ get => default; } // 0x0000000184296550-0x0000000184296610 
		public MonoUIContainer explainButton { /* [XID] */ /* 0x0000000189913CF0-0x0000000189913D10 */ get => default; } // 0x0000000184296850-0x0000000184296910 
		public MonoUIContainer custumServiceButton { /* [XID] */ /* 0x000000018991B660-0x000000018991B680 */ get => default; } // 0x0000000184296790-0x0000000184296850 
		public MonoUIContainer tipsButton { /* [XID] */ /* 0x0000000189922C00-0x0000000189922C20 */ get => default; } // 0x0000000184296A90-0x0000000184296B50 
		public MonoUIContainer buyButton { /* [XID] */ /* 0x000000018992A4F0-0x000000018992A510 */ get => default; } // 0x0000000184296610-0x00000001842966D0 
		public MonoUIContainer fetchButton { /* [XID] */ /* 0x0000000189931AA0-0x0000000189931AC0 */ get => default; } // 0x0000000184296910-0x00000001842969D0 
		public MonoUIContainer okButton { /* [XID] */ /* 0x0000000189939500-0x0000000189939520 */ get => default; } // 0x00000001842969D0-0x0000000184296A90 
	
		// Constructors
		public MonoMallPage() {} // 0x00000001842964A0-0x0000000184296550
	
		// Methods
		// [XID] // 0x00000001898F5B40-0x00000001898F5B60
		public string GetPanelPath(int type) => default; // 0x0000000184295FE0-0x0000000184296100
		// [XID] // 0x00000001898FD2E0-0x00000001898FD300
		protected void Awake() {} // 0x0000000184295EB0-0x0000000184295FE0
		// [XID] // 0x0000000189940830-0x0000000189940850
		public void InitMaterials(List<ShopMaterial> shopMaterialsList) {} // 0x0000000184296100-0x00000001842963A0
	}
}
