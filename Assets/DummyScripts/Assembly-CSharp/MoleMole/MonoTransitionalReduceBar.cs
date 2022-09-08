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
	public class MonoTransitionalReduceBar : MonoBehaviour // TypeDefIndex: 31283
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private SmoothMask _fill; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _transitionFill; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _fillImage; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _backgroundImage; // 0x30
		// [Range] // 0x0000000189A02010-0x0000000189A02060
		[SerializeField] // 0x0000000189A02010-0x0000000189A02060
		[Space] // 0x0000000189A02010-0x0000000189A02060
		private float _transitionSpeed; // 0x38
		// [Range] // 0x00000001898594A0-0x00000001898594E0
		[SerializeField] // 0x00000001898594A0-0x00000001898594E0
		private float _transitionDelay; // 0x3C
		private float _transitionDelayTimer; // 0x40
	
		// Properties
		public Color fillColor { /* [XID] */ /* 0x0000000189A2FD70-0x0000000189A2FD90 */ set {} } // 0x0000000184889F90-0x000000018488A070
		public Color transitionFillColor { /* [XID] */ /* 0x0000000189A37740-0x0000000189A37760 */ set {} } // 0x000000018488A070-0x000000018488A1A0
		public Color backgroundColor { /* [XID] */ /* 0x0000000189A3EE50-0x0000000189A3EE70 */ set {} } // 0x0000000184889EB0-0x0000000184889F90
	
		// Constructors
		public MonoTransitionalReduceBar() {} // 0x0000000184889E30-0x0000000184889EB0
	
		// Methods
		// [XID] // 0x00000001898B1870-0x00000001898B1890
		public void InitFill(float value) {} // 0x0000000184889930-0x0000000184889A60
		// [XID] // 0x0000000189A211A0-0x0000000189A211C0
		public void UpdateFill(float value) {} // 0x0000000184889A60-0x0000000184889B70
		// [XID] // 0x0000000189A28760-0x0000000189A28780
		public void UpdateView() {} // 0x0000000184889B70-0x0000000184889E30
	}
}
