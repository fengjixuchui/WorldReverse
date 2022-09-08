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
	public class MonoGrpConversation : MonoBehaviour // TypeDefIndex: 31075
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtContent; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTypewriter _typewriter; // 0x28
		// [Header] // 0x0000000189AE4B80-0x0000000189AE4BD0
		[SerializeField] // 0x0000000189AE4B80-0x0000000189AE4BD0
		private UnityEngine.UI.Text _txtTalkerName; // 0x30
		// [Header] // 0x0000000189AF0E40-0x0000000189AF0E90
		[SerializeField] // 0x0000000189AF0E40-0x0000000189AF0E90
		private Color _talkerNameColor; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTalkerTitle; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _rectDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement _layoutTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _objDescLine; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _objTitleLine; // 0x70
		private bool _isOpening; // 0x78
	
		// Properties
		public uint version { /* [XID] */ /* 0x0000000189B29100-0x0000000189B29140 */ get; /* [XID] */ /* 0x0000000189B33570-0x0000000189B335B0 */ set; } // 0x00000001840819E0-0x0000000184081A40 0x0000000184081A40-0x0000000184081AA0
	
		// Constructors
		public MonoGrpConversation() {} // 0x0000000184081930-0x00000001840819E0
	
		// Methods
		// [XID] // 0x0000000189B3DCF0-0x0000000189B3DD10
		private void OnDisable() {} // 0x0000000184080D10-0x0000000184080DB0
		// [XID] // 0x0000000189B45A70-0x0000000189B45A90
		public void UpdateContextByCfg(ConfigDialogScheme dialogConfig, uint mainQuestId) {} // 0x0000000184080F20-0x00000001840815F0
		// [XID] // 0x0000000189B4CF10-0x0000000189B4CF30
		public void UpdateContext(string talker, string content) {} // 0x00000001840815F0-0x0000000184081730
		// [XID] // 0x0000000189B54610-0x0000000189B54630
		private void CheckAnimation() {} // 0x0000000184080B60-0x0000000184080D10
		// [XID] // 0x0000000189B5C1E0-0x0000000189B5C200
		public void SetTitleActive(bool active) {} // 0x0000000184080DB0-0x0000000184080F20
		// [XID] // 0x0000000189B637E0-0x0000000189B63800
		private void PlayTypewriterAnim() {} // 0x0000000184080970-0x0000000184080A60
		// [XID] // 0x0000000189B6AFA0-0x0000000189B6AFC0
		public bool ForceShowAllText() => default; // 0x0000000184080A60-0x0000000184080B60
		// [XID] // 0x0000000189B725E0-0x0000000189B72600
		private void Update() {} // 0x0000000184081730-0x0000000184081930
	}
}
