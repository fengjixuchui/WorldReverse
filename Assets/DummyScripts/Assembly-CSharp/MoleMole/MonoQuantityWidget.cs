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
	public class MonoQuantityWidget : MonoBehaviour // TypeDefIndex: 30425
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _plusBtn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _minusBtn; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _numText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _numSimpleText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _minText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _slider; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _minusBtnName; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _plusBtnName; // 0x60
		private uint _maxNum; // 0x68
		private uint _minNum; // 0x6C
		private uint _curNum; // 0x70
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public bool useOtherBtn; // 0x74
		public Action<MonoQuantityWidget> onNumChanged; // 0x78
		public uint index; // 0x80
		protected MonoMultiClickButton _multiPlusBtn; // 0x88
		protected MonoMultiClickButton _multiMinusBtn; // 0x90
		public Func<uint, bool> _maxCheckFunc; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _enableRatioNumChange; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMinTime; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMaxTime; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _ratioMax; // 0xAC
		protected float _clickStartTime; // 0xB0
		protected bool _holdPlusBtn; // 0xB4
	
		// Properties
		public Button plusBtn { /* [XID] */ /* 0x000000018963AFD0-0x000000018963AFF0 */ get => default; } // 0x0000000183727CD0-0x0000000183727F50 
		public Button minusBtn { /* [XID] */ /* 0x00000001896426C0-0x00000001896426E0 */ get => default; } // 0x0000000183727A50-0x0000000183727CD0 
		public uint curNum { /* [XID] */ /* 0x0000000189649DD0-0x0000000189649DF0 */ get => default; } // 0x00000001837279B0-0x0000000183727A50 
	
		// Constructors
		public MonoQuantityWidget() {} // 0x00000001837278E0-0x00000001837279B0
	
		// Methods
		// [XID] // 0x00000001896514F0-0x0000000189651510
		private void OnEnable() {} // 0x00000001837271B0-0x0000000183727250
		// [XID] // 0x0000000189658D10-0x0000000189658D30
		public void InitMultiClickButtons() {} // 0x0000000183726A70-0x0000000183726CB0
		// [XID] // 0x0000000189660420-0x0000000189660440
		public void InitNum(uint minNum, uint maxNum, uint curNum = 0 /* Metadata: 0x00B10EE5 */) {} // 0x0000000183726CB0-0x0000000183726FD0
		// [XID] // 0x0000000189667DE0-0x0000000189667E00
		public void OnPlusBtnClick() {} // 0x00000001837274D0-0x0000000183727630
		// [XID] // 0x000000018966F850-0x000000018966F870
		public void OnMinusBtnClick() {} // 0x0000000183727390-0x00000001837274D0
		// [XID] // 0x00000001896771A0-0x00000001896771C0
		public void OnMaxBtnClick() {} // 0x0000000183727250-0x0000000183727390
		// [XID] // 0x000000018967E750-0x000000018967E770
		public void SetMaxFunc(Func<uint, bool> maxCheckFunc) {} // 0x0000000183727830-0x00000001837278E0
		// [XID] // 0x0000000189685F60-0x0000000189685F80
		private void RefreshBtnState() {} // 0x0000000183726780-0x0000000183726A70
		// [XID] // 0x000000018968DD70-0x000000018968DD90
		private void OnSliderValueChanged(float value) {} // 0x0000000183727630-0x0000000183727710
		// [XID] // 0x0000000189695700-0x0000000189695720
		public void SetCurNum(uint value) {} // 0x0000000183727710-0x0000000183727830
		// [XID] // 0x000000018969CD30-0x000000018969CD50
		protected uint GetChangeValueBaseOnMinMax() => default; // 0x0000000183726FD0-0x00000001837271B0
	}
}
