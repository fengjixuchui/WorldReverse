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
	public class MonoArrowPointRecon : MonoBehaviour // TypeDefIndex: 31182
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _fillImg; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _fillBgCanvas; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _bgCanvas; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _arrowTrans; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ParticleSystem _alertEffect; // 0x38
		private float _lastFillValue; // 0x40
	
		// Constructors
		public MonoArrowPointRecon() {} // 0x0000000184C96280-0x0000000184C96300
	
		// Methods
		// [XID] // 0x00000001898EFA80-0x00000001898EFAA0
		public void UpdateArrowPoint(float fillValue, float arrowAngle) {} // 0x0000000184C960D0-0x0000000184C96280
	}
}
