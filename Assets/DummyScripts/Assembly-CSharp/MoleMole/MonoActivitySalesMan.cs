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
	public class MonoActivitySalesMan : MonoUIProxy // TypeDefIndex: 31174
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _progressDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _specialRewardDesc; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _specialRewardAnimator; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _specialRewardButton; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollDesc; // 0x80
	
		// Properties
		public ScrollRect scrollDesc { /* [XID] */ /* 0x000000018988E000-0x000000018988E020 */ get => default; } // 0x00000001852DB6F0-0x00000001852DB7A0 
		public Animator specialRewardAnimator { /* [XID] */ /* 0x00000001898956A0-0x00000001898956C0 */ get => default; } // 0x00000001852DB7A0-0x00000001852DB840 
		public Button specialRewardButton { /* [XID] */ /* 0x000000018989CDE0-0x000000018989CE00 */ get => default; } // 0x00000001852DB840-0x00000001852DB8E0 
		public string title { /* [XID] */ /* 0x00000001898A45A0-0x00000001898A45C0 */ set {} } // 0x00000001852DBC50-0x00000001852DBD20
		public string timeDesc { /* [XID] */ /* 0x00000001898ABA30-0x00000001898ABA50 */ set {} } // 0x00000001852DBB80-0x00000001852DBC50
		public string Desc { /* [XID] */ /* 0x00000001898B31F0-0x00000001898B3210 */ set {} } // 0x00000001852DB8E0-0x00000001852DB9C0
		public string progressDesc { /* [XID] */ /* 0x00000001898BAF30-0x00000001898BAF50 */ set {} } // 0x00000001852DB9C0-0x00000001852DBAA0
		public string specialRewardDesc { /* [XID] */ /* 0x00000001898C2260-0x00000001898C2280 */ set {} } // 0x00000001852DBAA0-0x00000001852DBB80
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x00000001898C9CE0-0x00000001898C9D00 */ get => default; } // 0x00000001852DB3F0-0x00000001852DB4B0 
		public MonoUIContainer BtnDescription { /* [XID] */ /* 0x00000001898D12E0-0x00000001898D1300 */ get => default; } // 0x00000001852DB1B0-0x00000001852DB270 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x00000001898D8B50-0x00000001898D8B70 */ get => default; } // 0x00000001852DB0F0-0x00000001852DB1B0 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x00000001898E0850-0x00000001898E0870 */ get => default; } // 0x00000001852DB270-0x00000001852DB330 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x00000001898E8340-0x00000001898E8360 */ get => default; } // 0x00000001852DB4B0-0x00000001852DB570 
		public MonoUIContainer BtnRewardInfo { /* [XID] */ /* 0x00000001898EFAA0-0x00000001898EFAC0 */ get => default; } // 0x00000001852DB570-0x00000001852DB630 
		public MonoUIContainer BtnToday { /* [XID] */ /* 0x00000001898F7350-0x00000001898F7370 */ get => default; } // 0x00000001852DB630-0x00000001852DB6F0 
		public MonoUIContainer BtnGiftBox { /* [XID] */ /* 0x00000001898FEAC0-0x00000001898FEAE0 */ get => default; } // 0x00000001852DB330-0x00000001852DB3F0 
	
		// Constructors
		public MonoActivitySalesMan() {} // 0x00000001852DB060-0x00000001852DB0F0
	
		// Methods
		// [XID] // 0x00000001899061E0-0x0000000189906200
		public void SetSpecicalRewardState(SalesmanActivityDetailInfo salemanInfo) {} // 0x00000001852DAE00-0x00000001852DB060
	}
}
