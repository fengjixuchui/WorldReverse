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
	public class MonoInLevelNamePage : MonoUIProxy // TypeDefIndex: 29751
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _okButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _backButton; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _backButtonTransparent; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameShow; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _nameField; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _onlyMaleShowObjs; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _onlyFemaleShowObjs; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Vector3 offsetPos; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Vector3 offsetRotation; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float closeDelayDuration; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transDuration; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transLerpRatio; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float transDistance; // 0xA4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public StoryCameraLerpPattern lerpPattern; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform errorBubble; // 0xB0
		public int NAME_MIN_COUNT; // 0xB8
	
		// Properties
		public Button okButton { /* [XID] */ /* 0x000000018981B550-0x000000018981B570 */ get => default; } // 0x0000000183D6D7B0-0x0000000183D6D860 
		public Button backButton { /* [XID] */ /* 0x0000000189822BC0-0x0000000189822BE0 */ get => default; } // 0x0000000183D6D700-0x0000000183D6D7B0 
		public Button backButtonTransparent { /* [XID] */ /* 0x000000018982A4F0-0x000000018982A510 */ get => default; } // 0x0000000183D6D660-0x0000000183D6D700 
		public UnityEngine.UI.Text Name { /* [XID] */ /* 0x0000000189831840-0x0000000189831860 */ get => default; } // 0x0000000183D6D5C0-0x0000000183D6D660 
		public UnityEngine.UI.Text NameShow { /* [XID] */ /* 0x0000000189838F20-0x0000000189838F40 */ get => default; } // 0x0000000183D6D520-0x0000000183D6D5C0 
		public InputField NameField { /* [XID] */ /* 0x00000001898405A0-0x00000001898405C0 */ get => default; } // 0x0000000183D6D480-0x0000000183D6D520 
	
		// Constructors
		public MonoInLevelNamePage() {} // 0x0000000183D6D3C0-0x0000000183D6D480
	
		// Methods
		// [XID] // 0x0000000189847B50-0x0000000189847B70
		public void ShowMale(bool isMale) {} // 0x0000000183D6D1C0-0x0000000183D6D3C0
	}
}
