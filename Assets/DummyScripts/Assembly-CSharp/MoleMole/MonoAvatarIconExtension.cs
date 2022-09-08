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
	public class MonoAvatarIconExtension : MonoBehaviour // TypeDefIndex: 30400
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _hpBarBackground; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _hpFill; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _inRecovery; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _hoursRemain; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _preHpFill; // 0x38
		private float _hpBarOriginWidth; // 0x40
		private float _ratio; // 0x44
		private float _preRatio; // 0x48
	
		// Properties
		public float hpRatio { /* [XID] */ /* 0x00000001895FEF50-0x00000001895FEF70 */ set {} } // 0x000000018421C050-0x000000018421C160
		public float preHpRatio { /* [XID] */ /* 0x00000001896067D0-0x00000001896067F0 */ set {} } // 0x000000018421C160-0x000000018421C2A0
		public uint hoursRemain { /* [XID] */ /* 0x000000018960E170-0x000000018960E190 */ set {} } // 0x000000018421BEF0-0x000000018421C050
		public bool showBottomText { /* [XID] */ /* 0x00000001896157E0-0x0000000189615800 */ set {} } // 0x000000018421C2A0-0x000000018421C3E0
		public bool showPreHp { /* [XID] */ /* 0x000000018961CFC0-0x000000018961CFE0 */ set {} } // 0x000000018421C3E0-0x000000018421C4E0
	
		// Constructors
		public MonoAvatarIconExtension() {} // 0x000000018421BE60-0x000000018421BEF0
	
		// Methods
		// [XID] // 0x00000001895F7C10-0x00000001895F7C30
		private void Start() {} // 0x000000018421BD50-0x000000018421BE60
	}
}
