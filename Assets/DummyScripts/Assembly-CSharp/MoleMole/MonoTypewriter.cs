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
	// [RequireComponent] // 0x00000001898D2B00-0x00000001898D2B70
	public class MonoTypewriter : MonoBehaviour // TypeDefIndex: 31082
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MihoyoTextMeshEffect _textMeshEffect; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _secondPerChar; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _isActive; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _ignoreSpace; // 0x2D
		private int _currCharIndex; // 0x30
		private float _currCharFadeTime; // 0x34
		private bool _inUpdate; // 0x38
		private string _textContent; // 0x40
	
		// Constructors
		public MonoTypewriter() {} // 0x0000000184890610-0x00000001848906A0
	
		// Methods
		// [XID] // 0x0000000189904BA0-0x0000000189904BC0
		public void PlayTypewriterAnim() {} // 0x000000018488FF00-0x0000000184890150
		// [XID] // 0x000000018990C3E0-0x000000018990C400
		public bool ShowAllText() => default; // 0x0000000184890150-0x0000000184890270
		// [XID] // 0x0000000189913CD0-0x0000000189913CF0
		private void Update() {} // 0x0000000184890270-0x0000000184890610
	}
}
