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
	public class MonoNewbieDialog : MonoUIProxy // TypeDefIndex: 30563
	{
		// Fields
		public MonoNewbieMask defaultAreaMask; // 0x40
		public MonoUIContainer[] areaMaskList; // 0x48
		public GameObject tutorialGlow; // 0x50
		public Canvas dialogCanvas; // 0x58
		public Transform content; // 0x60
		public Button bgButton; // 0x68
		public GameObject hintText; // 0x70
		public GameObject warningText; // 0x78
		public GameObject progressBar; // 0x80
		public SmoothMask progressFill; // 0x88
		public GameObject inputKeyHint; // 0x90
		public GameObject inputHintListObj; // 0x98
		public MonoSimpleReusableList inputHintList; // 0xA0
		public Transform inputKeyTrans; // 0xA8
		public GameObject keyPrefab; // 0xB0
		private List<GameObject> keyObjects; // 0xD0
		private Vector3 _hintTextTransPos; // 0xD8
		private Vector3 _keyHintTextTransPos; // 0xE4
		private Vector3 _warningTextTransPos; // 0xF0
		private Vector3 _inputHintListTransPos; // 0xFC
		private bool _initialized; // 0x108
		public Transform followWidget; // 0x110
		public Vector3 curFollowPos; // 0x118
	
		// Properties
		public RectTransform warningTextTrans { /* [XID] */ /* 0x00000001899B5E80-0x00000001899B5EC0 */ get; /* [XID] */ /* 0x00000001899C0830-0x00000001899C0870 */ private set; } // 0x0000000183715EA0-0x0000000183715F00 0x0000000183713160-0x00000001837131D0
		public RectTransform hintTextTrans { /* [XID] */ /* 0x00000001899CB1F0-0x00000001899CB230 */ get; /* [XID] */ /* 0x00000001899D57A0-0x00000001899D57E0 */ private set; } // 0x0000000183715DE0-0x0000000183715E40 0x00000001837131D0-0x0000000183713240
		public RectTransform keyHintTextTrans { /* [XID] */ /* 0x00000001899DFC70-0x00000001899DFCB0 */ get; /* [XID] */ /* 0x00000001899EA410-0x00000001899EA450 */ private set; } // 0x0000000183715E40-0x0000000183715EA0 0x0000000183713080-0x00000001837130F0
		public int curmaskIndex { /* [XID] */ /* 0x00000001899F4F80-0x00000001899F4FC0 */ get; /* [XID] */ /* 0x00000001899FF370-0x00000001899FF3B0 */ private set; } // 0x0000000183715D80-0x0000000183715DE0 0x00000001837130F0-0x0000000183713160
	
		// Constructors
		public MonoNewbieDialog() {} // 0x0000000183715C90-0x0000000183715D80
	
		// Methods
		// [XID] // 0x0000000189A09950-0x0000000189A09970
		protected void Awake() {} // 0x0000000183712EB0-0x0000000183713080
		// [XID] // 0x0000000189A11090-0x0000000189A110B0
		public void SetHintTextOffset(float offset) {} // 0x0000000183713860-0x0000000183713A30
		// [XID] // 0x0000000189A18440-0x0000000189A18460
		public void SetKeyHintTextOffset(float offset) {} // 0x0000000183715480-0x0000000183715650
		// [XID] // 0x0000000189A1FB80-0x0000000189A1FBA0
		public void SetWarningHintTextOffset(float offset) {} // 0x0000000183715AC0-0x0000000183715C90
		// [XID] // 0x0000000189A26ED0-0x0000000189A26EF0
		public void SetInputHintListOffset(float offset) {} // 0x0000000183713A30-0x0000000183713BE0
		// [XID] // 0x0000000189A2E710-0x0000000189A2E730
		public MonoNewbieMask SetNewbieMaskIndex(int index) => default; // 0x0000000183715650-0x0000000183715AC0
		// [XID] // 0x0000000189A36040-0x0000000189A36060
		public void Reset() {} // 0x0000000183713240-0x0000000183713860
		// [IDTag] // 0x0000000189A3D660-0x0000000189A3D6A0
		// [XID] // 0x0000000189A3D660-0x0000000189A3D6A0
		public void SetKeyControlInfo(InputActionType[] actions) {} // 0x0000000183714C50-0x0000000183715480
		// [IDTag] // 0x0000000189A47D90-0x0000000189A47DD0
		// [XID] // 0x0000000189A47D90-0x0000000189A47DD0
		public void SetKeyControlInfo(ConfigInputHint[] inputHints) {} // 0x0000000183713E60-0x0000000183714830
		// [IDTag] // 0x0000000189A523D0-0x0000000189A52410
		// [XID] // 0x0000000189A523D0-0x0000000189A52410
		public void SetKeyControlInfo(MonoControlElement element, InputActionType action) {} // 0x0000000183713D40-0x0000000183713E60
		// [IDTag] // 0x0000000189A5CF70-0x0000000189A5CFB0
		// [XID] // 0x0000000189A5CF70-0x0000000189A5CFB0
		public void SetKeyControlInfo(MonoControlElement element, InputActionType action1, InputActionType action2) {} // 0x0000000183713BE0-0x0000000183713D40
		// [IDTag] // 0x0000000189A67AA0-0x0000000189A67AE0
		// [XID] // 0x0000000189A67AA0-0x0000000189A67AE0
		public void SetKeyControlInfo(MonoControlElement element, string inputSprite) {} // 0x0000000183714830-0x00000001837149B0
		// [IDTag] // 0x0000000189A71FA0-0x0000000189A71FE0
		// [XID] // 0x0000000189A71FA0-0x0000000189A71FE0
		public void SetKeyControlInfo(MonoControlElement element, KeyCode key) {} // 0x00000001837149B0-0x0000000183714C50
	}
}
