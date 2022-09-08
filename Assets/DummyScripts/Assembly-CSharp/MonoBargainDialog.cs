/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonoBargainDialog : MonoUIProxy // TypeDefIndex: 30699
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected MonoUIContainer _bargainSlider; // 0x40
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _minPrice; // 0x48
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _maxPrice; // 0x50
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected MonoUIContainer _buttonIncrease; // 0x58
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected MonoUIContainer _buttonDecrease; // 0x60
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _expectedPrice; // 0x68
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected MonoUIContainer _inputField; // 0x70
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _reserveNum; // 0x78
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Image _reserveIcon; // 0x80
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _bargainTitle; // 0x88
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _affordTitle; // 0x90
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _storageTitle; // 0x98
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected Text _moodDescText; // 0xA0
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected MonoQuantityWidget _quantityWidget; // 0xA8
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private MonoElementSwitch _elementSwitch; // 0xB0
	private MonoPS4IMEProxy _ps4ImeProxy; // 0xB8

	// Properties
	public Slider bargainSlider { get => default; } // 0x0000000181D80760-0x0000000181D807E0 
	public Text minPriceText { get => default; } // 0x0000000181D80CC0-0x0000000181D80D20 
	public Text maxPriceText { get => default; } // 0x0000000181D80C60-0x0000000181D80CC0 
	public Button buttonIncrease { get => default; } // 0x0000000181D809B0-0x0000000181D80A30 
	public Button buttonDecrease { get => default; } // 0x0000000181D80930-0x0000000181D809B0 
	public InputField inputField { get => default; } // 0x0000000181D80BE0-0x0000000181D80C60 
	public Text reserveNum { get => default; } // 0x0000000181D80F20-0x0000000181D80F80 
	public Image reserveIcon { get => default; } // 0x0000000181D80EC0-0x0000000181D80F20 
	public Button buttonBargain { get => default; } // 0x0000000181D80840-0x0000000181D80930 
	public Button buttonInput { get => default; } // 0x0000000181D80A30-0x0000000181D80B20 
	public Text bargainTitle { get => default; } // 0x0000000181D807E0-0x0000000181D80840 
	public Text affordTitle { get => default; } // 0x0000000181D80700-0x0000000181D80760 
	public Text storageTitle { get => default; } // 0x0000000181D80F80-0x0000000181D80FE0 
	public Text moodDescText { get => default; } // 0x0000000181D80D20-0x0000000181D80D80 
	public Transform grpTips { get => default; } // 0x0000000181D80B20-0x0000000181D80BE0 
	public MonoQuantityWidget quantityWidget { get => default; } // 0x0000000181D80E60-0x0000000181D80EC0 
	public MonoPS4IMEProxy ps4IMEProxy { get => default; } // 0x0000000181D80D80-0x0000000181D80E60 

	// Constructors
	public MonoBargainDialog() {} // 0x0000000181D80690-0x0000000181D80700
}

