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
	public class MonoPlayerProfileMenuItem : MonoReusableListItem // TypeDefIndex: 31258
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _label; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _forbiddenIcon; // 0x38
	
		// Properties
		public string title { /* [XID] */ /* 0x00000001896156E0-0x0000000189615700 */ set {} } // 0x0000000183720830-0x0000000183720900
		public Sprite icon { /* [XID] */ /* 0x000000018961CEC0-0x000000018961CEE0 */ set {} } // 0x0000000183720680-0x0000000183720740
		public Button actionButton { /* [XID] */ /* 0x0000000189624430-0x0000000189624450 */ get => default; } // 0x0000000183720540-0x00000001837205E0 
		public bool selected { /* [XID] */ /* 0x000000018962BB00-0x000000018962BB20 */ set {} } // 0x0000000183720740-0x0000000183720830
		public Image forbiddenIcon { /* [XID] */ /* 0x0000000189633670-0x0000000189633690 */ get => default; } // 0x00000001837205E0-0x0000000183720680 
	
		// Constructors
		public MonoPlayerProfileMenuItem() {} // 0x00000001837204C0-0x0000000183720540
	}
}
