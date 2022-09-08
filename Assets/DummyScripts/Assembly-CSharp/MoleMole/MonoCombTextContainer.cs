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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCombTextContainer : MonoBehaviour // TypeDefIndex: 30729
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _textPrefab; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _linkPrefab; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _containerRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _textColor; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _fontSize; // 0x40
		private List<GameObject> _textList; // 0x48
		private List<GameObject> _linkList; // 0x50
		private const string CUSTOM_PATTERN = "<type=\"(.+?)\"\\s(.+?)/>"; // Metadata: 0x00B114CC
	
		// Properties
		public List<GameObject> linkList { /* [XID] */ /* 0x000000018996D620-0x000000018996D640 */ get => default; } // 0x0000000184BAEA50-0x0000000184BAEAF0 
	
		// Constructors
		public MonoCombTextContainer() {} // 0x0000000184BAE970-0x0000000184BAEA50
	
		// Methods
		// [XID] // 0x00000001899751A0-0x00000001899751C0
		public void SetFontSize(int fs) {} // 0x0000000184BAE1F0-0x0000000184BAE2A0
		// [XID] // 0x000000018997C360-0x000000018997C380
		public void SetText(string input) {} // 0x0000000184BAE2A0-0x0000000184BAE970
		// [XID] // 0x0000000189984080-0x00000001899840A0
		private GameObject SetTextContent(string text, int index) => default; // 0x0000000184BAD660-0x0000000184BAD900
		// [XID] // 0x000000018998BC10-0x000000018998BC30
		private GameObject SetLinkContent(LinkInfo link, int index) => default; // 0x0000000184BADD10-0x0000000184BAE1F0
		// [XID] // 0x00000001899937E0-0x0000000189993800
		private LinkInfo GetLinkInfo(string input, bool isWebview) => default; // 0x0000000184BADAB0-0x0000000184BADD10
		// [XID] // 0x000000018999B0A0-0x000000018999B0C0
		private void OnLinkClick(LinkInfo linkInfo) {} // 0x0000000184BAD900-0x0000000184BADAB0
	}
}
