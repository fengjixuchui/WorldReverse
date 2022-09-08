/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x000000018991B610-0x000000018991B660
	public class MonoTypewriterEffect : MonoBehaviour // TypeDefIndex: 31083
	{
		// Fields
		public UnityEvent myEvent; // 0x18
		public int charsPerSecond; // 0x20
		private float _timer; // 0x28
		private string _originWords; // 0x30
		private StringBuilder _realWords; // 0x38
		private int _originPre; // 0x40
		private int _originPost; // 0x44
		private int _originCurrent; // 0x48
		private int _pureCurrent; // 0x4C
		private int _current; // 0x50
		private UnityEngine.UI.Text _mText; // 0x58
		private bool _inRichText; // 0x60
	
		// Properties
		public bool isActive { /* [XID] */ /* 0x0000000189931A60-0x0000000189931AA0 */ get; /* [XID] */ /* 0x000000018993C480-0x000000018993C4C0 */ private set; } // 0x000000018488FEA0-0x000000018488FF00 0x000000018488F1D0-0x000000018488F230
	
		// Constructors
		public MonoTypewriterEffect() {} // 0x000000018488FE10-0x000000018488FEA0
	
		// Methods
		// [XID] // 0x0000000189946900-0x0000000189946920
		private void Start() {} // 0x000000018488FBD0-0x000000018488FCD0
		// [XID] // 0x000000018994DFA0-0x000000018994DFC0
		public bool ShowAllText() => default; // 0x000000018488FA80-0x000000018488FBD0
		// [XID] // 0x0000000189955620-0x0000000189955640
		public void RestartRead() {} // 0x000000018488F9A0-0x000000018488FA80
		// [XID] // 0x000000018995D0E0-0x000000018995D100
		private void ReloadText() {} // 0x000000018488F820-0x000000018488F9A0
		// [XID] // 0x0000000189964780-0x00000001899647A0
		public void Finish() {} // 0x000000018488F230-0x000000018488F2D0
		// [XID] // 0x000000018996BE70-0x000000018996BE90
		private void Update() {} // 0x000000018488FCD0-0x000000018488FE10
		// [XID] // 0x0000000189973960-0x0000000189973980
		private void OnFinish() {} // 0x000000018488F2D0-0x000000018488F430
		// [XID] // 0x000000018997AFB0-0x000000018997AFD0
		private void MoveOneChar() {} // 0x000000018488F430-0x000000018488F820
	}
}
