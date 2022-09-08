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
	public class MonoItemPurchaseDialog : MonoUIProxy // TypeDefIndex: 30557
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _freeClickBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _itemTipAnimator; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _slider; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMinNum; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMaxNum; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _txtContentNum; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTip; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _selectScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _sliderNum; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSlider; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTipsUncheck; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpTips; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMinTime; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMaxTime; // 0xAC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMax; // 0xB0
	
		// Properties
		public Button freeClickBtn { /* [XID] */ /* 0x000000018963F740-0x000000018963F760 */ get => default; } // 0x0000000184328150-0x00000001843281F0 
		public Animator itemTipAnimator { /* [XID] */ /* 0x0000000189646F40-0x0000000189646F60 */ get => default; } // 0x0000000184328400-0x00000001843284A0 
		public Slider slider { /* [XID] */ /* 0x000000018964E6B0-0x000000018964E6D0 */ get => default; } // 0x0000000184328AD0-0x0000000184328BD0 
		public UnityEngine.UI.Text txtMinNum { /* [XID] */ /* 0x0000000189655EA0-0x0000000189655EC0 */ get => default; } // 0x0000000184328D10-0x0000000184328DB0 
		public UnityEngine.UI.Text txtMaxNum { /* [XID] */ /* 0x000000018965D680-0x000000018965D6A0 */ get => default; } // 0x0000000184328C70-0x0000000184328D10 
		public SimpleText txtContentNum { /* [XID] */ /* 0x0000000189664D80-0x0000000189664DA0 */ get => default; } // 0x0000000184328BD0-0x0000000184328C70 
		public UnityEngine.UI.Text txtTip { /* [XID] */ /* 0x000000018966C3A0-0x000000018966C3C0 */ get => default; } // 0x0000000184328DB0-0x0000000184328E50 
		public MonoGridScroller selectScroller { /* [XID] */ /* 0x0000000189674260-0x0000000189674280 */ get => default; } // 0x0000000184328970-0x0000000184328A20 
		public GameObject sliderNum { /* [XID] */ /* 0x000000018967BA40-0x000000018967BA60 */ get => default; } // 0x0000000184328A20-0x0000000184328AD0 
		public GameObject grpSlider { /* [XID] */ /* 0x0000000189683150-0x0000000189683170 */ get => default; } // 0x00000001843281F0-0x00000001843282A0 
		public GameObject grpTipsUncheck { /* [XID] */ /* 0x000000018968ABE0-0x000000018968AC00 */ get => default; } // 0x00000001843282A0-0x0000000184328350 
		public GameObject grpTips { /* [XID] */ /* 0x0000000189692900-0x0000000189692920 */ get => default; } // 0x0000000184328350-0x0000000184328400 
		public float ratioMinTime { /* [XID] */ /* 0x0000000189699C80-0x0000000189699CA0 */ get => default; } // 0x00000001843288C0-0x0000000184328970 
		public float ratioMaxTime { /* [XID] */ /* 0x00000001896A13A0-0x00000001896A13C0 */ get => default; } // 0x0000000184328760-0x0000000184328810 
		public float ratioMax { /* [XID] */ /* 0x00000001896A8810-0x00000001896A8830 */ get => default; } // 0x0000000184328810-0x00000001843288C0 
		public Button closeBtn { /* [XID] */ /* 0x00000001896AF9E0-0x00000001896AFA00 */ get => default; } // 0x0000000184327E90-0x0000000184327FF0 
		public Button cancelBtn { /* [XID] */ /* 0x00000001896B7350-0x00000001896B7370 */ get => default; } // 0x0000000184327D30-0x0000000184327E90 
		public Button confirmBtn { /* [XID] */ /* 0x00000001896BE480-0x00000001896BE4A0 */ get => default; } // 0x0000000184327FF0-0x0000000184328150 
		public Button plusBtn { /* [XID] */ /* 0x00000001896C5CB0-0x00000001896C5CD0 */ get => default; } // 0x0000000184328600-0x0000000184328760 
		public Button minusBtn { /* [XID] */ /* 0x00000001896CD420-0x00000001896CD440 */ get => default; } // 0x00000001843284A0-0x0000000184328600 
	
		// Constructors
		public MonoItemPurchaseDialog() {} // 0x0000000184327C60-0x0000000184327D30
	}
}
