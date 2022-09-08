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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoEnvironmentDebugger : MonoBehaviour // TypeDefIndex: 31736
	{
		// Fields
		public EnviroSky dynamicSkyManager; // 0x18
		public GameObject cloudsObj; // 0x20
		public GameObject auroraObj; // 0x28
		public GameObject atmosphereObj; // 0x30
		public GameObject starsObbj; // 0x38
		public Slider sliderTime; // 0x40
		public UnityEngine.UI.Text timeText; // 0x48
		public UnityEngine.UI.Text cloudText; // 0x50
		public UnityEngine.UI.Text fogText; // 0x58
		public UnityEngine.UI.Text lightText; // 0x60
		public UnityEngine.UI.Text windStrText; // 0x68
		public UnityEngine.UI.Text windDirText; // 0x70
		public UnityEngine.UI.Text surfaceText; // 0x78
		public UnityEngine.UI.Text enviroWeatherText; // 0x80
		public UnityEngine.UI.Text questWeatherText; // 0x88
		public UnityEngine.UI.Text profileText; // 0x90
		public UnityEngine.UI.Text pauseText; // 0x98
		public UnityEngine.UI.Text lockWeatherText; // 0xA0
		public InputField skyTimeScaleInput; // 0xA8
		public Slider skyTimeScaleSlider; // 0xB0
		public InputField howSecondADayInput; // 0xB8
		public Slider howSecondADaySlider; // 0xC0
		public InputField transitionTimeInput; // 0xC8
		// [Header] // 0x0000000189BB0270-0x0000000189BB02A0
		public Dropdown weatherDropdown; // 0xD0
		public Slider weatherChange; // 0xD8
		// [Header] // 0x0000000189BB8F20-0x0000000189BB8F50
		public Dropdown volumeDropdown; // 0xE0
		public Slider volumeChange; // 0xE8
		private float _transitionTime; // 0xF0
		private string _lastWeather; // 0xF8
		private bool _isTimePause; // 0x100
		private bool _isWeatherLocked; // 0x101
		private InputField.OnChangeEvent emptyInputEvent; // 0x108
		private Slider.SliderEvent emptySliderEvent; // 0x110
		private string _lastVolume; // 0x118
		private readonly List<string> _bigWorldWeatherNames; // 0x120
		private List<string> _weatherNameList; // 0x128
		private bool _allBigWorldWeather; // 0x130
	
		// Constructors
		public MonoEnvironmentDebugger() {} // 0x0000000183CA91C0-0x0000000183CA92C0
	
		// Methods
		// [XID] // 0x0000000189BD1560-0x0000000189BD1580
		private void Start() {} // 0x0000000183CA7A70-0x0000000183CA83B0
		// [XID] // 0x0000000189BD8BA0-0x0000000189BD8BC0
		private void OnEnable() {} // 0x0000000183CA6F70-0x0000000183CA7010
		// [XID] // 0x00000001895E5760-0x00000001895E5780
		private void SetupDrodown() {} // 0x0000000183CA5940-0x0000000183CA6020
		// [XID] // 0x00000001895ED050-0x00000001895ED070
		public void ChangeTimeSlider() {} // 0x0000000183CA53E0-0x0000000183CA5690
		// [XID] // 0x00000001895F4710-0x00000001895F4730
		public void ChangeTimeLenghtSlider(float value) {} // 0x0000000183CA52F0-0x0000000183CA53E0
		// [XID] // 0x00000001895FBF00-0x00000001895FBF20
		public void ChangeWindStrSlider(float value) {} // 0x0000000183CA5780-0x0000000183CA5870
		// [XID] // 0x0000000189603920-0x0000000189603940
		public void ChangeWindDirSlider(float value) {} // 0x0000000183CA5690-0x0000000183CA5780
		// [XID] // 0x000000018960B280-0x000000018960B2A0
		public void SetWeatherID(int id) {} // 0x0000000183CA7930-0x0000000183CA7A70
		// [XID] // 0x0000000189612630-0x0000000189612650
		public void SetVolumeID(int id) {} // 0x0000000183CA7790-0x0000000183CA7930
		// [XID] // 0x0000000189619FA0-0x0000000189619FC0
		public void SetTimeProgress(int id) {} // 0x0000000183CA7600-0x0000000183CA7790
		// [XID] // 0x00000001896214B0-0x00000001896214D0
		public void SetFog(bool i) {} // 0x0000000183CA7550-0x0000000183CA7600
		// [XID] // 0x0000000189628E00-0x0000000189628E20
		public void SetCTS(bool i) {} // 0x0000000183CA7470-0x0000000183CA7550
		// [XID] // 0x0000000189630780-0x00000001896307A0
		private void UpdateWeatherSlider() {} // 0x0000000183CA67F0-0x0000000183CA6A80
		// [XID] // 0x00000001896381E0-0x0000000189638200
		private void UpdateVolumeSlider() {} // 0x0000000183CA6A80-0x0000000183CA6D10
		// [XID] // 0x000000018963F5C0-0x000000018963F5E0
		private void Update() {} // 0x0000000183CA83B0-0x0000000183CA91C0
		// [XID] // 0x0000000189646D50-0x0000000189646D70
		public void OnShowCloudsToggleClicked(bool enabled) {} // 0x0000000183CA71B0-0x0000000183CA7280
		// [XID] // 0x000000018964E510-0x000000018964E530
		public void OnShowAuroraToggleClicked(bool enabled) {} // 0x0000000183CA70E0-0x0000000183CA71B0
		// [XID] // 0x0000000189655D40-0x0000000189655D60
		public void OnShowAtmosphereToggleClicked(bool enabled) {} // 0x0000000183CA7010-0x0000000183CA70E0
		// [XID] // 0x000000018965D500-0x000000018965D520
		public void OnShowStarsToggleClicked(bool enabled) {} // 0x0000000183CA7280-0x0000000183CA7350
		// [XID] // 0x0000000189664C00-0x0000000189664C20
		public void OnAllBigWorldWeatherClicked(bool enabled) {} // 0x0000000183CA6EB0-0x0000000183CA6F70
	}
}
