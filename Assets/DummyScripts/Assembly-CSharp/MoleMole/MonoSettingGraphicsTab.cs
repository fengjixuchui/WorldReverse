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
	public class MonoSettingGraphicsTab : MonoBehaviour // TypeDefIndex: 30933
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Dropdown _uiResolutionDropdown; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Slider _perfLoadSlider; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PerfCostGradeSetting[] perfGradeSettings; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _perfLoadTitle; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _perfLoadDesc; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _perfSliderImage; // 0x40
	
		// Properties
		public Dropdown uiResolutionDropdown { /* [XID] */ /* 0x0000000189A7C920-0x0000000189A7C940 */ get => default; } // 0x00000001841197D0-0x0000000184119870 
		public Slider perfLoadSlider { /* [XID] */ /* 0x0000000189A841D0-0x0000000189A841F0 */ get => default; } // 0x0000000184119730-0x00000001841197D0 
	
		// Nested types
		[Serializable]
		public struct PerfCostGradeSetting // TypeDefIndex: 30934
		{
			// Fields
			public PerfCostRatioGrade perfGrade; // 0x00
			public Color perfColor; // 0x04
			public string perfText; // 0x18
		}
	
		// Constructors
		public MonoSettingGraphicsTab() {} // 0x00000001841196C0-0x0000000184119730
	
		// Methods
		// [XID] // 0x0000000189A8BB10-0x0000000189A8BB30
		public void SetLoadSilder(float currentRatio, float minRatio, float maxRatio, PerfCostRatioGrade perfGrade) {} // 0x00000001841193D0-0x00000001841196C0
	}
}
