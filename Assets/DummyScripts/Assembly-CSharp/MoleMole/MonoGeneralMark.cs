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
	public class MonoGeneralMark : MonoBehaviour // TypeDefIndex: 31218
	{
		// Fields
		public Image icon; // 0x18
		private string _currName; // 0x20
		private bool _characterNameActive; // 0x28
		public UnityEngine.UI.Text characterName; // 0x30
		private bool _haveTitle; // 0x38
		public GameObject characterTitle; // 0x40
		public MonoAsyncPrefabPlugin plugin; // 0x48
		private MonoUIContainer subTitleChangeContainer; // 0x50
		public VerticalLayoutGroup verticalLayout; // 0x58
		public HorizontalLayoutGroup titleHorizontalLayout; // 0x60
		private bool _nameActive; // 0x68
	
		// Constructors
		public MonoGeneralMark() {} // 0x000000018406F320-0x000000018406F3A0
	
		// Methods
		// [XID] // 0x0000000189AD56F0-0x0000000189AD5710
		public void ForceRebuild() {} // 0x000000018406EB30-0x000000018406EC00
		// [XID] // 0x0000000189B05870-0x0000000189B05890
		public void SetNameActive(bool active) {} // 0x000000018406EEE0-0x000000018406EFE0
		// [XID] // 0x0000000189B0D040-0x0000000189B0D060
		private void SetTitleActive() {} // 0x000000018406EA50-0x000000018406EB30
		// [XID] // 0x0000000189B14610-0x0000000189B14630
		public void SetName(string currName) {} // 0x000000018406EFE0-0x000000018406F140
		// [XID] // 0x0000000189610D80-0x0000000189610DA0
		public bool SetTitle(bool showTitle, string title, bool isChange) => default; // 0x000000018406F140-0x000000018406F320
		// [XID] // 0x0000000189B23570-0x0000000189B23590
		public void Recycle() {} // 0x000000018406EC00-0x000000018406ED40
		// [XID] // 0x000000018969F930-0x000000018969F950
		public void SetIcon(Sprite iconSprite) {} // 0x000000018406ED40-0x000000018406EEE0
	}
}
