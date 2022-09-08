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
	public class MonoLikingBar : MonoBehaviour // TypeDefIndex: 31250
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAttachToPoint _monoAttachToPoint; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _monoProgressBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _likingBarText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _barAnimator; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _downIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _lerpTime; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _disappearHoldTime; // 0x44
		private float _lerpTimer; // 0x48
		private float _lerpStartValue; // 0x4C
		private float _curFillValue; // 0x50
		private float _fillValueTarget; // 0x54
	
		// Properties
		public float lerpTime { /* [XID] */ /* 0x000000018986C510-0x000000018986C530 */ get => default; } // 0x000000018427D330-0x000000018427D3E0 
		public float disappearHoldTime { /* [XID] */ /* 0x0000000189873940-0x0000000189873960 */ get => default; } // 0x000000018427D280-0x000000018427D330 
	
		// Constructors
		public MonoLikingBar() {} // 0x000000018427D200-0x000000018427D280
	
		// Methods
		// [XID] // 0x000000018987B3B0-0x000000018987B3D0
		public void SetLikingBar(BaseEntity attachEntity, float fillValue, bool isWarning, string likingBarText, bool fillInstant = false /* Metadata: 0x00B1211C */) {} // 0x000000018427CD70-0x000000018427D070
		// [XID] // 0x0000000189882590-0x00000001898825B0
		public void SetAttachParam(string attachPoint, Vector3 offset) {} // 0x000000018427CC30-0x000000018427CD70
		// [XID] // 0x0000000189889C70-0x0000000189889C90
		private void Update() {} // 0x000000018427D070-0x000000018427D200
	}
}
