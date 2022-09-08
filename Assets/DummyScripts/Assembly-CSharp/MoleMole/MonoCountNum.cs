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
	public class MonoCountNum : MonoBehaviour // TypeDefIndex: 31195
	{
		// Fields
		private const int ANIM_INDEX_START = 0; // Metadata: 0x00B11FF7
		private const int ANIM_INDEX_ADD = 1; // Metadata: 0x00B11FFB
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtCount; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _anim; // 0x20
		private List<string> _animationNameList; // 0x28
		private bool _isStarted; // 0x30
	
		// Constructors
		public MonoCountNum() {} // 0x0000000183F39C00-0x0000000183F39CA0
	
		// Methods
		// [XID] // 0x000000018975A4A0-0x000000018975A4C0
		public void Start() {} // 0x0000000183F39860-0x0000000183F39AD0
		// [XID] // 0x0000000189762180-0x00000001897621A0
		public void OnEnable() {} // 0x0000000183F39600-0x0000000183F396B0
		// [XID] // 0x00000001897696F0-0x0000000189769710
		public void ResetCount() {} // 0x0000000183F397C0-0x0000000183F39860
		// [XID] // 0x0000000189770CF0-0x0000000189770D10
		public void UpdateCountText(int count) {} // 0x0000000183F39AD0-0x0000000183F39C00
		// [XID] // 0x0000000189778680-0x00000001897786A0
		public void PlayAnim(int index) {} // 0x0000000183F396B0-0x0000000183F397C0
	}
}
