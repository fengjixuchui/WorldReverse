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
	public class MonoMaskSliderGrow : MonoBehaviour // TypeDefIndex: 30831
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMaskSlider maskSlider; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text currentValueText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text MaxValueText; // 0x28
		private float _value; // 0x30
		private float speed; // 0x34
		private bool play; // 0x38
		private float valueAfter; // 0x3C
		private int growTimes; // 0x40
		private float _ratioBefore; // 0x44
		private float _ratioAfter; // 0x48
		private int _count; // 0x4C
		private List<float> maxList; // 0x50
		private Action<Transform> everyFullAction; // 0x58
		private Action<Transform> overAction; // 0x60
	
		// Constructors
		public MonoMaskSliderGrow() {} // 0x00000001849370F0-0x0000000184937180
	
		// Methods
		// [XID] // 0x00000001898C8590-0x00000001898C85B0
		private void Update() {} // 0x0000000184936BC0-0x00000001849370F0
		// [XID] // 0x00000001898CFF60-0x00000001898CFF80
		public void Play(float valBefore, float valAfter, List<float> maxList, Action<Transform> firstFullAction = null, Action<Transform> overAction = null) {} // 0x0000000184936870-0x0000000184936BC0
	}
}
