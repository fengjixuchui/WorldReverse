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
	public class MonoFriendJoinButton : MonoBehaviour // TypeDefIndex: 30775
	{
		// Fields
		public GameObject icon; // 0x18
		public GameObject disable; // 0x20
		public UnityEngine.UI.Text time; // 0x28
		public GameObject goPlayerNum; // 0x30
		public UnityEngine.UI.Text txtPlayerNum; // 0x38
		public Button btn; // 0x40
		private int applyCooldown; // 0x48
		public GameObject goMP; // 0x50
	
		// Constructors
		public MonoFriendJoinButton() {} // 0x0000000184AEC290-0x0000000184AEC300
	
		// Methods
		// [XID] // 0x0000000189A64790-0x0000000189A647B0
		public void SetupForIcon() {} // 0x0000000184AEC120-0x0000000184AEC290
		// [XID] // 0x0000000189A6BFF0-0x0000000189A6C010
		public bool IsButtonClickable() => default; // 0x0000000184AEAFC0-0x0000000184AEB0F0
		// [IDTag] // 0x0000000189A736C0-0x0000000189A73700
		// [XID] // 0x0000000189A736C0-0x0000000189A73700
		public void RefreshData(MPRequestState state, uint uid, HostPlayerData playerData) {} // 0x0000000184AEB910-0x0000000184AEC120
		// [IDTag] // 0x0000000189A7E000-0x0000000189A7E040
		// [XID] // 0x0000000189A7E000-0x0000000189A7E040
		public void RefreshData(MPRequestState state, uint uid, FriendBriefStruct friendData) {} // 0x0000000184AEB0F0-0x0000000184AEB910
	}
}
