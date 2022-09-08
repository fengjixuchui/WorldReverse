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
	public class MonoGachaPanel : MonoBehaviour // TypeDefIndex: 30781
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _titleTextID; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text gachaTitleLabel; // 0x20
		public Button upDetailBtn; // 0x28
		public GameObject limitObj; // 0x30
		public UnityEngine.UI.Text limtText; // 0x38
		public UnityEngine.UI.Text timeText; // 0x40
		public List<PanelElement> panelELements; // 0x48
		private InLevelGachaGroupContext _gachaContext; // 0x50
	
		// Properties
		public string TitleTextID { /* [XID] */ /* 0x00000001897EFCF0-0x00000001897EFD10 */ get => default; /* [XID] */ /* 0x00000001897F7520-0x00000001897F7540 */ set {} } // 0x00000001840668D0-0x0000000184066970 0x0000000184066970-0x0000000184066A20
	
		// Nested types
		public enum ElementType // TypeDefIndex: 30782
		{
			Text = 0,
			Image = 1,
			Layout = 2
		}
	
		[Serializable]
		public struct PanelElement // TypeDefIndex: 30783
		{
			// Fields
			public string name; // 0x00
			public Transform trans; // 0x08
			public ElementType type; // 0x10
		}
	
		// Constructors
		public MonoGachaPanel() {} // 0x0000000184066860-0x00000001840668D0
	
		// Methods
		// [XID] // 0x00000001897FEC10-0x00000001897FEC30
		public void Init(InLevelGachaGroupContext gachaContext) {} // 0x00000001840660A0-0x0000000184066160
		// [XID] // 0x0000000189806350-0x0000000189806370
		public void ResetLimitInfo() {} // 0x0000000184066160-0x00000001840663F0
		// [XID] // 0x000000018980D9F0-0x000000018980DA10
		public void Update() {} // 0x00000001840667C0-0x0000000184066860
		// [XID] // 0x00000001898151D0-0x00000001898151F0
		public void UpdateTime() {} // 0x00000001840663F0-0x00000001840667C0
	}
}
